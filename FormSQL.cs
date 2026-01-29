using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CasinoLabs
{
    public partial class FormSQL : Form
    {
        public FormSQL()
        {
            InitializeComponent();
        }

        DataTable FillDataGridView(string sqlSelect)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.КазиноConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private void radioButtonPlayers_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Player");
        }

        private void radioButtonGames_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(
                @"SELECT game_id, table_id, dealer_id, start_time, game_conditions 
                  FROM Game 
                  WHERE end_time IS NULL 
                  ORDER BY start_time DESC");
        }

        private void radioButtonGameDetails_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (!TableExists("Game"))
                {
                    MessageBox.Show("Таблица 'Game' не существует в базе данных!");
                    return;
                }

                dataGridViewSelect.DataSource = FillDataGridView(@"
                    SELECT 
                        g.game_id AS [ID игры],
                        pt.table_number AS [Номер стола],
                        pt.table_type AS [Тип игры],
                        s.full_name AS [Крупье],
                        g.start_time AS [Начало],
                        g.end_time AS [Окончание],
                        g.game_conditions AS [Условия],
                        CASE 
                            WHEN g.end_time IS NULL THEN 'Активна'
                            ELSE 'Завершена'
                        END AS [Статус]
                    FROM Game g
                    JOIN PokerTable pt ON g.table_id = pt.table_id
                    JOIN Staff s ON g.dealer_id = s.staff_id
                    ORDER BY g.start_time DESC");
            }
            catch (SqlException ex)
            {
                var columns = GetTableColumns("Game");
                string errorMessage = $"Ошибка: {ex.Message}\n\n" +
                                      $"Доступные столбцы в таблице 'Game':\n" +
                                      string.Join(", ", columns);

                MessageBox.Show(errorMessage, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool TableExists(string tableName)
        {
            string sql = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = @TableName";

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.КазиноConnectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@TableName", tableName);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public List<string> GetTableColumns(string tableName)
        {
            var columns = new List<string>();
            string sql = $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableName}'";

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.КазиноConnectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        columns.Add(reader["COLUMN_NAME"].ToString());
                    }
                }
            }
            return columns;
        }

        private void buttonF_select_Click(object sender, EventArgs e)
        {
            string playerName = textBoxPlayerName.Text.Trim();
            string playerId = textBoxPlayerID.Text.Trim();

            string sql = @"
                SELECT 
                    p.player_id,
                    p.full_name
                    AS [Паспорт]";

            if (radioButtonDet_Phone.Checked)
            {
                sql += ", p.phone";
            }
            else if (radioButtonDet_Passport.Checked)
            {
                sql += ", p.passport_series, p.passport_number";
            }

            sql += @",
                    COUNT(gp.game_id) AS [Количество игр],
                    SUM(COALESCE(gp.cash_out, 0) - gp.buy_in) AS [Общий результат]
                FROM Player p
                LEFT JOIN GameParticipation gp ON p.player_id = gp.player_id
                WHERE 1=1";

            SqlParameter[] parameters = null;

            if (!string.IsNullOrEmpty(playerName))
            {
                sql += " AND p.full_name LIKE @PlayerName";
                if (parameters == null) parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@PlayerName", SqlDbType.NVarChar)
                {
                    Value = "%" + playerName + "%"
                };
            }

            if (!string.IsNullOrEmpty(playerId))
            {
                sql += " AND p.player_id = @PlayerID";
                if (parameters == null)
                {
                    parameters = new SqlParameter[1];
                    parameters[0] = new SqlParameter("@PlayerID", SqlDbType.Int)
                    {
                        Value = int.Parse(playerId)
                    };
                }
                else
                {
                    Array.Resize(ref parameters, parameters.Length + 1);
                    parameters[parameters.Length - 1] = new SqlParameter("@PlayerID", SqlDbType.Int)
                    {
                        Value = int.Parse(playerId)
                    };
                }
            }

            sql += " GROUP BY p.player_id, p.full_name, p.phone, p.passport_series, p.passport_number";
            sql += " HAVING COUNT(gp.game_id) > 0";

            if (checkBoxOrder.Checked)
            {
                sql += " ORDER BY [Количество игр] DESC";
            }
            else
            {
                sql += " ORDER BY p.full_name";
            }

            ExecuteAndShowQuery(sql, dataGridViewFSelect, parameters);
        }
        private void buttonSubquery_Click(object sender, EventArgs e)
        {
            string playerName = textBoxSubPlayerName.Text.Trim();

            string sql;
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@PlayerName", SqlDbType.NVarChar) { Value = "%" + playerName + "%" }
            };

            if (radioButtonCorrelated.Checked)
            {
                sql = @"
                    SELECT 
                        p.player_id,
                        p.full_name,
                        p.phone,
                        (SELECT AVG(gp.cash_out - gp.buy_in)
                         FROM GameParticipation gp
                         WHERE gp.player_id = p.player_id
                           AND gp.cash_out IS NOT NULL
                        ) AS [Средний выигрыш]
                    FROM Player p
                    WHERE p.full_name LIKE @PlayerName";
            }
            else
            {
                sql = @"
                    SELECT 
                        p.player_id,
                        p.full_name,
                        p.phone
                    FROM Player p
                    WHERE p.player_id IN (
                        SELECT DISTINCT gp.player_id
                        FROM GameParticipation gp
                        WHERE gp.game_id IN (
                            SELECT game_id
                            FROM Game
                            WHERE table_id = 1  -- Например, стол с ID 1
                        )
                    )
                    AND p.full_name LIKE @PlayerName";
            }

            ExecuteAndShowQuery(sql, dataGridViewSubquery, parameters);
        }
        private void ExecuteAndShowQuery(string sql, DataGridView dgv, SqlParameter[] parameters = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.КазиноConnectionString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.DataSource = dt;
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    foreach (DataGridViewColumn column in dgv.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL Ошибка ({ex.Number}): {ex.Message}", "Ошибка БД",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Общая ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string gameId = textBoxGameId.Text.Trim();
            string tableId = textBoxTableId.Text.Trim();
            string dealerId = textBoxDealerId.Text.Trim();

            if (string.IsNullOrEmpty(gameId) || string.IsNullOrEmpty(tableId) || string.IsNullOrEmpty(dealerId))
            {
                MessageBox.Show("Заполните обязательные поля: ID игры, ID стола, ID крупье",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = @"
                INSERT INTO Game (game_id, table_id, dealer_id, start_time, end_time, game_conditions) 
                VALUES (@GameId, @TableId, @DealerId, @StartTime, @EndTime, @GameConditions)";

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.КазиноConnectionString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@GameId", int.Parse(gameId));
                    cmd.Parameters.AddWithValue("@TableId", int.Parse(tableId));
                    cmd.Parameters.AddWithValue("@DealerId", int.Parse(dealerId));

                    // Обработка дат
                    if (!string.IsNullOrEmpty(textBoxStartTime.Text))
                        cmd.Parameters.AddWithValue("@StartTime", DateTime.Parse(textBoxStartTime.Text));
                    else
                        cmd.Parameters.AddWithValue("@StartTime", DateTime.Now);

                    if (!string.IsNullOrEmpty(textBoxEndTime.Text))
                        cmd.Parameters.AddWithValue("@EndTime", DateTime.Parse(textBoxEndTime.Text));
                    else
                        cmd.Parameters.Add("@EndTime", SqlDbType.DateTime).Value = DBNull.Value;

                    cmd.Parameters.AddWithValue("@GameConditions", textBoxGameConditions.Text.Trim());

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show($"Добавлено игр: {rowsAffected}");

                    // Обновляем DataGridView
                    RefreshDataGrid();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Проверьте правильность формата данных:\n" +
                              "ID должны быть числами\n" +
                              "Даты должны быть в формате ГГГГ-ММ-ДД ЧЧ:ММ:СС",
                              "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Нарушение уникальности
                {
                    MessageBox.Show($"Игра с ID {gameId} уже существует!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Number == 547) // Ошибка внешнего ключа
                {
                    MessageBox.Show("Проверьте существование:\n" +
                                  "- Стола с указанным ID\n" +
                                  "- Сотрудника с указанным ID",
                                  "Ошибка внешнего ключа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Ошибка добавления: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления: {ex.Message}");
            }
        }

        private void RefreshDataGrid()
        {
            ExecuteAndShowQuery("SELECT TOP 100 * FROM Game ORDER BY start_time DESC", dataGridViewChange);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxGameId.Text))
            {
                MessageBox.Show("Введите ID игры", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBoxGameId.Text, out int gameId))
            {
                MessageBox.Show("ID игры должен быть числом", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = "DELETE FROM Game WHERE game_id = @GameID";

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.КазиноConnectionString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@GameID", gameId);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show($"Удалено игр: {rowsAffected}");
                    else
                        MessageBox.Show("Игра с таким ID не найдена", "Внимание",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Обновляем DataGridView
                    RefreshDataGrid();
                }
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show("Нельзя удалить игру, так как есть связанные записи в таблице GameParticipation",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления: {ex.Message}");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxGameId.Text))
            {
                MessageBox.Show("Введите ID игры", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBoxGameId.Text, out int gameId))
            {
                MessageBox.Show("ID игры должен быть числом", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = @"
                UPDATE Game 
                SET table_id = @TableId, 
                    dealer_id = @DealerId,
                    start_time = @StartTime,
                    end_time = @EndTime,
                    game_conditions = @GameConditions
                WHERE game_id = @GameID";

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.КазиноConnectionString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@GameID", gameId);
                    cmd.Parameters.AddWithValue("@TableId", int.Parse(textBoxTableId.Text.Trim()));
                    cmd.Parameters.AddWithValue("@DealerId", int.Parse(textBoxDealerId.Text.Trim()));

                    if (!string.IsNullOrEmpty(textBoxStartTime.Text))
                        cmd.Parameters.AddWithValue("@StartTime", DateTime.Parse(textBoxStartTime.Text));
                    else
                        cmd.Parameters.AddWithValue("@StartTime", DateTime.Now);

                    if (!string.IsNullOrEmpty(textBoxEndTime.Text))
                        cmd.Parameters.AddWithValue("@EndTime", DateTime.Parse(textBoxEndTime.Text));
                    else
                        cmd.Parameters.Add("@EndTime", SqlDbType.DateTime).Value = DBNull.Value;

                    cmd.Parameters.AddWithValue("@GameConditions", textBoxGameConditions.Text.Trim());

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show($"Обновлено игр: {rowsAffected}");
                    else
                        MessageBox.Show("Игра с таким ID не найдена", "Внимание",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Обновляем DataGridView
                    RefreshDataGrid();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Проверьте правильность формата данных",
                    "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show("Проверьте существование:\n" +
                              "- Стола с указанным ID\n" +
                              "- Сотрудника с указанным ID",
                              "Ошибка внешнего ключа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления: {ex.Message}");
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxGameId.Clear();
            textBoxTableId.Clear();
            textBoxDealerId.Clear();
            textBoxStartTime.Clear();
            textBoxEndTime.Clear();
            textBoxGameConditions.Clear();
            textBoxPlayerName.Clear();
            textBoxPlayerID.Clear();
            textBoxSubPlayerName.Clear();
        }
        private void buttonNow_Click(object sender, EventArgs e)
        {
            textBoxStartTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void toolStripStatusLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasinoLabs
{
    public partial class GameForm: Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        static GameForm f;
        static public GameForm fe
        {
            get
            {
                if (f == null || f.IsDisposed) f = new GameForm();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void gameBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gameBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.казиноDataSet);

        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "казиноDataSet.Game". При необходимости она может быть перемещена или удалена.
            this.gameTableAdapter.Fill(this.казиноDataSet.Game);

        }

        private void gameDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Проверяем, что это не заголовок столбца
            if (e.RowIndex < 0 || e.RowIndex >= gameDataGridView.Rows.Count)
                return;

            // Получаем текущую строку
            DataGridViewRow currentRow = gameDataGridView.Rows[e.RowIndex];

            // Проверяем, есть ли у нас столбец с временем окончания игры
            // Предположим, что столбец называется "end_timeDataGridViewTextBoxColumn"
            if (currentRow.Cells["dataGridViewTextBoxColumn5"] != null)
            {
                object endTimeValue = currentRow.Cells["dataGridViewTextBoxColumn5"].Value;

                // Если end_time равен NULL или пустой - игра не завершена
                if (endTimeValue == null || endTimeValue == DBNull.Value || string.IsNullOrEmpty(endTimeValue.ToString()))
                {
                    // Игра активна (не завершена) - подсвечиваем зеленым
                    e.CellStyle.BackColor = Color.LightGreen;
                    e.CellStyle.ForeColor = Color.Black;
                }
                else
                {
                    // Игра завершена - подсвечиваем светло-серым
                    e.CellStyle.BackColor = Color.LightGray;
                    e.CellStyle.ForeColor = Color.DarkGray;
                }
            }
        }

        string GetSelectedFieldName()
        {
            return
           gameDataGridView.Columns[gameDataGridView.CurrentCell.ColumnIndex
           ].DataPropertyName;
        }
        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxFind.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos =
                gameBindingSource.Find(GetSelectedFieldName(),
                toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                gameBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких данных нет", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                gameBindingSource.Position = 0;
            }
        }

        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFilter.Checked)
            {
                if (toolStripTextBoxFind.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        gameBindingSource.Filter = GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                       err.Message);
                    }
            }
            else
                gameBindingSource.Filter = "";
            if (gameBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                gameBindingSource.Filter = "";
                checkBoxFilter.Checked = false;
            }
        }
    }
}

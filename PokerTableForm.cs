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
    public partial class PokerTableForm: Form
    {
        public PokerTableForm()
        {
            InitializeComponent();
        }

        static PokerTableForm f;
        static public PokerTableForm fa
        {
            get
            {
                if (f == null || f.IsDisposed) f = new PokerTableForm();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void pokerTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.pokerTableBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.казиноDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка при заполнении столов", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PokerTableForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "казиноDataSet.GameParticipation". При необходимости она может быть перемещена или удалена.
            this.gameParticipationTableAdapter.Fill(this.казиноDataSet.GameParticipation);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "казиноDataSet.PokerTable". При необходимости она может быть перемещена или удалена.
            this.pokerTableTableAdapter.Fill(this.казиноDataSet.PokerTable);

        }

        private void openPlayerButton_Click(object sender, EventArgs e)
        {
            int currentPlayerId = -1;

            if (((DataRowView)gameParticipationBindingSource.Current)["player_id"].ToString() != "")
                currentPlayerId = (int)((DataRowView)gameParticipationBindingSource.Current)["player_id"];

            int selectedId = PlayerForm.ff.ShowSelectForm(currentPlayerId);

            if (selectedId >= 0)
            {
                ((DataRowView)gameParticipationBindingSource.Current)["player_id"] = selectedId;
                gameParticipationBindingSource.EndEdit();
                MessageBox.Show("Выбран ID игрока: " + selectedId.ToString());
            }
        }

        private void gameParticipationDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Ошибка ввода данных: " + e.Exception.Message,
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

            e.ThrowException = false;
        }
    }
}

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
    public partial class PlayerForm: Form
    {
        public PlayerForm()
        {
            InitializeComponent();
        }

        static PlayerForm f;
        static public PlayerForm ff
        {
            get
            {
                if (f == null || f.IsDisposed) f = new PlayerForm();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "казиноDataSet.Player". При необходимости она может быть перемещена или удалена.
            this.playerTableAdapter.Fill(this.казиноDataSet.Player);

        }

        private void playerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.playerBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.казиноDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка при заполнении игроков", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
        
        int idCurrent = -1;
        public int ShowSelectForm(int id)
        {
            idCurrent = id;
            if (this.ShowDialog() == DialogResult.OK)
                return (int)((DataRowView)playerBindingSource.Current)["player_id"];
            else
                return -1;
        }

        private void okToolStripButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void playerDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Ошибка ввода данных: " + e.Exception.Message,
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

            e.ThrowException = false;
        }
    }
}

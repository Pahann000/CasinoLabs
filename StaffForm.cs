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
    public partial class StaffForm: Form
    {
        string fileImage = "";
        public StaffForm()
        {
            InitializeComponent();
        }

        static StaffForm f;
        static public StaffForm fs
        {
            get
            {
                if (f == null || f.IsDisposed) f = new StaffForm();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.staffBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.казиноDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка при заполнении должностей", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "казиноDataSet.Positions". При необходимости она может быть перемещена или удалена.
            this.positionsTableAdapter.Fill(this.казиноDataSet.Positions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "казиноDataSet.Staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this.казиноDataSet.Staff);

        }

        private void openPhotoButton_Click(object sender, EventArgs e)
        {
            openFileDialogPhoto.Title = "Укажите файл для фото";
            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                fileImage = openFileDialogPhoto.FileName;
                try
                {
                    photoPictureBox.Image = new
                    Bitmap(openFileDialogPhoto.FileName);
                }
                catch
                {
                    MessageBox.Show("Выбран не тот формат файла", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else fileImage = "";
        }

        private void positionDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Ошибка ввода данных: " + e.Exception.Message,
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

            e.ThrowException = false;
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.positionsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.казиноDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка при заполнении должностей", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void staffBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

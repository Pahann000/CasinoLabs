using CasinoLabs.Properties;
using System;
using System.Windows.Forms;

namespace CasinoLabs
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show(
                "Вы хотите закрыть программу?",
                "Внимание",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ) != DialogResult.Yes;
            Settings.Default.Save();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "(C)ТУСУР, КСУП, Красников Игорь Дмитриевич, гр. 533-1, 2025",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void TasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameForm.fe.ShowForm();
        }

        private void EmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void фильмыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffForm.fs.ShowForm();
        }

        private void WorkerButton_Click(object sender, EventArgs e)
        {
            PlayerForm.ff.ShowForm();
        }

        private void PostButton_Click(object sender, EventArgs e)
        {
            
        }

        private void SessionButton_Click(object sender, EventArgs e)
        {
            PokerTableForm.fa.ShowForm();
        }
    }
}

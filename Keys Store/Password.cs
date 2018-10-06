using System;
using System.Windows.Forms;

namespace Keys_Store
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBConnection.Password = textBox1.Text;
            try
            {
                KeysDAO.ReadAll();
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (System.Data.SQLite.SQLiteException)
            {
                MessageBox.Show("Wrong password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Password_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing || this.DialogResult == DialogResult.Cancel)
                Environment.Exit(0);
        }
    }
}

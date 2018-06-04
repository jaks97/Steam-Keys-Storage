using System;
using System.Windows.Forms;

namespace Keys_Store
{
    public partial class Encryption : Form
    {
        public Encryption()
        {
            InitializeComponent();
        }

        private void Encryption_Load(object sender, EventArgs e)
        {
            statuslbl.Text += DBConnection.IsEncrypted ? "Encrypted" : "Not encrypted";
            if (!DBConnection.IsEncrypted)
            {
                oldPasstxt.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (newPasstxt.Text == repeatPasstxt.Text)
            {
                if (DBConnection.IsEncrypted)
                {
                    if (DBConnection.Password == oldPasstxt.Text)
                    {
                        DBConnection.SetPassword(newPasstxt.Text);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Old password is wrong", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    DBConnection.SetPassword(newPasstxt.Text);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Passwords mismatch", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}

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

        private readonly bool IsDBEncrypted = DBConnection.IsEncrypted;

        private void Encryption_Load(object sender, EventArgs e)
        {
            statuslbl.Text += IsDBEncrypted ? "Encrypted" : "Not encrypted";
            oldPasstxt.Enabled = IsDBEncrypted;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (newPasstxt.Text == repeatPasstxt.Text)
            {
                if (IsDBEncrypted || DBConnection.Password == oldPasstxt.Text)
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
                MessageBox.Show("Passwords mismatch", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}

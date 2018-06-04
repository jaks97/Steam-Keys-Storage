using System;
using System.Windows.Forms;

namespace Keys_Store
{
    public partial class FindKeys : Form
    {
        public FindKeys()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((Form1)this.Owner).gamesToAdd = textBox1.Lines;
            this.Close();
        }
    }
}

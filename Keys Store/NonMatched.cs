using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Keys_Store
{
    public partial class NonMatched : Form
    {
        public NonMatched()
        {
            InitializeComponent();
        }

        private void NonMatched_Load(object sender, EventArgs e)
        {
            foreach (var game in missing)
            {
                dataGridView1.Rows.Add(game, "");
            }
        }

        public List<String> missing = null;
        private void button1_Click(object sender, EventArgs e)
        {
            List<String> games = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                games.Add(row.Cells["Match"].Value as string);
            }
            (Owner as Form1).gamesToAdd = games.ToArray();
            this.Close();
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox autoText = e.Control as TextBox;
            autoText.AutoCompleteMode = AutoCompleteMode.Suggest;
            autoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            DataCollection.AddRange(((Form1)this.Owner).bs.Select(x => x.AppName).ToArray());

            autoText.AutoCompleteCustomSource = DataCollection;
        }
    }
}

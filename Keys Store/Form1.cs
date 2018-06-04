using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;


namespace Keys_Store
{
    public partial class Form1 : Form
    {
        public List<Package> bs = new List<Package>();
        private List<CartItem> selected = new List<CartItem>();
        private BindingList<CartItem> bl;

        List<string> games = new List<string>();
        public Form1()
        {
            
            InitializeComponent();
            bl = new BindingList<CartItem>(selected);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSize = true;
            

            selectedGames.AutoGenerateColumns = false;

            this.CenterToScreen();

            try
            {
                update();
            }
            catch (System.Data.SQLite.SQLiteException)
            {
                using (var password = new Password())
                {
                    password.ShowDialog(this);
                }
                update();
            }


        }

        public void update()
        {
            bs = new List<Package>();
            foreach (Package package in PackagesDAO.readAll())
            {
                if ((hide.Checked && package.Quantity>0)||!hide.Checked)
                {
                    bs.Add(package);
                }
            }
            dataGridView1.DataSource = bs;

            selected = new List<CartItem>();
            bl = new BindingList<CartItem>(selected);
            selectedGames.DataSource = bl;

            int keys = 0;
            foreach (var item in bs)
            {
                keys+=item.Quantity;
            }
            label1.Text = "Total: " + keys + " Keys - " + bs.Count + " Games";

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (((Package)row.DataBoundItem).Quantity == 0)
                {
                    row.Frozen = true;
                }
            }

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {

                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (var addKey = new AddKey())
            {
                addKey.ShowDialog();
            }
            update();

        }
        
        private void copyButton_Click(object sender, EventArgs e)
        {
            if (selected.Count > 0)
            {
                using (var removeKeys = new RemoveKeys())
                {
                    removeKeys.Items = selected;
                    removeKeys.ShowDialog();
                }
                update();
            }
        }
        
        
        private void rightBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (((Package)row.DataBoundItem).Quantity>0)
                {
                    CartItem item = new CartItem((Package)row.DataBoundItem);
                    if (selected.Exists(x => item.Equals(x)))
                    {
                        selected.Find(x => item.Equals(x)).Quantity++;
                    }
                    else
                    {
                        selected.Add(new CartItem((Package)row.DataBoundItem));
                    }
                }
            }
            bl = new BindingList<CartItem>(selected);
            selectedGames.DataSource = bl;
        }

        private void leftBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in selectedGames.SelectedRows)
            {
                CartItem item = (CartItem)row.DataBoundItem;
                if (selected.Exists(x => item.Equals(x)))
                {
                    if ((selected.Find(x => item.Package.Equals(x.Package)).Quantity-=1) == 0)
                    {
                        selected.Remove(selected.Find(x => item.Package.Equals(x.Package)));
                    }
                }
            }
            bl = new BindingList<CartItem>(selected);
            selectedGames.DataSource = bl;
        }
        
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (((Package)row.DataBoundItem).Quantity == 0)
                {
                    dataGridView1.ClearSelection();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }

        public string[] gamesToAdd = null;
        
        private void button1_Click(object sender, EventArgs e)
        {
            using (var findkeys = new FindKeys())
            {
                findkeys.ShowDialog(this);
            }
            if (gamesToAdd != null && gamesToAdd.Count()>0)
            {
                List<String> missing = new List<string>();
                foreach (string game in gamesToAdd.Where(x => x != null && x != ""))
                {
                    Package match = bs.Find(x => x.AppName.ToLower() == game.Trim().ToLower());
                    if (match == null)
                    {
                        missing.Add(game);
                    }
                    else
                    {
                        CartItem item = new CartItem(match);
                        if (selected.Exists(x => item.Equals(x)))
                        {
                            selected.Find(x => item.Equals(x)).Quantity++;
                        }
                        else
                        {
                            selected.Add(item);
                        }
                    }
                }
                if (missing.Count > 0)
                {
                    using (var nonmatched = new NonMatched())
                    {
                        nonmatched.missing = missing;
                        nonmatched.ShowDialog(this);

                    }
                    if (gamesToAdd != null && gamesToAdd.Count() > 0)
                    {
                        foreach (string game in gamesToAdd.Where(x => x != null && x != ""))
                        {
                            Package match = bs.Find(x => x.AppName == game);
                            if (match != null)
                            {
                                CartItem item = new CartItem(match);
                                if (selected.Exists(x => item.Equals(x)))
                                {
                                    selected.Find(x => item.Equals(x)).Quantity++;
                                }
                                else
                                {
                                    selected.Add(item);
                                }
                            }
                        }
                    }
                }
                bl = new BindingList<CartItem>(selected);
                selectedGames.DataSource = bl;
                gamesToAdd = null;
            }
        }

        private void exportgamesbtn_Click(object sender, EventArgs e)
        {
            using (var export = new ExportGames())
            {
                export.Packages = bs;
                export.ShowDialog(this);
            }
        }

        private void exportkeysbtn_Click(object sender, EventArgs e)
        {
            using (var export = new ExportKeys())
            {
                export.ShowDialog(this);
            }
        }

        private void encryptbtn_Click(object sender, EventArgs e)
        {
            using (var encryption = new Encryption())
            {
                encryption.ShowDialog(this);
            }
        }

        private bool sortAscending = false;
        private void dataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.ClearSelection();
            if (sortAscending)
                dataGridView1.DataSource = bs.OrderBy(dataGridView1.Columns[e.ColumnIndex].DataPropertyName).ToList();
            else
                dataGridView1.DataSource = bs.OrderBy(dataGridView1.Columns[e.ColumnIndex].DataPropertyName).Reverse().ToList();

            sortAscending = !sortAscending;
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                rightBtn_Click(sender, e);
        }
        
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}

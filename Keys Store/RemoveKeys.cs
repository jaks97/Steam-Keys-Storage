using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Keys_Store
{
    public partial class RemoveKeys : Form
    {
        private List<CartItem> items;
        List<CheckBox> checkBoxes = new List<CheckBox>();
        string keysString = "";
        List<Key> keys = new List<Key>();

        public RemoveKeys()
        {
            InitializeComponent();
            this.CenterToScreen();
        }


        internal List<CartItem> Items
        {
            set
            {
                items = value;
            }
        }

        private void RemoveKeys_Load(object sender, EventArgs e)
        {
            foreach (CartItem item in items)
            {
                while (item.Quantity > 0)
                {
                    Key key = item.Package.GetKey;
                    keysString += item.AppName + ": " + key.KeyCode + "\r\n";
                    keys.Add(key);

                    CheckBox cb = new CheckBox();
                    cb.Width = 500;
                    cb.Height = 17;
                    cb.Text = item.AppName + ": " + key.KeyCode;
                    cb.Checked = true;
                    cb.Visible = true;

                    keysPanel.Controls.Add(cb);
                    checkBoxes.Add(cb);

                    item.Quantity--;
                }
            }
            Clipboard.SetDataObject(keysString, false, 5, 200);
            
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(keysString, false, 5, 200);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            List<Key> toRemove = new List<Key>();
            foreach (CheckBox cb in checkBoxes)
            {
                if (cb.Checked)
                {
                    toRemove.Add(keys.Find(x => x.KeyCode.Equals(cb.Text.Split(':').Last<string>().TrimStart())));
                }
            }

            if (keys.Count>0)
            {
                KeysDAO.remove(toRemove);

                List<Package> packages = PackagesDAO.readAll();
                List<Package> emptyGames = new List<Package>();
                string emptyGamesString = "";
                foreach (var removed in toRemove)
                {
                    Package package = packages.Find(x => removed.SubId == x.SubId);
                    if (package.Quantity < 1 && !emptyGames.Contains(package))
                    {
                        emptyGames.Add(package);
                        emptyGamesString += " - " + package.AppName + "\r\n";
                    }
                }

                if (emptyGames.Count > 0)
                {
                    MessageBox.Show("The following games are out of keys now: \r\n\r\n" + emptyGamesString, "No more keys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            this.Close();
        }
    }
}

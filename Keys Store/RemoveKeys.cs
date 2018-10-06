using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Keys_Store
{
    public partial class RemoveKeys : Form
    {
        public List<CartItem> Items { private get; set; }
        private List<CheckBox> checkBoxes = new List<CheckBox>();
        private StringBuilder keysString = new StringBuilder();
        private List<Key> keys = new List<Key>();

        public RemoveKeys()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void RemoveKeys_Load(object sender, EventArgs e)
        {
            foreach (CartItem item in Items)
            {
                while (item.Quantity > 0)
                {
                    Key key = item.Package.GetKey;

                    string itemString = item.AppName + ": " + key.KeyCode;
                    keysString.AppendLine(itemString);
                    keys.Add(key);

                    CheckBox cb = new CheckBox
                    {
                        Width = 500,
                        Height = 17,
                        Text = itemString,
                        Checked = true,
                        Visible = true
                    };

                    keysPanel.Controls.Add(cb);
                    checkBoxes.Add(cb);

                    item.Quantity--;
                }
            }
            Clipboard.SetDataObject(keysString.ToString(), false, 5, 200);

        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(keysString.ToString(), false, 5, 200);
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

            if (keys.Count > 0)
            {
                KeysDAO.Remove(toRemove);

                List<Package> packages = PackagesDAO.ReadAll();
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

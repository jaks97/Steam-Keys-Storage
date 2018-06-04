using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Keys_Store
{
    public partial class ExportKeys : Form
    {
        private Dictionary<Package,List<Key>> keys = new Dictionary<Package, List<Key>>();

        public ExportKeys()
        {
            InitializeComponent();
        }

        private void ExportKeys_Load(object sender, EventArgs e)
        {
            var keys = KeysDAO.readAll();
            foreach (Package pack in PackagesDAO.readAll().FindAll( x => x.Quantity > 0 ))
            {
                this.keys.Add(pack, keys.FindAll(x => x.SubId == pack.SubId));
            }

            update();
        }
        private void update()
        {

            string format = this.format.Text + (lineJump.Checked ? "\r\n" : "");
            results.Text = String.Empty;

            foreach (var item in keys)
            {
                foreach (var key in item.Value)
                {
                    results.Text += format.ReplaceIgnoreCase("{SUBID}", key.SubId.ToString())
                    .ReplaceIgnoreCase("{NAME}", item.Key.AppName)
                    .ReplaceIgnoreCase("{APPID}", item.Key.AppId.ToString())
                    .ReplaceIgnoreCase("{DETAILS}", key.Details)
                    .ReplaceIgnoreCase("{CARDS}", item.Key.HasCards ? "With Cards" : "No Cards")
                    .ReplaceIgnoreCase("{APPURL}", item.Key.StorePage.ToString())
                    .ReplaceIgnoreCase("{KEY}", key.KeyCode)
                    .ReplaceIgnoreCase("{PACKAGEURL}", item.Key.SubPage.ToString());
                }
                
            }

        }
        private void copybtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(results.Text, false, 5, 200);
        }
        private void update(object sender, EventArgs e)
        {
            update();
        }
    }
}

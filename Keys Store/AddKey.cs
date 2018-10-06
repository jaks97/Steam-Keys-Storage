using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Keys_Store
{
    public partial class AddKey : Form
    {
        public AddKey()
        {
            InitializeComponent();
            this.CenterToScreen();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls12;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int subID;
            int appID;
            try
            {
                subID = Int32.Parse(this.subID.Text);
                appID = Int32.Parse(this.appID.Text);
            }
            catch (System.FormatException)
            {
                return;
            }
            string name = this.name.Text;
            bool cards = this.hasCards.Checked;

            if (string.IsNullOrWhiteSpace(name))
            {
                return;
            }
            Package pack = new Package(subID, appID, name, cards);
            PackagesDAO.Add(pack);

            List<Key> keys = new List<Key>();
            foreach (string key in this.keys.Lines)
            {
                if (!string.IsNullOrWhiteSpace(key))
                {
                    keys.Add(new Key(key.Trim(), subID, DateTime.Now, detailsBox.Text));
                }
            }
            KeysDAO.Add(keys);
            this.Close();
        }

        private string WebAPICall(string uri)
        {
            return new StreamReader(WebRequest.Create(uri).GetResponse().GetResponseStream()).ReadToEnd();
        }
        private bool HasCards(int appID)
        {
            string json;
            try
            {
                json = WebAPICall("https://jaks.cf/api/cards");
            }
            catch (Exception)
            {
                return false;
            }
            return JsonConvert.DeserializeObject<List<int>>(json).Contains(appID);
        }

        private void BindByApp(int appID)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string json = WebAPICall("https://store.steampowered.com/api/appdetails?appids=" + appID);

                var jsonObject = JsonConvert.DeserializeObject<Dictionary<int, dynamic>>(json).FirstOrDefault().Value.data;
                name.Text = jsonObject.name;
                subID.Text = jsonObject.packages[0];

                hasCards.Checked = HasCards(appID);
            }
            catch (Exception)
            {
                hasCards.Checked = false;
            }
            Cursor.Current = Cursors.Default;
        }

        private void BindBySub(int subID)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string json = WebAPICall("https://store.steampowered.com/api/packagedetails?packageids=" + subID);

                var jsonObject = JsonConvert.DeserializeObject<Dictionary<int, dynamic>>(json).FirstOrDefault().Value.data;
                name.Text = jsonObject.name;
                int appID = jsonObject.apps[0].id;
                this.appID.Text = appID.ToString();

                hasCards.Checked = HasCards(appID);
            }
            catch (Exception)
            {
                hasCards.Checked = false;
            }
            Cursor.Current = Cursors.Default;
        }

        private void BindByName(string name)
        {
            //TODO
        }

        private void appID_Leave(object sender, EventArgs e)
        {
            if (!appID.Text.Equals("") && !removed.Checked)
            {
                try
                {
                    BindByApp(Convert.ToInt32(appID.Text));
                }
                catch (System.FormatException)
                {

                }
            }
        }

        private void subID_Leave(object sender, EventArgs e)
        {
            if (!subID.Text.Equals("") && !removed.Checked)
            {
                try
                {
                    BindBySub(Convert.ToInt32(subID.Text));
                }
                catch (System.FormatException)
                {

                }
            }
        }

        private void name_Leave(object sender, EventArgs e)
        {
            //TODO
        }
    }
}

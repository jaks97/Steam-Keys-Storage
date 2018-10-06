using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
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

        private async Task<string> WebAPICall(string uri)
        {
            return new StreamReader((await WebRequest.Create(uri).GetResponseAsync()).GetResponseStream()).ReadToEnd();
        }
        private async Task<bool> HasCards(int appID)
        {
            string json;
            try
            {
                json = await WebAPICall("https://jaks.cf/api/cards");
            }
            catch (Exception)
            {
                return false;
            }
            return JsonConvert.DeserializeObject<List<int>>(json).Contains(appID);
        }

        private async void BindByApp(int appID)
        {
            this.name.Enabled = false;
            this.appID.Enabled = false;
            this.subID.Enabled = false;
            this.hasCards.Enabled = false;

            try
            {
                string json = await WebAPICall("https://store.steampowered.com/api/appdetails?appids=" + appID);

                var jsonObject = JsonConvert.DeserializeObject<Dictionary<int, dynamic>>(json).FirstOrDefault().Value.data;
                name.Text = jsonObject.name;
                subID.Text = jsonObject.packages[0];

                hasCards.Checked = await HasCards(appID);
            }
            catch (Exception)
            {
                hasCards.Checked = false;
            }
            finally
            {
                this.name.Enabled = true;
                this.appID.Enabled = true;
                this.subID.Enabled = true;
                this.hasCards.Enabled = true;
            }
        }

        private async void BindBySub(int subID)
        {
            this.name.Enabled = false;
            this.appID.Enabled = false;
            this.subID.Enabled = false;
            this.hasCards.Enabled = false;
            try
            {
                string json = await WebAPICall("https://store.steampowered.com/api/packagedetails?packageids=" + subID);

                var jsonObject = JsonConvert.DeserializeObject<Dictionary<int, dynamic>>(json).FirstOrDefault().Value.data;
                name.Text = jsonObject.name;
                int appID = jsonObject.apps[0].id;
                this.appID.Text = appID.ToString();

                hasCards.Checked = await HasCards(appID);
            }
            catch (Exception)
            {
                hasCards.Checked = false;
            }
            finally
            {
                this.name.Enabled = true;
                this.appID.Enabled = true;
                this.subID.Enabled = true;
                this.hasCards.Enabled = true;
            }
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

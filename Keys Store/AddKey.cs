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
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Package pack = new Package(Int32.Parse(this.subID.Text), Int32.Parse(this.appID.Text), this.name.Text, this.hasCards.Checked, "");
            PackagesDAO.add(pack);

            List<Key> keys = new List<Key>();
            foreach (string key in this.keys.Lines)
            {
                if (key!= null && !key.Equals(""))
                {
                    keys.Add(new Key(key.Trim(), Int32.Parse(this.subID.Text), DateTime.Now, detailsBox.Text));
                }
            }
            KeysDAO.add(keys);
            this.Close();
        }

        private void BindByApp(int appID)
        {
            if (!removed.Checked)
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    string json = new StreamReader((WebRequest.Create("http://store.steampowered.com/api/appdetails?appids=" + appID).GetResponse() as HttpWebResponse).GetResponseStream()).ReadToEnd();

                    var jsonObject = JsonConvert.DeserializeObject<Dictionary<int, dynamic>>(json).FirstOrDefault().Value.data;
                    name.Text = jsonObject.name;
                    subID.Text = jsonObject.packages[0];

                    json = new StreamReader((WebRequest.Create("https://jaks.cf/api/cards").GetResponse() as HttpWebResponse).GetResponseStream()).ReadToEnd();
                    hasCards.Checked = JsonConvert.DeserializeObject<List<int>>(json).Contains(appID);
                }
                catch (Exception)
                {
                    hasCards.Checked = false;
                }
                Cursor.Current = Cursors.Default;
            }
        }

        private void BindBySub(int subID)
        {
            if (!removed.Checked)
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    string json = new StreamReader((WebRequest.Create("http://store.steampowered.com/api/packagedetails?packageids=" + subID).GetResponse() as HttpWebResponse).GetResponseStream()).ReadToEnd();

                    var jsonObject = JsonConvert.DeserializeObject<Dictionary<int, dynamic>>(json).FirstOrDefault().Value.data;
                    name.Text = jsonObject.name;
                    int appID = jsonObject.apps[0].id;
                    this.appID.Text = appID.ToString();
                    
                    json = new StreamReader((WebRequest.Create("https://jaks.cf/api/cards").GetResponse() as HttpWebResponse).GetResponseStream()).ReadToEnd();
                    hasCards.Checked = JsonConvert.DeserializeObject<List<int>>(json).Contains(appID);
                }
                catch (Exception)
                {
                    hasCards.Checked = false;
                }
                Cursor.Current = Cursors.Default;
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
                BindByApp(Convert.ToInt32(appID.Text));
            }
        }

        private void subID_Leave(object sender, EventArgs e)
        {
            if (!subID.Text.Equals("") && !removed.Checked)
            {
                BindBySub(Convert.ToInt32(subID.Text));
            }
        }

        private void name_Leave(object sender, EventArgs e)
        {
            //TODO
        }
    }
}

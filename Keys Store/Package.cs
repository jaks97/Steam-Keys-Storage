using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Keys_Store
{
    public class Package
    {
        public int SubId { get; set; }
        public int AppId { get; set; }
        public string AppName { get; set; }
        public bool HasCards { get; set; }
        private List<string> details = new List<string>();
        public string Details
        {
            get
            {
                StringBuilder sb = new StringBuilder("  ");
                foreach (string detail in this.details)
                    sb.Append(detail).Append(" ");

                return sb.ToString();
            }
        }

        private List<Key> keys;

        public Uri StorePage
        {
            get { return new Uri("https://store.steampowered.com/app/" + AppId + "/"); }
        }

        public Uri SubPage
        {
            get { return new Uri("https://store.steampowered.com/sub/" + SubId + "/"); }
        }

        public int Quantity
        {
            get { return keys.Count; }
        }

        public Key GetKey
        {
            get
            {
                Key key = keys.First<Key>();
                keys.Remove(key);
                return key;
            }
        }

        public Package(int subId, int appId, string appName, bool hasCards)
        {
            this.SubId = subId;
            this.AppId = appId;
            this.AppName = appName;
            this.HasCards = hasCards;
            this.keys = KeysDAO.find(subId);

            foreach (Key key in this.keys)
                if (!this.details.Contains(key.Details))
                    this.details.Add(key.Details);
        }

        public bool Equals(Package package)
        {
            return this.SubId == package.SubId;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Keys_Store
{
    public class Package
    {
        private int subId;
        private int appId;
        private string appName;
        private bool hasCards;
        private string details = "";

        private List<Key> keys;

        public Package(int subId, int appId, string appName, bool hasCards, string details)
        {
            this.SubId = subId;
            this.AppId = appId;
            this.AppName = appName;
            this.HasCards = hasCards;
            this.keys = KeysDAO.find(subId);
            this.details = details + "  ";

            foreach (Key key in this.keys)
            {
                if(!this.details.Contains(key.Details))
                {
                    this.details += " "+key.Details+" ";
                }
            }
        }

        public bool Equals(Package package)
        {
            return this.SubId == package.SubId;
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

        public int SubId
        {
            get
            {
                return subId;
            }

            set
            {
                subId = value;
            }
        }

        public int AppId
        {
            get
            {
                return appId;
            }

            set
            {
                appId = value;
            }
        }

        public string AppName
        {
            get
            {
                return appName;
            }

            set
            {
                appName = value;
            }
        }

        public bool HasCards
        {
            get
            {
                return hasCards;
            }

            set
            {
                hasCards = value;
            }
        }

        public string Details
        {
            get
            {
                return details;
            }

            set
            {
                details = value;
            }
        }
        
        public Uri StorePage
        {
            get
            {
                return new Uri("https://store.steampowered.com/app/" + AppId + "/");
            }
        }

        public Uri SubPage
        {
            get
            {
                return new Uri("https://store.steampowered.com/sub/" + SubId + "/");
            }
        }

        public int Quantity
        {
            get
            {
                return keys.Count;
            }
        }
    }
}

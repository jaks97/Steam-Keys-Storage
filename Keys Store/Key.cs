using System;

namespace Keys_Store
{
    public class Key
    {
        private string key;
        private int subId;
        private DateTime date;
        private string details = "";

        public Key(string key, int subId)
        {
            this.key = key;
            this.SubId = subId;
        }

        public Key(string key, int subId, DateTime date, string details)
        {
            this.key = key;
            this.SubId = subId;
            this.date = date;
            this.details = details;
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return this.KeyCode.Equals(((Key)obj).KeyCode);
        }

        public string KeyCode
        {
            get
            {
                return key;
            }

            set
            {
                key = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
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
        
    }
}

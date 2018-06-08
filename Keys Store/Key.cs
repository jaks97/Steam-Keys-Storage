using System;

namespace Keys_Store
{
    public class Key
    {
        public string KeyCode { get; set; }
        public int SubId { get; set; }
        public DateTime Date { get; set; }
        public string Details { get; set; } = "";

        public Key(string key, int subId)
        {
            this.KeyCode = key;
            this.SubId = subId;
        }

        public Key(string key, int subId, DateTime date, string details)
        {
            this.KeyCode = key;
            this.SubId = subId;
            this.Date = date;
            this.Details = details;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return this.KeyCode.Equals(((Key)obj).KeyCode);
        }

    }
}

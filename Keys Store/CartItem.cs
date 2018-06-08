namespace Keys_Store
{
    public class CartItem
    {
        public Package Package { get; }
        private int quantity = 1;
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (Package.Quantity >= value && value >= 0)
                    quantity = value;
            }
        }
        public string AppName
        {
            get { return Package.AppName; }
        }

        public CartItem(Package package)
        {
            this.Package = package;
        }

        public bool Equals(CartItem item)
        {
            return this.Package.SubId == item.Package.SubId;
        }
    }
}

namespace Keys_Store
{
    class CartItem
    {
        private Package package;
        private int quantity;

        public CartItem(Package package)
        {
            this.package = package;
            this.quantity = 1;
        }

        public bool Equals(CartItem item)
        {
            return this.package.SubId == item.Package.SubId;
        }


        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                if (package.Quantity>=value && value >= 0)
                {
                    quantity = value;
                }
            }
        }

        internal Package Package
        {
            get
            {
                return package;
            }
        }
        public string AppName
        {
            get
            {
                return package.AppName;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualMethods
{
    class InventoryItem : Item
    {
        private decimal price;
        private string buyer;
        private bool sold;

        public InventoryItem(int id, decimal price)
            : base(id)
        {
            this.price = price;
        }

        public InventoryItem(int id, decimal price, string buyer)
            : this(id, price)
        {
            if (buyer != null && buyer.Length > 0)
            {
                this.buyer = buyer;
                this.sold = true;
            }
        }

        public override void PrintReport()
        {
            base.PrintReport();

            Console.WriteLine("Price: {0:N2}", price);
            Console.WriteLine("Status: {0}\n",
                    sold ? string.Format("Sold to {0}", buyer) : "No buyer");
        }
    }
}

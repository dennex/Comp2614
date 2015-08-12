using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstructorInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryItem item = new InventoryItem(101, 299.00m);
            Console.WriteLine("List Price:    {0:N2}", item.Price);

            decimal sellPrice = item.Sell("ACME Corp", true);
            Console.WriteLine("Selling Price: {0:N2}", sellPrice);
        }
    }


    class Item // base class
    {
        private int id;

        public Item()
        {
        }

        public Item(int id)
        {
            this.id = id;
        }
    }

    class InventoryItem : Item // derived class
    {
        public const decimal DEFAULT_DISCOUNT = 0.1m;
        public const decimal ALREADY_SOLD = -1m;

        private decimal price;
        private string buyer;
        private bool sold;

        public InventoryItem()
        {
        }

        public InventoryItem(int id, decimal price)
            : base(id) // calls base class ctor 
        {
            this.price = price;
        }

        public InventoryItem(int id, decimal price, string buyer)
            : this(id, price) // calls 2 param ctor
        {
            sold = true;
            this.buyer = buyer;
        }

        public decimal Price
        {
            get { return price; }
        }

        public decimal Sell(string buyer, bool applyDiscount)
        {
            if (!sold)
            {
                sold = true;
                this.buyer = buyer;

                return calculateSalePrice(applyDiscount);
            }
            else
            {
                return ALREADY_SOLD;
            }
        }

        private decimal calculateSalePrice(bool applyDiscount)
        {
            if (applyDiscount)
            {
                return price - (price * DEFAULT_DISCOUNT);
            }
            else
            {
                return price;
            }
        }
    }
}

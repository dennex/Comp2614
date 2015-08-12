using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP2614HomeLab02
{
    public enum Status
    {
         ForSale
       , Sold
       , Shipped
    }

    class Product
    {
        private decimal price;
        private string description;
        private Status productStatus;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }


        public string Description
        {
            get { return description; }
            set { description = value; }
        }


        public Status ProductStatus
        {
            get { return productStatus; }
            private set { productStatus = value; }
        }


        public Product()
        {
            ProductStatus = Status.ForSale;
        }

        public Product(decimal price, string desc)
        {
            Price = price;
            Description = desc;
            ProductStatus = Status.ForSale;
        }

        public void Sell()
        {
            if (ProductStatus == Status.ForSale)
            {
                ProductStatus = Status.Sold;
            }
            else
            {
                Console.WriteLine("Error - Product must have ForSale Status to be Sold\n");
            }

        }

        public void Ship()
        {
            if (ProductStatus == Status.Sold)
            {
                ProductStatus = Status.Shipped;
            }
            else
            {
                Console.WriteLine("Error - Product must have Sold Status to be Shipped\n");
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2:N2}", ProductStatus, Description, Price);
        }
    }
}

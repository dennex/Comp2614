using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NamedParametersExample
{
    class Widget
    {
        private int id;
        private string description;
        private decimal price;

        public Widget(int id, string description, decimal price)
        {
            this.id = id;
            this.Description = description;
            this.Price = price;
        }

        public int Id
        {
            get { return id; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}

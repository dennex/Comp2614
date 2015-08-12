using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumerationExample
{

    public enum ApplyDiscount
    {
        No
      , Yes
    }
    
    class InventoryItem
    {
        public const decimal DEFAULT_DISCOUNT = 0.1m;

        private int id;
        private decimal price;
        private string buyer;

        public InventoryItem(int id, decimal price)
        {
            this.id = id;
            this.price = price;
        }


        public decimal SellVersion1(string buyer, bool applyDiscount)
        {
            decimal sellPrice;

            this.buyer = buyer;

            if (applyDiscount)
            {
                sellPrice = price - (price * DEFAULT_DISCOUNT);
            }
            else
            {
                sellPrice = price;
            }

            return sellPrice;
        }


        public decimal SellVersion2(string buyer, ApplyDiscount discountMode)
        {
            decimal sellPrice;

            this.buyer = buyer;

            if (discountMode == ApplyDiscount.Yes)
            {
                sellPrice = price - (price * DEFAULT_DISCOUNT);
            }
            else
            {
                sellPrice = price;
            }

            return sellPrice;
        }   
    }
}

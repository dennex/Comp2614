using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumerationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryItem item = new InventoryItem(1001, 1500m);

            decimal sellPrice;

            sellPrice = item.SellVersion1("ACME Corp", true);
            Console.WriteLine("Sell price: {0:N2}", sellPrice);

            sellPrice = item.SellVersion2("ACME Corp", ApplyDiscount.Yes);
            Console.WriteLine("Sell price: {0:N2}", sellPrice);

            sellPrice = item.SellVersion1("ACME Corp", false);
            Console.WriteLine("Sell price: {0:N2}", sellPrice);

            sellPrice = item.SellVersion2("ACME Corp", ApplyDiscount.No);
            Console.WriteLine("Sell price: {0:N2}", sellPrice);
        }
    }
}

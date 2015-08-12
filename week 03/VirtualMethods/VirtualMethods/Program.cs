using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryItem firstItem = new InventoryItem(101, 1024.93m, "Gary Sanders");
            firstItem.PrintReport();

            InventoryItem secondItem = new InventoryItem(102, 824m);
            secondItem.PrintReport();
        }
    }   
}

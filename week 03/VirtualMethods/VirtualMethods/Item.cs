using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualMethods
{
    class Item
    {
        private int id;

        public Item(int id)
        {
            this.id = id;
        }

        public virtual void PrintReport()
        {
            Console.WriteLine("ID: {0}", id);
        }
    }
}

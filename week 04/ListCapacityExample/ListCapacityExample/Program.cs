using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListCapacityExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegerList intList = new IntegerList();

            Console.WriteLine("{0, 9} {1, 9}", "Elements", "Capacity");
            Console.WriteLine("{0}", new string('-', 19));
            Console.WriteLine("{0, 9} {1, 9}", intList.Count, intList.Capacity);

            for (int count = 0; count < 50; count++)
            {
                intList.Add(count);
                Console.WriteLine("{0, 9} {1, 9}", intList.Count, intList.Capacity);
            }
        }
    }
}

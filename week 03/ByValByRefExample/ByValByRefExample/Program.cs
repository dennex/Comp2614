using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ByValByRefExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int testVal = 100;

            Console.WriteLine("Original value:            {0}\n", testVal);

            add50ByVal(testVal);
            Console.WriteLine("Value after ByVal call:    {0}\n", testVal);

            add50ByRef(ref testVal);
            Console.WriteLine("Value after ByRef call:    {0}\n", testVal);

        }


        private static void add50ByVal(int input)
        {
            input += 50;
            Console.WriteLine("Value inside ByVal method: {0}", input);
        }


        private static void add50ByRef(ref int input)
        {
            input += 50;
            Console.WriteLine("Value inside ByRef method: {0}", input);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OptionalParametersExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Total: {0, 6:N0}", sumIntegers(100, 200, 300));
            Console.WriteLine("Total: {0, 6:N0}", sumIntegers(100, 200));
            Console.WriteLine("Total: {0, 6:N0}\n", sumIntegers(100));
            // Can not "skip" an optional parameter
            //Console.WriteLine("Total: {0, 6:N0}", sumIntegers(100,,300)); // no go

            Console.WriteLine("Total: {0, 6:N0}", sumIntegersOld(100, 200, 300));
            Console.WriteLine("Total: {0, 6:N0}", sumIntegersOld(100, 200));
            Console.WriteLine("Total: {0, 6:N0}\n", sumIntegersOld(100));

            Console.WriteLine("Value: {0, 6:N0}", getValue());
            Console.WriteLine("Value: {0, 6:N0}\n", getValue(335));
        }


        // all parameters can be optional
        private static int getValue(int value = 50)
        {
            return value;
        }

        // optional parameters must occur last in the signature
        private static int sumIntegers(int first, int second = 20, int third = 30)
        {
            return first + second + third;
        }

        // previous approach to solve this
        private static int sumIntegersOld(int first, int second, int third)
        {
            return first + second + third;
        }

        private static int sumIntegersOld(int first, int second)
        {
            return sumIntegersOld(first, second, 30);
        }

        private static int sumIntegersOld(int first)
        {
            return sumIntegersOld(first, 20, 30);
        }
    }
}

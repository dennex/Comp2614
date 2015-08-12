using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckedUncheckedExample
{
    class Program
    {
        static void Main(string[] args)
        {
            short adder = 5000;
            // short adder = 15000;

            short shortVal = 20000;
            Console.WriteLine("Value is: {0:N0}", shortVal);

            shortVal += adder;
            Console.WriteLine("Value is: {0:N0}", shortVal);

            checked
            {
                shortVal = 20000;
                Console.WriteLine("Value is: {0:N0}", shortVal);

                shortVal += adder;
                Console.WriteLine("Value is: {0:N0}", shortVal);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ByValByRefWithStringsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Moe";

            Console.WriteLine("Original Value:     {0}\n", name);

            processStringByVal(name);

            Console.WriteLine("After call by Val:  {0}\n", name);

            processStringByRef(ref name);

            Console.WriteLine("After call by Ref:  {0}\n", name);
        }


        private static void processStringByVal(string input)
        {
            input += " Howard";
            Console.WriteLine("Inside call by Val: {0}", input);
        }


        private static void processStringByRef(ref string input)
        {
            input += " Howard";
            Console.WriteLine("Inside call by Ref: {0}", input);
        }
    }
}

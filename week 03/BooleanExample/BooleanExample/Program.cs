using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BooleanExample
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result;

            Console.WriteLine("true && true");
            result = returnTrue() && returnTrue();
            Console.WriteLine("result = {0}\n", result);

            Console.WriteLine("false && true");
            result = returnFalse() && returnTrue();
            Console.WriteLine("result = {0}\n", result);
            
            Console.WriteLine("false & true");
            result = returnFalse() & returnTrue();
            Console.WriteLine("result = {0}\n", result);
            
            Console.WriteLine("true && false");
            result = returnTrue() && returnFalse();
            Console.WriteLine("result = {0}\n", result);

            Console.WriteLine("false && false");
            result = returnFalse() && returnFalse();
            Console.WriteLine("result = {0}\n\n\n", result);


            Console.WriteLine("true || true");
            result = returnTrue() || returnTrue();
            Console.WriteLine("result = {0}\n", result);

            Console.WriteLine("true | true");
            result = returnTrue() | returnTrue();
            Console.WriteLine("result = {0}\n", result);

            Console.WriteLine("false || true");
            result = returnFalse() || returnTrue();
            Console.WriteLine("result = {0}\n", result);

            Console.WriteLine("true || false");
            result = returnTrue() || returnFalse();
            Console.WriteLine("result = {0}\n", result);

            Console.WriteLine("false || false");
            result = returnFalse() || returnFalse();
            Console.WriteLine("result = {0}\n", result);

        }

        private static bool returnTrue()
        {
            Console.WriteLine("returnTrue method called");
            return true;
        }

        private static bool returnFalse()
        {
            Console.WriteLine("returnFalse method called");
            return false;
        }
    }
}

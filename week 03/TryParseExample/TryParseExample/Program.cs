using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TryParseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            string input;

            // This loop prompts the user for an integer again and again until
            // the input string can be converted to an integer value.  
            do
            {
                Console.Write("Enter your age in years: ");
                input = Console.ReadLine();

                if (input == string.Empty)
                {
                    break;	// Allow user to exit.
                }

            } while (!int.TryParse(input, out age));

            if (age > 0)
            {
                Console.WriteLine("\nYou entered: {0}", age);
            }

            // Note that the int.TryParse returns a boolean value to indicate 
            // whether the input can be converted.  If it returns true then
            // it also "passes back" the converted integer value through its
            // second parameter.  In this way, TryParse can serve two purposes:
            // 1) validate the input, using its return value and 
            // 2) convert from a string to a integer value, using its second parameter.

            // There are also:
            //
            // double.TryParse
            // bool.TryParse
            // DateTime.TryParse
            // float.TryParse
            // etc.
        }
    }
}

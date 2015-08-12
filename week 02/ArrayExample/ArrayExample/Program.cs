using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] someNumbers;
            someNumbers = new int[3];

            someNumbers[0] = 329;
            someNumbers[1] = 19;
            someNumbers[2] = -392;

            displayArray(someNumbers);

            Random rand = new Random(DateTime.Now.Millisecond);
            int arrayCount = rand.Next(10);

            int[] someNumbers2 = new int[arrayCount];

            for (int counter = 0; counter < someNumbers2.Length; counter++)
            {
                someNumbers2[counter] = rand.Next(100);
            }


            displayArray(someNumbers2);


            int[] someMoreNumbers;
            someMoreNumbers = new int[3] { 100, 200, -50 };

            displayArray(someMoreNumbers);
        }


        static void displayArray(int[] intArray)
        {
            for (int counter = 0; counter < intArray.Length; counter++)
            {
                Console.WriteLine("Value: {0}", intArray[counter]);
            }

            Console.WriteLine("\n");
        }
    }
}

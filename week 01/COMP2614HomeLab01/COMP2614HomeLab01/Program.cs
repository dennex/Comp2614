using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP2614HomeLab01
{
    class Program
    {
        static void Main(string[] args)
        {
            int square;
            int cube;
            int sumBase = 0;
            int sumSquare = 0;
            int sumCube = 0;

            Console.WriteLine("{0, 8} {1, 8} {2, 8}", "number", "square", "cube");
            Console.WriteLine(new string('-', 26));

            for (int counter = 0; counter <= 20; counter += 2)
            {
                square = counter * counter;
                cube = square * counter;
                sumBase += counter;
                sumSquare += square;
                sumCube += cube;

                Console.WriteLine("{0, 8:N0} {1, 8:N0} {2, 8:N0}", counter, square, cube);
            }

            Console.WriteLine(new string('-', 26));
            Console.WriteLine("{0, 8:N0} {1, 8:N0} {2, 8:N0}", sumBase, sumSquare, sumCube);
        }
    }
}

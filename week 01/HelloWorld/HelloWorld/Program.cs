using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World"); // cursor advances to next line

            Console.Write("Hello World"); // keeps cursor on same line

            // equivalent to Console.WriteLine("Hello World");
            Console.Write("Hello World\n\n"); // \n is the newline character


            Console.Write("Enter your name: "); // prompt user for their name
            string name = Console.ReadLine();  // reads user input from console
                        
            Console.WriteLine("Hello, {0}", name);
        }
    }
}

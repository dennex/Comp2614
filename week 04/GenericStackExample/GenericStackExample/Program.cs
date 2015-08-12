using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericStackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("One");
            stack.Push("Two");
            stack.Push("Three");

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int age;

            Console.Write("Enter your age in years: ");
            input = Console.ReadLine();

            age = int.Parse(input);

            Console.WriteLine("You entered: {0}", age);
        }
    }
}

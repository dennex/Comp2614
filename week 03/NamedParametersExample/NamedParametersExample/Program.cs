﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NamedParametersExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // standard method call
            displayPerson("Moe", "Howard", 63);

            // call with parameter naming
            displayPerson(firstName: "Larry", lastName: "Fine", age: 61);

            // call with parameter naming - alternate order
            displayPerson(age: 58, lastName: "Howard", firstName: "Curley");

            // works with constructors as well
            Widget widget = new Widget(id: 1001, price: 2200m, description: "Really nice widget");

            Console.WriteLine("ID:    {0}\nDesc:  {1}\nPrice: {2:N2}\n"
                  , widget.Id
                  , widget.Description
                  , widget.Price);
        }

        // method defined as usual
        private static void displayPerson(string firstName, string lastName, int age)
        {
            Console.WriteLine("Name: {0} {1}\nAge:  {2}\n", firstName, lastName, age);
        }
    }
}

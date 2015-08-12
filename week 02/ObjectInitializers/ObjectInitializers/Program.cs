using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person =
              new Person { FirstName = "Moe", LastName = "Howard" };

            Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
        }
    }
}

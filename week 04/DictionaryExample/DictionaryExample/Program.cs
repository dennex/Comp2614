using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonDictionary people = new PersonDictionary();

            people.Add("MH", new Person { FirstName = "Moe", LastName = "Howard" });
            people.Add("CH", new Person { FirstName = "Curley", LastName = "Howard" });
            people.Add("LF", new Person { FirstName = "Larry", LastName = "Fine" });

            Console.WriteLine("{0}\n\n", people["LF"]);

            displayDictionary(people);

            people.Remove("CH");

            displayDictionary(people);
        }

        private static void displayDictionary(PersonDictionary personDictionary)
        {
            foreach (KeyValuePair<string, Person> kvp in personDictionary)
            {
                Console.WriteLine("{0} {1}", kvp.Key, kvp.Value);
            }

            Console.WriteLine();
        }
    }
}

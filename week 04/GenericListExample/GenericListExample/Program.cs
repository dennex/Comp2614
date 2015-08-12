using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonCollection people = new PersonCollection();

            people.Add(new Person { FirstName = "Larry", LastName = "Fine" });
            people.Add(new Person { FirstName = "Moe", LastName = "Howard" });
            people.Add(new Person { FirstName = "Curly", LastName = "Howard" });

            showPeople(people);

            people.RemoveAt(1);

            showPeople(people);

            Person person = people[0];

            people.Remove(person);

            showPeople(people);
        }

        static void showPeople(PersonCollection persons)
        {
            foreach (Person person in persons)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();
        }
    }
}

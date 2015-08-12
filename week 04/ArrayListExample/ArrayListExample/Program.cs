using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList students = new ArrayList();

            Student tempStudent;

            students.Add(new Student { ID = "A00123456", FirstName = "Cosmo", LastName = "Kramer" });
            students.Add(new Student { ID = "A00123412", FirstName = "Charlie", LastName = "Harper" });

            //Console.WriteLine(students[0].);

            tempStudent = (Student)students[0];

            Console.WriteLine(tempStudent.ID);

            students.Add(new Cat { Name = "Felix" });

            foreach (object item in students)
            {
                Console.WriteLine(item);
            }

        }
    }
}

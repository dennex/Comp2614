using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateTimeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = new DateTime(2011, 9, 26);

            int year = today.Year;
            int month = today.Month;
            int day = today.Day;

            DateTime tomorrow = today.AddDays(1);
            DateTime yesterday = today.AddDays(-1);

            string todayString = today.ToString("MMM d, yyyy");
            // returns Sep 26, 2011

            Console.WriteLine(todayString);
        }
    }
}

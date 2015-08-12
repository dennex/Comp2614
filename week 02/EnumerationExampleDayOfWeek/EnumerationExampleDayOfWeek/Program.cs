using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumerationExampleDayOfWeek
{
    public enum DaysOfWeek
    {
        Sunday
      , Monday
      , Tuesday
      , Wednesday
      , Thursday
      , Friday
      , Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            DaysOfWeek day = DaysOfWeek.Wednesday;
            DaysOfWeek nextDay = day + 1;

            Console.WriteLine("Today is:    {0}", day.ToString());
            Console.WriteLine("Tomorrow is: {0}", nextDay.ToString());
        }
    }
}

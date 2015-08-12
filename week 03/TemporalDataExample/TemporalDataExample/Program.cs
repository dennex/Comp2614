using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemporalDataExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;

            DateTime tomorrow = today.AddDays(1);

            DateTime yesterday = today.AddDays(-1);

            DateTime yesterdayDateOnly = yesterday.Date;

            TimeSpan yesterdayTimeOnly = yesterday.TimeOfDay;

            DateTime bom = new DateTime(DateTime.Now.Year
                                      , DateTime.Now.Month
                                      , 1);

            DateTime eom = bom.AddMonths(1).AddDays(-1);

            DateTime boy = new DateTime(DateTime.Now.Year
                                      , 1
                                      , 1);

            Console.WriteLine("Today is:      {0:MMM d, yyyy}", today);
            Console.WriteLine("Tomorrow is:   {0:yyyy/MM/dd}", tomorrow);
            Console.WriteLine("Yesterday was: {0}", yesterday);
            Console.WriteLine("Yesterday was: {0}", yesterdayDateOnly);
            Console.WriteLine("Yesterday was: {0}\n", yesterdayTimeOnly);

            Console.WriteLine("BofM was:      {0}", bom.ToShortDateString());
            Console.WriteLine("EofM is:       {0}", eom.ToString());
            Console.WriteLine("BofY was:      {0}\n", boy.ToLongDateString());

            Console.WriteLine("Min DateTimeValue: {0}", DateTime.MinValue);
            Console.WriteLine("Max DateTimeValue: {0}\n", DateTime.MaxValue);

            Console.WriteLine("Ticks on Jan 1, 0001: {0:N0}", new DateTime(1, 1, 1).Ticks);
            Console.WriteLine("Ticks on Jan 2, 0001: {0:N0}\n", new DateTime(1, 1, 2).Ticks);

            Console.WriteLine("Ticks since Jan 1, 0001: {0:N0}\n", DateTime.Now.Ticks);
        }
    }
}

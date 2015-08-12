using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeSpanExample
{
    class Program
    {        
        static void Main(string[] args)
        {
            TimeSpan span = new TimeSpan(0, 0, 3690);
                        
            Console.WriteLine("Duration: {0:D2}:{1:D2}:{2:D2}"
                                , span.Hours
                                , span.Minutes
                                , span.Seconds);
            // outputs Duration: 01:01:30
         
            Console.WriteLine("Total minutes: {0}\n"
                                , span.TotalMinutes);
            // outputs Total minutes: 61.5

            DateTime futureEvent = new DateTime(2011, 10, 14, 18, 0, 0);
            Console.WriteLine("Event scheduled at: {0:MMM d, yyyy hh:mm tt}", futureEvent);
            Console.WriteLine("Current time:       {0:MMM d, yyyy hh:mm tt}\n", DateTime.Now);

            TimeSpan timeToEvent = futureEvent - DateTime.Now;

            Console.WriteLine("Event will occur in {0} day{1}, {2} hour{3}, {4} minute{5}, {6} second{7}."
                                       , timeToEvent.Days
                                       , timeToEvent.Days == 1 ? "" :"s"
                                       , timeToEvent.Hours
                                       , timeToEvent.Hours == 1 ? "" : "s"
                                       , timeToEvent.Minutes
                                       , timeToEvent.Minutes == 1 ? "" : "s"
                                       , timeToEvent.Seconds
                                       , timeToEvent.Seconds == 1 ? "" : "s");
        }
    }
}

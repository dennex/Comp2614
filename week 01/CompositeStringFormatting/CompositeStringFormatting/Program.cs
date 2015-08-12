using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeStringFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemUser[] users = new SystemUser[5];

            users[0] = new SystemUser("Geoff", 15.2, UserType.Administrator);
            users[1] = new SystemUser("Bridgette", 3.09, UserType.Administrator);
            users[2] = new SystemUser("Andrew", 44.45, UserType.PowerUser);
            users[3] = new SystemUser("Brenda", 1, UserType.User);
            users[4] = new SystemUser("Natalie", 0, UserType.User);

            Console.WriteLine("Average Logins Per Week");
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("{0, -10}  {1, 10}  {2}", "Name", "Average", "User Type");
            Console.WriteLine(new string('=', 40));

            foreach (SystemUser user in users)
            {
                Console.WriteLine("{0, -10}  {1, 10:F2}  {2}"
                       , user.Name
                       , user.AvgLoginsPerWeek
                       , user.Type);
            }

            Console.ReadLine(); // to hold console window open
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Gillian";
            int numMessages = 1;

            // Create a literal, properly punctuated string first
            Console.WriteLine("Hello Gillian, you have 3 messages.");

            // Substitute variable text with placeholders
            Console.WriteLine("Hello {0}, you have {1} messages.", name, numMessages);

            // Take the extra effort to make your output grammatically correct
            Console.WriteLine("Hello {0}, you have {1} {2}."
                               , name
                               , numMessages
                               , numMessages == 1 ? "message" : "messages");


            // Can repeat index positions in the format string
            Console.WriteLine("Hello {0}, your name is {0}", name);

            // Excess data is ignored
            Console.WriteLine("Hello {0}, your name is {0}", name, numMessages);
        }
    }
}

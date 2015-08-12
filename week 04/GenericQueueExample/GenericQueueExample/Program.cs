using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericQueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("One");
            queue.Enqueue("Two");
            queue.Enqueue("Three");

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}

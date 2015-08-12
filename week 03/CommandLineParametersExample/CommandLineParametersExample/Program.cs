using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandLineParametersExample
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                for (int index = 0; index < args.Length; index++)
                {
                    Console.WriteLine("args[{0}] == {1}", index, args[index]);
                }
            }
        }
    }
}

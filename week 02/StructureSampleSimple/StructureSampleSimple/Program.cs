using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructureSampleSimple
{
    struct Coordinates
    {
        public int X, Y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Coordinates point;

            point.X = 10;
            point.Y = 25;

            Console.WriteLine("Your co-ordinates are: {0}, {1}"
                              , point.X
                              , point.Y);
        }
    }
}

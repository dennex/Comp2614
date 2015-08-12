using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructureSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinates first = new Coordinates(10, 10);
            Coordinates second = new Coordinates(13, 14);

            double distance = first.Distance(second);

            Console.WriteLine("Distance between the coordinates: {0}", distance);
        }
    }

    struct Coordinates
    {
        private int x;
        private int y;

        public Coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public double Distance(Coordinates otherPoint)
        {
            int distanceX = Math.Abs(this.X - otherPoint.X);
            int distanceY = Math.Abs(this.Y - otherPoint.Y);

            return Math.Sqrt((distanceX * distanceX) + (distanceY * distanceY));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
                new Circle()
              , new Triangle()
              , new Rectangle()
            };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Draw());
            }
        }
    }
}

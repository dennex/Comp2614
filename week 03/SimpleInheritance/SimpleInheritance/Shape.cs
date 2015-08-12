using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleInheritance
{
    class Shape
    {
        public virtual string Draw()
        {
            return "Drawing Shape";
        }
    }

    class Circle : Shape
    {
        public override string Draw()
        {
            return "Drawing Circle";
        }
    }

    class Triangle : Shape
    {
        // experiment with this, or other overridden Draw methods
        //  1) Remove the override keyword - run and observe behaviour
        //  2) Replace override with new - run and observe behaviour
        public override string Draw()
        {
            return "Drawing Triangle";
        }
    }

    class Rectangle : Shape
    {
        public override string Draw()
        {
            return "Drawing Rectangle";
        }
    }
}

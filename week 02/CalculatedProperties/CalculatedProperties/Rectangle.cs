using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatedProperties
{
    class Rectangle
    {
        private double width;
        private double height;

        public Rectangle()
        {

        }

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }


        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Area
        {
            get { return width * height; }
        }
    }
}

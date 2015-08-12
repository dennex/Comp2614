using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ByValByRefObjectExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Widget widget = new Widget(10);
            Console.WriteLine("Widget size (Original Value):   {0}\n", widget.Size);

            processWidget(widget);
            Console.WriteLine("Widget size (After ByVal Call): {0}\n", widget.Size);

            processWidget(ref widget);
            Console.WriteLine("Widget size (After ByRef Call): {0}\n", widget.Size);
        }

        private static void processWidget(Widget widget)
        {
            widget.Size = 20;
        }

        private static void processWidget(ref Widget widget)
        {
            widget.Size = 20;
        }
    }

    // class Widget
    struct Widget
    {
        private int size;

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public Widget(int size)
        {
            this.size = size;
        }
    }
}

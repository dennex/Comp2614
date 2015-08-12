using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayListExample
{
    class Cat
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return name;
        }
    }  
}

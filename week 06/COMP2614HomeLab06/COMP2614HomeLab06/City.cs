using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP2614HomeLab06
{
    class City
    {
        public string Name { get; private set; }
        public long Population { get; private set; }
        
        public City(string name, long population)
        {
            this.Name = name;
            this.Population = population;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

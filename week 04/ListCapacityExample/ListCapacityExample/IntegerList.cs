using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListCapacityExample
{
    class IntegerList : List<int>
    {
        public IntegerList()
        {

        }

        public IntegerList(int capacity)
            : base(capacity)
        {

        }
    }
}

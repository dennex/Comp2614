﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectInitializers
{
    class Person
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
    }
}

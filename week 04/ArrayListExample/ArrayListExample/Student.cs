using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayListExample
{
    class Student
    {
        private string id;
        private string firstName;
        private string lastName;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

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

        public override string ToString()
        {
            return string.Format("{0}: {1} {2}", id, firstName, lastName);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP2614HomeLab06
{
    class Contact
    {
        public string Name { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }

        public Contact(string name, string phone, string email)
        {
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
        } 

        public override string ToString()
        {
            return Name;
        }
    }
}

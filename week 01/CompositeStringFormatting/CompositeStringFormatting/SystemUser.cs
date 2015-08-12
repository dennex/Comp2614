using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeStringFormatting
{
    public enum UserType
    {
        Administrator
      , PowerUser
      , User
    }

    public class SystemUser
    {
        private string name;
        private double avgLoginsPerWeek;
        private UserType type;

        public SystemUser(string name, double avgLogins, UserType type)
        {
            this.name = name;
            this.avgLoginsPerWeek = avgLogins;
            this.type = type;
        }

        public string Name
        {
            get { return this.name; }
        }

        public double AvgLoginsPerWeek
        {
            get { return this.avgLoginsPerWeek; }
        }

        public UserType Type
        {
            get { return this.type; }
        }
    }
}

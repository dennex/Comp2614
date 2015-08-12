using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersonInput
{
    public partial class PersonControl : UserControl
    {
        public PersonControl()
        {
            InitializeComponent();
        }

        public string FirstName
        {
            get { return textBoxFirstName.Text; }
            set { textBoxFirstName.Text = value; }
        }

        public string LastName
        {
            get { return textBoxLastName.Text; }
            set { textBoxLastName.Text = value; }
        }

        public string Age
        {
            get { return textBoxAge.Text; }
            set { textBoxAge.Text = value; }
        }
    }
}

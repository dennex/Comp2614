using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace ErrorProviderDemo
{
    
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBoxFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxFirstName.Text == string.Empty)
            {
                errorProvider.SetError(textBoxFirstName, "Enter First Name");
            }
            else
            {
                errorProvider.SetError(textBoxFirstName, string.Empty);
            }
        }

        private void textBoxLastName_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxLastName.Text == string.Empty)
            {
                errorProvider.SetError(textBoxLastName, "Enter Last Name");
            }
            else
            {
                errorProvider.SetError(textBoxLastName, string.Empty);
            }

            
        }

        private void textBoxAge_Validating(object sender, CancelEventArgs e)
        {
            int age;

            if (!int.TryParse(textBoxAge.Text, out age))
            {
                errorProvider.SetError(textBoxAge, "Enter Age as Number");
            }
            else
            {
                errorProvider.SetError(textBoxAge, string.Empty);
            }
        }

        private void maskedTextBoxPostalCode_Validating(object sender, CancelEventArgs e)
        {
            string regExCdnPostalCode = @"^[A-Z]\d[A-Z] \d[A-Z]\d$";

            if (!Regex.IsMatch(maskedTextBoxPostalCode.Text, regExCdnPostalCode))
            {
                errorProvider.SetError(maskedTextBoxPostalCode, "Postal Code Format is Incorrect");
            }

            else
            {
                errorProvider.SetError(maskedTextBoxPostalCode, string.Empty);
            }      
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
        }
    }
}

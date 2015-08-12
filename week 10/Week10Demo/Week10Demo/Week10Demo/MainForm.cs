using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Week10Demo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (checkBoxUseErrorProvider.Checked)
            {
                validateBetter();
            }
            else
            {
                validate();
            }
        }

        private void validate()
        {
            int age;

            if (textBoxFirstName.Text == string.Empty)
            {
                MessageBox.Show("Enter a Firstname");
            }

            else if (textBoxLastName.Text == string.Empty)
            {
                MessageBox.Show("Enter a Lastname");
            } 

            else if (!int.TryParse(textBoxAge.Text, out age ))
            {
                MessageBox.Show("Enter Age as a Whole Number");
            }

        }

        private void validateBetter()
        {
            int age;

            if (textBoxFirstName.Text == string.Empty)
            {
                errorProviderMain.SetError(textBoxFirstName, "Enter a Firstname");
            }
            else
            {
                errorProviderMain.SetError(textBoxFirstName, string.Empty);
            }

            if (textBoxLastName.Text == string.Empty)
            {
                errorProviderMain.SetError(textBoxLastName, "Enter a Lastname");
            }
            else
            {
                errorProviderMain.SetError(textBoxLastName, string.Empty);
            }

            if (!int.TryParse(textBoxAge.Text, out age))
            {
                errorProviderMain.SetError(textBoxAge, "Enter Age as a Whole Number");
            }
            else
            {
                errorProviderMain.SetError(textBoxAge, string.Empty);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

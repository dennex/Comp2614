using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DateTimePickerTest
{
    public partial class DtpTestForm : Form
    {
        public DtpTestForm()
        {
            InitializeComponent();
        }

        private void dateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {
            labelDateOutput.Text = dateTimePickerStartDate.Value.ToString("MMM d, yyyy h:mm tt");
        }

        private void DtpTestForm_Load(object sender, EventArgs e)
        {
            labelDateOutput.Text = string.Empty;
            dateTimePickerStartDate.MinDate = new DateTime(2011, 5, 1);
        }

        private void buttonSetDate_Click(object sender, EventArgs e)
        {
            dateTimePickerStartDate.Value = new DateTime(2011, 5, 26, 18, 0, 0);
        }
    }
}

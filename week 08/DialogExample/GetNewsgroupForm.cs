using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DialogExample
{
	public partial class GetNewsgroupForm : Form
	{
		public GetNewsgroupForm()
		{
			InitializeComponent();
		}

        public string NewsgroupName
        {
            get { return textBoxNewsgroup.Text; }
            set { textBoxNewsgroup.Text = value; }
        }

		private void GetNewsgroupForm_Load(object sender, EventArgs e)
		{
			textBoxNewsgroup.Select();
			textBoxNewsgroup.SelectAll();
		}

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxNewsgroup.Text == "")
            {
                MessageBox.Show("Please enter a newsgroup", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
	}
}
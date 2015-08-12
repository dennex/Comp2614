using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ExceptionExample
{
	public partial class SingleValueInputForm : Form
	{
		private bool emptyInputAllowed;
		private bool mustBeDecimalValue;
		private decimal amount;	// If the input is a decimal value then this value is set.

		public SingleValueInputForm()
		{
			InitializeComponent();
		}

        private void SingleValueInputForm_Load(object sender, EventArgs e)
        {
            emptyInputAllowed = false;
            mustBeDecimalValue = false;
            amount = 0m;
        }

		public string Prompt
		{
			get { return labelPrompt.Text; }
			set { labelPrompt.Text = value; }
		}

		public string Input
		{
			get { return textBoxInput.Text; }
			set { textBoxInput.Text = value; }
		}

		public bool EmptyInputAllowed
		{
			get { return emptyInputAllowed; }
			set { emptyInputAllowed = value; }
		}

		public bool MustBeDecimalValue
		{
			get { return mustBeDecimalValue; }
			set { mustBeDecimalValue = value; }
		}

		public decimal Amount { get { return amount; } }

		protected bool validateData(out decimal amount)
		{
			amount = 0m;

			if(mustBeDecimalValue)
			{
				if (!decimal.TryParse(textBoxInput.Text, out amount))
				{
					MessageBox.Show("Invalid amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					textBoxInput.Select();
					textBoxInput.SelectAll();
					return false;
				}
				else
				{
					return true;
				}
			}
			else if(emptyInputAllowed)
			{
				return true;
			}
			else if(textBoxInput.Text != "")
			{
				decimal.TryParse(textBoxInput.Text, out amount);
				return true;
			}
			else
			{
				return false;
			}
		}

		private void textBoxInput_Enter(object sender, EventArgs e)
		{
			textBoxInput.SelectAll();
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (textBoxInput.Text == "" && !emptyInputAllowed)
			{
				MessageBox.Show("Must enter a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				textBoxInput.Select();
			}
			else
			{
				if(validateData(out amount))
				{
					this.DialogResult = DialogResult.OK;
				}
			}
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
	}
}
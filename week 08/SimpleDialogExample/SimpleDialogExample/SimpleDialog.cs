using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleDialogExample
{
	public partial class SimpleDialog : Form
	{
		public SimpleDialog()
		{
			InitializeComponent();
		}

		private void SimpleDialog_Load(object sender, EventArgs e)
		{
			// These properties can be set in the form designer properties window
			// instead of here.  This is to clarify the required settings.
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.AcceptButton = buttonOK;
			this.CancelButton = buttonCancel;
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			// Setting this object's DialogResult property to any value other than
			// None will 1) close the dialog and 2) complete the call to ShowDialog 
			// in the calling form.
			this.DialogResult = DialogResult.OK;
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			// Setting this object's DialogResult property to any value other than
			// None will 1) close the dialog and 2) complete the call to ShowDialog 
			// in the calling form.
			this.DialogResult = DialogResult.Cancel;
		}

	}
}
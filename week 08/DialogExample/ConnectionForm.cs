using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using COMP2614.News;

namespace DialogExample
{
	public partial class ConnectionForm : Form
	{
		private NewsConnection connection;

		public ConnectionForm()
		{
			InitializeComponent();
		}

		private void ConnectionForm_Load(object sender, EventArgs e)
		{
			// Default news server.
			textBoxNewsServer.Text = "forums.sybase.com";
			textBoxNewsServer.Select();
			textBoxNewsServer.SelectAll();

			refreshControls();
		}

		private void checkBoxAuthRequired_CheckedChanged(object sender, EventArgs e)
		{
			refreshControls();
		}

		private void refreshControls()
		{
			textBoxUsername.Enabled = textBoxPassword.Enabled = checkBoxAuthRequired.Checked;
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (validateData())
			{
				try
				{
					connection = new NewsConnection();
					connection.Connect(textBoxNewsServer.Text);

					// This will close the dialog.  It will also allow the caller to
					// learn that the user didn't cancel the dialog.
					this.DialogResult = DialogResult.OK;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}

		private bool validateData()
		{
			// Any form of data is valid here except username cannot
			// be blank if "authentication" is checked.

			if (checkBoxAuthRequired.Checked && textBoxUsername.Text == "")
			{
				// This is one time that I break my own rule that says 
				// a method should do what its name suggests and nothing
				// else.
				MessageBox.Show("Please enter a username.", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
				textBoxUsername.Focus();
				return false;
			}

			return true;
		}

		public NewsConnection Connection { get { return connection; } }
	}
}
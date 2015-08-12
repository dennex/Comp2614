using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleDialogExample
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			labelDlgResult.Text = string.Empty;
		}

		private void buttonDoDialog_Click(object sender, EventArgs e)
		{

			// Create and display the dialog *modally* (user must complete
			// the dialog before continuing with the app).
			SimpleDialog dlg = new SimpleDialog();
			dlg.ShowDialog();

			// Note that ShowDialog() is a blocking call, meaning that the code
			// below will not execute until after the dialog closes.

			if(dlg.DialogResult == DialogResult.OK)
			{
				labelDlgResult.ForeColor = Color.Green;
				labelDlgResult.Text = "Dialog complete (OK pressed).";
			}
			else if(dlg.DialogResult == DialogResult.Cancel)
			{
				labelDlgResult.ForeColor = Color.Red;
				labelDlgResult.Text = "Dialog canceled.";
			}
			else
			{
				labelDlgResult.ForeColor = Color.Red;
				labelDlgResult.Text = "Unexpected dialog result";
			}

            dlg.Dispose();
		}
	}
}
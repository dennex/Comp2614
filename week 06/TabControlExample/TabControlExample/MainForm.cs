using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TabControlExample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // initialize controls
            checkBoxAutoSave.Checked = true;
            checkBoxNewWindow.Checked = false;
            checkBoxPromptOnExit.Checked = true;

            textBoxPort.Text = "6200";
            textBoxTimeoutSeconds.Text = "15";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            // Notice that each control is inside a TabPage container control,
            // however, it is not necessary to refer to the TabPage or the TabControl
            // control at all in order to refer to each control inside the tab.
            // The TabControl and its TabPage controls are just containers, like the
            // GroupBox.
            sb.Append("General Options\n\n");
            sb.Append("Autosave: ");
            sb.Append(checkBoxAutoSave.Checked ? "Yes" : "No");
            sb.Append("\nPrompt on exit: ");
            sb.Append(checkBoxPromptOnExit.Checked ? "Yes" : "No");
            sb.Append("\nOpen each document in a separate window: ");
            sb.Append(checkBoxNewWindow.Checked ? "Yes" : "No");

            sb.Append("\n\nAdvanced Options\n\n");
            sb.Append("Connection port: ");
            sb.Append(textBoxPort.Text);
            sb.Append("\nTimeout: ");
            sb.Append(textBoxTimeoutSeconds.Text);
            sb.Append(" seconds");

            MessageBox.Show(sb.ToString(),
                    "All Options",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            Application.Exit();
        }

        private void tabControlOptions_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabControlOptions.SelectedTab == tabPageAdvanced)
            {
                if (MessageBox.Show("Are you sure you wish to change advanced options?",
                        "Advanced Options",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.No)
                {
                    // Don't allow the tab change.
                    e.Cancel = true;
                }
            }
        }

        private void tabControlOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set focus to the correct control, depending on the newly selected
            // tab.
            if (tabControlOptions.SelectedTab == tabPageGeneral)
            {
                buttonOK.Select();
            }
            else if (tabControlOptions.SelectedTab == tabPageAdvanced)
            {
                textBoxPort.Select();
                textBoxPort.SelectAll();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

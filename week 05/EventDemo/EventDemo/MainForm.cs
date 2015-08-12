using System;
using System.Windows.Forms;

namespace EventDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonClearEvents_Click(object sender, EventArgs e)
        {
            listBoxEvents.Items.Clear();
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("Form Click");
        }

        private void MainForm_DoubleClick(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("Form Double Click");
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("OK Button Click");
        }

        private void buttonOK_MouseClick(object sender, MouseEventArgs e)
        {
            listBoxEvents.Items.Add("OK Button Mouse Click");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("Cancel Button Click");
        }

        private void buttonCancel_MouseClick(object sender, MouseEventArgs e)
        {
            listBoxEvents.Items.Add("Cancel Button Mouse Click");
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("TextBox - Text Changed");
        }

        private void labelNamePrompt_Click(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("Name Label Click");
        }

        private void labelNamePrompt_DoubleClick(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("Name Label Double Click");
        }

        private void labelNamePrompt_MouseClick(object sender, MouseEventArgs e)
        {
            listBoxEvents.Items.Add("Name Label Mouse Click");
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("TextBox - Enter");
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("TextBox - Leave");
        }

        private void MainForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBoxEvents.Items.Add("Form Mouse Double Click");
        }

        private void listBoxEvents_DoubleClick(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("ListBox Double Click");
        }

        private void listBoxEvents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBoxEvents.Items.Add("ListBox Mouse Double Click");
        }
    }
}

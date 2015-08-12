using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextBoxExample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelGreeting.Text = string.Empty;
        }

        private void buttonCreateGreeting_Click(object sender, EventArgs e)
        {
            labelGreeting.Text = string.Format("Welcome, {0} {1}!"
                       , textBoxFirstName.Text
                       , textBoxLastName.Text);

            // clear text boxes
            textBoxFirstName.Text = string.Empty;
            textBoxLastName.Text = string.Empty;

            // set focus to First name textbox ready for next entry
            textBoxFirstName.Select();
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            // labelGreeting.Text = string.Format("X:{0} Y:{1}", e.X, e.Y);
        }
    }
}

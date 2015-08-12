using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExtensionMethods
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelResult.Text = string.Empty;
        }

        private void buttonLower_Click(object sender, EventArgs e)
        {
            labelResult.Text = textBoxInput.Text.ToLower();

            textBoxInput.Select();
            textBoxInput.SelectAll();
        }

        private void buttonUpper_Click(object sender, EventArgs e)
        {
            labelResult.Text = textBoxInput.Text.ToUpper();

            textBoxInput.Select();
            textBoxInput.SelectAll();
        }

        private void buttonProperStatic_Click(object sender, EventArgs e)
        {
            labelResult.Text = StringUtilities.ToProper(textBoxInput.Text);

            textBoxInput.Select();
            textBoxInput.SelectAll();
        }

        private void buttonProperExtension_Click(object sender, EventArgs e)
        {
            labelResult.Text = textBoxInput.Text.ToProper();

            textBoxInput.Select();
            textBoxInput.SelectAll();
        }
    }
}

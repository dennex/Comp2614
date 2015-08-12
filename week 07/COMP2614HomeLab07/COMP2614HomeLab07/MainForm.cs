using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace COMP2614HomeLab07
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotes.BackColor = Color.Red;
            textBoxNotes.ForeColor = Color.White;
            toolStripStatusLabelBgColor.Text = "Background Color Red";
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotes.BackColor = Color.Green;
            textBoxNotes.ForeColor = Color.White;
            toolStripStatusLabelBgColor.Text = "Background Color Green";
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotes.BackColor = Color.Blue;
            textBoxNotes.ForeColor = Color.White;
            toolStripStatusLabelBgColor.Text = "Background Color Blue";
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxNotes.BackColor = Color.White;
            textBoxNotes.ForeColor = Color.Black;
            toolStripStatusLabelBgColor.Text = "Background Color White";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("COMP2614 Home Lab 07");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelBgColor.Text = "Background Color White";
        }
    }
}

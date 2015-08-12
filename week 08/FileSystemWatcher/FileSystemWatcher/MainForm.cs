using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Create a folder C:\Test on your machine
//  Copy files with and without .txt extensions
//  Change Properties and observer behaviour

namespace FileSystemWatcher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Initialize FileSystemWatcher
                fileSystemWatcher.EnableRaisingEvents = true;
                fileSystemWatcher.Path = @"C:\Test";
                fileSystemWatcher.IncludeSubdirectories = false;
                fileSystemWatcher.Filter = @"*.txt";

                // Initialize Display
                checkBoxEnable.Checked = fileSystemWatcher.EnableRaisingEvents;
                labelDirectory.Text = fileSystemWatcher.Path;
                labelInclude.Text = fileSystemWatcher.IncludeSubdirectories.ToString();
                labelFilter.Text = fileSystemWatcher.Filter;

                // Initialize StatusStrip
                statusBarLabel.Text = string.Format("Monitoring {0}", fileSystemWatcher.Path);

            }
            catch (Exception ex)
            {
                statusBarLabel.Text = ex.Message;
            }
        }

        private void fileSystemWatcher_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            textBoxResults.Text += string.Format("File {0} added\r\n", e.FullPath);
        }

        private void fileSystemWatcher_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            textBoxResults.Text += string.Format("File {0} deleted\r\n", e.FullPath);
        }

        private void fileSystemWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            textBoxResults.Text += string.Format("File {0} changed {1}\r\n", e.FullPath, e.ChangeType.ToString());
        }

        private void fileSystemWatcher_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            textBoxResults.Text += string.Format("File {0} renamed to {1}\r\n", e.OldFullPath, e.FullPath);
        }

        private void checkBoxEnable_CheckedChanged(object sender, EventArgs e)
        {
            fileSystemWatcher.EnableRaisingEvents = checkBoxEnable.Checked;

            if (checkBoxEnable.Checked)
            {
                statusBarLabel.Text = string.Format("Monitoring {0}", fileSystemWatcher.Path);
            }
            else
            {
                statusBarLabel.Text = string.Empty;
            }
        }
    }
}

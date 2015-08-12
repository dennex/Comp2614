using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TreeViewExample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TreeNode node;
            TreeNode rootNode; ;

            treeViewCities.ImageList = imageList;

            treeViewCities.BeginUpdate();
            
            rootNode = treeViewCities.Nodes.Add("Canada");

            rootNode.ImageIndex = 0;
            rootNode.SelectedImageIndex = 1;
       
            node = rootNode.Nodes.Add("British Columbia");
            node.Nodes.Add("Richmond");
            node.Nodes.Add("Surrey");
            node.Nodes.Add("Vancouver");
            node.Nodes.Add("Victoria");

            node.ImageIndex = 0;
            node.SelectedImageIndex = 1;

            node = rootNode.Nodes.Add("Alberta");
            node.Nodes.Add("Calgary");
            node.Nodes.Add("Edmonton");
            node.Nodes.Add("Lethbridge");
            node.Nodes.Add("Red Deer");

            node.ImageIndex = 0;
            node.SelectedImageIndex = 1;

            node = rootNode.Nodes.Add("Saskatchewan");
            node.Nodes.Add("Regina");
            node.Nodes.Add("Saskatoon");
            node.Nodes.Add("Weyburn");
            node.Nodes.Add("Yorkton");

            node.ImageIndex = 0;
            node.SelectedImageIndex = 1;
            
            node = rootNode.Nodes.Add("Manitoba");
            node.Nodes.Add("Brandon");
            node.Nodes.Add("Dauphin");
            node.Nodes.Add("Flin Flon");
            node.Nodes.Add("Winnipeg");

            node.ImageIndex = 0;
            node.SelectedImageIndex = 1;

            treeViewCities.EndUpdate();
        }


        private void treeViewCities_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            listBoxEvents.Items.Add("After Collapse: " + e.Node.Text);
        }

        private void treeViewCities_AfterExpand(object sender, TreeViewEventArgs e)
        {
            listBoxEvents.Items.Add("After Expand: " + e.Node.Text);
        }

        private void treeViewCities_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string data = string.Empty;
            
            listBoxEvents.Items.Add("After Select: " + e.Node.Text);

            textBoxDetails.Text = data;

            data += "Full Path:   " + e.Node.FullPath + "\r\n";
            data += "Node Level:  " + e.Node.Level.ToString() + "\r\n";
            data += "Prev Node:   " + e.Node.PrevNode + "\r\n";
            data += "Next Node:   " + e.Node.NextNode + "\r\n";
            data += "Parent Node: " + e.Node.Parent + "\r\n";

            textBoxDetails.Text = data;
        }

        private void treeViewCities_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            listBoxEvents.Items.Add("Before Collapse: " + e.Node.Text);
        }

        private void treeViewCities_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            listBoxEvents.Items.Add("Before Expand: " + e.Node.Text);
        }

        private void treeViewCities_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            listBoxEvents.Items.Add("Before Select: " + e.Node.Text);
        }


        private void buttonClearEvents_Click(object sender, EventArgs e)
        {
            listBoxEvents.Items.Clear();
        }

        private void treeViewCities_Click(object sender, EventArgs e)
        {
            listBoxEvents.Items.Add("TreeView Click");
        }
    }
}

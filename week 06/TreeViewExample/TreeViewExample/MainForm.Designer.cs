namespace TreeViewExample
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainerVertical = new System.Windows.Forms.SplitContainer();
            this.treeViewCities = new System.Windows.Forms.TreeView();
            this.splitContainerHorizontal = new System.Windows.Forms.SplitContainer();
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.buttonClearEvents = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVertical)).BeginInit();
            this.splitContainerVertical.Panel1.SuspendLayout();
            this.splitContainerVertical.Panel2.SuspendLayout();
            this.splitContainerVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHorizontal)).BeginInit();
            this.splitContainerHorizontal.Panel1.SuspendLayout();
            this.splitContainerHorizontal.Panel2.SuspendLayout();
            this.splitContainerHorizontal.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerVertical
            // 
            this.splitContainerVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerVertical.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerVertical.Location = new System.Drawing.Point(0, 0);
            this.splitContainerVertical.Name = "splitContainerVertical";
            // 
            // splitContainerVertical.Panel1
            // 
            this.splitContainerVertical.Panel1.Controls.Add(this.treeViewCities);
            // 
            // splitContainerVertical.Panel2
            // 
            this.splitContainerVertical.Panel2.Controls.Add(this.splitContainerHorizontal);
            this.splitContainerVertical.Size = new System.Drawing.Size(642, 412);
            this.splitContainerVertical.SplitterDistance = 192;
            this.splitContainerVertical.SplitterWidth = 5;
            this.splitContainerVertical.TabIndex = 0;
            // 
            // treeViewCities
            // 
            this.treeViewCities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewCities.Location = new System.Drawing.Point(0, 0);
            this.treeViewCities.Name = "treeViewCities";
            this.treeViewCities.Size = new System.Drawing.Size(192, 412);
            this.treeViewCities.TabIndex = 0;
            this.treeViewCities.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewCities_BeforeCollapse);
            this.treeViewCities.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCities_AfterCollapse);
            this.treeViewCities.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewCities_BeforeExpand);
            this.treeViewCities.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCities_AfterExpand);
            this.treeViewCities.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewCities_BeforeSelect);
            this.treeViewCities.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCities_AfterSelect);
            this.treeViewCities.Click += new System.EventHandler(this.treeViewCities_Click);
            // 
            // splitContainerHorizontal
            // 
            this.splitContainerHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerHorizontal.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerHorizontal.Location = new System.Drawing.Point(0, 0);
            this.splitContainerHorizontal.Name = "splitContainerHorizontal";
            this.splitContainerHorizontal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerHorizontal.Panel1
            // 
            this.splitContainerHorizontal.Panel1.Controls.Add(this.textBoxDetails);
            // 
            // splitContainerHorizontal.Panel2
            // 
            this.splitContainerHorizontal.Panel2.Controls.Add(this.listBoxEvents);
            this.splitContainerHorizontal.Panel2.Controls.Add(this.panelHeader);
            this.splitContainerHorizontal.Size = new System.Drawing.Size(445, 412);
            this.splitContainerHorizontal.SplitterDistance = 145;
            this.splitContainerHorizontal.SplitterWidth = 5;
            this.splitContainerHorizontal.TabIndex = 0;
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDetails.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDetails.Location = new System.Drawing.Point(0, 0);
            this.textBoxDetails.Multiline = true;
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.ReadOnly = true;
            this.textBoxDetails.Size = new System.Drawing.Size(445, 145);
            this.textBoxDetails.TabIndex = 0;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.IntegralHeight = false;
            this.listBoxEvents.ItemHeight = 15;
            this.listBoxEvents.Location = new System.Drawing.Point(0, 30);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(445, 232);
            this.listBoxEvents.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Controls.Add(this.buttonClearEvents);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(445, 30);
            this.panelHeader.TabIndex = 0;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(2, 7);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(109, 17);
            this.labelHeader.TabIndex = 3;
            this.labelHeader.Text = "TreeView Events";
            // 
            // buttonClearEvents
            // 
            this.buttonClearEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearEvents.Location = new System.Drawing.Point(358, 3);
            this.buttonClearEvents.Name = "buttonClearEvents";
            this.buttonClearEvents.Size = new System.Drawing.Size(75, 23);
            this.buttonClearEvents.TabIndex = 2;
            this.buttonClearEvents.Text = "&Clear";
            this.buttonClearEvents.UseVisualStyleBackColor = true;
            this.buttonClearEvents.Click += new System.EventHandler(this.buttonClearEvents_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Red;
            this.imageList.Images.SetKeyName(0, "folder-closed.bmp");
            this.imageList.Images.SetKeyName(1, "folder-open.bmp");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 412);
            this.Controls.Add(this.splitContainerVertical);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TreeView Example";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainerVertical.Panel1.ResumeLayout(false);
            this.splitContainerVertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVertical)).EndInit();
            this.splitContainerVertical.ResumeLayout(false);
            this.splitContainerHorizontal.Panel1.ResumeLayout(false);
            this.splitContainerHorizontal.Panel1.PerformLayout();
            this.splitContainerHorizontal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHorizontal)).EndInit();
            this.splitContainerHorizontal.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerVertical;
        private System.Windows.Forms.TreeView treeViewCities;
        private System.Windows.Forms.SplitContainer splitContainerHorizontal;
        private System.Windows.Forms.TextBox textBoxDetails;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonClearEvents;
        private System.Windows.Forms.ImageList imageList;
    }
}


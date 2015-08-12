namespace FileSystemWatcher
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
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.textBoxResults = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelPromptDirectory = new System.Windows.Forms.Label();
            this.labelDirectory = new System.Windows.Forms.Label();
            this.labelPromptInclude = new System.Windows.Forms.Label();
            this.labelInclude = new System.Windows.Forms.Label();
            this.labelPromptFilter = new System.Windows.Forms.Label();
            this.labelFilter = new System.Windows.Forms.Label();
            this.labelChanges = new System.Windows.Forms.Label();
            this.checkBoxEnable = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.SynchronizingObject = this;
            this.fileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
            this.fileSystemWatcher.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Created);
            this.fileSystemWatcher.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Deleted);
            this.fileSystemWatcher.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher_Renamed);
            // 
            // textBoxResults
            // 
            this.textBoxResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResults.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxResults.Location = new System.Drawing.Point(12, 137);
            this.textBoxResults.Multiline = true;
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.ReadOnly = true;
            this.textBoxResults.Size = new System.Drawing.Size(370, 226);
            this.textBoxResults.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarLabel});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip.Location = new System.Drawing.Point(0, 376);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(394, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusBarLabel
            // 
            this.statusBarLabel.AutoSize = false;
            this.statusBarLabel.Name = "statusBarLabel";
            this.statusBarLabel.Size = new System.Drawing.Size(300, 14);
            this.statusBarLabel.Spring = true;
            this.statusBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPromptDirectory
            // 
            this.labelPromptDirectory.AutoSize = true;
            this.labelPromptDirectory.Location = new System.Drawing.Point(14, 9);
            this.labelPromptDirectory.Name = "labelPromptDirectory";
            this.labelPromptDirectory.Size = new System.Drawing.Size(52, 13);
            this.labelPromptDirectory.TabIndex = 2;
            this.labelPromptDirectory.Text = "Directory:";
            // 
            // labelDirectory
            // 
            this.labelDirectory.AutoSize = true;
            this.labelDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDirectory.Location = new System.Drawing.Point(141, 6);
            this.labelDirectory.Name = "labelDirectory";
            this.labelDirectory.Size = new System.Drawing.Size(76, 16);
            this.labelDirectory.TabIndex = 3;
            this.labelDirectory.Text = "<Directory>";
            // 
            // labelPromptInclude
            // 
            this.labelPromptInclude.AutoSize = true;
            this.labelPromptInclude.Location = new System.Drawing.Point(14, 31);
            this.labelPromptInclude.Name = "labelPromptInclude";
            this.labelPromptInclude.Size = new System.Drawing.Size(115, 13);
            this.labelPromptInclude.TabIndex = 4;
            this.labelPromptInclude.Text = "Include Subdirectories:";
            // 
            // labelInclude
            // 
            this.labelInclude.AutoSize = true;
            this.labelInclude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInclude.Location = new System.Drawing.Point(141, 29);
            this.labelInclude.Name = "labelInclude";
            this.labelInclude.Size = new System.Drawing.Size(65, 16);
            this.labelInclude.TabIndex = 5;
            this.labelInclude.Text = "<Include>";
            // 
            // labelPromptFilter
            // 
            this.labelPromptFilter.AutoSize = true;
            this.labelPromptFilter.Location = new System.Drawing.Point(14, 53);
            this.labelPromptFilter.Name = "labelPromptFilter";
            this.labelPromptFilter.Size = new System.Drawing.Size(30, 13);
            this.labelPromptFilter.TabIndex = 6;
            this.labelPromptFilter.Text = "Flter:";
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(141, 51);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(51, 16);
            this.labelFilter.TabIndex = 7;
            this.labelFilter.Text = "<Filter>";
            // 
            // labelChanges
            // 
            this.labelChanges.AutoSize = true;
            this.labelChanges.Location = new System.Drawing.Point(12, 121);
            this.labelChanges.Name = "labelChanges";
            this.labelChanges.Size = new System.Drawing.Size(71, 13);
            this.labelChanges.TabIndex = 8;
            this.labelChanges.Text = "File Changes:";
            // 
            // checkBoxEnable
            // 
            this.checkBoxEnable.AutoSize = true;
            this.checkBoxEnable.Location = new System.Drawing.Point(17, 83);
            this.checkBoxEnable.Name = "checkBoxEnable";
            this.checkBoxEnable.Size = new System.Drawing.Size(133, 17);
            this.checkBoxEnable.TabIndex = 9;
            this.checkBoxEnable.Text = "&Enable Raising Events";
            this.checkBoxEnable.UseVisualStyleBackColor = true;
            this.checkBoxEnable.CheckedChanged += new System.EventHandler(this.checkBoxEnable_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 398);
            this.Controls.Add(this.checkBoxEnable);
            this.Controls.Add(this.labelChanges);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.labelPromptFilter);
            this.Controls.Add(this.labelInclude);
            this.Controls.Add(this.labelPromptInclude);
            this.Controls.Add(this.labelDirectory);
            this.Controls.Add(this.labelPromptDirectory);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.textBoxResults);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File System Watcher Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.TextBox textBoxResults;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusBarLabel;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.Label labelPromptFilter;
        private System.Windows.Forms.Label labelInclude;
        private System.Windows.Forms.Label labelPromptInclude;
        private System.Windows.Forms.Label labelDirectory;
        private System.Windows.Forms.Label labelPromptDirectory;
        private System.Windows.Forms.Label labelChanges;
        private System.Windows.Forms.CheckBox checkBoxEnable;
    }
}


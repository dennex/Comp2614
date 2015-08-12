namespace EventDemo
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
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.buttonClearEvents = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelNamePrompt = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEvents.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 17;
            this.listBoxEvents.Location = new System.Drawing.Point(368, 68);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(322, 446);
            this.listBoxEvents.TabIndex = 0;
            this.listBoxEvents.DoubleClick += new System.EventHandler(this.listBoxEvents_DoubleClick);
            this.listBoxEvents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxEvents_MouseDoubleClick);
            // 
            // buttonClearEvents
            // 
            this.buttonClearEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearEvents.Location = new System.Drawing.Point(582, 35);
            this.buttonClearEvents.Name = "buttonClearEvents";
            this.buttonClearEvents.Size = new System.Drawing.Size(108, 27);
            this.buttonClearEvents.TabIndex = 1;
            this.buttonClearEvents.Text = "Clear &Events";
            this.buttonClearEvents.UseVisualStyleBackColor = true;
            this.buttonClearEvents.Click += new System.EventHandler(this.buttonClearEvents_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(128, 174);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(87, 27);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            this.buttonOK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonOK_MouseClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(221, 174);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 27);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            this.buttonCancel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonCancel_MouseClick);
            // 
            // labelNamePrompt
            // 
            this.labelNamePrompt.AutoSize = true;
            this.labelNamePrompt.Location = new System.Drawing.Point(28, 71);
            this.labelNamePrompt.Name = "labelNamePrompt";
            this.labelNamePrompt.Size = new System.Drawing.Size(42, 15);
            this.labelNamePrompt.TabIndex = 4;
            this.labelNamePrompt.Text = "&Name:";
            this.labelNamePrompt.Click += new System.EventHandler(this.labelNamePrompt_Click);
            this.labelNamePrompt.DoubleClick += new System.EventHandler(this.labelNamePrompt_DoubleClick);
            this.labelNamePrompt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelNamePrompt_MouseClick);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(80, 68);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(228, 23);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(702, 528);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelNamePrompt);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonClearEvents);
            this.Controls.Add(this.listBoxEvents);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Demo";
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.DoubleClick += new System.EventHandler(this.MainForm_DoubleClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Button buttonClearEvents;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelNamePrompt;
        private System.Windows.Forms.TextBox textBoxName;
    }
}


namespace TabControlExample
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
            this.textBoxTimeoutSeconds = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.tabControlOptions = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.checkBoxNewWindow = new System.Windows.Forms.CheckBox();
            this.checkBoxPromptOnExit = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoSave = new System.Windows.Forms.CheckBox();
            this.tabPageAdvanced = new System.Windows.Forms.TabPage();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelPromptSeconds = new System.Windows.Forms.Label();
            this.labelPromptTimeout = new System.Windows.Forms.Label();
            this.labelPromptConnectionPort = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tabControlOptions.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.tabPageAdvanced.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTimeoutSeconds
            // 
            this.textBoxTimeoutSeconds.Location = new System.Drawing.Point(98, 37);
            this.textBoxTimeoutSeconds.Name = "textBoxTimeoutSeconds";
            this.textBoxTimeoutSeconds.Size = new System.Drawing.Size(84, 20);
            this.textBoxTimeoutSeconds.TabIndex = 3;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(137, 188);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // tabControlOptions
            // 
            this.tabControlOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlOptions.Controls.Add(this.tabPageGeneral);
            this.tabControlOptions.Controls.Add(this.tabPageAdvanced);
            this.tabControlOptions.Location = new System.Drawing.Point(0, 12);
            this.tabControlOptions.Name = "tabControlOptions";
            this.tabControlOptions.SelectedIndex = 0;
            this.tabControlOptions.Size = new System.Drawing.Size(293, 162);
            this.tabControlOptions.TabIndex = 2;
            this.tabControlOptions.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlOptions_Selecting);
            this.tabControlOptions.SelectedIndexChanged += new System.EventHandler(this.tabControlOptions_SelectedIndexChanged);
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.checkBoxNewWindow);
            this.tabPageGeneral.Controls.Add(this.checkBoxPromptOnExit);
            this.tabPageGeneral.Controls.Add(this.checkBoxAutoSave);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(285, 136);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // checkBoxNewWindow
            // 
            this.checkBoxNewWindow.AutoSize = true;
            this.checkBoxNewWindow.Location = new System.Drawing.Point(14, 59);
            this.checkBoxNewWindow.Name = "checkBoxNewWindow";
            this.checkBoxNewWindow.Size = new System.Drawing.Size(211, 17);
            this.checkBoxNewWindow.TabIndex = 2;
            this.checkBoxNewWindow.Text = "&Open each document in a new window";
            this.checkBoxNewWindow.UseVisualStyleBackColor = true;
            // 
            // checkBoxPromptOnExit
            // 
            this.checkBoxPromptOnExit.AutoSize = true;
            this.checkBoxPromptOnExit.Location = new System.Drawing.Point(14, 36);
            this.checkBoxPromptOnExit.Name = "checkBoxPromptOnExit";
            this.checkBoxPromptOnExit.Size = new System.Drawing.Size(238, 17);
            this.checkBoxPromptOnExit.TabIndex = 1;
            this.checkBoxPromptOnExit.Text = "&Prompt on exit when document needs saving";
            this.checkBoxPromptOnExit.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoSave
            // 
            this.checkBoxAutoSave.AutoSize = true;
            this.checkBoxAutoSave.Location = new System.Drawing.Point(14, 13);
            this.checkBoxAutoSave.Name = "checkBoxAutoSave";
            this.checkBoxAutoSave.Size = new System.Drawing.Size(71, 17);
            this.checkBoxAutoSave.TabIndex = 0;
            this.checkBoxAutoSave.Text = "&Autosave";
            this.checkBoxAutoSave.UseVisualStyleBackColor = true;
            // 
            // tabPageAdvanced
            // 
            this.tabPageAdvanced.Controls.Add(this.textBoxTimeoutSeconds);
            this.tabPageAdvanced.Controls.Add(this.textBoxPort);
            this.tabPageAdvanced.Controls.Add(this.labelPromptSeconds);
            this.tabPageAdvanced.Controls.Add(this.labelPromptTimeout);
            this.tabPageAdvanced.Controls.Add(this.labelPromptConnectionPort);
            this.tabPageAdvanced.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdvanced.Name = "tabPageAdvanced";
            this.tabPageAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdvanced.Size = new System.Drawing.Size(285, 136);
            this.tabPageAdvanced.TabIndex = 1;
            this.tabPageAdvanced.Text = "Advanced";
            this.tabPageAdvanced.UseVisualStyleBackColor = true;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(98, 12);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(84, 20);
            this.textBoxPort.TabIndex = 1;
            // 
            // labelPromptSeconds
            // 
            this.labelPromptSeconds.AutoSize = true;
            this.labelPromptSeconds.Location = new System.Drawing.Point(192, 40);
            this.labelPromptSeconds.Name = "labelPromptSeconds";
            this.labelPromptSeconds.Size = new System.Drawing.Size(47, 13);
            this.labelPromptSeconds.TabIndex = 4;
            this.labelPromptSeconds.Text = "seconds";
            // 
            // labelPromptTimeout
            // 
            this.labelPromptTimeout.AutoSize = true;
            this.labelPromptTimeout.Location = new System.Drawing.Point(6, 40);
            this.labelPromptTimeout.Name = "labelPromptTimeout";
            this.labelPromptTimeout.Size = new System.Drawing.Size(48, 13);
            this.labelPromptTimeout.TabIndex = 2;
            this.labelPromptTimeout.Text = "&Timeout:";
            // 
            // labelPromptConnectionPort
            // 
            this.labelPromptConnectionPort.AutoSize = true;
            this.labelPromptConnectionPort.Location = new System.Drawing.Point(6, 15);
            this.labelPromptConnectionPort.Name = "labelPromptConnectionPort";
            this.labelPromptConnectionPort.Size = new System.Drawing.Size(85, 13);
            this.labelPromptConnectionPort.TabIndex = 0;
            this.labelPromptConnectionPort.Text = "Connection &port:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(218, 188);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(298, 219);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.tabControlOptions);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlOptions.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.tabPageAdvanced.ResumeLayout(false);
            this.tabPageAdvanced.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTimeoutSeconds;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TabControl tabControlOptions;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.CheckBox checkBoxNewWindow;
        private System.Windows.Forms.CheckBox checkBoxPromptOnExit;
        private System.Windows.Forms.CheckBox checkBoxAutoSave;
        private System.Windows.Forms.TabPage tabPageAdvanced;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelPromptSeconds;
        private System.Windows.Forms.Label labelPromptTimeout;
        private System.Windows.Forms.Label labelPromptConnectionPort;
        private System.Windows.Forms.Button buttonCancel;
    }
}


namespace COMP2614HomeLab08
{
    partial class LibraryBookDialog
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxCopyrightYear = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelCopyrightYearPrompt = new System.Windows.Forms.Label();
            this.labelAuthorPrompt = new System.Windows.Forms.Label();
            this.labelTitlePrompt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(388, 103);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(307, 103);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 14;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxCopyrightYear
            // 
            this.textBoxCopyrightYear.Location = new System.Drawing.Point(95, 65);
            this.textBoxCopyrightYear.Name = "textBoxCopyrightYear";
            this.textBoxCopyrightYear.Size = new System.Drawing.Size(76, 20);
            this.textBoxCopyrightYear.TabIndex = 13;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(95, 41);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(368, 20);
            this.textBoxAuthor.TabIndex = 11;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(95, 17);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(368, 20);
            this.textBoxTitle.TabIndex = 9;
            // 
            // labelCopyrightYearPrompt
            // 
            this.labelCopyrightYearPrompt.AutoSize = true;
            this.labelCopyrightYearPrompt.Location = new System.Drawing.Point(12, 68);
            this.labelCopyrightYearPrompt.Name = "labelCopyrightYearPrompt";
            this.labelCopyrightYearPrompt.Size = new System.Drawing.Size(79, 13);
            this.labelCopyrightYearPrompt.TabIndex = 12;
            this.labelCopyrightYearPrompt.Text = "Copyright &Year:";
            // 
            // labelAuthorPrompt
            // 
            this.labelAuthorPrompt.AutoSize = true;
            this.labelAuthorPrompt.Location = new System.Drawing.Point(12, 44);
            this.labelAuthorPrompt.Name = "labelAuthorPrompt";
            this.labelAuthorPrompt.Size = new System.Drawing.Size(41, 13);
            this.labelAuthorPrompt.TabIndex = 10;
            this.labelAuthorPrompt.Text = "&Author:";
            // 
            // labelTitlePrompt
            // 
            this.labelTitlePrompt.AutoSize = true;
            this.labelTitlePrompt.Location = new System.Drawing.Point(12, 20);
            this.labelTitlePrompt.Name = "labelTitlePrompt";
            this.labelTitlePrompt.Size = new System.Drawing.Size(30, 13);
            this.labelTitlePrompt.TabIndex = 8;
            this.labelTitlePrompt.Text = "&Title:";
            // 
            // LibraryBookDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(479, 141);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxCopyrightYear);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelCopyrightYearPrompt);
            this.Controls.Add(this.labelAuthorPrompt);
            this.Controls.Add(this.labelTitlePrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LibraryBookDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Library Book";
            this.Load += new System.EventHandler(this.LibraryBookDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxCopyrightYear;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelCopyrightYearPrompt;
        private System.Windows.Forms.Label labelAuthorPrompt;
        private System.Windows.Forms.Label labelTitlePrompt;
    }
}
namespace Week10Demo
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
            this.labelFirstNamePrompt = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastNamePrompt = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelAgePrompt = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxUseErrorProvider = new System.Windows.Forms.CheckBox();
            this.errorProviderMain = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFirstNamePrompt
            // 
            this.labelFirstNamePrompt.AutoSize = true;
            this.labelFirstNamePrompt.Location = new System.Drawing.Point(23, 24);
            this.labelFirstNamePrompt.Name = "labelFirstNamePrompt";
            this.labelFirstNamePrompt.Size = new System.Drawing.Size(58, 13);
            this.labelFirstNamePrompt.TabIndex = 0;
            this.labelFirstNamePrompt.Text = "&First name:";
            // 
            // textBoxFirstName
            // 
            this.errorProviderMain.SetIconPadding(this.textBoxFirstName, 3);
            this.textBoxFirstName.Location = new System.Drawing.Point(88, 21);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(203, 20);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            this.errorProviderMain.SetIconPadding(this.textBoxLastName, 3);
            this.textBoxLastName.Location = new System.Drawing.Point(88, 47);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(203, 20);
            this.textBoxLastName.TabIndex = 3;
            // 
            // labelLastNamePrompt
            // 
            this.labelLastNamePrompt.AutoSize = true;
            this.labelLastNamePrompt.Location = new System.Drawing.Point(23, 50);
            this.labelLastNamePrompt.Name = "labelLastNamePrompt";
            this.labelLastNamePrompt.Size = new System.Drawing.Size(59, 13);
            this.labelLastNamePrompt.TabIndex = 2;
            this.labelLastNamePrompt.Text = "&Last name:";
            // 
            // textBoxAge
            // 
            this.errorProviderMain.SetIconPadding(this.textBoxAge, 3);
            this.textBoxAge.Location = new System.Drawing.Point(88, 73);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(80, 20);
            this.textBoxAge.TabIndex = 5;
            // 
            // labelAgePrompt
            // 
            this.labelAgePrompt.AutoSize = true;
            this.labelAgePrompt.Location = new System.Drawing.Point(23, 76);
            this.labelAgePrompt.Name = "labelAgePrompt";
            this.labelAgePrompt.Size = new System.Drawing.Size(29, 13);
            this.labelAgePrompt.TabIndex = 4;
            this.labelAgePrompt.Text = "&Age:";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(135, 122);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(216, 122);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // checkBoxUseErrorProvider
            // 
            this.checkBoxUseErrorProvider.AutoSize = true;
            this.checkBoxUseErrorProvider.Location = new System.Drawing.Point(26, 99);
            this.checkBoxUseErrorProvider.Name = "checkBoxUseErrorProvider";
            this.checkBoxUseErrorProvider.Size = new System.Drawing.Size(112, 17);
            this.checkBoxUseErrorProvider.TabIndex = 8;
            this.checkBoxUseErrorProvider.Text = "&Use Error Provider";
            this.checkBoxUseErrorProvider.UseVisualStyleBackColor = true;
            // 
            // errorProviderMain
            // 
            this.errorProviderMain.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderMain.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(319, 159);
            this.Controls.Add(this.checkBoxUseErrorProvider);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.labelAgePrompt);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastNamePrompt);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelFirstNamePrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Week 10 Demo";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstNamePrompt;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastNamePrompt;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelAgePrompt;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxUseErrorProvider;
        private System.Windows.Forms.ErrorProvider errorProviderMain;
    }
}


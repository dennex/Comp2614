namespace ErrorProviderDemo
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
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelAgePrompt = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelFirstNamePrompt = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLastNamePrompt = new System.Windows.Forms.Label();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.labelPostalPrompt = new System.Windows.Forms.Label();
            this.maskedTextBoxPostalCode = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAge
            // 
            this.errorProvider.SetIconPadding(this.textBoxAge, 5);
            this.textBoxAge.Location = new System.Drawing.Point(97, 77);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(65, 20);
            this.textBoxAge.TabIndex = 5;
            this.textBoxAge.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAge_Validating);
            // 
            // labelAgePrompt
            // 
            this.labelAgePrompt.AutoSize = true;
            this.labelAgePrompt.Location = new System.Drawing.Point(25, 80);
            this.labelAgePrompt.Name = "labelAgePrompt";
            this.labelAgePrompt.Size = new System.Drawing.Size(29, 13);
            this.labelAgePrompt.TabIndex = 4;
            this.labelAgePrompt.Text = "&Age:";
            // 
            // textBoxLastName
            // 
            this.errorProvider.SetIconPadding(this.textBoxLastName, 5);
            this.textBoxLastName.Location = new System.Drawing.Point(97, 49);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(205, 20);
            this.textBoxLastName.TabIndex = 3;
            this.textBoxLastName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLastName_Validating);
            // 
            // labelFirstNamePrompt
            // 
            this.labelFirstNamePrompt.AutoSize = true;
            this.labelFirstNamePrompt.Location = new System.Drawing.Point(25, 52);
            this.labelFirstNamePrompt.Name = "labelFirstNamePrompt";
            this.labelFirstNamePrompt.Size = new System.Drawing.Size(56, 13);
            this.labelFirstNamePrompt.TabIndex = 2;
            this.labelFirstNamePrompt.Text = "&Lastname:";
            // 
            // textBoxFirstName
            // 
            this.errorProvider.SetIconPadding(this.textBoxFirstName, 5);
            this.textBoxFirstName.Location = new System.Drawing.Point(97, 22);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(205, 20);
            this.textBoxFirstName.TabIndex = 1;
            this.textBoxFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxFirstName_Validating);
            // 
            // labelLastNamePrompt
            // 
            this.labelLastNamePrompt.AutoSize = true;
            this.labelLastNamePrompt.Location = new System.Drawing.Point(25, 25);
            this.labelLastNamePrompt.Name = "labelLastNamePrompt";
            this.labelLastNamePrompt.Size = new System.Drawing.Size(55, 13);
            this.labelLastNamePrompt.TabIndex = 0;
            this.labelLastNamePrompt.Text = "&Firstname:";
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(227, 153);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(75, 23);
            this.buttonValidate.TabIndex = 8;
            this.buttonValidate.Text = "&Validate";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // labelPostalPrompt
            // 
            this.labelPostalPrompt.AutoSize = true;
            this.labelPostalPrompt.Location = new System.Drawing.Point(25, 112);
            this.labelPostalPrompt.Name = "labelPostalPrompt";
            this.labelPostalPrompt.Size = new System.Drawing.Size(67, 13);
            this.labelPostalPrompt.TabIndex = 6;
            this.labelPostalPrompt.Text = "&Postal Code:";
            // 
            // maskedTextBoxPostalCode
            // 
            this.errorProvider.SetIconPadding(this.maskedTextBoxPostalCode, 5);
            this.maskedTextBoxPostalCode.Location = new System.Drawing.Point(97, 109);
            this.maskedTextBoxPostalCode.Mask = ">L0L 0L0";
            this.maskedTextBoxPostalCode.Name = "maskedTextBoxPostalCode";
            this.maskedTextBoxPostalCode.Size = new System.Drawing.Size(65, 20);
            this.maskedTextBoxPostalCode.TabIndex = 7;
            this.maskedTextBoxPostalCode.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxPostalCode_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonValidate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 208);
            this.Controls.Add(this.maskedTextBoxPostalCode);
            this.Controls.Add(this.labelPostalPrompt);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.labelAgePrompt);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelFirstNamePrompt);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelLastNamePrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error Provider and Masked Textbox";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelAgePrompt;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelFirstNamePrompt;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelLastNamePrompt;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPostalCode;
        private System.Windows.Forms.Label labelPostalPrompt;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}


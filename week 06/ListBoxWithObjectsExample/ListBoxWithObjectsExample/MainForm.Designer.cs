namespace ListBoxWithObjectsExample
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
            this.textBoxBirthDate = new System.Windows.Forms.TextBox();
            this.listBoxNames = new System.Windows.Forms.ListBox();
            this.comboBoxDropDownList = new System.Windows.Forms.ComboBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelComboBoxSimple = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelComboBoxDropDown = new System.Windows.Forms.Label();
            this.labelBirthDatePrompt = new System.Windows.Forms.Label();
            this.comboBoxDropDown = new System.Windows.Forms.ComboBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.comboBoxSimple = new System.Windows.Forms.ComboBox();
            this.labelAgePrompt = new System.Windows.Forms.Label();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.labelLastNamePrompt = new System.Windows.Forms.Label();
            this.labelFirstNamePrompt = new System.Windows.Forms.Label();
            this.labelComboBoxDropDownList = new System.Windows.Forms.Label();
            this.groupBoxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBirthDate
            // 
            this.textBoxBirthDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBirthDate.Location = new System.Drawing.Point(80, 85);
            this.textBoxBirthDate.Name = "textBoxBirthDate";
            this.textBoxBirthDate.ReadOnly = true;
            this.textBoxBirthDate.Size = new System.Drawing.Size(200, 13);
            this.textBoxBirthDate.TabIndex = 5;
            this.textBoxBirthDate.Text = "<birthdate>";
            // 
            // listBoxNames
            // 
            this.listBoxNames.FormattingEnabled = true;
            this.listBoxNames.Location = new System.Drawing.Point(12, 12);
            this.listBoxNames.Name = "listBoxNames";
            this.listBoxNames.Size = new System.Drawing.Size(292, 121);
            this.listBoxNames.TabIndex = 12;
            this.listBoxNames.SelectedIndexChanged += new System.EventHandler(this.listBoxNames_SelectedIndexChanged);
            // 
            // comboBoxDropDownList
            // 
            this.comboBoxDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDropDownList.FormattingEnabled = true;
            this.comboBoxDropDownList.Location = new System.Drawing.Point(659, 178);
            this.comboBoxDropDownList.Name = "comboBoxDropDownList";
            this.comboBoxDropDownList.Size = new System.Drawing.Size(150, 21);
            this.comboBoxDropDownList.TabIndex = 16;
            // 
            // textBoxAge
            // 
            this.textBoxAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAge.Location = new System.Drawing.Point(80, 65);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.ReadOnly = true;
            this.textBoxAge.Size = new System.Drawing.Size(200, 13);
            this.textBoxAge.TabIndex = 5;
            this.textBoxAge.Text = "<age>";
            // 
            // labelComboBoxSimple
            // 
            this.labelComboBoxSimple.AutoSize = true;
            this.labelComboBoxSimple.Location = new System.Drawing.Point(340, 162);
            this.labelComboBoxSimple.Name = "labelComboBoxSimple";
            this.labelComboBoxSimple.Size = new System.Drawing.Size(38, 13);
            this.labelComboBoxSimple.TabIndex = 17;
            this.labelComboBoxSimple.Text = "Simple";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(80, 45);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(200, 13);
            this.textBoxLastName.TabIndex = 4;
            this.textBoxLastName.Text = "<lastname>";
            // 
            // labelComboBoxDropDown
            // 
            this.labelComboBoxDropDown.AutoSize = true;
            this.labelComboBoxDropDown.Location = new System.Drawing.Point(500, 162);
            this.labelComboBoxDropDown.Name = "labelComboBoxDropDown";
            this.labelComboBoxDropDown.Size = new System.Drawing.Size(58, 13);
            this.labelComboBoxDropDown.TabIndex = 18;
            this.labelComboBoxDropDown.Text = "DropDown";
            // 
            // labelBirthDatePrompt
            // 
            this.labelBirthDatePrompt.AutoSize = true;
            this.labelBirthDatePrompt.Location = new System.Drawing.Point(16, 85);
            this.labelBirthDatePrompt.Name = "labelBirthDatePrompt";
            this.labelBirthDatePrompt.Size = new System.Drawing.Size(55, 13);
            this.labelBirthDatePrompt.TabIndex = 2;
            this.labelBirthDatePrompt.Text = "Birth date:";
            // 
            // comboBoxDropDown
            // 
            this.comboBoxDropDown.FormattingEnabled = true;
            this.comboBoxDropDown.Location = new System.Drawing.Point(503, 178);
            this.comboBoxDropDown.Name = "comboBoxDropDown";
            this.comboBoxDropDown.Size = new System.Drawing.Size(138, 21);
            this.comboBoxDropDown.TabIndex = 15;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(80, 25);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(200, 13);
            this.textBoxFirstName.TabIndex = 3;
            this.textBoxFirstName.Text = "<firstname>";
            // 
            // comboBoxSimple
            // 
            this.comboBoxSimple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxSimple.FormattingEnabled = true;
            this.comboBoxSimple.Location = new System.Drawing.Point(343, 178);
            this.comboBoxSimple.Name = "comboBoxSimple";
            this.comboBoxSimple.Size = new System.Drawing.Size(143, 150);
            this.comboBoxSimple.TabIndex = 14;
            // 
            // labelAgePrompt
            // 
            this.labelAgePrompt.AutoSize = true;
            this.labelAgePrompt.Location = new System.Drawing.Point(16, 65);
            this.labelAgePrompt.Name = "labelAgePrompt";
            this.labelAgePrompt.Size = new System.Drawing.Size(29, 13);
            this.labelAgePrompt.TabIndex = 2;
            this.labelAgePrompt.Text = "Age:";
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.textBoxBirthDate);
            this.groupBoxDetails.Controls.Add(this.textBoxAge);
            this.groupBoxDetails.Controls.Add(this.textBoxLastName);
            this.groupBoxDetails.Controls.Add(this.textBoxFirstName);
            this.groupBoxDetails.Controls.Add(this.labelBirthDatePrompt);
            this.groupBoxDetails.Controls.Add(this.labelAgePrompt);
            this.groupBoxDetails.Controls.Add(this.labelLastNamePrompt);
            this.groupBoxDetails.Controls.Add(this.labelFirstNamePrompt);
            this.groupBoxDetails.Location = new System.Drawing.Point(12, 152);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(292, 113);
            this.groupBoxDetails.TabIndex = 13;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = " Details ";
            // 
            // labelLastNamePrompt
            // 
            this.labelLastNamePrompt.AutoSize = true;
            this.labelLastNamePrompt.Location = new System.Drawing.Point(16, 45);
            this.labelLastNamePrompt.Name = "labelLastNamePrompt";
            this.labelLastNamePrompt.Size = new System.Drawing.Size(59, 13);
            this.labelLastNamePrompt.TabIndex = 1;
            this.labelLastNamePrompt.Text = "Last name:";
            // 
            // labelFirstNamePrompt
            // 
            this.labelFirstNamePrompt.AutoSize = true;
            this.labelFirstNamePrompt.Location = new System.Drawing.Point(16, 25);
            this.labelFirstNamePrompt.Name = "labelFirstNamePrompt";
            this.labelFirstNamePrompt.Size = new System.Drawing.Size(58, 13);
            this.labelFirstNamePrompt.TabIndex = 0;
            this.labelFirstNamePrompt.Text = "First name:";
            // 
            // labelComboBoxDropDownList
            // 
            this.labelComboBoxDropDownList.AutoSize = true;
            this.labelComboBoxDropDownList.Location = new System.Drawing.Point(656, 162);
            this.labelComboBoxDropDownList.Name = "labelComboBoxDropDownList";
            this.labelComboBoxDropDownList.Size = new System.Drawing.Size(74, 13);
            this.labelComboBoxDropDownList.TabIndex = 19;
            this.labelComboBoxDropDownList.Text = "DropDownList";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 280);
            this.Controls.Add(this.listBoxNames);
            this.Controls.Add(this.comboBoxDropDownList);
            this.Controls.Add(this.labelComboBoxSimple);
            this.Controls.Add(this.labelComboBoxDropDown);
            this.Controls.Add(this.comboBoxDropDown);
            this.Controls.Add(this.comboBoxSimple);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.labelComboBoxDropDownList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBox With Objects";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBirthDate;
        private System.Windows.Forms.ListBox listBoxNames;
        private System.Windows.Forms.ComboBox comboBoxDropDownList;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelComboBoxSimple;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelComboBoxDropDown;
        private System.Windows.Forms.Label labelBirthDatePrompt;
        private System.Windows.Forms.ComboBox comboBoxDropDown;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.ComboBox comboBoxSimple;
        private System.Windows.Forms.Label labelAgePrompt;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Label labelLastNamePrompt;
        private System.Windows.Forms.Label labelFirstNamePrompt;
        private System.Windows.Forms.Label labelComboBoxDropDownList;
    }
}


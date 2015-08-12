namespace COMP2614HomeLab06
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPagePersonalContacts = new System.Windows.Forms.TabPage();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelEmailPrompt = new System.Windows.Forms.Label();
            this.labelPhoneNumberPrompt = new System.Windows.Forms.Label();
            this.labelNamePrompt = new System.Windows.Forms.Label();
            this.buttonRemoveContact = new System.Windows.Forms.Button();
            this.textBoxContactEmail = new System.Windows.Forms.TextBox();
            this.buttonAddContact = new System.Windows.Forms.Button();
            this.textBoxContactPhone = new System.Windows.Forms.TextBox();
            this.textBoxContactName = new System.Windows.Forms.TextBox();
            this.listBoxContacts = new System.Windows.Forms.ListBox();
            this.tabPageCityDemographics = new System.Windows.Forms.TabPage();
            this.buttonResetCities = new System.Windows.Forms.Button();
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelCitiesPrompt = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPagePersonalContacts.SuspendLayout();
            this.tabPageCityDemographics.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPagePersonalContacts);
            this.tabControlMain.Controls.Add(this.tabPageCityDemographics);
            this.tabControlMain.Location = new System.Drawing.Point(7, 9);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(358, 306);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPagePersonalContacts
            // 
            this.tabPagePersonalContacts.Controls.Add(this.labelContact);
            this.tabPagePersonalContacts.Controls.Add(this.labelEmailPrompt);
            this.tabPagePersonalContacts.Controls.Add(this.labelPhoneNumberPrompt);
            this.tabPagePersonalContacts.Controls.Add(this.labelNamePrompt);
            this.tabPagePersonalContacts.Controls.Add(this.buttonRemoveContact);
            this.tabPagePersonalContacts.Controls.Add(this.textBoxContactEmail);
            this.tabPagePersonalContacts.Controls.Add(this.buttonAddContact);
            this.tabPagePersonalContacts.Controls.Add(this.textBoxContactPhone);
            this.tabPagePersonalContacts.Controls.Add(this.textBoxContactName);
            this.tabPagePersonalContacts.Controls.Add(this.listBoxContacts);
            this.tabPagePersonalContacts.Location = new System.Drawing.Point(4, 22);
            this.tabPagePersonalContacts.Name = "tabPagePersonalContacts";
            this.tabPagePersonalContacts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonalContacts.Size = new System.Drawing.Size(350, 280);
            this.tabPagePersonalContacts.TabIndex = 0;
            this.tabPagePersonalContacts.Text = "Personal Contacts";
            this.tabPagePersonalContacts.UseVisualStyleBackColor = true;
            // 
            // labelContact
            // 
            this.labelContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.Location = new System.Drawing.Point(16, 196);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(284, 32);
            this.labelContact.TabIndex = 7;
            this.labelContact.Text = "<Contact Details>";
            // 
            // labelEmailPrompt
            // 
            this.labelEmailPrompt.AutoSize = true;
            this.labelEmailPrompt.Location = new System.Drawing.Point(16, 59);
            this.labelEmailPrompt.Name = "labelEmailPrompt";
            this.labelEmailPrompt.Size = new System.Drawing.Size(35, 13);
            this.labelEmailPrompt.TabIndex = 4;
            this.labelEmailPrompt.Text = "&Email:";
            // 
            // labelPhoneNumberPrompt
            // 
            this.labelPhoneNumberPrompt.AutoSize = true;
            this.labelPhoneNumberPrompt.Location = new System.Drawing.Point(16, 37);
            this.labelPhoneNumberPrompt.Name = "labelPhoneNumberPrompt";
            this.labelPhoneNumberPrompt.Size = new System.Drawing.Size(79, 13);
            this.labelPhoneNumberPrompt.TabIndex = 2;
            this.labelPhoneNumberPrompt.Text = "&Phone number:";
            // 
            // labelNamePrompt
            // 
            this.labelNamePrompt.AutoSize = true;
            this.labelNamePrompt.Location = new System.Drawing.Point(16, 15);
            this.labelNamePrompt.Name = "labelNamePrompt";
            this.labelNamePrompt.Size = new System.Drawing.Size(38, 13);
            this.labelNamePrompt.TabIndex = 0;
            this.labelNamePrompt.Text = "&Name:";
            // 
            // buttonRemoveContact
            // 
            this.buttonRemoveContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveContact.Location = new System.Drawing.Point(247, 251);
            this.buttonRemoveContact.Name = "buttonRemoveContact";
            this.buttonRemoveContact.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveContact.TabIndex = 9;
            this.buttonRemoveContact.Text = "&Remove";
            this.buttonRemoveContact.UseVisualStyleBackColor = true;
            this.buttonRemoveContact.Click += new System.EventHandler(this.btnRemoveContact_Click);
            // 
            // textBoxContactEmail
            // 
            this.textBoxContactEmail.Location = new System.Drawing.Point(101, 55);
            this.textBoxContactEmail.Name = "textBoxContactEmail";
            this.textBoxContactEmail.Size = new System.Drawing.Size(221, 20);
            this.textBoxContactEmail.TabIndex = 5;
            // 
            // buttonAddContact
            // 
            this.buttonAddContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddContact.Location = new System.Drawing.Point(166, 251);
            this.buttonAddContact.Name = "buttonAddContact";
            this.buttonAddContact.Size = new System.Drawing.Size(75, 23);
            this.buttonAddContact.TabIndex = 8;
            this.buttonAddContact.Text = "&Add";
            this.buttonAddContact.UseVisualStyleBackColor = true;
            this.buttonAddContact.Click += new System.EventHandler(this.buttonAddContact_Click);
            // 
            // textBoxContactPhone
            // 
            this.textBoxContactPhone.Location = new System.Drawing.Point(101, 33);
            this.textBoxContactPhone.Name = "textBoxContactPhone";
            this.textBoxContactPhone.Size = new System.Drawing.Size(221, 20);
            this.textBoxContactPhone.TabIndex = 3;
            // 
            // textBoxContactName
            // 
            this.textBoxContactName.Location = new System.Drawing.Point(101, 11);
            this.textBoxContactName.Name = "textBoxContactName";
            this.textBoxContactName.Size = new System.Drawing.Size(221, 20);
            this.textBoxContactName.TabIndex = 1;
            // 
            // listBoxContacts
            // 
            this.listBoxContacts.FormattingEnabled = true;
            this.listBoxContacts.Location = new System.Drawing.Point(19, 90);
            this.listBoxContacts.Name = "listBoxContacts";
            this.listBoxContacts.Size = new System.Drawing.Size(303, 95);
            this.listBoxContacts.TabIndex = 6;
            this.listBoxContacts.SelectedIndexChanged += new System.EventHandler(this.listBoxContacts_SelectedIndexChanged);
            // 
            // tabPageCityDemographics
            // 
            this.tabPageCityDemographics.Controls.Add(this.buttonResetCities);
            this.tabPageCityDemographics.Controls.Add(this.comboBoxCities);
            this.tabPageCityDemographics.Controls.Add(this.labelCity);
            this.tabPageCityDemographics.Controls.Add(this.labelCitiesPrompt);
            this.tabPageCityDemographics.Location = new System.Drawing.Point(4, 22);
            this.tabPageCityDemographics.Name = "tabPageCityDemographics";
            this.tabPageCityDemographics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCityDemographics.Size = new System.Drawing.Size(350, 280);
            this.tabPageCityDemographics.TabIndex = 1;
            this.tabPageCityDemographics.Text = "City Demographics";
            this.tabPageCityDemographics.UseVisualStyleBackColor = true;
            // 
            // buttonResetCities
            // 
            this.buttonResetCities.Location = new System.Drawing.Point(247, 251);
            this.buttonResetCities.Name = "buttonResetCities";
            this.buttonResetCities.Size = new System.Drawing.Size(75, 23);
            this.buttonResetCities.TabIndex = 3;
            this.buttonResetCities.Text = "&Reset";
            this.buttonResetCities.UseVisualStyleBackColor = true;
            this.buttonResetCities.Click += new System.EventHandler(this.buttonResetCities_Click);
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Location = new System.Drawing.Point(19, 36);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(303, 21);
            this.comboBoxCities.TabIndex = 1;
            this.comboBoxCities.SelectedIndexChanged += new System.EventHandler(this.comboBoxCities_SelectedIndexChanged);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(18, 84);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(85, 13);
            this.labelCity.TabIndex = 2;
            this.labelCity.Text = "<City Details>";
            // 
            // labelCitiesPrompt
            // 
            this.labelCitiesPrompt.AutoSize = true;
            this.labelCitiesPrompt.Location = new System.Drawing.Point(18, 20);
            this.labelCitiesPrompt.Name = "labelCitiesPrompt";
            this.labelCitiesPrompt.Size = new System.Drawing.Size(32, 13);
            this.labelCitiesPrompt.TabIndex = 0;
            this.labelCitiesPrompt.Text = "&Cities";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 322);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMP2614 - HomeLab06 - List Controls";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPagePersonalContacts.ResumeLayout(false);
            this.tabPagePersonalContacts.PerformLayout();
            this.tabPageCityDemographics.ResumeLayout(false);
            this.tabPageCityDemographics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPagePersonalContacts;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelEmailPrompt;
        private System.Windows.Forms.Label labelPhoneNumberPrompt;
        private System.Windows.Forms.Label labelNamePrompt;
        private System.Windows.Forms.Button buttonRemoveContact;
        private System.Windows.Forms.TextBox textBoxContactEmail;
        private System.Windows.Forms.Button buttonAddContact;
        private System.Windows.Forms.TextBox textBoxContactPhone;
        private System.Windows.Forms.TextBox textBoxContactName;
        private System.Windows.Forms.ListBox listBoxContacts;
        private System.Windows.Forms.TabPage tabPageCityDemographics;
        private System.Windows.Forms.Button buttonResetCities;
        private System.Windows.Forms.ComboBox comboBoxCities;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelCitiesPrompt;
    }
}


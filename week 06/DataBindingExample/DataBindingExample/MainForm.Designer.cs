namespace DataBindingExample
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
            this.labelSelectedPerson = new System.Windows.Forms.Label();
            this.groupBoxSelectedPerson = new System.Windows.Forms.GroupBox();
            this.labelListBoxPrompt = new System.Windows.Forms.Label();
            this.buttonAddPerson = new System.Windows.Forms.Button();
            this.listBoxPeople = new System.Windows.Forms.ListBox();
            this.groupBoxSelectedPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSelectedPerson
            // 
            this.labelSelectedPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectedPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedPerson.Location = new System.Drawing.Point(6, 22);
            this.labelSelectedPerson.Name = "labelSelectedPerson";
            this.labelSelectedPerson.Size = new System.Drawing.Size(269, 49);
            this.labelSelectedPerson.TabIndex = 3;
            this.labelSelectedPerson.Text = "<Selected person goes here>";
            // 
            // groupBoxSelectedPerson
            // 
            this.groupBoxSelectedPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSelectedPerson.Controls.Add(this.labelSelectedPerson);
            this.groupBoxSelectedPerson.Location = new System.Drawing.Point(9, 118);
            this.groupBoxSelectedPerson.Name = "groupBoxSelectedPerson";
            this.groupBoxSelectedPerson.Size = new System.Drawing.Size(281, 85);
            this.groupBoxSelectedPerson.TabIndex = 8;
            this.groupBoxSelectedPerson.TabStop = false;
            this.groupBoxSelectedPerson.Text = "Selected person";
            // 
            // labelListBoxPrompt
            // 
            this.labelListBoxPrompt.AutoSize = true;
            this.labelListBoxPrompt.Location = new System.Drawing.Point(12, 12);
            this.labelListBoxPrompt.Name = "labelListBoxPrompt";
            this.labelListBoxPrompt.Size = new System.Drawing.Size(40, 13);
            this.labelListBoxPrompt.TabIndex = 7;
            this.labelListBoxPrompt.Text = "&People";
            // 
            // buttonAddPerson
            // 
            this.buttonAddPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddPerson.Location = new System.Drawing.Point(215, 209);
            this.buttonAddPerson.Name = "buttonAddPerson";
            this.buttonAddPerson.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPerson.TabIndex = 6;
            this.buttonAddPerson.Text = "&Add";
            this.buttonAddPerson.UseVisualStyleBackColor = true;
            this.buttonAddPerson.Click += new System.EventHandler(this.buttonAddPerson_Click);
            // 
            // listBoxPeople
            // 
            this.listBoxPeople.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPeople.FormattingEnabled = true;
            this.listBoxPeople.ItemHeight = 16;
            this.listBoxPeople.Location = new System.Drawing.Point(12, 28);
            this.listBoxPeople.Name = "listBoxPeople";
            this.listBoxPeople.Size = new System.Drawing.Size(278, 84);
            this.listBoxPeople.TabIndex = 5;
            this.listBoxPeople.SelectedIndexChanged += new System.EventHandler(this.listBoxPeople_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 247);
            this.Controls.Add(this.groupBoxSelectedPerson);
            this.Controls.Add(this.labelListBoxPrompt);
            this.Controls.Add(this.buttonAddPerson);
            this.Controls.Add(this.listBoxPeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Binding Example";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxSelectedPerson.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectedPerson;
        private System.Windows.Forms.GroupBox groupBoxSelectedPerson;
        private System.Windows.Forms.Label labelListBoxPrompt;
        private System.Windows.Forms.Button buttonAddPerson;
        private System.Windows.Forms.ListBox listBoxPeople;
    }
}


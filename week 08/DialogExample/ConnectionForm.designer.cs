namespace DialogExample
{
	partial class ConnectionForm
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxNewsServer = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.checkBoxAuthRequired = new System.Windows.Forms.CheckBox();
            this.labelNewsServerPrompt = new System.Windows.Forms.Label();
            this.labelUsernamePrompt = new System.Windows.Forms.Label();
            this.labelPasswordPrompt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(246, 147);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(327, 147);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxNewsServer
            // 
            this.textBoxNewsServer.Location = new System.Drawing.Point(87, 8);
            this.textBoxNewsServer.Name = "textBoxNewsServer";
            this.textBoxNewsServer.Size = new System.Drawing.Size(315, 20);
            this.textBoxNewsServer.TabIndex = 1;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(87, 71);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(315, 20);
            this.textBoxUsername.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(87, 97);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(315, 20);
            this.textBoxPassword.TabIndex = 6;
            // 
            // checkBoxAuthRequired
            // 
            this.checkBoxAuthRequired.AutoSize = true;
            this.checkBoxAuthRequired.Location = new System.Drawing.Point(15, 44);
            this.checkBoxAuthRequired.Name = "checkBoxAuthRequired";
            this.checkBoxAuthRequired.Size = new System.Drawing.Size(135, 17);
            this.checkBoxAuthRequired.TabIndex = 2;
            this.checkBoxAuthRequired.Text = "&Authentication required";
            this.checkBoxAuthRequired.UseVisualStyleBackColor = true;
            this.checkBoxAuthRequired.CheckedChanged += new System.EventHandler(this.checkBoxAuthRequired_CheckedChanged);
            // 
            // labelNewsServerPrompt
            // 
            this.labelNewsServerPrompt.AutoSize = true;
            this.labelNewsServerPrompt.Location = new System.Drawing.Point(12, 11);
            this.labelNewsServerPrompt.Name = "labelNewsServerPrompt";
            this.labelNewsServerPrompt.Size = new System.Drawing.Size(69, 13);
            this.labelNewsServerPrompt.TabIndex = 0;
            this.labelNewsServerPrompt.Text = "&News server:";
            // 
            // labelUsernamePrompt
            // 
            this.labelUsernamePrompt.AutoSize = true;
            this.labelUsernamePrompt.Location = new System.Drawing.Point(12, 74);
            this.labelUsernamePrompt.Name = "labelUsernamePrompt";
            this.labelUsernamePrompt.Size = new System.Drawing.Size(58, 13);
            this.labelUsernamePrompt.TabIndex = 3;
            this.labelUsernamePrompt.Text = "&Username:";
            // 
            // labelPasswordPrompt
            // 
            this.labelPasswordPrompt.AutoSize = true;
            this.labelPasswordPrompt.Location = new System.Drawing.Point(12, 100);
            this.labelPasswordPrompt.Name = "labelPasswordPrompt";
            this.labelPasswordPrompt.Size = new System.Drawing.Size(56, 13);
            this.labelPasswordPrompt.TabIndex = 5;
            this.labelPasswordPrompt.Text = "&Password:";
            // 
            // ConnectionForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(414, 182);
            this.Controls.Add(this.labelPasswordPrompt);
            this.Controls.Add(this.labelUsernamePrompt);
            this.Controls.Add(this.labelNewsServerPrompt);
            this.Controls.Add(this.checkBoxAuthRequired);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxNewsServer);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connect";
            this.Load += new System.EventHandler(this.ConnectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.TextBox textBoxNewsServer;
		private System.Windows.Forms.TextBox textBoxUsername;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.CheckBox checkBoxAuthRequired;
		private System.Windows.Forms.Label labelNewsServerPrompt;
		private System.Windows.Forms.Label labelUsernamePrompt;
		private System.Windows.Forms.Label labelPasswordPrompt;
	}
}
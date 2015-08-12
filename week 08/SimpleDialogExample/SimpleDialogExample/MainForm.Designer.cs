namespace SimpleDialogExample
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
            this.buttonDoDialog = new System.Windows.Forms.Button();
            this.labelDlgResult = new System.Windows.Forms.Label();
            this.groupBoxDialogResult = new System.Windows.Forms.GroupBox();
            this.groupBoxDialogResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDoDialog
            // 
            this.buttonDoDialog.Location = new System.Drawing.Point(109, 21);
            this.buttonDoDialog.Name = "buttonDoDialog";
            this.buttonDoDialog.Size = new System.Drawing.Size(75, 23);
            this.buttonDoDialog.TabIndex = 0;
            this.buttonDoDialog.Text = "Do &Dialog";
            this.buttonDoDialog.UseVisualStyleBackColor = true;
            this.buttonDoDialog.Click += new System.EventHandler(this.buttonDoDialog_Click);
            // 
            // labelDlgResult
            // 
            this.labelDlgResult.AutoSize = true;
            this.labelDlgResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDlgResult.Location = new System.Drawing.Point(19, 25);
            this.labelDlgResult.Name = "labelDlgResult";
            this.labelDlgResult.Size = new System.Drawing.Size(57, 13);
            this.labelDlgResult.TabIndex = 1;
            this.labelDlgResult.Text = "<Result>";
            // 
            // groupBoxDialogResult
            // 
            this.groupBoxDialogResult.Controls.Add(this.labelDlgResult);
            this.groupBoxDialogResult.Location = new System.Drawing.Point(12, 56);
            this.groupBoxDialogResult.Name = "groupBoxDialogResult";
            this.groupBoxDialogResult.Size = new System.Drawing.Size(268, 64);
            this.groupBoxDialogResult.TabIndex = 2;
            this.groupBoxDialogResult.TabStop = false;
            this.groupBoxDialogResult.Text = "Dialog Result";
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonDoDialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 144);
            this.Controls.Add(this.groupBoxDialogResult);
            this.Controls.Add(this.buttonDoDialog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Dialog Example";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxDialogResult.ResumeLayout(false);
            this.groupBoxDialogResult.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonDoDialog;
		private System.Windows.Forms.Label labelDlgResult;
		private System.Windows.Forms.GroupBox groupBoxDialogResult;
	}
}


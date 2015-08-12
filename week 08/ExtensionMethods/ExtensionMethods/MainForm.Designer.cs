namespace ExtensionMethods
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
            this.buttonProperStatic = new System.Windows.Forms.Button();
            this.buttonProperExtension = new System.Windows.Forms.Button();
            this.buttonUpper = new System.Windows.Forms.Button();
            this.buttonLower = new System.Windows.Forms.Button();
            this.labelInputPrompt = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonProperStatic
            // 
            this.buttonProperStatic.Location = new System.Drawing.Point(411, 83);
            this.buttonProperStatic.Name = "buttonProperStatic";
            this.buttonProperStatic.Size = new System.Drawing.Size(136, 23);
            this.buttonProperStatic.TabIndex = 12;
            this.buttonProperStatic.Text = "Proper Case (&Static)";
            this.buttonProperStatic.UseVisualStyleBackColor = true;
            this.buttonProperStatic.Click += new System.EventHandler(this.buttonProperStatic_Click);
            // 
            // buttonProperExtension
            // 
            this.buttonProperExtension.Location = new System.Drawing.Point(411, 112);
            this.buttonProperExtension.Name = "buttonProperExtension";
            this.buttonProperExtension.Size = new System.Drawing.Size(136, 23);
            this.buttonProperExtension.TabIndex = 13;
            this.buttonProperExtension.Text = "Proper Case (&Ext)";
            this.buttonProperExtension.UseVisualStyleBackColor = true;
            this.buttonProperExtension.Click += new System.EventHandler(this.buttonProperExtension_Click);
            // 
            // buttonUpper
            // 
            this.buttonUpper.Location = new System.Drawing.Point(411, 54);
            this.buttonUpper.Name = "buttonUpper";
            this.buttonUpper.Size = new System.Drawing.Size(136, 23);
            this.buttonUpper.TabIndex = 11;
            this.buttonUpper.Text = "&Upper Case";
            this.buttonUpper.UseVisualStyleBackColor = true;
            this.buttonUpper.Click += new System.EventHandler(this.buttonUpper_Click);
            // 
            // buttonLower
            // 
            this.buttonLower.Location = new System.Drawing.Point(411, 25);
            this.buttonLower.Name = "buttonLower";
            this.buttonLower.Size = new System.Drawing.Size(136, 23);
            this.buttonLower.TabIndex = 10;
            this.buttonLower.Text = "&Lower Case";
            this.buttonLower.UseVisualStyleBackColor = true;
            this.buttonLower.Click += new System.EventHandler(this.buttonLower_Click);
            // 
            // labelInputPrompt
            // 
            this.labelInputPrompt.AutoSize = true;
            this.labelInputPrompt.Location = new System.Drawing.Point(11, 10);
            this.labelInputPrompt.Name = "labelInputPrompt";
            this.labelInputPrompt.Size = new System.Drawing.Size(108, 13);
            this.labelInputPrompt.TabIndex = 7;
            this.labelInputPrompt.Text = "Enter &Test Sentence:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(10, 84);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(66, 19);
            this.labelResult.TabIndex = 9;
            this.labelResult.Text = "<Result>";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(14, 26);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(382, 20);
            this.textBoxInput.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 174);
            this.Controls.Add(this.buttonProperStatic);
            this.Controls.Add(this.buttonProperExtension);
            this.Controls.Add(this.buttonUpper);
            this.Controls.Add(this.buttonLower);
            this.Controls.Add(this.labelInputPrompt);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extension Methods";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProperStatic;
        private System.Windows.Forms.Button buttonProperExtension;
        private System.Windows.Forms.Button buttonUpper;
        private System.Windows.Forms.Button buttonLower;
        private System.Windows.Forms.Label labelInputPrompt;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxInput;
    }
}


﻿namespace COMP2614HomeLab05
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
            this.buttonF2C = new System.Windows.Forms.Button();
            this.buttonC2F = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxInputTemperature = new System.Windows.Forms.TextBox();
            this.labelInputTemperaturePrompt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonF2C
            // 
            this.buttonF2C.Location = new System.Drawing.Point(135, 134);
            this.buttonF2C.Name = "buttonF2C";
            this.buttonF2C.Size = new System.Drawing.Size(94, 23);
            this.buttonF2C.TabIndex = 24;
            this.buttonF2C.Text = "Convert &F to C";
            this.buttonF2C.UseVisualStyleBackColor = true;
            this.buttonF2C.Click += new System.EventHandler(this.buttonF2C_Click);
            // 
            // buttonC2F
            // 
            this.buttonC2F.Location = new System.Drawing.Point(16, 134);
            this.buttonC2F.Name = "buttonC2F";
            this.buttonC2F.Size = new System.Drawing.Size(94, 23);
            this.buttonC2F.TabIndex = 23;
            this.buttonC2F.Text = "Convert &C to F";
            this.buttonC2F.UseVisualStyleBackColor = true;
            this.buttonC2F.Click += new System.EventHandler(this.buttonC2F_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(16, 77);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(68, 16);
            this.labelResult.TabIndex = 22;
            this.labelResult.Text = "<Result>";
            // 
            // textBoxInputTemperature
            // 
            this.textBoxInputTemperature.Location = new System.Drawing.Point(16, 30);
            this.textBoxInputTemperature.Name = "textBoxInputTemperature";
            this.textBoxInputTemperature.Size = new System.Drawing.Size(213, 20);
            this.textBoxInputTemperature.TabIndex = 21;
            // 
            // labelInputTemperaturePrompt
            // 
            this.labelInputTemperaturePrompt.Location = new System.Drawing.Point(13, 14);
            this.labelInputTemperaturePrompt.Name = "labelInputTemperaturePrompt";
            this.labelInputTemperaturePrompt.Size = new System.Drawing.Size(100, 18);
            this.labelInputTemperaturePrompt.TabIndex = 20;
            this.labelInputTemperaturePrompt.Text = "&Value to convert:";
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonC2F;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 185);
            this.Controls.Add(this.buttonF2C);
            this.Controls.Add(this.buttonC2F);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxInputTemperature);
            this.Controls.Add(this.labelInputTemperaturePrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Converter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonF2C;
        private System.Windows.Forms.Button buttonC2F;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxInputTemperature;
        private System.Windows.Forms.Label labelInputTemperaturePrompt;
    }
}


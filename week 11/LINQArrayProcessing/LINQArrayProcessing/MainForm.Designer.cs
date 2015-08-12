namespace LINQArrayProcessing
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
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.buttonDelayed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.Location = new System.Drawing.Point(12, 12);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(137, 212);
            this.textBoxResult.TabIndex = 6;
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(186, 13);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(126, 23);
            this.buttonQuery.TabIndex = 7;
            this.buttonQuery.Text = "&Query";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // buttonDelayed
            // 
            this.buttonDelayed.Location = new System.Drawing.Point(186, 60);
            this.buttonDelayed.Name = "buttonDelayed";
            this.buttonDelayed.Size = new System.Drawing.Size(126, 23);
            this.buttonDelayed.TabIndex = 8;
            this.buttonDelayed.Text = "&Delayed Execution";
            this.buttonDelayed.UseVisualStyleBackColor = true;
            this.buttonDelayed.Click += new System.EventHandler(this.buttonDelayed_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 240);
            this.Controls.Add(this.buttonDelayed);
            this.Controls.Add(this.buttonQuery);
            this.Controls.Add(this.textBoxResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LINQ Array Processing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.Button buttonDelayed;
    }
}


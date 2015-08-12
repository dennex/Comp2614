namespace DateTimePickerTest
{
    partial class DtpTestForm
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
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelDateOutput = new System.Windows.Forms.Label();
            this.buttonSetDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.CustomFormat = "MMM d, yyyy h:mm tt";
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(285, 36);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 0;
            this.dateTimePickerStartDate.ValueChanged += new System.EventHandler(this.dateTimePickerStartDate_ValueChanged);
            // 
            // labelDateOutput
            // 
            this.labelDateOutput.AutoSize = true;
            this.labelDateOutput.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOutput.Location = new System.Drawing.Point(211, 289);
            this.labelDateOutput.Name = "labelDateOutput";
            this.labelDateOutput.Size = new System.Drawing.Size(140, 22);
            this.labelDateOutput.TabIndex = 1;
            this.labelDateOutput.Text = "<Date Output>";
            // 
            // buttonSetDate
            // 
            this.buttonSetDate.Location = new System.Drawing.Point(35, 32);
            this.buttonSetDate.Name = "buttonSetDate";
            this.buttonSetDate.Size = new System.Drawing.Size(75, 23);
            this.buttonSetDate.TabIndex = 2;
            this.buttonSetDate.Text = "&Set Date";
            this.buttonSetDate.UseVisualStyleBackColor = true;
            this.buttonSetDate.Click += new System.EventHandler(this.buttonSetDate_Click);
            // 
            // DtpTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 335);
            this.Controls.Add(this.buttonSetDate);
            this.Controls.Add(this.labelDateOutput);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Name = "DtpTestForm";
            this.Text = "Date Time Picker Test Form";
            this.Load += new System.EventHandler(this.DtpTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label labelDateOutput;
        private System.Windows.Forms.Button buttonSetDate;
    }
}


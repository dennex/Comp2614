namespace PicBoxAndScroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.scrollBarHorizontal = new System.Windows.Forms.HScrollBar();
            this.scrollBarVertical = new System.Windows.Forms.VScrollBar();
            this.groupBoxSizeMode = new System.Windows.Forms.GroupBox();
            this.radioButtonZoom = new System.Windows.Forms.RadioButton();
            this.radioButtonCenter = new System.Windows.Forms.RadioButton();
            this.radioButtonAutoSize = new System.Windows.Forms.RadioButton();
            this.radioButtonStretch = new System.Windows.Forms.RadioButton();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.groupBoxSizeMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMain.Image = global::PicBoxAndScroll.Properties.Resources.Stormtroopers;
            this.pictureBoxMain.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMain.InitialImage")));
            this.pictureBoxMain.Location = new System.Drawing.Point(181, 19);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(387, 260);
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            // 
            // scrollBarHorizontal
            // 
            this.scrollBarHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.scrollBarHorizontal.Location = new System.Drawing.Point(181, 279);
            this.scrollBarHorizontal.Name = "scrollBarHorizontal";
            this.scrollBarHorizontal.Size = new System.Drawing.Size(387, 18);
            this.scrollBarHorizontal.TabIndex = 1;
            this.scrollBarHorizontal.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBarVertical_Scroll);
            // 
            // scrollBarVertical
            // 
            this.scrollBarVertical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.scrollBarVertical.Location = new System.Drawing.Point(569, 19);
            this.scrollBarVertical.Name = "scrollBarVertical";
            this.scrollBarVertical.Size = new System.Drawing.Size(17, 259);
            this.scrollBarVertical.TabIndex = 2;
            this.scrollBarVertical.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBarVertical_Scroll);
            // 
            // groupBoxSizeMode
            // 
            this.groupBoxSizeMode.Controls.Add(this.radioButtonZoom);
            this.groupBoxSizeMode.Controls.Add(this.radioButtonCenter);
            this.groupBoxSizeMode.Controls.Add(this.radioButtonAutoSize);
            this.groupBoxSizeMode.Controls.Add(this.radioButtonStretch);
            this.groupBoxSizeMode.Controls.Add(this.radioButtonNormal);
            this.groupBoxSizeMode.Location = new System.Drawing.Point(24, 12);
            this.groupBoxSizeMode.Name = "groupBoxSizeMode";
            this.groupBoxSizeMode.Size = new System.Drawing.Size(135, 169);
            this.groupBoxSizeMode.TabIndex = 3;
            this.groupBoxSizeMode.TabStop = false;
            this.groupBoxSizeMode.Text = " Size Mode ";
            // 
            // radioButtonZoom
            // 
            this.radioButtonZoom.AutoSize = true;
            this.radioButtonZoom.Location = new System.Drawing.Point(24, 125);
            this.radioButtonZoom.Name = "radioButtonZoom";
            this.radioButtonZoom.Size = new System.Drawing.Size(52, 17);
            this.radioButtonZoom.TabIndex = 4;
            this.radioButtonZoom.TabStop = true;
            this.radioButtonZoom.Text = "&Zoom";
            this.radioButtonZoom.UseVisualStyleBackColor = true;
            this.radioButtonZoom.CheckedChanged += new System.EventHandler(this.radioButtonNormal_CheckedChanged);
            // 
            // radioButtonCenter
            // 
            this.radioButtonCenter.AutoSize = true;
            this.radioButtonCenter.Location = new System.Drawing.Point(24, 101);
            this.radioButtonCenter.Name = "radioButtonCenter";
            this.radioButtonCenter.Size = new System.Drawing.Size(56, 17);
            this.radioButtonCenter.TabIndex = 3;
            this.radioButtonCenter.TabStop = true;
            this.radioButtonCenter.Text = "&Center";
            this.radioButtonCenter.UseVisualStyleBackColor = true;
            this.radioButtonCenter.CheckedChanged += new System.EventHandler(this.radioButtonNormal_CheckedChanged);
            // 
            // radioButtonAutoSize
            // 
            this.radioButtonAutoSize.AutoSize = true;
            this.radioButtonAutoSize.Location = new System.Drawing.Point(24, 77);
            this.radioButtonAutoSize.Name = "radioButtonAutoSize";
            this.radioButtonAutoSize.Size = new System.Drawing.Size(70, 17);
            this.radioButtonAutoSize.TabIndex = 2;
            this.radioButtonAutoSize.TabStop = true;
            this.radioButtonAutoSize.Text = "&Auto Size";
            this.radioButtonAutoSize.UseVisualStyleBackColor = true;
            this.radioButtonAutoSize.CheckedChanged += new System.EventHandler(this.radioButtonNormal_CheckedChanged);
            // 
            // radioButtonStretch
            // 
            this.radioButtonStretch.AutoSize = true;
            this.radioButtonStretch.Location = new System.Drawing.Point(24, 54);
            this.radioButtonStretch.Name = "radioButtonStretch";
            this.radioButtonStretch.Size = new System.Drawing.Size(59, 17);
            this.radioButtonStretch.TabIndex = 1;
            this.radioButtonStretch.TabStop = true;
            this.radioButtonStretch.Text = "&Stretch";
            this.radioButtonStretch.UseVisualStyleBackColor = true;
            this.radioButtonStretch.CheckedChanged += new System.EventHandler(this.radioButtonNormal_CheckedChanged);
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Location = new System.Drawing.Point(24, 31);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(58, 17);
            this.radioButtonNormal.TabIndex = 0;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Text = "&Normal";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            this.radioButtonNormal.CheckedChanged += new System.EventHandler(this.radioButtonNormal_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 313);
            this.Controls.Add(this.groupBoxSizeMode);
            this.Controls.Add(this.scrollBarVertical);
            this.Controls.Add(this.scrollBarHorizontal);
            this.Controls.Add(this.pictureBoxMain);
            this.Name = "MainForm";
            this.Text = "PictureBox and ScrollBars";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.groupBoxSizeMode.ResumeLayout(false);
            this.groupBoxSizeMode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.HScrollBar scrollBarHorizontal;
        private System.Windows.Forms.VScrollBar scrollBarVertical;
        private System.Windows.Forms.GroupBox groupBoxSizeMode;
        private System.Windows.Forms.RadioButton radioButtonZoom;
        private System.Windows.Forms.RadioButton radioButtonCenter;
        private System.Windows.Forms.RadioButton radioButtonAutoSize;
        private System.Windows.Forms.RadioButton radioButtonStretch;
        private System.Windows.Forms.RadioButton radioButtonNormal;
    }
}


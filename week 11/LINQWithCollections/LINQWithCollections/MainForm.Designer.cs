namespace LINQWithCollections
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.buttonShowByArtist = new System.Windows.Forms.Button();
            this.textBoxArtistName = new System.Windows.Forms.TextBox();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.labelArtistPrompt = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResults.Size = new System.Drawing.Size(460, 540);
            this.dataGridViewResults.TabIndex = 0;
            // 
            // buttonShowByArtist
            // 
            this.buttonShowByArtist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowByArtist.Location = new System.Drawing.Point(499, 12);
            this.buttonShowByArtist.Name = "buttonShowByArtist";
            this.buttonShowByArtist.Size = new System.Drawing.Size(136, 23);
            this.buttonShowByArtist.TabIndex = 1;
            this.buttonShowByArtist.Text = "&Show By Artist";
            this.buttonShowByArtist.UseVisualStyleBackColor = true;
            this.buttonShowByArtist.Click += new System.EventHandler(this.buttonShowByArtist_Click);
            // 
            // textBoxArtistName
            // 
            this.textBoxArtistName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.errorProvider.SetIconPadding(this.textBoxArtistName, 3);
            this.textBoxArtistName.Location = new System.Drawing.Point(499, 57);
            this.textBoxArtistName.Name = "textBoxArtistName";
            this.textBoxArtistName.Size = new System.Drawing.Size(136, 20);
            this.textBoxArtistName.TabIndex = 2;
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowAll.Location = new System.Drawing.Point(499, 112);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(136, 23);
            this.buttonShowAll.TabIndex = 3;
            this.buttonShowAll.Text = "Show &All";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // labelArtistPrompt
            // 
            this.labelArtistPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelArtistPrompt.AutoSize = true;
            this.labelArtistPrompt.Location = new System.Drawing.Point(497, 42);
            this.labelArtistPrompt.Name = "labelArtistPrompt";
            this.labelArtistPrompt.Size = new System.Drawing.Size(58, 13);
            this.labelArtistPrompt.TabIndex = 4;
            this.labelArtistPrompt.Text = "Enter Artist";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonShowByArtist;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 567);
            this.Controls.Add(this.labelArtistPrompt);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.textBoxArtistName);
            this.Controls.Add(this.buttonShowByArtist);
            this.Controls.Add(this.dataGridViewResults);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LINQ With Collections";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.Button buttonShowByArtist;
        private System.Windows.Forms.TextBox textBoxArtistName;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Label labelArtistPrompt;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}


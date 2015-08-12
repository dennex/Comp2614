namespace ValidationDemoOF
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
            this.labelMaxTicketsPrompt = new System.Windows.Forms.Label();
            this.labelTotalTicketsPrompt = new System.Windows.Forms.Label();
            this.labelTicketsRemainingPrompt = new System.Windows.Forms.Label();
            this.labelQtyPrompt = new System.Windows.Forms.Label();
            this.labelMaxTickets = new System.Windows.Forms.Label();
            this.labelTotalPurchased = new System.Windows.Forms.Label();
            this.labelTicketsRemaining = new System.Windows.Forms.Label();
            this.textBoxPurchaseQty = new System.Windows.Forms.TextBox();
            this.buttonPurchase = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMaxTicketsPrompt
            // 
            this.labelMaxTicketsPrompt.AutoSize = true;
            this.labelMaxTicketsPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxTicketsPrompt.Location = new System.Drawing.Point(72, 63);
            this.labelMaxTicketsPrompt.Name = "labelMaxTicketsPrompt";
            this.labelMaxTicketsPrompt.Size = new System.Drawing.Size(115, 16);
            this.labelMaxTicketsPrompt.TabIndex = 0;
            this.labelMaxTicketsPrompt.Text = "Maximum Tickets:";
            // 
            // labelTotalTicketsPrompt
            // 
            this.labelTotalTicketsPrompt.AutoSize = true;
            this.labelTotalTicketsPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTicketsPrompt.Location = new System.Drawing.Point(72, 99);
            this.labelTotalTicketsPrompt.Name = "labelTotalTicketsPrompt";
            this.labelTotalTicketsPrompt.Size = new System.Drawing.Size(157, 16);
            this.labelTotalTicketsPrompt.TabIndex = 1;
            this.labelTotalTicketsPrompt.Text = "Total Tickets Purchased:";
            // 
            // labelTicketsRemainingPrompt
            // 
            this.labelTicketsRemainingPrompt.AutoSize = true;
            this.labelTicketsRemainingPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicketsRemainingPrompt.Location = new System.Drawing.Point(72, 135);
            this.labelTicketsRemainingPrompt.Name = "labelTicketsRemainingPrompt";
            this.labelTicketsRemainingPrompt.Size = new System.Drawing.Size(176, 16);
            this.labelTicketsRemainingPrompt.TabIndex = 2;
            this.labelTicketsRemainingPrompt.Text = "Tickets Balance Remaining:";
            // 
            // labelQtyPrompt
            // 
            this.labelQtyPrompt.AutoSize = true;
            this.labelQtyPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQtyPrompt.Location = new System.Drawing.Point(72, 189);
            this.labelQtyPrompt.Name = "labelQtyPrompt";
            this.labelQtyPrompt.Size = new System.Drawing.Size(194, 16);
            this.labelQtyPrompt.TabIndex = 3;
            this.labelQtyPrompt.Text = "&Number of Tickets to Purchase:";
            this.labelQtyPrompt.DoubleClick += new System.EventHandler(this.labelQtyPrompt_DoubleClick);
            // 
            // labelMaxTickets
            // 
            this.labelMaxTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxTickets.Location = new System.Drawing.Point(261, 59);
            this.labelMaxTickets.Name = "labelMaxTickets";
            this.labelMaxTickets.Size = new System.Drawing.Size(87, 23);
            this.labelMaxTickets.TabIndex = 4;
            this.labelMaxTickets.Text = "<Max>";
            this.labelMaxTickets.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotalPurchased
            // 
            this.labelTotalPurchased.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPurchased.Location = new System.Drawing.Point(261, 95);
            this.labelTotalPurchased.Name = "labelTotalPurchased";
            this.labelTotalPurchased.Size = new System.Drawing.Size(87, 23);
            this.labelTotalPurchased.TabIndex = 5;
            this.labelTotalPurchased.Text = "<Prev>";
            this.labelTotalPurchased.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTicketsRemaining
            // 
            this.labelTicketsRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicketsRemaining.Location = new System.Drawing.Point(261, 131);
            this.labelTicketsRemaining.Name = "labelTicketsRemaining";
            this.labelTicketsRemaining.Size = new System.Drawing.Size(87, 23);
            this.labelTicketsRemaining.TabIndex = 6;
            this.labelTicketsRemaining.Text = "<Remain>";
            this.labelTicketsRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxPurchaseQty
            // 
            this.textBoxPurchaseQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorProvider.SetIconPadding(this.textBoxPurchaseQty, 5);
            this.textBoxPurchaseQty.Location = new System.Drawing.Point(270, 186);
            this.textBoxPurchaseQty.Name = "textBoxPurchaseQty";
            this.textBoxPurchaseQty.Size = new System.Drawing.Size(78, 22);
            this.textBoxPurchaseQty.TabIndex = 7;
            this.textBoxPurchaseQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonPurchase
            // 
            this.buttonPurchase.Location = new System.Drawing.Point(254, 228);
            this.buttonPurchase.Name = "buttonPurchase";
            this.buttonPurchase.Size = new System.Drawing.Size(94, 23);
            this.buttonPurchase.TabIndex = 8;
            this.buttonPurchase.Text = "&Purchase";
            this.buttonPurchase.UseVisualStyleBackColor = true;
            this.buttonPurchase.Click += new System.EventHandler(this.buttonPurchase_Click);
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(4, 281);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(468, 23);
            this.labelResult.TabIndex = 10;
            this.labelResult.Text = "<Purchase Results>";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // labelHeader
            // 
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(-1, 3);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(473, 29);
            this.labelHeader.TabIndex = 11;
            this.labelHeader.Text = "Ticket Ordering";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonPurchase;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 320);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonPurchase);
            this.Controls.Add(this.textBoxPurchaseQty);
            this.Controls.Add(this.labelTicketsRemaining);
            this.Controls.Add(this.labelTotalPurchased);
            this.Controls.Add(this.labelMaxTickets);
            this.Controls.Add(this.labelQtyPrompt);
            this.Controls.Add(this.labelTicketsRemainingPrompt);
            this.Controls.Add(this.labelTotalTicketsPrompt);
            this.Controls.Add(this.labelMaxTicketsPrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validation Demo ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMaxTicketsPrompt;
        private System.Windows.Forms.Label labelTotalTicketsPrompt;
        private System.Windows.Forms.Label labelTicketsRemainingPrompt;
        private System.Windows.Forms.Label labelQtyPrompt;
        private System.Windows.Forms.Label labelMaxTickets;
        private System.Windows.Forms.Label labelTotalPurchased;
        private System.Windows.Forms.Label labelTicketsRemaining;
        private System.Windows.Forms.TextBox textBoxPurchaseQty;
        private System.Windows.Forms.Button buttonPurchase;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label labelHeader;
    }
}


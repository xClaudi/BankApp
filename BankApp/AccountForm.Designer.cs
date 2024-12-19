namespace BankApp
{
    partial class AccountForm
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
            this.typelabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.moneylabel = new System.Windows.Forms.Label();
            this.tView = new System.Windows.Forms.ListView();
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Merchant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // typelabel
            // 
            this.typelabel.AutoSize = true;
            this.typelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typelabel.Location = new System.Drawing.Point(313, 21);
            this.typelabel.Name = "typelabel";
            this.typelabel.Size = new System.Drawing.Size(195, 33);
            this.typelabel.TabIndex = 1;
            this.typelabel.Text = "PLN Account";
            this.typelabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "dlkkl",
            "dfdfff",
            "dffff"});
            this.listBox1.Location = new System.Drawing.Point(23, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(138, 340);
            this.listBox1.TabIndex = 3;
            // 
            // moneylabel
            // 
            this.moneylabel.AutoSize = true;
            this.moneylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.moneylabel.Location = new System.Drawing.Point(329, 81);
            this.moneylabel.Name = "moneylabel";
            this.moneylabel.Size = new System.Drawing.Size(150, 29);
            this.moneylabel.TabIndex = 4;
            this.moneylabel.Text = "2000.00 PLN";
            this.moneylabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // tView
            // 
            this.tView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Amount,
            this.Merchant});
            this.tView.HideSelection = false;
            this.tView.Location = new System.Drawing.Point(235, 163);
            this.tView.Name = "tView";
            this.tView.Size = new System.Drawing.Size(374, 186);
            this.tView.TabIndex = 7;
            this.tView.UseCompatibleStateImageBehavior = false;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 150;
            // 
            // Merchant
            // 
            this.Merchant.Text = "Merchant";
            this.Merchant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Merchant.Width = 150;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 386);
            this.Controls.Add(this.tView);
            this.Controls.Add(this.moneylabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.typelabel);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label typelabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label moneylabel;
        private System.Windows.Forms.ListView tView;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Merchant;
    }
}
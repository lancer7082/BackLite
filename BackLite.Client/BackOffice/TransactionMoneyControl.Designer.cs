namespace BackLite.Client
{
    partial class TransactionMoneyControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.edAccount = new System.Windows.Forms.TextBox();
            this.tcMain.SuspendLayout();
            this.pgMain.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pgMain
            // 
            this.pgMain.Controls.Add(this.edAccount);
            this.pgMain.Controls.Add(this.label1);
            // 
            // bsMain
            // 
            this.bsMain.DataSource = typeof(BackLite.Data.Models.TransactionMoney);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Счет:";
            // 
            // edAccount
            // 
            this.edAccount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "AccountId", true));
            this.edAccount.Location = new System.Drawing.Point(86, 20);
            this.edAccount.Name = "edAccount";
            this.edAccount.Size = new System.Drawing.Size(100, 20);
            this.edAccount.TabIndex = 1;
            // 
            // TransactionMoneyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "TransactionMoneyControl";
            this.tcMain.ResumeLayout(false);
            this.pgMain.ResumeLayout(false);
            this.pgMain.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox edAccount;
        private System.Windows.Forms.Label label1;

    }
}

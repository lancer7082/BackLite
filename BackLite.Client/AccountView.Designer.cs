namespace BackLite.Client
{
    partial class AccountView
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbAccountId = new System.Windows.Forms.Label();
            this.edAccount = new System.Windows.Forms.TextBox();
            this.bsAccount = new System.Windows.Forms.BindingSource(this.components);
            this.edClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edPlatform = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edIdentifier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgCodes = new System.Windows.Forms.DataGridView();
            this.bsAccountCodes = new System.Windows.Forms.BindingSource(this.components);
            this.codeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRegisteredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.accountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAccountCodes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(16, 229);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(394, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lbAccountId
            // 
            this.lbAccountId.AutoSize = true;
            this.lbAccountId.Location = new System.Drawing.Point(13, 15);
            this.lbAccountId.Name = "lbAccountId";
            this.lbAccountId.Size = new System.Drawing.Size(47, 13);
            this.lbAccountId.TabIndex = 2;
            this.lbAccountId.Text = "Account";
            // 
            // edAccount
            // 
            this.edAccount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAccount, "AccountId", true));
            this.edAccount.Location = new System.Drawing.Point(86, 12);
            this.edAccount.Name = "edAccount";
            this.edAccount.Size = new System.Drawing.Size(138, 20);
            this.edAccount.TabIndex = 3;
            // 
            // bsAccount
            // 
            this.bsAccount.DataSource = typeof(BackLite.Data.Models.Account);
            // 
            // edClient
            // 
            this.edClient.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAccount, "ClientId", true));
            this.edClient.Location = new System.Drawing.Point(86, 38);
            this.edClient.Name = "edClient";
            this.edClient.Size = new System.Drawing.Size(138, 20);
            this.edClient.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Client";
            // 
            // edPlatform
            // 
            this.edPlatform.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAccount, "PlatformId", true));
            this.edPlatform.Location = new System.Drawing.Point(323, 38);
            this.edPlatform.Name = "edPlatform";
            this.edPlatform.Size = new System.Drawing.Size(138, 20);
            this.edPlatform.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Platform";
            // 
            // edIdentifier
            // 
            this.edIdentifier.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAccount, "Identifier", true));
            this.edIdentifier.Location = new System.Drawing.Point(323, 12);
            this.edIdentifier.Name = "edIdentifier";
            this.edIdentifier.Size = new System.Drawing.Size(138, 20);
            this.edIdentifier.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Identifier";
            // 
            // dgCodes
            // 
            this.dgCodes.AutoGenerateColumns = false;
            this.dgCodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCodes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeIdDataGridViewTextBoxColumn,
            this.accountIdDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.isRegisteredDataGridViewCheckBoxColumn,
            this.accountDataGridViewTextBoxColumn});
            this.dgCodes.DataSource = this.bsAccountCodes;
            this.dgCodes.Location = new System.Drawing.Point(16, 75);
            this.dgCodes.Name = "dgCodes";
            this.dgCodes.Size = new System.Drawing.Size(445, 139);
            this.dgCodes.TabIndex = 10;
            // 
            // bsAccountCodes
            // 
            this.bsAccountCodes.DataSource = typeof(BackLite.Data.Models.AccountCode);
            // 
            // codeIdDataGridViewTextBoxColumn
            // 
            this.codeIdDataGridViewTextBoxColumn.DataPropertyName = "CodeId";
            this.codeIdDataGridViewTextBoxColumn.HeaderText = "CodeId";
            this.codeIdDataGridViewTextBoxColumn.Name = "codeIdDataGridViewTextBoxColumn";
            this.codeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // accountIdDataGridViewTextBoxColumn
            // 
            this.accountIdDataGridViewTextBoxColumn.DataPropertyName = "AccountId";
            this.accountIdDataGridViewTextBoxColumn.HeaderText = "AccountId";
            this.accountIdDataGridViewTextBoxColumn.Name = "accountIdDataGridViewTextBoxColumn";
            this.accountIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // isRegisteredDataGridViewCheckBoxColumn
            // 
            this.isRegisteredDataGridViewCheckBoxColumn.DataPropertyName = "IsRegistered";
            this.isRegisteredDataGridViewCheckBoxColumn.HeaderText = "IsRegistered";
            this.isRegisteredDataGridViewCheckBoxColumn.Name = "isRegisteredDataGridViewCheckBoxColumn";
            // 
            // accountDataGridViewTextBoxColumn
            // 
            this.accountDataGridViewTextBoxColumn.DataPropertyName = "Account";
            this.accountDataGridViewTextBoxColumn.HeaderText = "Account";
            this.accountDataGridViewTextBoxColumn.Name = "accountDataGridViewTextBoxColumn";
            this.accountDataGridViewTextBoxColumn.Visible = false;
            // 
            // AccountView
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(481, 264);
            this.Controls.Add(this.dgCodes);
            this.Controls.Add(this.edPlatform);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edIdentifier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edAccount);
            this.Controls.Add(this.lbAccountId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "AccountView";
            this.Text = "AccountView";
            this.Load += new System.EventHandler(this.AccountView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAccountCodes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbAccountId;
        private System.Windows.Forms.TextBox edAccount;
        private System.Windows.Forms.TextBox edClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edPlatform;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edIdentifier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bsAccount;
        private System.Windows.Forms.DataGridView dgCodes;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isRegisteredDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsAccountCodes;
    }
}
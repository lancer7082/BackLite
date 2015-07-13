namespace BackLite.Client
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
            this.bsAccounts = new System.Windows.Forms.BindingSource(this.components);
            this.pnlTree = new System.Windows.Forms.Panel();
            this.treePlatforms = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.bsPlatformsTree = new System.Windows.Forms.BindingSource(this.components);
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgMain = new System.Windows.Forms.DataGridView();
            this.accountIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identifierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsAccounts)).BeginInit();
            this.pnlTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treePlatforms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPlatformsTree)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMain)).BeginInit();
            this.SuspendLayout();
            // 
            // bsAccounts
            // 
            this.bsAccounts.DataSource = typeof(BackLite.Data.Models.Account);
            // 
            // pnlTree
            // 
            this.pnlTree.Controls.Add(this.treePlatforms);
            this.pnlTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTree.Location = new System.Drawing.Point(0, 0);
            this.pnlTree.Name = "pnlTree";
            this.pnlTree.Size = new System.Drawing.Size(200, 379);
            this.pnlTree.TabIndex = 1;
            // 
            // treePlatforms
            // 
            this.treePlatforms.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName});
            this.treePlatforms.DataSource = this.bsPlatformsTree;
            this.treePlatforms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treePlatforms.KeyFieldName = "Id";
            this.treePlatforms.Location = new System.Drawing.Point(0, 0);
            this.treePlatforms.Name = "treePlatforms";
            this.treePlatforms.OptionsBehavior.Editable = false;
            this.treePlatforms.OptionsView.ShowColumns = false;
            this.treePlatforms.OptionsView.ShowHorzLines = false;
            this.treePlatforms.OptionsView.ShowIndicator = false;
            this.treePlatforms.ParentFieldName = "ParentId";
            this.treePlatforms.Size = new System.Drawing.Size(200, 379);
            this.treePlatforms.TabIndex = 0;
            this.treePlatforms.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treePlatforms_FocusedNodeChanged);
            // 
            // colName
            // 
            this.colName.Caption = "Наименование";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 61;
            // 
            // bsPlatformsTree
            // 
            this.bsPlatformsTree.DataSource = typeof(BackLite.Data.Models.Platforms_Tree_Result);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgMain);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(200, 0);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(593, 379);
            this.pnlGrid.TabIndex = 2;
            // 
            // dgMain
            // 
            this.dgMain.AllowUserToAddRows = false;
            this.dgMain.AllowUserToDeleteRows = false;
            this.dgMain.AutoGenerateColumns = false;
            this.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountIdDataGridViewTextBoxColumn,
            this.clientIdDataGridViewTextBoxColumn,
            this.identifierDataGridViewTextBoxColumn,
            this.platformIdDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn});
            this.dgMain.DataSource = this.bsAccounts;
            this.dgMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgMain.Location = new System.Drawing.Point(0, 0);
            this.dgMain.Name = "dgMain";
            this.dgMain.Size = new System.Drawing.Size(593, 379);
            this.dgMain.TabIndex = 1;
            // 
            // accountIdDataGridViewTextBoxColumn
            // 
            this.accountIdDataGridViewTextBoxColumn.DataPropertyName = "AccountId";
            this.accountIdDataGridViewTextBoxColumn.HeaderText = "AccountId";
            this.accountIdDataGridViewTextBoxColumn.Name = "accountIdDataGridViewTextBoxColumn";
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            // 
            // identifierDataGridViewTextBoxColumn
            // 
            this.identifierDataGridViewTextBoxColumn.DataPropertyName = "Identifier";
            this.identifierDataGridViewTextBoxColumn.HeaderText = "Identifier";
            this.identifierDataGridViewTextBoxColumn.Name = "identifierDataGridViewTextBoxColumn";
            // 
            // platformIdDataGridViewTextBoxColumn
            // 
            this.platformIdDataGridViewTextBoxColumn.DataPropertyName = "PlatformId";
            this.platformIdDataGridViewTextBoxColumn.HeaderText = "PlatformId";
            this.platformIdDataGridViewTextBoxColumn.Name = "platformIdDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 379);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlTree);
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsAccounts)).EndInit();
            this.pnlTree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treePlatforms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPlatformsTree)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsAccounts;
        private System.Windows.Forms.Panel pnlTree;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identifierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private DevExpress.XtraTreeList.TreeList treePlatforms;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private System.Windows.Forms.BindingSource bsPlatformsTree;
    }
}


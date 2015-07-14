namespace BackLite.Client
{
    partial class TransactionsView
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
            this.tranIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tranTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instrumentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identifierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMain = new System.Windows.Forms.DataGridView();
            this.tranIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tranTypeIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instrumentIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identifierDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pmGrid = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.mnNew = new DevExpress.XtraBars.BarButtonItem();
            this.mnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.mnDelete = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // bsMain
            // 
            this.bsMain.DataSource = typeof(BackLite.Data.Models.TransactionsViewItem);
            // 
            // tranIdDataGridViewTextBoxColumn
            // 
            this.tranIdDataGridViewTextBoxColumn.DataPropertyName = "TranId";
            this.tranIdDataGridViewTextBoxColumn.HeaderText = "TranId";
            this.tranIdDataGridViewTextBoxColumn.Name = "tranIdDataGridViewTextBoxColumn";
            // 
            // accountIdDataGridViewTextBoxColumn
            // 
            this.accountIdDataGridViewTextBoxColumn.DataPropertyName = "AccountId";
            this.accountIdDataGridViewTextBoxColumn.HeaderText = "AccountId";
            this.accountIdDataGridViewTextBoxColumn.Name = "accountIdDataGridViewTextBoxColumn";
            // 
            // tranTypeIdDataGridViewTextBoxColumn
            // 
            this.tranTypeIdDataGridViewTextBoxColumn.DataPropertyName = "TranTypeId";
            this.tranTypeIdDataGridViewTextBoxColumn.HeaderText = "TranTypeId";
            this.tranTypeIdDataGridViewTextBoxColumn.Name = "tranTypeIdDataGridViewTextBoxColumn";
            // 
            // instrumentIdDataGridViewTextBoxColumn
            // 
            this.instrumentIdDataGridViewTextBoxColumn.DataPropertyName = "InstrumentId";
            this.instrumentIdDataGridViewTextBoxColumn.HeaderText = "InstrumentId";
            this.instrumentIdDataGridViewTextBoxColumn.Name = "instrumentIdDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // sumDataGridViewTextBoxColumn
            // 
            this.sumDataGridViewTextBoxColumn.DataPropertyName = "Sum";
            this.sumDataGridViewTextBoxColumn.HeaderText = "Sum";
            this.sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            // 
            // identifierDataGridViewTextBoxColumn
            // 
            this.identifierDataGridViewTextBoxColumn.DataPropertyName = "Identifier";
            this.identifierDataGridViewTextBoxColumn.HeaderText = "Identifier";
            this.identifierDataGridViewTextBoxColumn.Name = "identifierDataGridViewTextBoxColumn";
            // 
            // dgMain
            // 
            this.dgMain.AllowUserToAddRows = false;
            this.dgMain.AllowUserToDeleteRows = false;
            this.dgMain.AutoGenerateColumns = false;
            this.dgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tranIdDataGridViewTextBoxColumn1,
            this.accountIdDataGridViewTextBoxColumn1,
            this.tranTypeIdDataGridViewTextBoxColumn1,
            this.instrumentIdDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.sumDataGridViewTextBoxColumn1,
            this.identifierDataGridViewTextBoxColumn1});
            this.dgMain.DataSource = this.bsMain;
            this.dgMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgMain.Location = new System.Drawing.Point(0, 0);
            this.dgMain.Name = "dgMain";
            this.barManager.SetPopupContextMenu(this.dgMain, this.pmGrid);
            this.dgMain.Size = new System.Drawing.Size(780, 425);
            this.dgMain.TabIndex = 0;
            // 
            // tranIdDataGridViewTextBoxColumn1
            // 
            this.tranIdDataGridViewTextBoxColumn1.DataPropertyName = "TranId";
            this.tranIdDataGridViewTextBoxColumn1.HeaderText = "TranId";
            this.tranIdDataGridViewTextBoxColumn1.Name = "tranIdDataGridViewTextBoxColumn1";
            // 
            // accountIdDataGridViewTextBoxColumn1
            // 
            this.accountIdDataGridViewTextBoxColumn1.DataPropertyName = "AccountId";
            this.accountIdDataGridViewTextBoxColumn1.HeaderText = "AccountId";
            this.accountIdDataGridViewTextBoxColumn1.Name = "accountIdDataGridViewTextBoxColumn1";
            // 
            // tranTypeIdDataGridViewTextBoxColumn1
            // 
            this.tranTypeIdDataGridViewTextBoxColumn1.DataPropertyName = "TranTypeId";
            this.tranTypeIdDataGridViewTextBoxColumn1.HeaderText = "TranTypeId";
            this.tranTypeIdDataGridViewTextBoxColumn1.Name = "tranTypeIdDataGridViewTextBoxColumn1";
            // 
            // instrumentIdDataGridViewTextBoxColumn1
            // 
            this.instrumentIdDataGridViewTextBoxColumn1.DataPropertyName = "InstrumentId";
            this.instrumentIdDataGridViewTextBoxColumn1.HeaderText = "InstrumentId";
            this.instrumentIdDataGridViewTextBoxColumn1.Name = "instrumentIdDataGridViewTextBoxColumn1";
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            // 
            // sumDataGridViewTextBoxColumn1
            // 
            this.sumDataGridViewTextBoxColumn1.DataPropertyName = "Sum";
            this.sumDataGridViewTextBoxColumn1.HeaderText = "Sum";
            this.sumDataGridViewTextBoxColumn1.Name = "sumDataGridViewTextBoxColumn1";
            // 
            // identifierDataGridViewTextBoxColumn1
            // 
            this.identifierDataGridViewTextBoxColumn1.DataPropertyName = "Identifier";
            this.identifierDataGridViewTextBoxColumn1.HeaderText = "Identifier";
            this.identifierDataGridViewTextBoxColumn1.Name = "identifierDataGridViewTextBoxColumn1";
            // 
            // pmGrid
            // 
            this.pmGrid.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnDelete)});
            this.pmGrid.Manager = this.barManager;
            this.pmGrid.Name = "pmGrid";
            // 
            // barManager
            // 
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mnNew,
            this.mnEdit,
            this.mnDelete});
            this.barManager.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(780, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 425);
            this.barDockControlBottom.Size = new System.Drawing.Size(780, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 425);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(780, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 425);
            // 
            // mnNew
            // 
            this.mnNew.Caption = "Добавить";
            this.mnNew.Id = 0;
            this.mnNew.Name = "mnNew";
            this.mnNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnNew_ItemClick);
            // 
            // mnEdit
            // 
            this.mnEdit.Caption = "Редактировать";
            this.mnEdit.Id = 1;
            this.mnEdit.Name = "mnEdit";
            // 
            // mnDelete
            // 
            this.mnDelete.Caption = "Удалить";
            this.mnDelete.Id = 2;
            this.mnDelete.Name = "mnDelete";
            // 
            // TransactionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 425);
            this.Controls.Add(this.dgMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "TransactionsView";
            this.Text = "TransactionsView";
            this.Shown += new System.EventHandler(this.TransactionsView_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn tranIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tranTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instrumentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identifierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn tranIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tranTypeIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn instrumentIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn identifierDataGridViewTextBoxColumn1;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem mnNew;
        private DevExpress.XtraBars.BarButtonItem mnEdit;
        private DevExpress.XtraBars.BarButtonItem mnDelete;
        private DevExpress.XtraBars.PopupMenu pmGrid;
    }
}
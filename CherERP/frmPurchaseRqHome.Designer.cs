namespace Belayab
{
    partial class frmPurchaseRqHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseRqHome));
            this.belayAbSSDataSet = new Belayab.BelayAbSSDataSet();
            this.purchaseRequisitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseRequisitionTableAdapter = new Belayab.BelayAbSSDataSetTableAdapters.PurchaseRequisitionTableAdapter();
            this.purchaseRequisitionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripAddNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripRefresh = new System.Windows.Forms.ToolStripButton();
            this.purchaseRequisitionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseReqNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApprovedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionBindingNavigator)).BeginInit();
            this.purchaseRequisitionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // belayAbSSDataSet
            // 
            this.belayAbSSDataSet.DataSetName = "BelayAbSSDataSet";
            this.belayAbSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseRequisitionBindingSource
            // 
            this.purchaseRequisitionBindingSource.DataMember = "PurchaseRequisition";
            this.purchaseRequisitionBindingSource.DataSource = this.belayAbSSDataSet;
            // 
            // purchaseRequisitionTableAdapter
            // 
            this.purchaseRequisitionTableAdapter.ClearBeforeFill = true;
            // 
            // purchaseRequisitionBindingNavigator
            // 
            this.purchaseRequisitionBindingNavigator.AddNewItem = null;
            this.purchaseRequisitionBindingNavigator.BindingSource = this.purchaseRequisitionBindingSource;
            this.purchaseRequisitionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.purchaseRequisitionBindingNavigator.DeleteItem = null;
            this.purchaseRequisitionBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.purchaseRequisitionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.txtFind,
            this.toolStripAddNew,
            this.toolStripSeparator3,
            this.toolStripLabel3,
            this.toolStripRefresh});
            this.purchaseRequisitionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.purchaseRequisitionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.purchaseRequisitionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.purchaseRequisitionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.purchaseRequisitionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.purchaseRequisitionBindingNavigator.Name = "purchaseRequisitionBindingNavigator";
            this.purchaseRequisitionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.purchaseRequisitionBindingNavigator.Size = new System.Drawing.Size(1225, 27);
            this.purchaseRequisitionBindingNavigator.TabIndex = 0;
            this.purchaseRequisitionBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(57, 24);
            this.toolStripLabel1.Text = "Find>>";
            // 
            // txtFind
            // 
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(132, 27);
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // toolStripAddNew
            // 
            this.toolStripAddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripAddNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAddNew.Image")));
            this.toolStripAddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAddNew.Name = "toolStripAddNew";
            this.toolStripAddNew.Size = new System.Drawing.Size(75, 24);
            this.toolStripAddNew.Text = "Add New";
            this.toolStripAddNew.Click += new System.EventHandler(this.toolStripAddNew_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(21, 24);
            this.toolStripLabel3.Text = "   ";
            // 
            // toolStripRefresh
            // 
            this.toolStripRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRefresh.Image")));
            this.toolStripRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRefresh.Name = "toolStripRefresh";
            this.toolStripRefresh.Size = new System.Drawing.Size(62, 24);
            this.toolStripRefresh.Text = "Refresh";
            this.toolStripRefresh.Click += new System.EventHandler(this.toolStripRefresh_Click);
            // 
            // purchaseRequisitionDataGridView
            // 
            this.purchaseRequisitionDataGridView.AllowDrop = true;
            this.purchaseRequisitionDataGridView.AllowUserToAddRows = false;
            this.purchaseRequisitionDataGridView.AutoGenerateColumns = false;
            this.purchaseRequisitionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseRequisitionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PurchaseReqNo,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.RequestType,
            this.RequestedBy,
            this.ApprovedBy,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn6});
            this.purchaseRequisitionDataGridView.DataSource = this.purchaseRequisitionBindingSource;
            this.purchaseRequisitionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseRequisitionDataGridView.Location = new System.Drawing.Point(0, 27);
            this.purchaseRequisitionDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.purchaseRequisitionDataGridView.Name = "purchaseRequisitionDataGridView";
            this.purchaseRequisitionDataGridView.Size = new System.Drawing.Size(1225, 608);
            this.purchaseRequisitionDataGridView.TabIndex = 1;
            this.purchaseRequisitionDataGridView.DoubleClick += new System.EventHandler(this.purchaseRequisitionDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PerchaseReqNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Perchase Req No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "StoreID";
            this.dataGridViewTextBoxColumn7.HeaderText = "StoreID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn8.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // PurchaseReqNo
            // 
            this.PurchaseReqNo.DataPropertyName = "PerchaseReqNo";
            this.PurchaseReqNo.HeaderText = "Perchase Req No";
            this.PurchaseReqNo.Name = "PurchaseReqNo";
            this.PurchaseReqNo.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Refrerence";
            this.dataGridViewTextBoxColumn3.HeaderText = "Refrerence";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "Req. Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn5.HeaderText = "Status";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // RequestType
            // 
            this.RequestType.DataPropertyName = "RequestType";
            this.RequestType.HeaderText = "Request Type";
            this.RequestType.Name = "RequestType";
            this.RequestType.Width = 110;
            // 
            // RequestedBy
            // 
            this.RequestedBy.DataPropertyName = "RequestedBy";
            this.RequestedBy.HeaderText = "RequestedBy";
            this.RequestedBy.Name = "RequestedBy";
            // 
            // ApprovedBy
            // 
            this.ApprovedBy.DataPropertyName = "ApprovedBy";
            this.ApprovedBy.HeaderText = "ApprovedBy";
            this.ApprovedBy.Name = "ApprovedBy";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "StoreID";
            this.dataGridViewTextBoxColumn9.HeaderText = "Store";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn6.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // frmPurchaseRqHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 635);
            this.Controls.Add(this.purchaseRequisitionDataGridView);
            this.Controls.Add(this.purchaseRequisitionBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPurchaseRqHome";
            this.Text = "Purchase Requisition Home";
            this.Load += new System.EventHandler(this.frmPurchaseRqHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionBindingNavigator)).EndInit();
            this.purchaseRequisitionBindingNavigator.ResumeLayout(false);
            this.purchaseRequisitionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BelayAbSSDataSet belayAbSSDataSet;
        private System.Windows.Forms.BindingSource purchaseRequisitionBindingSource;
        private BelayAbSSDataSetTableAdapters.PurchaseRequisitionTableAdapter purchaseRequisitionTableAdapter;
        private System.Windows.Forms.BindingNavigator purchaseRequisitionBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView purchaseRequisitionDataGridView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtFind;
        private System.Windows.Forms.ToolStripButton toolStripAddNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseReqNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApprovedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
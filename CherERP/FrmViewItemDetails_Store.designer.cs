namespace Belayab
{
    partial class FrmViewItemDetails_Store
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
            this.itemsReceivedTableAdapter = new Belayab.BelayabViewReceivedHistoryTableAdapters.ItemsReceivedTableAdapter();
            this.itemsReceivedDetailsTableAdapter = new Belayab.BelayabViewReceivedHistoryTableAdapters.ItemsReceivedDetailsTableAdapter();
            this.belayAbSSItemHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbSSItemHistory = new Belayab.BelayAbSSItemHistory();
            this.belayAbInvoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbInvoices = new Belayab.BelayAbInvoices();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.storeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.store1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.belayAbSecurity1 = new Belayab.BelayAbSecurity();
            this.grdTranList = new System.Windows.Forms.DataGrid();
            this.itemsReceivedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsReceivedDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cboStore = new System.Windows.Forms.ToolStripComboBox();
            this.belayAbBranchStore = new Belayab.BelayAbBranchStore();
            this.i_StoreListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.i_StoreListTableAdapter = new Belayab.BelayAbBranchStoreTableAdapters.I_StoreListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSItemHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSItemHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbInvoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbInvoices)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSecurity1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTranList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsReceivedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsReceivedDetailsBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbBranchStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.i_StoreListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // itemsReceivedTableAdapter
            // 
            this.itemsReceivedTableAdapter.ClearBeforeFill = true;
            // 
            // itemsReceivedDetailsTableAdapter
            // 
            this.itemsReceivedDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // belayAbSSItemHistoryBindingSource
            // 
            this.belayAbSSItemHistoryBindingSource.DataSource = this.belayAbSSItemHistory;
            this.belayAbSSItemHistoryBindingSource.Position = 0;
            // 
            // belayAbSSItemHistory
            // 
            this.belayAbSSItemHistory.DataSetName = "BelayAbSSItemHistory";
            this.belayAbSSItemHistory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // belayAbInvoicesBindingSource
            // 
            this.belayAbInvoicesBindingSource.DataSource = this.belayAbInvoices;
            this.belayAbInvoicesBindingSource.Position = 0;
            // 
            // belayAbInvoices
            // 
            this.belayAbInvoices.DataSetName = "BelayAbInvoices";
            this.belayAbInvoices.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrintPreview,
            this.storeViewToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 48);
            // 
            // mnuPrintPreview
            // 
            this.mnuPrintPreview.Name = "mnuPrintPreview";
            this.mnuPrintPreview.Size = new System.Drawing.Size(143, 22);
            this.mnuPrintPreview.Text = "Print Preview";
            this.mnuPrintPreview.Click += new System.EventHandler(this.mnuPrintPreview_Click);
            // 
            // storeViewToolStripMenuItem
            // 
            this.storeViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.store1ToolStripMenuItem});
            this.storeViewToolStripMenuItem.Name = "storeViewToolStripMenuItem";
            this.storeViewToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.storeViewToolStripMenuItem.Text = "Store View";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.mainToolStripMenuItem.Text = "Main";
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // store1ToolStripMenuItem
            // 
            this.store1ToolStripMenuItem.Name = "store1ToolStripMenuItem";
            this.store1ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.store1ToolStripMenuItem.Text = "Store1";
            this.store1ToolStripMenuItem.Click += new System.EventHandler(this.store1ToolStripMenuItem_Click);
            // 
            // belayAbSecurity1
            // 
            this.belayAbSecurity1.DataSetName = "BelayAbSecurity";
            this.belayAbSecurity1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdTranList
            // 
            this.grdTranList.AlternatingBackColor = System.Drawing.Color.Silver;
            this.grdTranList.BackColor = System.Drawing.Color.White;
            this.grdTranList.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.grdTranList.CaptionFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdTranList.CaptionForeColor = System.Drawing.Color.White;
            this.grdTranList.DataMember = "";
            this.grdTranList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdTranList.Font = new System.Drawing.Font("Tahoma", 8F);
            this.grdTranList.ForeColor = System.Drawing.Color.Black;
            this.grdTranList.GridLineColor = System.Drawing.Color.Silver;
            this.grdTranList.HeaderBackColor = System.Drawing.Color.Silver;
            this.grdTranList.HeaderFont = new System.Drawing.Font("Tahoma", 8F);
            this.grdTranList.HeaderForeColor = System.Drawing.Color.Black;
            this.grdTranList.LinkColor = System.Drawing.Color.Maroon;
            this.grdTranList.Location = new System.Drawing.Point(0, 28);
            this.grdTranList.Name = "grdTranList";
            this.grdTranList.ParentRowsBackColor = System.Drawing.Color.Silver;
            this.grdTranList.ParentRowsForeColor = System.Drawing.Color.Black;
            this.grdTranList.SelectionBackColor = System.Drawing.Color.Maroon;
            this.grdTranList.SelectionForeColor = System.Drawing.Color.White;
            this.grdTranList.Size = new System.Drawing.Size(978, 505);
            this.grdTranList.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cboStore});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(978, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(34, 22);
            this.toolStripLabel1.Text = "Store";
            // 
            // cboStore
            // 
            this.cboStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStore.Name = "cboStore";
            this.cboStore.Size = new System.Drawing.Size(121, 25);
            this.cboStore.SelectedIndexChanged += new System.EventHandler(this.cboStore_SelectedIndexChanged);
            // 
            // belayAbBranchStore
            // 
            this.belayAbBranchStore.DataSetName = "BelayAbBranchStore";
            this.belayAbBranchStore.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // i_StoreListBindingSource
            // 
            this.i_StoreListBindingSource.DataMember = "I_StoreList";
            this.i_StoreListBindingSource.DataSource = this.belayAbBranchStore;
            // 
            // i_StoreListTableAdapter
            // 
            this.i_StoreListTableAdapter.ClearBeforeFill = true;
            // 
            // FrmViewItemDetails_Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(978, 533);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grdTranList);
            this.Name = "FrmViewItemDetails_Store";
            this.Text = "Item Transaction Details";
            this.Load += new System.EventHandler(this.FrmViewItemDetails_Load);
            this.Resize += new System.EventHandler(this.FrmViewItemDetails_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSItemHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSItemHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbInvoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbInvoices)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSecurity1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTranList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsReceivedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsReceivedDetailsBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbBranchStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.i_StoreListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource itemsReceivedBindingSource;
        private Belayab.BelayabViewReceivedHistoryTableAdapters.ItemsReceivedTableAdapter itemsReceivedTableAdapter;
        private System.Windows.Forms.BindingSource itemsReceivedDetailsBindingSource;
        private Belayab.BelayabViewReceivedHistoryTableAdapters.ItemsReceivedDetailsTableAdapter itemsReceivedDetailsTableAdapter;
        private System.Windows.Forms.BindingSource belayAbSSItemHistoryBindingSource;
        private BelayAbSSItemHistory belayAbSSItemHistory;
        private System.Windows.Forms.BindingSource belayAbInvoicesBindingSource;
        private BelayAbInvoices belayAbInvoices;
        private BelayAbSecurity belayAbSecurity1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuPrintPreview;
        private System.Windows.Forms.ToolStripMenuItem storeViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem store1ToolStripMenuItem;
        private System.Windows.Forms.DataGrid grdTranList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cboStore;
        private BelayAbBranchStore belayAbBranchStore;
        private System.Windows.Forms.BindingSource i_StoreListBindingSource;
        private Belayab.BelayAbBranchStoreTableAdapters.I_StoreListTableAdapter i_StoreListTableAdapter;
    }
}
namespace Belayab
{
    partial class frmMechanic
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
            System.Windows.Forms.Label mechanicIDLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label telephoneNumberLabel;
            System.Windows.Forms.Label mechancic_TypeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMechanic));
            this.BelayAbVMaintain = new Belayab.BelayAbVMaintain();
            this.m_MechanicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_MechanicTableAdapter = new Belayab.BelayAbVMaintainTableAdapters.m_MechanicTableAdapter();
            this.m_MechanicBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.m_MechanicBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mechanicIDTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.telephoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.mechancic_TypeComboBox = new System.Windows.Forms.ComboBox();
            this.btnListAll = new System.Windows.Forms.Button();
            this.grdMechList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mechanicIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mechancicTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            mechanicIDLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            telephoneNumberLabel = new System.Windows.Forms.Label();
            mechancic_TypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BelayAbVMaintain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_MechanicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_MechanicBindingNavigator)).BeginInit();
            this.m_MechanicBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMechList)).BeginInit();
            this.SuspendLayout();
            // 
            // mechanicIDLabel
            // 
            mechanicIDLabel.AutoSize = true;
            mechanicIDLabel.Location = new System.Drawing.Point(64, 42);
            mechanicIDLabel.Name = "mechanicIDLabel";
            mechanicIDLabel.Size = new System.Drawing.Size(71, 13);
            mechanicIDLabel.TabIndex = 1;
            mechanicIDLabel.Text = "Mechanic ID:";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(78, 75);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(57, 13);
            fullNameLabel.TabIndex = 3;
            fullNameLabel.Text = "Full Name:";
            // 
            // telephoneNumberLabel
            // 
            telephoneNumberLabel.AutoSize = true;
            telephoneNumberLabel.Location = new System.Drawing.Point(34, 108);
            telephoneNumberLabel.Name = "telephoneNumberLabel";
            telephoneNumberLabel.Size = new System.Drawing.Size(101, 13);
            telephoneNumberLabel.TabIndex = 5;
            telephoneNumberLabel.Text = "Telephone Number:";
            // 
            // mechancic_TypeLabel
            // 
            mechancic_TypeLabel.AutoSize = true;
            mechancic_TypeLabel.Location = new System.Drawing.Point(45, 141);
            mechancic_TypeLabel.Name = "mechancic_TypeLabel";
            mechancic_TypeLabel.Size = new System.Drawing.Size(90, 13);
            mechancic_TypeLabel.TabIndex = 7;
            mechancic_TypeLabel.Text = "Mechancic Type:";
            // 
            // BelayAbVMaintain
            // 
            this.BelayAbVMaintain.DataSetName = "BelayAbVMaintain";
            this.BelayAbVMaintain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_MechanicBindingSource
            // 
            this.m_MechanicBindingSource.DataMember = "m_Mechanic";
            this.m_MechanicBindingSource.DataSource = this.BelayAbVMaintain;
            // 
            // m_MechanicTableAdapter
            // 
            this.m_MechanicTableAdapter.ClearBeforeFill = true;
            // 
            // m_MechanicBindingNavigator
            // 
            this.m_MechanicBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.m_MechanicBindingNavigator.BindingSource = this.m_MechanicBindingSource;
            this.m_MechanicBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.m_MechanicBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.m_MechanicBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.m_MechanicBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.bindingNavigatorDeleteItem});
            this.m_MechanicBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.m_MechanicBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.m_MechanicBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.m_MechanicBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.m_MechanicBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.m_MechanicBindingNavigator.Name = "m_MechanicBindingNavigator";
            this.m_MechanicBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.m_MechanicBindingNavigator.Size = new System.Drawing.Size(491, 25);
            this.m_MechanicBindingNavigator.TabIndex = 0;
            this.m_MechanicBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(69, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(58, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // m_MechanicBindingNavigatorSaveItem
            // 
            this.m_MechanicBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("m_MechanicBindingNavigatorSaveItem.Image")));
            this.m_MechanicBindingNavigatorSaveItem.Name = "m_MechanicBindingNavigatorSaveItem";
            this.m_MechanicBindingNavigatorSaveItem.Size = new System.Drawing.Size(77, 22);
            this.m_MechanicBindingNavigatorSaveItem.Text = "Save Data";
            this.m_MechanicBindingNavigatorSaveItem.Click += new System.EventHandler(this.m_MechanicBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // mechanicIDTextBox
            // 
            this.mechanicIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_MechanicBindingSource, "MechanicID", true));
            this.mechanicIDTextBox.Location = new System.Drawing.Point(141, 38);
            this.mechanicIDTextBox.Name = "mechanicIDTextBox";
            this.mechanicIDTextBox.Size = new System.Drawing.Size(134, 20);
            this.mechanicIDTextBox.TabIndex = 2;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_MechanicBindingSource, "FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(141, 71);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(311, 20);
            this.fullNameTextBox.TabIndex = 4;
            // 
            // telephoneNumberTextBox
            // 
            this.telephoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_MechanicBindingSource, "TelephoneNumber", true));
            this.telephoneNumberTextBox.Location = new System.Drawing.Point(141, 104);
            this.telephoneNumberTextBox.Name = "telephoneNumberTextBox";
            this.telephoneNumberTextBox.Size = new System.Drawing.Size(150, 20);
            this.telephoneNumberTextBox.TabIndex = 6;
            // 
            // mechancic_TypeComboBox
            // 
            this.mechancic_TypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_MechanicBindingSource, "Mechancic Type", true));
            this.mechancic_TypeComboBox.FormattingEnabled = true;
            this.mechancic_TypeComboBox.Items.AddRange(new object[] {
            "Emplyee",
            "Contract",
            "Part Time",
            "Other"});
            this.mechancic_TypeComboBox.Location = new System.Drawing.Point(141, 137);
            this.mechancic_TypeComboBox.Name = "mechancic_TypeComboBox";
            this.mechancic_TypeComboBox.Size = new System.Drawing.Size(169, 21);
            this.mechancic_TypeComboBox.TabIndex = 8;
            // 
            // btnListAll
            // 
            this.btnListAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListAll.Location = new System.Drawing.Point(12, 180);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(70, 24);
            this.btnListAll.TabIndex = 9;
            this.btnListAll.Text = "List All >>>";
            this.btnListAll.UseVisualStyleBackColor = true;
            this.btnListAll.Click += new System.EventHandler(this.btnListAll_Click);
            // 
            // grdMechList
            // 
            this.grdMechList.AutoGenerateColumns = false;
            this.grdMechList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMechList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mechanicIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.telephoneNumberDataGridViewTextBoxColumn,
            this.mechancicTypeDataGridViewTextBoxColumn});
            this.grdMechList.DataSource = this.m_MechanicBindingSource;
            this.grdMechList.Location = new System.Drawing.Point(22, 221);
            this.grdMechList.Name = "grdMechList";
            this.grdMechList.Size = new System.Drawing.Size(456, 291);
            this.grdMechList.TabIndex = 10;
            this.grdMechList.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MechanicID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MechanicID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FullName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TelephoneNumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "TelephoneNumber";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Mechancic Type";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mechancic Type";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // mechanicIDDataGridViewTextBoxColumn
            // 
            this.mechanicIDDataGridViewTextBoxColumn.DataPropertyName = "MechanicID";
            this.mechanicIDDataGridViewTextBoxColumn.HeaderText = "MechanicID";
            this.mechanicIDDataGridViewTextBoxColumn.Name = "mechanicIDDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // telephoneNumberDataGridViewTextBoxColumn
            // 
            this.telephoneNumberDataGridViewTextBoxColumn.DataPropertyName = "TelephoneNumber";
            this.telephoneNumberDataGridViewTextBoxColumn.HeaderText = "TelephoneNumber";
            this.telephoneNumberDataGridViewTextBoxColumn.Name = "telephoneNumberDataGridViewTextBoxColumn";
            // 
            // mechancicTypeDataGridViewTextBoxColumn
            // 
            this.mechancicTypeDataGridViewTextBoxColumn.DataPropertyName = "Mechancic Type";
            this.mechancicTypeDataGridViewTextBoxColumn.HeaderText = "Mechancic Type";
            this.mechancicTypeDataGridViewTextBoxColumn.Name = "mechancicTypeDataGridViewTextBoxColumn";
            // 
            // frmMechanic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 524);
            this.Controls.Add(this.grdMechList);
            this.Controls.Add(this.btnListAll);
            this.Controls.Add(mechancic_TypeLabel);
            this.Controls.Add(this.mechancic_TypeComboBox);
            this.Controls.Add(mechanicIDLabel);
            this.Controls.Add(this.mechanicIDTextBox);
            this.Controls.Add(fullNameLabel);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(telephoneNumberLabel);
            this.Controls.Add(this.telephoneNumberTextBox);
            this.Controls.Add(this.m_MechanicBindingNavigator);
            this.MaximizeBox = false;
            this.Name = "frmMechanic";
            this.Text = "Mechanic Informmation";
            this.Load += new System.EventHandler(this.frmMaintenance_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMechanic_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.BelayAbVMaintain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_MechanicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_MechanicBindingNavigator)).EndInit();
            this.m_MechanicBindingNavigator.ResumeLayout(false);
            this.m_MechanicBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMechList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BelayAbVMaintain BelayAbVMaintain;
        private System.Windows.Forms.BindingSource m_MechanicBindingSource;
        private Belayab.BelayAbVMaintainTableAdapters.m_MechanicTableAdapter m_MechanicTableAdapter;
        private System.Windows.Forms.BindingNavigator m_MechanicBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton m_MechanicBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox mechanicIDTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox telephoneNumberTextBox;
        private System.Windows.Forms.ComboBox mechancic_TypeComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.DataGridView grdMechList;
        private System.Windows.Forms.DataGridViewTextBoxColumn mechanicIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mechancicTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}


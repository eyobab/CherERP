namespace Belayab.Reports
{
    partial class frmReportForm
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
            this.btnGo = new System.Windows.Forms.Button();
            this.tabPeriodicReport = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cboVehicleTypes = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optTransfered = new System.Windows.Forms.RadioButton();
            this.optIssued = new System.Windows.Forms.RadioButton();
            this.optSales = new System.Windows.Forms.RadioButton();
            this.optReceived = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.cboCusType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboItemServiceType = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.rptGroup = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.tabPeriodicReport.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.rptGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(416, 128);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(96, 23);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Show Report";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tabPeriodicReport
            // 
            this.tabPeriodicReport.Controls.Add(this.tabPage1);
            this.tabPeriodicReport.Controls.Add(this.tabPage2);
            this.tabPeriodicReport.Location = new System.Drawing.Point(5, 4);
            this.tabPeriodicReport.Name = "tabPeriodicReport";
            this.tabPeriodicReport.SelectedIndex = 0;
            this.tabPeriodicReport.Size = new System.Drawing.Size(200, 305);
            this.tabPeriodicReport.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cboVehicleTypes);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 279);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Item Quanities";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Category";
            // 
            // cboVehicleTypes
            // 
            this.cboVehicleTypes.DropDownHeight = 200;
            this.cboVehicleTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehicleTypes.FormattingEnabled = true;
            this.cboVehicleTypes.IntegralHeight = false;
            this.cboVehicleTypes.Location = new System.Drawing.Point(6, 239);
            this.cboVehicleTypes.Name = "cboVehicleTypes";
            this.cboVehicleTypes.Size = new System.Drawing.Size(161, 21);
            this.cboVehicleTypes.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Controls.Add(this.radioButton9);
            this.groupBox2.Location = new System.Drawing.Point(6, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 81);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Report Grouping Method";
            this.groupBox2.Visible = false;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(30, 42);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(67, 17);
            this.radioButton8.TabIndex = 9;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Category";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Checked = true;
            this.radioButton9.Location = new System.Drawing.Point(30, 19);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(45, 17);
            this.radioButton9.TabIndex = 8;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Item";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optTransfered);
            this.groupBox1.Controls.Add(this.optIssued);
            this.groupBox1.Controls.Add(this.optSales);
            this.groupBox1.Controls.Add(this.optReceived);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 121);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Type";
            // 
            // optTransfered
            // 
            this.optTransfered.AutoSize = true;
            this.optTransfered.Location = new System.Drawing.Point(29, 95);
            this.optTransfered.Name = "optTransfered";
            this.optTransfered.Size = new System.Drawing.Size(76, 17);
            this.optTransfered.TabIndex = 8;
            this.optTransfered.TabStop = true;
            this.optTransfered.Text = "Transfered";
            this.optTransfered.UseVisualStyleBackColor = true;
            this.optTransfered.CheckedChanged += new System.EventHandler(this.optTransfered_CheckedChanged);
            // 
            // optIssued
            // 
            this.optIssued.AutoSize = true;
            this.optIssued.Location = new System.Drawing.Point(29, 72);
            this.optIssued.Name = "optIssued";
            this.optIssued.Size = new System.Drawing.Size(56, 17);
            this.optIssued.TabIndex = 7;
            this.optIssued.TabStop = true;
            this.optIssued.Text = "Issued";
            this.optIssued.UseVisualStyleBackColor = true;
            this.optIssued.CheckedChanged += new System.EventHandler(this.optIssued_CheckedChanged);
            // 
            // optSales
            // 
            this.optSales.AutoSize = true;
            this.optSales.Checked = true;
            this.optSales.Location = new System.Drawing.Point(29, 24);
            this.optSales.Name = "optSales";
            this.optSales.Size = new System.Drawing.Size(46, 17);
            this.optSales.TabIndex = 6;
            this.optSales.TabStop = true;
            this.optSales.Text = "Sold";
            this.optSales.UseVisualStyleBackColor = true;
            this.optSales.CheckedChanged += new System.EventHandler(this.optSales_CheckedChanged);
            // 
            // optReceived
            // 
            this.optReceived.AutoSize = true;
            this.optReceived.Location = new System.Drawing.Point(29, 48);
            this.optReceived.Name = "optReceived";
            this.optReceived.Size = new System.Drawing.Size(71, 17);
            this.optReceived.TabIndex = 5;
            this.optReceived.TabStop = true;
            this.optReceived.Text = "Recieved";
            this.optReceived.UseVisualStyleBackColor = true;
            this.optReceived.CheckedChanged += new System.EventHandler(this.optReceived_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Receivables";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.cboCustomer);
            this.groupBox5.Controls.Add(this.cboCusType);
            this.groupBox5.Location = new System.Drawing.Point(9, 42);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(177, 140);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Customer Selection";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Customer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Customer Type";
            // 
            // cboCustomer
            // 
            this.cboCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(19, 98);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(152, 21);
            this.cboCustomer.TabIndex = 1;
            this.cboCustomer.SelectedIndexChanged += new System.EventHandler(this.cboCustomer_SelectedIndexChanged);
            // 
            // cboCusType
            // 
            this.cboCusType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCusType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCusType.FormattingEnabled = true;
            this.cboCusType.Location = new System.Drawing.Point(18, 39);
            this.cboCusType.Name = "cboCusType";
            this.cboCusType.Size = new System.Drawing.Size(144, 21);
            this.cboCusType.TabIndex = 0;
            this.cboCusType.SelectedIndexChanged += new System.EventHandler(this.cboCusType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Item Type";
            this.label4.Visible = false;
            // 
            // cboItemServiceType
            // 
            this.cboItemServiceType.DropDownHeight = 200;
            this.cboItemServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemServiceType.FormattingEnabled = true;
            this.cboItemServiceType.IntegralHeight = false;
            this.cboItemServiceType.Items.AddRange(new object[] {
            "All",
            "Parts Sales",
            "Vehicle Sales",
            "Maintenance",
            "Rentals"});
            this.cboItemServiceType.Location = new System.Drawing.Point(214, 250);
            this.cboItemServiceType.Name = "cboItemServiceType";
            this.cboItemServiceType.Size = new System.Drawing.Size(160, 21);
            this.cboItemServiceType.TabIndex = 17;
            this.cboItemServiceType.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dtTo);
            this.groupBox3.Controls.Add(this.dtFrom);
            this.groupBox3.Location = new System.Drawing.Point(347, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(167, 100);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Date Range";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "MMM dd, yyyy";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(48, 58);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(105, 20);
            this.dtTo.TabIndex = 0;
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "MMM dd, yyyy";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(48, 19);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(105, 20);
            this.dtFrom.TabIndex = 0;
            // 
            // rptGroup
            // 
            this.rptGroup.Controls.Add(this.radioButton5);
            this.rptGroup.Controls.Add(this.radioButton6);
            this.rptGroup.Controls.Add(this.radioButton1);
            this.rptGroup.Controls.Add(this.radioButton2);
            this.rptGroup.Controls.Add(this.radioButton4);
            this.rptGroup.Controls.Add(this.radioButton3);
            this.rptGroup.Location = new System.Drawing.Point(214, 20);
            this.rptGroup.Name = "rptGroup";
            this.rptGroup.Size = new System.Drawing.Size(121, 180);
            this.rptGroup.TabIndex = 19;
            this.rptGroup.TabStop = false;
            this.rptGroup.Text = "Grouping Duration";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(22, 117);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(91, 17);
            this.radioButton5.TabIndex = 7;
            this.radioButton5.Text = "Semi Annually";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(23, 141);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(54, 17);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.Text = "Yearly";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(23, 71);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = "Monthly";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(23, 94);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Quarterly";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(23, 48);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(61, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Weakly";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(23, 25);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(48, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Daily";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // frmReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 321);
            this.Controls.Add(this.rptGroup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboItemServiceType);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabPeriodicReport);
            this.Controls.Add(this.btnGo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report Specifications";
            this.Load += new System.EventHandler(this.frmReportForm_Load);
            this.tabPeriodicReport.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.rptGroup.ResumeLayout(false);
            this.rptGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboItemServiceType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboVehicleTypes;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.RadioButton radioButton8;
        public System.Windows.Forms.RadioButton radioButton9;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton optIssued;
        public System.Windows.Forms.RadioButton optSales;
        public System.Windows.Forms.RadioButton optReceived;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtTo;
        public System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.ComboBox cboCusType;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.GroupBox rptGroup;
        public System.Windows.Forms.RadioButton radioButton5;
        public System.Windows.Forms.RadioButton radioButton6;
        public System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton radioButton4;
        public System.Windows.Forms.RadioButton radioButton3;
        public System.Windows.Forms.TabControl tabPeriodicReport;
        public System.Windows.Forms.RadioButton optTransfered;
    }
}
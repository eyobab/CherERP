namespace Belayab.Reports
{
    partial class frmMechanicReport
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdBothDeliverdandNonDelivered = new System.Windows.Forms.RadioButton();
            this.rdnonDelivered = new System.Windows.Forms.RadioButton();
            this.rdDelivered = new System.Windows.Forms.RadioButton();
            this.rptGroup = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnGo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.mMechanicListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbVMaintain = new Belayab.BelayAbVMaintain();
            this.m_MechanicListTableAdapter = new Belayab.BelayAbVMaintainTableAdapters.m_MechanicListTableAdapter();
            this.groupBox4.SuspendLayout();
            this.rptGroup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mMechanicListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbVMaintain)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdBothDeliverdandNonDelivered);
            this.groupBox4.Controls.Add(this.rdnonDelivered);
            this.groupBox4.Controls.Add(this.rdDelivered);
            this.groupBox4.Location = new System.Drawing.Point(4, 155);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(182, 72);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Status";
            // 
            // rdBothDeliverdandNonDelivered
            // 
            this.rdBothDeliverdandNonDelivered.AutoSize = true;
            this.rdBothDeliverdandNonDelivered.Checked = true;
            this.rdBothDeliverdandNonDelivered.Location = new System.Drawing.Point(107, 20);
            this.rdBothDeliverdandNonDelivered.Name = "rdBothDeliverdandNonDelivered";
            this.rdBothDeliverdandNonDelivered.Size = new System.Drawing.Size(36, 17);
            this.rdBothDeliverdandNonDelivered.TabIndex = 25;
            this.rdBothDeliverdandNonDelivered.TabStop = true;
            this.rdBothDeliverdandNonDelivered.Text = "All";
            this.rdBothDeliverdandNonDelivered.UseVisualStyleBackColor = true;
            // 
            // rdnonDelivered
            // 
            this.rdnonDelivered.AutoSize = true;
            this.rdnonDelivered.Location = new System.Drawing.Point(13, 43);
            this.rdnonDelivered.Name = "rdnonDelivered";
            this.rdnonDelivered.Size = new System.Drawing.Size(93, 17);
            this.rdnonDelivered.TabIndex = 25;
            this.rdnonDelivered.TabStop = true;
            this.rdnonDelivered.Text = "Non-Delivered";
            this.rdnonDelivered.UseVisualStyleBackColor = true;
            // 
            // rdDelivered
            // 
            this.rdDelivered.AutoSize = true;
            this.rdDelivered.Location = new System.Drawing.Point(13, 20);
            this.rdDelivered.Name = "rdDelivered";
            this.rdDelivered.Size = new System.Drawing.Size(70, 17);
            this.rdDelivered.TabIndex = 25;
            this.rdDelivered.TabStop = true;
            this.rdDelivered.Text = "Delivered";
            this.rdDelivered.UseVisualStyleBackColor = true;
            // 
            // rptGroup
            // 
            this.rptGroup.Controls.Add(this.radioButton5);
            this.rptGroup.Controls.Add(this.radioButton6);
            this.rptGroup.Controls.Add(this.radioButton1);
            this.rptGroup.Controls.Add(this.radioButton2);
            this.rptGroup.Controls.Add(this.radioButton4);
            this.rptGroup.Controls.Add(this.radioButton3);
            this.rptGroup.Location = new System.Drawing.Point(3, 1);
            this.rptGroup.Name = "rptGroup";
            this.rptGroup.Size = new System.Drawing.Size(183, 151);
            this.rptGroup.TabIndex = 29;
            this.rptGroup.TabStop = false;
            this.rptGroup.Text = "Duration Grouping Method";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(23, 108);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(91, 17);
            this.radioButton5.TabIndex = 7;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Semi Annually";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(23, 130);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(54, 17);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Yearly";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(23, 65);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Monthly";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(23, 88);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Quarterly";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(23, 41);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(61, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Weakly";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(23, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(48, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Daily";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(258, 234);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(105, 22);
            this.btnGo.TabIndex = 27;
            this.btnGo.Text = "Show Report";
            this.btnGo.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dtTo);
            this.groupBox3.Controls.Add(this.dtFrom);
            this.groupBox3.Location = new System.Drawing.Point(192, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 99);
            this.groupBox3.TabIndex = 26;
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
            // mMechanicListBindingSource
            // 
            this.mMechanicListBindingSource.DataMember = "m_MechanicList";
            this.mMechanicListBindingSource.DataSource = this.belayAbVMaintain;
            // 
            // belayAbVMaintain
            // 
            this.belayAbVMaintain.DataSetName = "BelayAbVMaintain";
            this.belayAbVMaintain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_MechanicListTableAdapter
            // 
            this.m_MechanicListTableAdapter.ClearBeforeFill = true;
            // 
            // frmMechanicReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 263);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.rptGroup);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmMechanicReport";
            this.Text = "Mechanic Report";
            this.Load += new System.EventHandler(this.frmMechanicReport_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.rptGroup.ResumeLayout(false);
            this.rptGroup.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mMechanicListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbVMaintain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdBothDeliverdandNonDelivered;
        private System.Windows.Forms.RadioButton rdnonDelivered;
        private System.Windows.Forms.RadioButton rdDelivered;
        public System.Windows.Forms.GroupBox rptGroup;
        public System.Windows.Forms.RadioButton radioButton5;
        public System.Windows.Forms.RadioButton radioButton6;
        public System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton radioButton4;
        public System.Windows.Forms.RadioButton radioButton3;
        public System.Windows.Forms.Button btnGo;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtTo;
        public System.Windows.Forms.DateTimePicker dtFrom;
        private BelayAbVMaintain belayAbVMaintain;
        private System.Windows.Forms.BindingSource mMechanicListBindingSource;
        private Belayab.BelayAbVMaintainTableAdapters.m_MechanicListTableAdapter m_MechanicListTableAdapter;
    }
}
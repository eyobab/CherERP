using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Belayab;

namespace Belayab
{
	/// <summary>
	/// Summary description for frmSecurity.
	/// </summary>
	public class frmSecurity : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lvUsers;
        private IContainer components;

        public string oldUName = "";
		
		clsSecurity objSecurity = new clsSecurity();
		string selectedUserNam;
		clsUtility  objUtility = new clsUtility();
		clsData	objData = clsData.Instance;
		bool bolForNew = false;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpBasicInfo;
		private System.Windows.Forms.GroupBox grpSecurityInfo;
		private System.Windows.Forms.TextBox txtPassword2;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Button cmdAddNew;
		private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdSave;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Label lblPassword2;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.TabControl tabMain;
		private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.CheckBox chkIsAdmin;
        private Button btnEditRoles;
        private TextBox txtFullName;
        private ComboBox cboRole;
        private BelayAbSecurity belayAbSecurity;
        private BindingSource userRolesBindingSource;
        private Belayab.BelayAbSecurityTableAdapters.UserRolesTableAdapter userRolesTableAdapter;
        private ToolTip toolTip1;
        private CheckBox chkEmployee;
        private ComboBox cboFullName;
		private System.Windows.Forms.Button cmdCancel;
		
		
		
		public frmSecurity()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			

			//For UI
            //clsXmlAccess xmlReader=new clsXmlAccess(this);
            //xmlReader.readXmlFile(strLang,strXmlFile);

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecurity));
            this.lvUsers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdCancel = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkIsAdmin = new System.Windows.Forms.CheckBox();
            this.cmdAddNew = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.grpSecurityInfo = new System.Windows.Forms.GroupBox();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.grpBasicInfo = new System.Windows.Forms.GroupBox();
            this.cboFullName = new System.Windows.Forms.ComboBox();
            this.chkEmployee = new System.Windows.Forms.CheckBox();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.userRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbSecurity = new Belayab.BelayAbSecurity();
            this.btnEditRoles = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.userRolesTableAdapter = new Belayab.BelayAbSecurityTableAdapters.UserRolesTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpSecurityInfo.SuspendLayout();
            this.grpBasicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSecurity)).BeginInit();
            this.SuspendLayout();
            // 
            // lvUsers
            // 
            this.lvUsers.BackColor = System.Drawing.Color.Gainsboro;
            this.lvUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvUsers.FullRowSelect = true;
            this.lvUsers.GridLines = true;
            this.lvUsers.HideSelection = false;
            this.lvUsers.Location = new System.Drawing.Point(11, 9);
            this.lvUsers.MultiSelect = false;
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.Size = new System.Drawing.Size(171, 387);
            this.lvUsers.TabIndex = 28;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            this.lvUsers.View = System.Windows.Forms.View.Details;
            this.lvUsers.SelectedIndexChanged += new System.EventHandler(this.lvUsers_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "EmployeeId";
            this.columnHeader1.Width = 2;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "User Name";
            this.columnHeader2.Width = 200;
            // 
            // cmdCancel
            // 
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Location = new System.Drawing.Point(416, 151);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(88, 32);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Close";
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(222, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(555, 383);
            this.tabMain.TabIndex = 0;
            this.tabMain.Tag = "REQ-Enter a Valid Description";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkIsAdmin);
            this.tabPage1.Controls.Add(this.cmdCancel);
            this.tabPage1.Controls.Add(this.cmdAddNew);
            this.tabPage1.Controls.Add(this.cmdDelete);
            this.tabPage1.Controls.Add(this.cmdSave);
            this.tabPage1.Controls.Add(this.grpSecurityInfo);
            this.tabPage1.Controls.Add(this.grpBasicInfo);
            this.tabPage1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(547, 354);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkIsAdmin
            // 
            this.chkIsAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkIsAdmin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsAdmin.ForeColor = System.Drawing.Color.Black;
            this.chkIsAdmin.Location = new System.Drawing.Point(20, 295);
            this.chkIsAdmin.Name = "chkIsAdmin";
            this.chkIsAdmin.Size = new System.Drawing.Size(372, 24);
            this.chkIsAdmin.TabIndex = 60;
            this.chkIsAdmin.Text = "Is Administrator";
            this.chkIsAdmin.Visible = false;
            // 
            // cmdAddNew
            // 
            this.cmdAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdAddNew.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddNew.Location = new System.Drawing.Point(416, 24);
            this.cmdAddNew.Name = "cmdAddNew";
            this.cmdAddNew.Size = new System.Drawing.Size(88, 32);
            this.cmdAddNew.TabIndex = 0;
            this.cmdAddNew.Text = "Add New";
            this.cmdAddNew.Click += new System.EventHandler(this.cmdAddNew_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Enabled = false;
            this.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.Location = new System.Drawing.Point(416, 107);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(88, 32);
            this.cmdDelete.TabIndex = 2;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Enabled = false;
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Location = new System.Drawing.Point(416, 64);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(88, 32);
            this.cmdSave.TabIndex = 1;
            this.cmdSave.Text = "Save";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // grpSecurityInfo
            // 
            this.grpSecurityInfo.Controls.Add(this.lblPassword2);
            this.grpSecurityInfo.Controls.Add(this.lblPassword);
            this.grpSecurityInfo.Controls.Add(this.lblUserName);
            this.grpSecurityInfo.Controls.Add(this.txtPassword2);
            this.grpSecurityInfo.Controls.Add(this.txtPassword);
            this.grpSecurityInfo.Controls.Add(this.txtUserName);
            this.grpSecurityInfo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSecurityInfo.ForeColor = System.Drawing.Color.Navy;
            this.grpSecurityInfo.Location = new System.Drawing.Point(16, 167);
            this.grpSecurityInfo.Name = "grpSecurityInfo";
            this.grpSecurityInfo.Size = new System.Drawing.Size(376, 112);
            this.grpSecurityInfo.TabIndex = 31;
            this.grpSecurityInfo.TabStop = false;
            this.grpSecurityInfo.Text = "Security Info";
            // 
            // lblPassword2
            // 
            this.lblPassword2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword2.ForeColor = System.Drawing.Color.Black;
            this.lblPassword2.Location = new System.Drawing.Point(16, 88);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(135, 16);
            this.lblPassword2.TabIndex = 22;
            this.lblPassword2.Text = "Confirm Password";
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(16, 56);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(135, 24);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(16, 24);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(135, 24);
            this.lblUserName.TabIndex = 20;
            this.lblUserName.Text = "User Name";
            // 
            // txtPassword2
            // 
            this.txtPassword2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPassword2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword2.Location = new System.Drawing.Point(151, 85);
            this.txtPassword2.MaxLength = 10;
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(184, 22);
            this.txtPassword2.TabIndex = 2;
            this.txtPassword2.Tag = "";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(151, 52);
            this.txtPassword.MaxLength = 10;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(184, 22);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Tag = "";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(151, 20);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(158, 22);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Tag = "REQ-Enter a Valid User Name";
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            // 
            // grpBasicInfo
            // 
            this.grpBasicInfo.Controls.Add(this.cboFullName);
            this.grpBasicInfo.Controls.Add(this.chkEmployee);
            this.grpBasicInfo.Controls.Add(this.cboRole);
            this.grpBasicInfo.Controls.Add(this.btnEditRoles);
            this.grpBasicInfo.Controls.Add(this.txtFullName);
            this.grpBasicInfo.Controls.Add(this.lblDescription);
            this.grpBasicInfo.Controls.Add(this.lblFullName);
            this.grpBasicInfo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBasicInfo.ForeColor = System.Drawing.Color.Navy;
            this.grpBasicInfo.Location = new System.Drawing.Point(16, 16);
            this.grpBasicInfo.Name = "grpBasicInfo";
            this.grpBasicInfo.Size = new System.Drawing.Size(376, 132);
            this.grpBasicInfo.TabIndex = 30;
            this.grpBasicInfo.TabStop = false;
            this.grpBasicInfo.Text = "Basic Info";
            // 
            // cboFullName
            // 
            this.cboFullName.FormattingEnabled = true;
            this.cboFullName.Location = new System.Drawing.Point(99, 50);
            this.cboFullName.Name = "cboFullName";
            this.cboFullName.Size = new System.Drawing.Size(236, 24);
            this.cboFullName.TabIndex = 27;
            this.cboFullName.Visible = false;
            // 
            // chkEmployee
            // 
            this.chkEmployee.AutoSize = true;
            this.chkEmployee.Location = new System.Drawing.Point(99, 22);
            this.chkEmployee.Name = "chkEmployee";
            this.chkEmployee.Size = new System.Drawing.Size(104, 20);
            this.chkEmployee.TabIndex = 26;
            this.chkEmployee.Text = "Is Employee";
            this.chkEmployee.UseVisualStyleBackColor = true;
            this.chkEmployee.CheckedChanged += new System.EventHandler(this.chkEmployee_CheckedChanged);
            // 
            // cboRole
            // 
            this.cboRole.DataSource = this.userRolesBindingSource;
            this.cboRole.DisplayMember = "RoleID";
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(99, 87);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(196, 24);
            this.cboRole.TabIndex = 25;
            this.cboRole.ValueMember = "RoleID";
            // 
            // userRolesBindingSource
            // 
            this.userRolesBindingSource.DataMember = "UserRoles";
            this.userRolesBindingSource.DataSource = this.belayAbSecurity;
            // 
            // belayAbSecurity
            // 
            this.belayAbSecurity.DataSetName = "BelayAbSecurity";
            this.belayAbSecurity.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEditRoles
            // 
            this.btnEditRoles.Enabled = false;
            this.btnEditRoles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditRoles.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRoles.Location = new System.Drawing.Point(296, 86);
            this.btnEditRoles.Name = "btnEditRoles";
            this.btnEditRoles.Size = new System.Drawing.Size(29, 22);
            this.btnEditRoles.TabIndex = 24;
            this.btnEditRoles.Text = "...";
            this.toolTip1.SetToolTip(this.btnEditRoles, "Add/Edit User Roles");
            this.btnEditRoles.Click += new System.EventHandler(this.btnEditRoles_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(99, 52);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(226, 22);
            this.txtFullName.TabIndex = 23;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Black;
            this.lblDescription.Location = new System.Drawing.Point(47, 89);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(47, 18);
            this.lblDescription.TabIndex = 22;
            this.lblDescription.Text = "Role";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFullName
            // 
            this.lblFullName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.Black;
            this.lblFullName.Location = new System.Drawing.Point(20, 53);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(79, 22);
            this.lblFullName.TabIndex = 20;
            this.lblFullName.Text = "Full Name";
            // 
            // userRolesTableAdapter
            // 
            this.userRolesTableAdapter.ClearBeforeFill = true;
            // 
            // frmSecurity
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(795, 416);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.lvUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSecurity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Security";
            this.Load += new System.EventHandler(this.frmSecurity_Load);
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpSecurityInfo.ResumeLayout(false);
            this.grpSecurityInfo.PerformLayout();
            this.grpBasicInfo.ResumeLayout(false);
            this.grpBasicInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSecurity)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
		

		private void fillComboValues()
		{
			string[] strVals;	
			strVals =objSecurity.getDistinctVals("SELECT Distinct [User Role] FROM Users");
			objUtility.addToCombo(cboRole,strVals,false);

		}
        private void setAdapterConnectionString()
        {
            userRolesTableAdapter.Connection = clsData.connBel;
        }

		private void frmSecurity_Load(object sender, System.EventArgs e)
		{
           
            // try
            //{
                setAdapterConnectionString();

                // TODO: This line of code loads data into the 'belayAbSecurity.UserRoles' table. You can move, or remove it, as needed.
                this.userRolesTableAdapter.Fill(this.belayAbSecurity.UserRoles);
                // TODO: This line of code loads data into the 'belayAbItemRequistions.EmployeesLst' table. You can move, or remove it, as needed.

               string strSQL = "Select Distinct EmployeeId,EmployeeName From Employees Order By employeeName";
                //   objUtility.fillComboValues(requestedByComboBox, strSQL);
                objUtility.fillComboValues(cboFullName, strSQL);
                cboFullName.ValueMember = "EmployeeId";
                cboFullName.DisplayMember = "EmployeeName";
                
             

                 fillListView();
                 enablControls();
                 populateValues();

                 Program.sFrm = this;

            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void cmdCancel_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void cmdSave_Click(object sender, System.EventArgs e)
		{
		if (isDataValid())
			{
				collectValues();
                string strCriteria=txtUserName.Text;

               if (!bolForNew)	
                {

                    //    if(!chkIsAdmin.Checked)
                    //    {
                    //        if(IsLastAdmin())
                    //        {
                    //            MessageBox.Show("This user is the last administrator. You cannot remove it!", "Stosa",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //            chkIsAdmin.Checked=true;
                    //            return;
                    //        }
                    //    }

                   
                        if (Program.sFrm.oldUName.ToUpper()=="ADMIN" && clsVariables.sUsername.ToUpper() != "ADMIN" )
                            {

                                 MessageBox.Show("You can not change or remove this User account!", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                
                                    return;
                                }
                    
                    objSecurity.beginTransact();

					try
					{

                        objSecurity.updateUser();
						objSecurity.commitTransact();

					//	string Key=txtUserName.Text ;
	               //     string Description="User Information ("+ Key+ " ) " ;

                        
                        //clsAudit  objAudit=new clsAudit();
                        //objAudit.RecordAudit(DateTime.Now,frmMain.strUserName ,AuditAction.UPDATE ,Function.Security  ,Key.ToString(),Description);   
			
						
						fillListView();				//Refresh lst view
					}
					catch (Exception Exp)
					{
						objSecurity.rollbackTransact();
						MessageBox.Show(Exp.Message,"Stosa",MessageBoxButtons.OK,MessageBoxIcon.Error);
						return;
					}
					MessageBox.Show("Successfully Updated","Stosa",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
				else
				{	
					if(!objData.exists("SELECT * from Users WHERE UserName='"+strCriteria+"'"))
					{
						objSecurity.beginTransact();
						try
						{
							objSecurity.addUser();
							objSecurity.commitTransact();

                            //string Key=txtUserName.Text ;
                            //string Description="User Information ("+ Key + " ) " ;

                            //clsAudit  objAudit=new clsAudit();
                            //objAudit.RecordAudit(DateTime.Now,frmMain.strUserName ,AuditAction.ADD  ,Function.Security  ,Key.ToString(),Description);   
			

							bolForNew=false;
                            enablControls();
							fillListView();			//Refresh lst view
						}
						catch(Exception Exp)
						{
							objSecurity.rollbackTransact();
							MessageBox.Show(Exp.Message,"Stosa",MessageBoxButtons.OK,MessageBoxIcon.Error);
							return;
						}
						
						MessageBox.Show("Successfully Added","Stosa",MessageBoxButtons.OK,MessageBoxIcon.Information);
					}
					else
						MessageBox.Show("This User already recorded");
					
				}
			}
		}

		private bool isDataValid()
		{	
            //bool isValid=	objUtility.isDataValid(grpBasicInfo);
            //isValid= isValid && objUtility.isDataValid(grpSecurityInfo);

            bool isValid=true;
			
				if (!txtPassword.Text.Trim().Equals(txtPassword2.Text))
				{
					MessageBox.Show("Password mismatch, Check password again","Stosa", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
					txtPassword.Focus();
					isValid =isValid && false;
				}
                else if (txtPassword.Text.Trim().Equals("") || txtPassword2.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Empty Password, Write a valid password", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPassword.Focus();
                    isValid = isValid && false;
                }
			
			return isValid;
		}
		
	

		private void collectValues()
		{	
			objSecurity.pFullName= txtFullName.Text;
            objSecurity.pUserName= txtUserName.Text;
            objSecurity.pUserRole = cboRole.SelectedValue.ToString();
			objSecurity.pPassword=txtPassword.Text;
            objSecurity.isEmployee = chkEmployee.Checked;
            if (objSecurity.isEmployee)
                objSecurity.pEmployeeId = cboFullName.SelectedValue.ToString();
            else
                objSecurity.pEmployeeId = null;
			
            if(chkIsAdmin.Checked) 
				objSecurity.pIsAdmin =1; 
			else 
				objSecurity.pIsAdmin =0;
			
		}
		
		private void populateValues()
		  {

              if (clsVariables.userRole != "Admin")
                  objSecurity.pUserName = clsVariables.sUsername;
              else
                  objSecurity.pUserName = selectedUserNam;

              if (objSecurity.pUserName == null) objSecurity.pUserName = clsVariables.sUsername;

                objSecurity.getUserInfo();

                txtFullName.Text = objSecurity.pFullName;
                txtUserName.Text = objSecurity.pUserName;
                cboRole.Text = objSecurity.pUserRole;

                chkEmployee.Checked = objSecurity.isEmployee;
                cboFullName.SelectedValue = objSecurity.pEmployeeId;

         
               txtFullName.Visible = !objSecurity.isEmployee;
               cboFullName.Visible = objSecurity.isEmployee;

                //txtPassword.Text = objUtility.getHashedValue(objSecurity.pPassword);
                //txtPassword2.Text = txtPassword.Text;


                    if (objSecurity.pIsAdmin == 1)
                        chkIsAdmin.Checked = true;
                    else
                        chkIsAdmin.Checked = false;
	
		}
		
		private void fillListView()
		{

			lvUsers.Items.Clear();
			objSecurity.pUserName = selectedUserNam;
			
			DataTable dtblUsers = objSecurity.getUsers();
			lvUsers.Items.Clear();
            
            if (clsVariables.sUsername.ToUpper() == "ADMIN")
            {
			foreach(DataRow row in dtblUsers.Rows)
			{
				ListViewItem itmMain = new ListViewItem(row[0].ToString());
				itmMain.SubItems.Add(row[1].ToString());
				lvUsers.Items.AddRange(new ListViewItem[]{itmMain});
			}
            }
            else
               foreach (DataRow row in dtblUsers.Rows)
                {
                    ListViewItem itmMain = new ListViewItem(row[0].ToString());
                    if (row[1].ToString().ToUpper() == clsVariables.sUsername.ToUpper())
                    {
                        lvUsers.Items.Clear();
                        itmMain.SubItems.Add(row[1].ToString());
                        lvUsers.Items.AddRange(new ListViewItem[] { itmMain });
                    }

                      
                }

            if (lvUsers.Items.Count>0) lvUsers.Items[0].Selected =true;

         
		}
		
		private void clearValues()
		{	
			foreach(Control Cont in	this.grpBasicInfo.Controls)
				if ( Cont.GetType().Name.Equals("TextBox") || Cont.GetType().Name.Equals("ComboBox"))
					Cont.Text ="";
			foreach(Control Cont in	this.grpSecurityInfo.Controls)
				if ( Cont.GetType().Name.Equals("TextBox") || Cont.GetType().Name.Equals("ComboBox"))
					Cont.Text ="";
			chkIsAdmin.Checked =false;

	

		}

		private void cmdAddNew_Click(object sender, System.EventArgs e)
		{
			clearValues();
			bolForNew =true;
			cmdAddNew.Enabled=false;

            if (cmdSave.Enabled == false) cmdSave.Enabled = true;
            if (cmdDelete.Enabled == false) cmdDelete.Enabled = true;

		

		}

		private void lvUsers_SelectedIndexChanged(object sender, System.EventArgs e)
		{
          if(clsVariables.userRole=="Admin")

			if(lvUsers.SelectedItems.Count > 0)
			{
				clearValues();

                selectedUserNam = lvUsers.SelectedItems[0].SubItems[1].Text;

				populateValues();

				bolForNew =false;

                enablControls();
			}
         
            oldUName = "";

		}

		private void cmdDelete_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(lvUsers.SelectedItems.Count>0)
				{	
					if(IsLastAdmin())
					{
						MessageBox.Show("This user is the last administrator. You cannot remove it!", "Stosa",MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
					if (MessageBox.Show("Are you sure to delete?", "Stosa",MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
					{
						objSecurity.pUserName= selectedUserNam;
						objSecurity.deleteUser();
						lvUsers.SelectedItems[0].Remove();
						if (lvUsers.Items.Count>0) lvUsers.Items[0].Selected =true; 
					
					}
				}
			}
			catch(Exception ee)
			{
                MessageBox.Show(ee.Message);
			}
		}

		private bool IsLastAdmin()
		{
			string strVal="",strUserName=txtUserName.Text;

			strVal=objSecurity.getDistinctVal("Select [User Role] from Users where  rTrim(UserName) like '"+strUserName+"'");

			if(strVal.Equals("Admin"))
                strVal = objSecurity.getDistinctVal("Select count(*) from Users where [User Role] ='Admin'");

			if(strVal.Equals("Admin"))
				return true;

			return false;

		}

        private void enablControls()
        {
            if (clsVariables.sUsername.ToUpper() != "ADMIN")
            {
                cmdAddNew.Enabled = false;
                cmdDelete.Enabled = false;
                cmdSave.Enabled = true;
                grpBasicInfo.Enabled = false;
                lvUsers.Visible = false;
                lvUsers.Enabled = false;
                txtUserName.Enabled = false;

                tabMain.Left = 10;
                this.Width = tabMain.Width + 30;
            }


        }

        public void updateRoleList()
        {
            this.belayAbSecurity.UserRoles.Clear();
            this.userRolesTableAdapter.Fill(belayAbSecurity.UserRoles);
            cboRole.Refresh();

        }

        private void btnEditRoles_Click(object sender, EventArgs e)
        {
            frmRoles fRoles = new frmRoles(this);
            Program.mainFrm.OpenFrm(fRoles);
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (oldUName == "") oldUName = txtUserName.Text;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (oldUName == "") oldUName = txtUserName.Text;
        }

        private void chkEmployee_CheckedChanged(object sender, EventArgs e)
        {
            
                txtFullName.Visible = !chkEmployee.Checked;
                cboFullName.Visible = chkEmployee.Checked;
            
        }

                  
		
		
	}
}

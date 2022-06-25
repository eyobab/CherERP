using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmRoles : Form
    {
        frmSecurity fs=null;

        public frmRoles()
        {
            InitializeComponent();
        }
        public frmRoles(frmSecurity f)
        {
            InitializeComponent();
            fs = f;
        }


        private void userRolesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            saveRoles();

        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            setAdapterConnectionString();

            this.userRolesTableAdapter.Fill(this.belayAbSecurity.UserRoles);
           
           

        }

        private void setAdapterConnectionString()
        {
           
            userRolesTableAdapter.Connection = clsData.connBel;
        }
        private void saveRoles()
        {
            this.Validate();
            this.userRolesBindingSource.EndEdit();
            this.userRolesTableAdapter.Update(this.belayAbSecurity.UserRoles);
        }

        private void saveUserMembers()
        {
            this.Validate();
         }

        private void saveUserTasks()
        {
            this.Validate();
           
        }

        private void saveUserTaskPermissions()
        {
            this.Validate();
        
        }

        private void frmRoles_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveRoles();
            if (fs != null)
            {
                fs.updateRoleList();
            }
        }

        private void btnSaveMemberUsers_Click(object sender, EventArgs e)
        {
            saveUserMembers();
        }

        private void btnSaveTasks_Click(object sender, EventArgs e)
        {
            saveUserTasks();
        }

        private void btnSaveTaskPermissions_Click(object sender, EventArgs e)
        {
            saveUserTaskPermissions();
        }

       
        
    }
}
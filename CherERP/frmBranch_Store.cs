using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmBranch_Store : Form
    {
        public frmBranch_Store()
        {
            InitializeComponent();
        }

        private void branchesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            this.Validate();
            this.branchesBindingSource.EndEdit();
            this.branchesTableAdapter.Update(this.belayAbBranchStore.Branches);

            this.storesBindingSource.EndEdit();
            this.storesTableAdapter.Update(this.belayAbBranchStore.Stores);

            this.shelfsBindingSource.EndEdit();
            this.shelfsTableAdapter.Update(this.belayAbBranchStore.Shelfs);

            this.columnsBindingSource.EndEdit();
            this.columnsTableAdapter.Update(this.belayAbBranchStore.Columns);

            this.rowsBindingSource.EndEdit();
            this.rowsTableAdapter.Update(this.belayAbBranchStore.Rows);

        }

        private void frmBranch_Store_Load(object sender, EventArgs e)
        {
           
            setAdapterConnectionString();
            // TODO: This line of code loads data into the 'belayAbBranchStore.Rows' table. You can move, or remove it, as needed.
            this.rowsTableAdapter.Fill(this.belayAbBranchStore.Rows);
            // TODO: This line of code loads data into the 'belayAbBranchStore.Columns' table. You can move, or remove it, as needed.
            this.columnsTableAdapter.Fill(this.belayAbBranchStore.Columns);
            // TODO: This line of code loads data into the 'belayAbBranchStore.Shelfs' table. You can move, or remove it, as needed.
            this.shelfsTableAdapter.Fill(this.belayAbBranchStore.Shelfs);
            // TODO: This line of code loads data into the 'belayAbBranchStore.Stores' table. You can move, or remove it, as needed.
            this.storesTableAdapter.Fill(this.belayAbBranchStore.Stores);
            // TODO: This line of code loads data into the 'belayAbBranchStore.Branches' table. You can move, or remove it, as needed.
            this.branchesTableAdapter.Fill(this.belayAbBranchStore.Branches);

        }

        private void setAdapterConnectionString()
        {

            rowsTableAdapter.Connection = clsData.connBel;
            columnsTableAdapter.Connection = clsData.connBel;
            shelfsTableAdapter.Connection = clsData.connBel;
            storesTableAdapter.Connection = clsData.connBel;
            branchesTableAdapter.Connection = clsData.connBel;

        }

       
        private void branchesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
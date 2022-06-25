using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;

namespace Belayab
{
    static class Program
    {
        public static MainForm mainFrm;
        public static frmLoginScreen loginFrm;
        public static frmBranch_Stores brsFrm;
        public static frmSecurity sFrm;
        public static frmCustomersSuppliers scFrm;
        public static frmWait waitForm;

        
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
       
        static void Main()
        {

            startApplication();

            ////if (hasPrevInstance() == false)
            ////{
            ////    try
            ////    {
            ////        startApplication();
            ////    }
            ////    catch (Exception ex) { }
            ////}

            ////else
            ////{

            ////    DialogResult ret = MessageBox.Show("The application is already running! Do you want to close it first? (Click Ok to close it)", "Stosa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            ////    if (ret == DialogResult.OK)
            ////        if (closeApplication()) startApplication();
            ////        else
            ////            MessageBox.Show("Unable to close or start the application! \n  Please use the windows process management to close the running application!", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ////}

        }


        public static bool hasPrevInstance()
        {
            try
            {
                if (System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName).Length > 1) { 
                    return true; }
                else { return false; }
            }
            catch (Exception ex) { return false; }
        }


        private  static void startApplication()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmStartup fst = new frmStartup();
            Application.Run(fst);
        }
        private static bool closeApplication()
        {
            try
            {
                Process[] processes;

                processes = Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName);

                Process thisProcess = Process.GetProcessById(System.Diagnostics.Process.GetCurrentProcess().Id);

                foreach (Process proc in processes)
                {
                    if (proc.Id != thisProcess.Id) proc.Kill();
                }

                return true;
            }
            catch (Exception ex)
            { return false; }
          
        }
        public static  void showWorkOrder(string workOrdNo,  bool Startup)
        {
            clsData.trNo = workOrdNo;
            frmVehicleMaintenanceProcess fMnt = new frmVehicleMaintenanceProcess();
            Program.mainFrm.OpenOverFrm(fMnt);
            fMnt.startUp = Startup;
            fMnt.storeIDComboBox.Enabled = false;


        }

        public static void showLaborDetails(string workOrdNo, bool Startup)
        {
            clsData.trNo = workOrdNo;
            frmVLaborCostDetails fLbrD = new frmVLaborCostDetails();
            Program.mainFrm.OpenOverFrm(fLbrD);
            fLbrD.startUp = Startup;
            fLbrD.showHideWorkOrderList();
            
        }
    }
}  
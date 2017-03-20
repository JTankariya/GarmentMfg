using System;
using System.Collections.Generic;

using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.IO;

namespace GarmentMfg
{
    static class Program
    {
        public static bool flag = false;
        public static string CompName = "";
        public static string CompFromYear = "";
        public static string CompToYear = "";
        public static OleDbConnection Compconn;
        //public static string path;
        public static string ExpertDirectorypath;
        public static string MultiViewId = "";
        static string staticCompanyCode = "013";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args != null && args.Length > 0)
            {
                ExpertDirectorypath = Operation.gCurrentPath;
                staticCompanyCode = args[0].Trim().PadLeft(3, '0');
            }
            else
            {
                ExpertDirectorypath = "E:\\EXPERT";
            }
            Operation.expertpath = ExpertDirectorypath + "\\" + staticCompanyCode;
            Operation.iniFile = Operation.expertpath + "\\MfgCycle.ini";
            if (!string.IsNullOrEmpty(Operation.expertpath) && Directory.Exists(Operation.expertpath))
            {
                Compconn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ExpertDirectorypath + ";Mode=ReadWrite;Extended Properties=dBase IV;Persist Security Info=False");
                Operation.Conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Operation.expertpath + ";Mode=ReadWrite;Extended Properties=dBase IV;Persist Security Info=False");
                try
                {
                    OleDbCommand cmd = new OleDbCommand("Select * from Company where Code = " + staticCompanyCode, Compconn);
                    OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    SetCompDetail(dt);
                    SetCompanyInfo(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while setting Company Data......" + "Error : " + Environment.NewLine + ex.Message, Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Company Data Directory was not Found in Expert Folder.....", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (!File.Exists(Operation.expertpath + "\\MfgCycle.DBF"))
            {
                MessageBox.Show("MfgCycle.DBF is not found in " + Operation.expertpath + ".", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (!File.Exists(Operation.expertpath + "\\MfgTrans.DBF"))
            {
                MessageBox.Show("MfgTrans.DBF is not found in " + Operation.expertpath + ".", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (!File.Exists(Operation.expertpath + "\\MfgItems.DBF"))
            {
                MessageBox.Show("MfgItems.DBF is not found in " + Operation.expertpath + ".", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Application.Run(new mdiMain());
        }

        private static void SetCompDetail(DataTable dt)
        {
            CompName = dt.Rows[0]["NAME"].ToString();
            CompToYear = Convert.ToDateTime(dt.Rows[0]["DTO"]).ToShortDateString();
            CompFromYear = Convert.ToDateTime(dt.Rows[0]["DFR"]).ToShortDateString();
        }
        static void SetCompanyInfo(DataTable CompDt)
        {
            try
            {
                Operation.objComp.CompId = Convert.ToInt32(CompDt.Rows[0]["code"].ToString());
                Operation.objComp.CompName = CompDt.Rows[0]["Name"].ToString();
                Operation.objComp.CompAdd1 = CompDt.Rows[0]["Add1"].ToString();
                Operation.objComp.CompAdd2 = CompDt.Rows[0]["Add2"].ToString();
                Operation.objComp.CompAdd3 = CompDt.Rows[0]["Add3"].ToString();
                Operation.objComp.CompAdd4 = CompDt.Rows[0]["Add4"].ToString();
                Operation.objComp.CompFromDate = Convert.ToDateTime(CompDt.Rows[0]["DFR"].ToString());
                Operation.objComp.CompToDate = Convert.ToDateTime(CompDt.Rows[0]["DTO"].ToString());
                Operation.objComp.CompITNo = CompDt.Rows[0]["Itno"].ToString();
                Operation.objComp.CompMobile = CompDt.Rows[0]["Mobile"].ToString();
                Operation.objComp.CompFaxNo = CompDt.Rows[0]["Fax"].ToString();
                Operation.objComp.CompPhone = CompDt.Rows[0]["Phone"].ToString();
                Operation.objComp.CompLicense = CompDt.Rows[0]["Licno"].ToString();
                Operation.objComp.CompEmail = CompDt.Rows[0]["Email"].ToString();
                Operation.objComp.CompStno = CompDt.Rows[0]["Stno"].ToString();
                Operation.objComp.CompCstno = CompDt.Rows[0]["Cstno"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While SetCompanyInfo : " + ex.Message);
            }
        }
    }
}

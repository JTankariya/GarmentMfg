using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;

namespace GarmentMfg
{
    public class Operation
    {
        public static OleDbConnection Conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\InitialDBFs;Mode=ReadWrite;Extended Properties=dBASE IV;Persist Security Info=True");
        public static string MsgTitle = "Expert Mobile System By Shah Infotech-9979866022";
        public static string gViewQuery = "";
        public static string ViewID = "";
        public static string MultiViewId = "";
        public static bool isCloseApp = false;
        public static string expertpath = "";
        public static string iniFile = "";
        public static string gCurrentPath = Application.StartupPath.ToString();
        public static CompanyInfo objComp = new CompanyInfo();
        public static Boolean ExecuteTransaction(List<string> q)
        {
            OleDbCommand cmd;
            if (Conn.State != ConnectionState.Open)
            { Conn.Open(); }
            OleDbTransaction Tran = Conn.BeginTransaction();
            try
            {
                foreach (string query in q)
                {
                    cmd = new OleDbCommand(query, Conn, Tran);
                    cmd.ExecuteNonQuery();
                }
                Tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Tran.Rollback();
                return false;
            }

        }

        public static int ExecuteNonQuery(string Query)
        {
            OleDbCommand cmd = new OleDbCommand(Query, Conn);
            int Result = 0;
            try
            {
                if (Conn.State != ConnectionState.Open)
                    Conn.Open();
                cmd.CommandTimeout = 0;
                Result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //Operation.writeLog("===========================ExecuteNonQuery====================================" + Environment.NewLine + "Date & Time : " + DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString() + Environment.NewLine + "Query : " + Query + Environment.NewLine + "Error Msg: " + ex.Message + Environment.NewLine + Environment.NewLine + "--------------------------------------------------------------------" + Environment.NewLine + "Error Stack : " + ex.StackTrace + Environment.NewLine + "====================================================================" + Environment.NewLine, Operation.ErrorLog);
            }
            finally
            {
                Conn.Close();
            }
            return Result;
        }

        public static void Bindgrid(string selectcommond, DataGridView supplydatagrid)
        {
            DataTable dt = GetDataTable(selectcommond);
            supplydatagrid.DataSource = dt;
        }

        public static DataTable GetDataTable(string Query)
        {
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            DataTable dt = new DataTable();
            try
            {
                OleDbCommand cmd = new OleDbCommand(Query, Conn);
                OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
                adp.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                //Operation.writeLog("===========================GetDataTable=========================================" + Environment.NewLine + "Date & Time : " + DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString() + Environment.NewLine + "Query : " + Query + Environment.NewLine + "Error Msg: " + ex.Message + Environment.NewLine + Environment.NewLine + "--------------------------------------------------------------------" + Environment.NewLine + "Error Stack : " + ex.StackTrace + Environment.NewLine + "====================================================================" + Environment.NewLine, Operation.ErrorLog);
                //MessageBox.Show("Error Ocuured" + ex.Message, MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return dt;
            }
            finally
            {
                if (Conn.State == ConnectionState.Open)
                    Conn.Close();
            }
        }
        public static void BindComboBox(string SQLQuery, ComboBox ComboBoxName, string DisplayName, string ValueName, string InitMsg)
        {
            DataTable dt = GetDataTable(SQLQuery);
            ComboBoxName.DataSource = dt;
            ComboBoxName.DisplayMember = DisplayName;
            ComboBoxName.ValueMember = ValueName;
            dt.Rows.Add(1);
            dt.Rows[dt.Rows.Count - 1][DisplayName] = InitMsg;
            dt.Rows[dt.Rows.Count - 1][ValueName] = "0";
            ComboBoxName.SelectedIndex = ComboBoxName.Items.Count - 1;
        }

        public static void BindGridComboBox(DataGridView GridName, DataGridViewCell currcell, string Query, string DisplayMember, string ValueMember, string InitMsg)
        {
            DataGridViewComboBoxCell dgvcombo = default(DataGridViewComboBoxCell);
            DataTable dtGrpBrand = new DataTable();
            dgvcombo = (DataGridViewComboBoxCell)currcell;
            dtGrpBrand = GetDataTable(Query);
            dtGrpBrand.Rows.Add();
            dtGrpBrand.Rows[dtGrpBrand.Rows.Count - 1][DisplayMember] = InitMsg;
            dtGrpBrand.Rows[dtGrpBrand.Rows.Count - 1][ValueMember] = "0";
            dgvcombo.AutoComplete = true;
            ((DataGridViewComboBoxCell)GridName.Rows[currcell.RowIndex].Cells[currcell.ColumnIndex]).DataSource = dtGrpBrand;
            ((DataGridViewComboBoxCell)GridName.Rows[currcell.RowIndex].Cells[currcell.ColumnIndex]).DisplayMember = DisplayMember;
            ((DataGridViewComboBoxCell)GridName.Rows[currcell.RowIndex].Cells[currcell.ColumnIndex]).ValueMember = ValueMember;
            ((DataGridViewComboBoxCell)GridName.Rows[currcell.RowIndex].Cells[currcell.ColumnIndex]).ValueType = typeof(string);
            ((DataGridViewComboBoxCell)GridName.Rows[currcell.RowIndex].Cells[currcell.ColumnIndex]).Value = "0";
            //Call addserialno()
        }

        public static void BindGridComboBox(DataGridView GridName, DataGridViewCell currcell, DataTable dtTable, string DisplayMember, string ValueMember, string InitMsg)
        {
            DataGridViewComboBoxCell dgvcombo = default(DataGridViewComboBoxCell);
            dgvcombo = (DataGridViewComboBoxCell)currcell;
            dtTable.Rows.Add();
            dtTable.Rows[dtTable.Rows.Count - 1][DisplayMember] = InitMsg;
            dtTable.Rows[dtTable.Rows.Count - 1][ValueMember] = "0";
            dgvcombo.AutoComplete = true;
            ((DataGridViewComboBoxCell)GridName.Rows[currcell.RowIndex].Cells[currcell.ColumnIndex]).DataSource = dtTable;
            ((DataGridViewComboBoxCell)GridName.Rows[currcell.RowIndex].Cells[currcell.ColumnIndex]).DisplayMember = DisplayMember;
            ((DataGridViewComboBoxCell)GridName.Rows[currcell.RowIndex].Cells[currcell.ColumnIndex]).ValueMember = ValueMember;
            ((DataGridViewComboBoxCell)GridName.Rows[currcell.RowIndex].Cells[currcell.ColumnIndex]).ValueType = typeof(string);
            ((DataGridViewComboBoxCell)GridName.Rows[currcell.RowIndex].Cells[currcell.ColumnIndex]).Value = "0";
            //Call addserialno()
        }
    }
}
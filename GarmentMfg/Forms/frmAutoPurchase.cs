using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GarmentMfg
{
    public partial class frmAutoPurchase : Form
    {
        public frmAutoPurchase()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to close Auto Purchase Form?", Operation.MsgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                if (lblId.Text == "U")
                {
                    Operation.ExecuteNonQuery("delete from APurch where BillNo='" + txtBillNo.Text + "'");
                    Operation.ExecuteNonQuery("delete from PurTrans where BillNo='" + txtBillNo.Text + "'");
                }
                Operation.ExecuteNonQuery("Insert into APurch(Jobber,BillNo,[Date]) values('" + cmbJobber.SelectedValue + "','" + txtBillNo.Text + "','" + dteBillDate.Value.ToString("dd/MM/yyyy") + "')");
                for (var i = 0; i < dgvTransactions.Rows.Count; i++)
                {
                    if (dgvTransactions.Rows[i].Cells["Select"].Value != null && (bool)dgvTransactions.Rows[i].Cells["Select"].Value)
                    {
                        Operation.ExecuteNonQuery("Insert into PurTrans(ProgramNo,LotSize,StartDate,EndDate,Qty,Rate,Amount,BillNo) values('" +
                            dgvTransactions.Rows[i].Cells["Program No"].Value + "','" + dgvTransactions.Rows[i].Cells["Lot Size"].Value + "','" +
                            dgvTransactions.Rows[i].Cells["Start Date"].Value + "','" + dgvTransactions.Rows[i].Cells["End Date"].Value + "','" +
                            dgvTransactions.Rows[i].Cells["Jobber Qty"].Value + "','" + dgvTransactions.Rows[i].Cells["Rate"].Value + "','" +
                            dgvTransactions.Rows[i].Cells["Amount"].Value + "','" + txtBillNo.Text + "')");
                        Operation.ExecuteNonQuery("Update MfgTrans set IsBilled='Y' where Jobber='" + cmbJobber.SelectedValue +
                            "' and ProgramNo='" + dgvTransactions.Rows[i].Cells["Program No"].Value + "' and [Qty]=" +
                            dgvTransactions.Rows[i].Cells["Jobber Qty"].Value + " and [Rate]=" + dgvTransactions.Rows[i].Cells["Rate"].Value);
                        Operation.ExecuteNonQuery("Update MfgCycle set IsCBilled='Y' where Cutter='" + cmbJobber.SelectedValue + "' and ProgramNo='" + dgvTransactions.Rows[i].Cells["Program No"].Value + "'");
                        Operation.ExecuteNonQuery("Update MfgCycle set IsWBilled='Y' where Washer='" + cmbJobber.SelectedValue + "' and ProgramNo='" + dgvTransactions.Rows[i].Cells["Program No"].Value + "'");
                        Operation.ExecuteNonQuery("Update MfgCycle set IsPBilled='Y' where Presser='" + cmbJobber.SelectedValue + "' and ProgramNo='" + dgvTransactions.Rows[i].Cells["Program No"].Value + "'");
                    }
                }

                MessageBox.Show("Bill Saved successfully.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAdd_Click(null, null);
            }

        }

        private bool validateForm()
        {
            if (cmbJobber.SelectedValue == null || cmbJobber.SelectedValue == "0")
            {
                MessageBox.Show("Please select Jobber First.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cmbJobber.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtBillNo.Text))
            {
                MessageBox.Show("Please select Bill Number.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtBillNo.Focus();
                return false;
            }
            if (dgvTransactions.Rows.Count > 0)
            {
                var found = false;
                for (var i = 0; i < dgvTransactions.Rows.Count; i++)
                {
                    if (dgvTransactions.Rows[i].Cells["Select"].Value != null && (bool)dgvTransactions.Rows[i].Cells["Select"].Value)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    MessageBox.Show("Please select any transaction from items against which you want to do this bill.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    dgvTransactions.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("There is no record to save.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                dgvTransactions.Focus();
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblId.Text = "0";
            txtBillNo.Enabled = true;
            dteFromDate.Value = DateTime.Now.AddDays(-180);
            dteToDate.Value = dteBillDate.Value = DateTime.Now;
            txtBillNo.Text = "";
            Operation.BindComboBox("select * from Jobber where LEN(remarks)>0", cmbJobber, "Name", "Code", "-- Select --");
            dgvTransactions.DataSource = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblId.Text == "U")
            {
                Operation.ExecuteNonQuery("delete from APurch where BillNo='" + txtBillNo.Text + "'");
                Operation.ExecuteNonQuery("delete from PurTrans where BillNo='" + txtBillNo.Text + "'");
                MessageBox.Show("Record deleted successfully.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select any record first.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmSearch view = new frmSearch();
            Operation.gViewQuery = "select APurch.BillNo,APurch.[Date],Jobber.[Name] as Jobber from APurch inner join Jobber on Jobber.Code=APurch.Jobber";
            Operation.Bindgrid(Operation.gViewQuery, view.dgvSearch);
            view.OrderByColoumn = "BillNo";
            view.ShowDialog();
            view.dgvSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            if (Operation.ViewID != null && Operation.ViewID != string.Empty)
            {
                filldata();
                Operation.ViewID = "";
                btnDelete.Enabled = true;
            }
        }

        private void filldata()
        {
            var dtMain = Operation.GetDataTable("select * from APurch where BillNo='" + Operation.ViewID + "'");
            if (dtMain != null && dtMain.Rows.Count > 0)
            {
                txtBillNo.Text = dtMain.Rows[0]["BillNo"].ToString();
                txtBillNo.Enabled = false;
                dteBillDate.Value = Convert.ToDateTime(dtMain.Rows[0]["Date"].ToString());
                cmbJobber.SelectedValue = dtMain.Rows[0]["Jobber"].ToString();
                dgvTransactions.DataSource = null;
                dgvTransactions.Rows.Clear();
                var dtTrans = Operation.GetDataTable("select * from PurTrans where BillNo='" + txtBillNo.Text + "'");
                if (dtTrans != null && dtTrans.Rows.Count > 0)
                {
                    dgvTransactions.DataSource = Operation.GetDataTable("select [ProgramNo] as [Program No],[LotSize] as [Lot Size],[StartDate] as [Start Date],[EndDate] as [End Date],[Qty] as [Jobber Qty],[Rate] as [Rate],[Amount] as [Amount] from PurTrans where BillNo='" + txtBillNo.Text + "'");
                    for (var i = 0; i < dtTrans.Rows.Count; i++)
                    {
                        dgvTransactions.Rows[i].Cells["Select"].Value = true;
                    }
                }
            }
        }

        private void frmAutoPurchase_Load(object sender, EventArgs e)
        {
            btnAdd_Click(null, null);
        }

        private void cmbJobber_Validated(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void refreshGrid()
        {
            dgvTransactions.DataSource = null;
            dgvTransactions.Rows.Clear();
            dgvTransactions.Columns.Clear();
            dgvTransactions.DataSource = Operation.GetDataTable("select [ProgramNo] as [Program No],[LotSize] as [Lot Size],[StartDate] as [Start Date],[EndDate] as [End Date],[CRCVDQTY] as [Jobber Qty],[CCOSTPRPCS] as [Rate],[CTOTALAMT] as [Amount] from mfgcycle where [Cutter]='" +
                cmbJobber.SelectedValue + "' and [IsCBilled]='N' and [CENDDATE] is not null and [CENDDATE] between #" + dteFromDate.Value.ToString("yyyy/MM/dd") + "# and #" + dteToDate.Value.ToString("yyyy/MM/dd") +
                "# UNION select [MfgCycle].[ProgramNo] as [Program No],[MfgCycle].[LotSize] as [Lot Size],[MfgCycle].[StartDate] as [Start Date],[MfgCycle].[EndDate] as [End Date],[MfgTrans].[Qty] as [Jobber Qty],[MfgTrans].[Rate] as [Rate],[MfgTrans].[Amount] as [Amount] from mfgcycle inner join mfgtrans on mfgtrans.Jobber = MfgCycle.Washer where mfgtrans.Jobber='" +
                cmbJobber.SelectedValue + "' and [MfgTrans].[IsBilled]='N' and [MfgCycle].[WENDDATE] is not null and [WENDDATE] between #" + dteFromDate.Value.ToString("yyyy/MM/dd") + "# and #" + dteToDate.Value.ToString("yyyy/MM/dd") +
                "# UNION select [MfgCycle].ProgramNo as [Program No],[MfgCycle].LotSize as [Lot Size],[MfgCycle].StartDate as [Start Date],[MfgCycle].EndDate as [End Date],[MfgTrans].[Qty] as [Jobber Qty],[MfgTrans].[Rate] as [Rate],[MfgTrans].[Amount] as [Amount] from mfgcycle inner join mfgtrans on mfgtrans.Jobber = MfgCycle.Presser where mfgtrans.Jobber='" +
                cmbJobber.SelectedValue + "' and IsPBilled='N' and [PENDDATE] is not null and [PENDDATE] between #" + dteFromDate.Value.ToString("yyyy/MM/dd") + "# and #" + dteToDate.Value.ToString("yyyy/MM/dd") +
                "# UNION select [MfgCycle].ProgramNo as [Program No],[MfgCycle].LotSize as [Lot Size],[MfgCycle].StartDate as [Start Date],[MfgCycle].EndDate as [End Date],[MfgTrans].[RCVDQTY] as [Jobber Qty],[MfgTrans].[Rate] as [Rate],[MfgTrans].[Amount] as [Amount] from mfgcycle inner join mfgtrans on mfgtrans.ProgramNo = MfgCycle.ProgramNo where mfgtrans.Jobber='" +
                cmbJobber.SelectedValue + "' and Process='C' and IsBilled='N' and [RCVDDATE] is not null and [RCVDDATE] between #" + dteFromDate.Value.ToString("yyyy/MM/dd") + "# and #" + dteToDate.Value.ToString("yyyy/MM/dd") +
                "#");
            dgvTransactions.Columns.Add("SrNo", "Sr No");
            dgvTransactions.Columns["SrNo"].DisplayIndex = 0;
            var chkSelect = new DataGridViewCheckBoxColumn();
            chkSelect.Name = "Select";
            chkSelect.HeaderText = "Select";
            dgvTransactions.Columns.Add(chkSelect);
            dgvTransactions.Columns["Select"].DisplayIndex = 1;
            dgvTransactions.Columns["Program No"].ReadOnly = true;
            dgvTransactions.Columns["Lot Size"].ReadOnly = true;
            dgvTransactions.Columns["Start Date"].ReadOnly = true;
            dgvTransactions.Columns["End Date"].ReadOnly = true;
            dgvTransactions.Columns["Jobber Qty"].ReadOnly = true;
            dgvTransactions.Columns["Rate"].ReadOnly = true;
            dgvTransactions.Columns["Amount"].ReadOnly = true;
            rebuildSrNo();
        }

        private void dteFromDate_Validated(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void dteToDate_Validated(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void dgvTransactions_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            rebuildSrNo();
        }

        private void rebuildSrNo()
        {
            if (dgvTransactions.Columns["SrNo"] != null)
            {
                for (var i = 0; i < dgvTransactions.Rows.Count; i++)
                {
                    dgvTransactions.Rows[i].Cells["SrNo"].Value = i + 1;
                }
            }
        }

        private void txtBillNo_Validated(object sender, EventArgs e)
        {
            var dt = Operation.GetDataTable("select * from APurch where BillNo='" + txtBillNo.Text + "'");
            if (dt != null && dt.Rows.Count > 0)
            {
                MessageBox.Show("Bill No is already in use, Please enter another bill No.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtBillNo.Text = "";
            }
        }
    }
}

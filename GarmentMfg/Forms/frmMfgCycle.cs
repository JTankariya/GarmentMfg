using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GarmentMfg
{
    public partial class frmMfgCycle : Form
    {
        private DateTimePicker cell;
        public frmMfgCycle()
        {
            InitializeComponent();
            this.cell = new DateTimePicker();
            this.cell.ValueChanged += new EventHandler(cell_datePicker_Changed);
            this.cell.Visible = false;
            this.cell.Format = DateTimePickerFormat.Custom;
            this.cell.CustomFormat = "dd/MM/yyyy";
            this.cell.ShowCheckBox = true;
            this.cell.Checked = false;
            this.dgvCuttingProcess.Controls.Add(cell);
        }

        private void cell_datePicker_Changed(object sender, EventArgs e)
        {
            if (cell.Checked == false)
            {
                dgvCuttingProcess.CurrentCell.Value = null;
            }
            else
            {
                dgvCuttingProcess.CurrentCell.Value = cell.Value.ToString("dd/MM/yyyy");
            }
        }

        private string GetFabricItemsQuery(bool forProduct)
        {
            var query = "Select DISTINCT myMfg." + (forProduct ? "Code" : "*,BatchNo as BatchCode") + ",Product.Name From " +
"(SELECT MfgIssue_Sum.JCODE, MfgIssue_Sum.CODE, MfgIssue_Sum.BATCHNO, (MfgIssue_Sum.sQty - Iif(IsNull(MfgFinish_Sum.sQty),0,MfgFinish_Sum.sQty)) as Qty " +
"FROM (SELECT Mfg.JCODE, Stock.CODE, Stock.BATCHNO, Sum(IIF(Stock.AL='A',-Stock.QTY,Stock.Qty)) AS sQty, Sum(IIF(Stock.AL='A',-Stock.STK_QTY,Stock.STK_QTY)) AS sStk_Qty " +
"FROM Stock RIGHT JOIN Mfg ON Stock.LINK = Mfg.LINK " +
"WHERE (((Mfg.VType)='MI')) " +
"GROUP BY Stock.Code, Stock.BatchNo, Mfg.JCode) as MfgIssue_Sum LEFT JOIN (SELECT Mfg2.Code AS BomCode, Mfg2.BatchNo AS BomBatch, Sum(Mfg2.Qty) AS sQty, Mfg2.JCode " +
"FROM Mfg INNER JOIN Mfg2 ON Mfg.LINK = Left(MFG2.LINK,8) " +
"WHERE (((Mfg.Vtype)='MR')) " +
"GROUP BY Mfg2.Code, Mfg2.Batchno, Mfg2.JCode) as MfgFinish_Sum ON (MfgIssue_Sum.BATCHNO = MfgFinish_Sum.BomBatch) AND " +
"(MfgIssue_Sum.CODE = MfgFinish_Sum.BomCode) AND (MfgIssue_Sum.JCODE = MfgFinish_Sum.JCode) Where  " +
"(MfgIssue_Sum.sQty - Iif(IsNull(MfgFinish_Sum.sQty),0,MfgFinish_Sum.sQty)) <>0 and MfgIssue_Sum.JCode='" +
cmbCuttingJobberName.SelectedValue + "') as myMfg  inner join Product on myMfg.Code=Product.Code Order By Product.Name";
            if (lblId.Text == "U")
            {
                query = "Select myMfg." + (forProduct ? "Code" : "*,BatchNo as BatchCode") + ",Product.Name From (SELECT Mfg.JCODE, Stock.CODE, Stock.BATCHNO, Sum(IIF(Stock.AL='A',-Stock.QTY,Stock.Qty)) AS Qty, Sum(IIF(Stock.AL='A',-Stock.STK_QTY,Stock.STK_QTY)) AS sStk_Qty " +
"FROM Stock RIGHT JOIN Mfg ON Stock.LINK = Mfg.LINK " +
"WHERE (((Mfg.VType)='MI')) and Mfg.JCode='" + cmbCuttingJobberName.SelectedValue + "'" +
"GROUP BY Stock.Code, Stock.BatchNo, Mfg.JCode)  as myMfg  inner join Product on myMfg.Code=Product.Code Order By Product.Name";
            }
            return query;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dtMain = Operation.GetDataTable("select IIF(ISNULL(MAX(INT(ProgramNo))), 1,MAX(INT(ProgramNo))+1) as NewProgramNo from MfgCycle");
            if (dtMain != null && dtMain.Rows.Count > 0)
            {
                txtProgramNo.Text = Convert.ToString(dtMain.Rows[0]["NewProgramNo"]);
            }
            dtpProgramStartDate.Value = dtpProgramFinishedDate.Value = DateTime.Now;
            dtpProgramFinishedDate.Checked = false;
            dgvCuttingProcess.Rows.Clear();
            dgvFabricUsed.Rows.Clear();
            dgvWashingProcess.Rows.Clear();
            dgvPressingProcess.Rows.Clear();
            dgvItemUsed.Rows.Clear();
            Operation.BindGridComboBox(dgvFabricUsed,
                dgvFabricUsed.Rows[0].Cells["ProductName"],
                Operation.GetDataTable(GetFabricItemsQuery(true)),
                "Name",
                "Code",
                "-- Select Product--");
            Operation.BindGridComboBox(dgvItemUsed, dgvItemUsed.Rows[0].Cells["OthProduct"], "select Code,Name from Product", "Name", "Code", "-- Select Product --");

            Operation.BindGridComboBox(dgvCuttingProcess, dgvCuttingProcess.Rows[0].Cells["CuttingJobberName"], "select Code,Name from Jobber WHERE UCASE(LEFT(REMARKS,1))='E' OR UCASE(LEFT(REMARKS,1))='R'", "Name", "Code", "-- Select Cutter Jobber --");
            Operation.BindGridComboBox(dgvWashingProcess, dgvWashingProcess.Rows[0].Cells["WashingJobberName"], "select Code,Name from Jobber WHERE UCASE(LEFT(REMARKS,1))='W'", "Name", "Code", "-- Select Washing Jobber --");
            Operation.BindGridComboBox(dgvPressingProcess, dgvPressingProcess.Rows[0].Cells["PressingJobber"], "select Code,Name from Jobber WHERE UCASE(LEFT(REMARKS,1))='P'", "Name", "Code", "-- Select Pressing Jobber --");
            Operation.BindComboBox("select Code,Name from Product", cmbFinishedProductName, "Name", "Code", "-- Select --");
            Operation.BindComboBox("select Code,Name from Jobber where UCASE(LEFT(REMARKS,1))='C'", cmbCuttingJobberName, "Name", "Code", "-- Select --");
            Operation.BindComboBox("select Code,Name from Jobber where UCASE(LEFT(REMARKS,1))='W'", cmbWashingJobberName, "Name", "Code", "-- Select --");
            Operation.BindComboBox("select Code,Name from Jobber where UCASE(LEFT(REMARKS,1))='P'", cmbPressingJobberName, "Name", "Code", "-- Select --");
            ((Control)tabProcess.TabPages[1]).Enabled = ((Control)tabProcess.TabPages[2]).Enabled = ((Control)tabProcess.TabPages[3]).Enabled = false;
            dgvFabricUsed.Rows[0].Cells[0].Value = 1;
            dgvItemUsed.Rows[0].Cells[0].Value = 1;
            dtpProgramStartDate_Validated(null, null);
            dtpCuttingStartDate_Validated(null, null);
            dtpWashingStartDate_Validated(null, null);
            dtpPressStartDate_Validated(null, null);
            dtpCuttingStartDate.MinDate = dtpPressEndDate.MinDate = dtpCuttingEndDate.MinDate = dtpPressStartDate.MinDate = dtpWashingEndDate.MinDate = dtpWashingStartDate.MinDate = dtpProgramStartDate.MinDate = dtpProgramFinishedDate.MinDate = Operation.objComp.CompFromDate;
            dtpCuttingStartDate.MaxDate = dtpPressEndDate.MaxDate = dtpCuttingEndDate.MaxDate = dtpPressStartDate.MaxDate = dtpWashingEndDate.MaxDate = dtpWashingStartDate.MaxDate = dtpProgramStartDate.MaxDate = dtpProgramFinishedDate.MaxDate = Operation.objComp.CompToDate;
            lblId.Text = "I";
            lblExpertLinks.Text = "";
            txtLotSize.Text = txtFinishedQty.Text = txtCuttingIssuedQty.Text = txtCuttingReceivedQty.Text = txtCuttingRate.Text = txtWashingRate.Text = txtPressingRate.Text = txtWashingIssuedQty.Text = txtWashingReceivedQty.Text = txtPressIssuedQty.Text = txtPressReceivedQty.Text = "0";
            dtpProgramFinishedDate.Checked = false;
            dtpProgramFinishedDate_Validated(null, null);
            dtpCuttingEndDate_Validated(null, null);
            CalculateTotals();
        }

        private void frmMfgCycle_Load(object sender, EventArgs e)
        {
            btnAdd_Click(null, null);
            this.WindowState = FormWindowState.Maximized;
        }

        private void dgvCuttingProcess_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Operation.BindGridComboBox(
                dgvCuttingProcess,
                dgvCuttingProcess.Rows[dgvCuttingProcess.Rows.Count - 1].Cells["CuttingJobberName"],
                "select Code,Name from Jobber WHERE UCASE(LEFT(REMARKS,1))='E' OR UCASE(LEFT(REMARKS,1))='R'",
                "Name",
                "Code",
                "-- Select --");
            dgvCuttingProcess.Rows[dgvCuttingProcess.Rows.Count - 1].Cells[0].Value = dgvCuttingProcess.Rows.Count;
        }

        DataTable dtCutterIssuedProducts = new DataTable();

        private void dgvFabricUsed_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dtCutterIssuedProducts = Operation.GetDataTable(GetFabricItemsQuery(true));
            Operation.BindGridComboBox(dgvFabricUsed,
                dgvFabricUsed.Rows[dgvFabricUsed.Rows.Count - 1].Cells[1],
                dtCutterIssuedProducts,
                "Name",
                "Code",
                "-- Select --");
            dgvFabricUsed.Rows[dgvFabricUsed.Rows.Count - 1].Cells[0].Value = dgvFabricUsed.Rows.Count;
        }

        private void dgvWashingProcess_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Operation.BindGridComboBox(dgvWashingProcess, dgvWashingProcess.Rows[dgvWashingProcess.Rows.Count - 1].Cells["WashingJobberName"], "select Code,Name from Jobber WHERE UCASE(LEFT(REMARKS,1))='W'", "Name", "Code", "-- Select --");
            dgvWashingProcess.Rows[dgvWashingProcess.Rows.Count - 1].Cells[0].Value = dgvWashingProcess.Rows.Count;
        }

        private void dgvPressingProcess_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Operation.BindGridComboBox(dgvPressingProcess, dgvPressingProcess.Rows[dgvPressingProcess.Rows.Count - 1].Cells["PressingJobber"], "select Code,Name from Jobber WHERE UCASE(LEFT(REMARKS,1))='P'", "Name", "Code", "-- Select --");
            dgvPressingProcess.Rows[dgvPressingProcess.Rows.Count - 1].Cells[0].Value = dgvPressingProcess.Rows.Count;
        }

        private void dgvItemUsed_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Operation.BindGridComboBox(dgvItemUsed, dgvItemUsed.Rows[dgvItemUsed.Rows.Count - 1].Cells[1], "select Code,Name from Product", "Name", "Code", "-- Select --");
            dgvItemUsed.Rows[dgvItemUsed.Rows.Count - 1].Cells[0].Value = dgvItemUsed.Rows.Count;
        }

        private void dgvCuttingProcess_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvCuttingProcess.CurrentCell != null &&
                (dgvCuttingProcess.Columns[dgvCuttingProcess.CurrentCell.ColumnIndex].Name.ToUpper() == "CUTTINGISSUEDATE" ||
                dgvCuttingProcess.Columns[dgvCuttingProcess.CurrentCell.ColumnIndex].Name.ToUpper() == "CUTTINGRECEIVEDDATE"))
            {
                Rectangle rect = dgvCuttingProcess.GetCellDisplayRectangle(dgvCuttingProcess.CurrentCell.ColumnIndex, dgvCuttingProcess.CurrentCell.RowIndex, false);
                cell.Location = rect.Location;
                cell.Width = rect.Width;
                cell.Visible = true;
                cell.Checked = dgvCuttingProcess.CurrentCell.Value != null;
            }
            else
            {
                cell.Visible = false;
                if (dgvCuttingProcess.CurrentCell != null)
                {
                    dgvCuttingProcess.BeginEdit(true);
                }

            }
        }

        private void dtpCuttingEndDate_Validated(object sender, EventArgs e)
        {
            ((Control)tabProcess.TabPages[1]).Enabled = ((Control)tabProcess.TabPages[2]).Enabled = ((Control)tabProcess.TabPages[3]).Enabled = dtpCuttingEndDate.Checked;
            txtCuttingReceivedQty.Enabled = txtCuttingRate.Enabled = dtpCuttingEndDate.Checked;
        }

        private void dtpWashingEndDate_Validated(object sender, EventArgs e)
        {
            ((Control)tabProcess.TabPages[2]).Enabled = ((Control)tabProcess.TabPages[3]).Enabled = dtpWashingEndDate.Checked;
        }

        private void dtpPressEndDate_Validated(object sender, EventArgs e)
        {
            ((Control)tabProcess.TabPages[3]).Enabled = dtpPressEndDate.Checked;
        }

        private void txtPressReceivedQty_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPressIssuedQty.Text))
            {
                MessageBox.Show("Issued Qty can not be Empty.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPressIssuedQty.Focus();
                return;
            }
            if (!string.IsNullOrEmpty(txtPressReceivedQty.Text) && Convert.ToDecimal(txtPressIssuedQty.Text) < Convert.ToDecimal(txtPressReceivedQty.Text))
            {
                MessageBox.Show("Received Qty can not be greater then Issued Qty.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPressReceivedQty.Focus();
                return;
            }
            CalculateTotals();
        }

        private void txtCuttingReceivedQty_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCuttingIssuedQty.Text) && string.IsNullOrEmpty(txtCuttingReceivedQty.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(txtCuttingIssuedQty.Text))
            {
                MessageBox.Show("Issued Qty can not be Empty.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCuttingIssuedQty.Focus();
                return;
            }
            if (!string.IsNullOrEmpty(txtCuttingReceivedQty.Text) && Convert.ToDecimal(txtCuttingIssuedQty.Text) < Convert.ToDecimal(txtCuttingReceivedQty.Text))
            {
                MessageBox.Show("Received Qty can not be greater then Issued Qty.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCuttingReceivedQty.Focus();
                return;
            }
            if (MessageBox.Show("We can apply this qty directly to washing jobber, would you like to apply this to washing?", Operation.MsgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtWashingIssuedQty.Text = txtCuttingReceivedQty.Text;
                dtpWashingStartDate.Value = dtpCuttingEndDate.Value;
            }
            CalculateTotals();
        }

        private void txtWashingReceivedQty_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtWashingIssuedQty.Text))
            {
                MessageBox.Show("Issued Qty can not be Empty.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWashingIssuedQty.Focus();
                return;
            }
            if (!string.IsNullOrEmpty(txtWashingReceivedQty.Text) && Convert.ToDecimal(txtCuttingIssuedQty.Text) < Convert.ToDecimal(txtWashingReceivedQty.Text))
            {
                MessageBox.Show("Received Qty can not be greater then Issued Qty.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWashingReceivedQty.Focus();
                return;
            }
            if (MessageBox.Show("We can apply this qty directly to Pressing jobber, would you like to apply this to Pressing?", Operation.MsgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtPressIssuedQty.Text = txtWashingReceivedQty.Text;
                dtpPressStartDate.Value = dtpWashingEndDate.Value;
            }
            CalculateTotals();
        }

        private void txtCuttingIssuedQty_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCuttingIssuedQty.Text) && string.IsNullOrEmpty(txtCuttingReceivedQty.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(txtCuttingIssuedQty.Text) || (!string.IsNullOrEmpty(txtCuttingReceivedQty.Text) && Convert.ToDecimal(txtCuttingIssuedQty.Text) < Convert.ToDecimal(txtCuttingReceivedQty.Text)))
            {
                MessageBox.Show("Received Qty can not be greater then Issued Qty.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCuttingReceivedQty.Focus();
                return;
            }
            CalculateTotals();
        }

        private void txtWashingIssuedQty_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtWashingIssuedQty.Text) && Convert.ToDecimal(txtCuttingReceivedQty.Text) < Convert.ToDecimal(txtWashingIssuedQty.Text))
            {
                MessageBox.Show("Washing issue qty can not be greater then Cutting Received Qty.\nCutting Received Qty is : " + txtCuttingReceivedQty.Text, Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWashingIssuedQty.Focus();
                return;
            }
            if (!string.IsNullOrEmpty(txtWashingIssuedQty.Text) && !string.IsNullOrEmpty(txtWashingReceivedQty.Text) && Convert.ToDecimal(txtWashingIssuedQty.Text) < Convert.ToDecimal(txtWashingReceivedQty.Text))
            {
                MessageBox.Show("Received Qty can not be greater then Issued Qty.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWashingReceivedQty.Focus();
                return;
            }
        }

        private void txtPressIssuedQty_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPressIssuedQty.Text) && Convert.ToDecimal(txtWashingReceivedQty.Text) < Convert.ToDecimal(txtPressIssuedQty.Text))
            {
                MessageBox.Show("Press issue qty can not be greater then Washing Received Qty.\nWashing Received Qty is : " + txtWashingReceivedQty.Text, Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWashingIssuedQty.Focus();
                return;
            }
            if (!string.IsNullOrEmpty(txtPressIssuedQty.Text) && !string.IsNullOrEmpty(txtPressReceivedQty.Text) && Convert.ToDecimal(txtPressIssuedQty.Text) < Convert.ToDecimal(txtPressReceivedQty.Text))
            {
                MessageBox.Show("Received Qty can not be greater then Issued Qty.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPressReceivedQty.Focus();
                return;
            }
        }

        private void dtpProgramStartDate_Validated(object sender, EventArgs e)
        {
            dtpProgramFinishedDate.MinDate = dtpProgramStartDate.Value;
        }

        private void dtpProgramFinishedDate_Validated(object sender, EventArgs e)
        {
            txtFinishedQty.Enabled = dtpProgramFinishedDate.Checked;
        }

        private void dtpWashingStartDate_Validated(object sender, EventArgs e)
        {
            dtpWashingEndDate.MinDate = dtpWashingStartDate.Value;
        }

        private void dtpCuttingStartDate_Validated(object sender, EventArgs e)
        {
            var prevChecked = dtpCuttingEndDate.Checked;
            dtpCuttingEndDate.MinDate = dtpCuttingStartDate.Value;
            dtpCuttingEndDate.Checked = prevChecked;
        }

        private void dtpPressStartDate_Validated(object sender, EventArgs e)
        {
            dtpPressEndDate.MinDate = dtpPressStartDate.Value;
        }

        private void txtLotSize_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCuttingIssuedQty.Text))
            {
                txtCuttingIssuedQty.Text = txtLotSize.Text;
            }
            CalculateTotals();
            if (string.IsNullOrEmpty(txtFinishedQty.Text))
            {
                return;
            }
            if (Convert.ToDecimal(txtFinishedQty.Text) > Convert.ToDecimal(txtLotSize.Text))
            {
                MessageBox.Show("Finished Qty can not be less then Lot Size.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtFinishedQty.Focus();
                return;
            }
        }

        private void txtFinishedQty_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFinishedQty.Text))
            {
                return;
            }
            if (Convert.ToDecimal(txtFinishedQty.Text) > Convert.ToDecimal(txtLotSize.Text))
            {
                MessageBox.Show("Finished Qty can not be less then Lot Size.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtFinishedQty.Focus();
                return;
            }
            CalculateTotals();
        }

        private void txtLotSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeric_KeyPress(sender, e);
        }

        private void txtFinishedQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeric_KeyPress(sender, e);
        }

        private void txtCuttingIssuedQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeric_KeyPress(sender, e);
        }

        private void txtCuttingReceivedQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeric_KeyPress(sender, e);
        }

        private void txtWashingIssuedQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeric_KeyPress(sender, e);
        }

        private void txtWashingReceivedQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeric_KeyPress(sender, e);
        }

        private void txtPressIssuedQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeric_KeyPress(sender, e);
        }

        private void txtPressReceivedQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeric_KeyPress(sender, e);
        }

        private void dgvCuttingProcess_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Numeric_KeyPress);
            if (dgvCuttingProcess.Columns[dgvCuttingProcess.CurrentCell.ColumnIndex].Name.ToUpper() == "CUTTINGISSUEDQTY" ||
                dgvCuttingProcess.Columns[dgvCuttingProcess.CurrentCell.ColumnIndex].Name.ToUpper() == "CUTTINGRECEIVEDQTY" ||
                dgvCuttingProcess.Columns[dgvCuttingProcess.CurrentCell.ColumnIndex].Name.ToUpper() == "CUTTINGRATE" ||
                dgvCuttingProcess.Columns[dgvCuttingProcess.CurrentCell.ColumnIndex].Name.ToUpper() == "CUTTINGAMOUNT"
                )
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Numeric_KeyPress);
                }
            }
        }

        private void Numeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvFabricUsed_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Numeric_KeyPress);
            if (dgvFabricUsed.Columns[dgvFabricUsed.CurrentCell.ColumnIndex].Name.ToUpper() == "USEDMTR" ||
                dgvFabricUsed.Columns[dgvFabricUsed.CurrentCell.ColumnIndex].Name.ToUpper() == "RATE" ||
                dgvFabricUsed.Columns[dgvFabricUsed.CurrentCell.ColumnIndex].Name.ToUpper() == "AMOUNT"
                )
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Numeric_KeyPress);
                }
            }
        }

        private void dgvWashingProcess_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Numeric_KeyPress);
            if (dgvWashingProcess.Columns[dgvWashingProcess.CurrentCell.ColumnIndex].Name.ToUpper() == "WASHINGQTY" ||
                dgvWashingProcess.Columns[dgvWashingProcess.CurrentCell.ColumnIndex].Name.ToUpper() == "WASHINGRATE" ||
                dgvWashingProcess.Columns[dgvWashingProcess.CurrentCell.ColumnIndex].Name.ToUpper() == "WASHINGAMOUNT"
                )
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Numeric_KeyPress);
                }
            }
        }

        private void dgvPressingProcess_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Numeric_KeyPress);
            if (dgvPressingProcess.Columns[dgvPressingProcess.CurrentCell.ColumnIndex].Name.ToUpper() == "PRESSINGQTY" ||
                dgvPressingProcess.Columns[dgvPressingProcess.CurrentCell.ColumnIndex].Name.ToUpper() == "PRESSINGRATE" ||
                dgvPressingProcess.Columns[dgvPressingProcess.CurrentCell.ColumnIndex].Name.ToUpper() == "PRESSINGAMOUNT"
                )
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Numeric_KeyPress);
                }
            }
        }

        private void dgvItemUsed_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Numeric_KeyPress);
            if (dgvItemUsed.Columns[dgvItemUsed.CurrentCell.ColumnIndex].Name.ToUpper() == "OTHQTY" ||
                dgvItemUsed.Columns[dgvItemUsed.CurrentCell.ColumnIndex].Name.ToUpper() == "OTHRATE" ||
                dgvItemUsed.Columns[dgvItemUsed.CurrentCell.ColumnIndex].Name.ToUpper() == "OTHAMOUNT"
                )
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Numeric_KeyPress);
                }
            }
        }

        private void dgvFabricUsed_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFabricUsed.Columns[e.ColumnIndex].Name.ToUpper() == "PRODUCTNAME" && dgvFabricUsed.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != "0")
            {
                dtCutterIssuedProducts = Operation.GetDataTable(GetFabricItemsQuery(false));
                Operation.BindGridComboBox(dgvFabricUsed,
                    dgvFabricUsed.Rows[e.RowIndex].Cells["BatchNo"],
                    Operation.GetDataTable(GetFabricItemsQuery(false)),
                    "BatchNo",
                    "BatchCode",
                    "-- Select Batch --");
            }
            if (dgvFabricUsed.Columns[e.ColumnIndex].Name.ToUpper() == "BATCHNO" &&
                Convert.ToString(dgvFabricUsed.Rows[e.RowIndex].Cells["BatchNo"].Value) != "0")
            {
                if (dtCutterIssuedProducts != null && dtCutterIssuedProducts.Rows.Count > 0 && dtCutterIssuedProducts.Columns.Count > 2)
                {
                    dtCutterIssuedProducts.DefaultView.RowFilter = "BatchNo='" + dgvFabricUsed.Rows[e.RowIndex].Cells["BatchNo"].Value + "' and Code='" + dgvFabricUsed.Rows[e.RowIndex].Cells["ProductName"].Value + "'";
                    var data = dtCutterIssuedProducts.DefaultView.ToTable();
                    if (data != null && data.Rows.Count > 0)
                    {
                        var rateDt = Operation.GetDataTable("select [rate] from stock where [vtype]='PU' and [Code]='" +
                            Convert.ToString(dgvFabricUsed.Rows[e.RowIndex].Cells["ProductName"].Value) + "' and [BatchNo]='" +
                            Convert.ToString(dgvFabricUsed.Rows[e.RowIndex].Cells["BatchNo"].Value) + "' order by [Date] desc");
                        dgvFabricUsed.Rows[e.RowIndex].Cells["UsedMtr"].Value = data.Rows[0]["Qty"].ToString();
                        if (rateDt != null && rateDt.Rows.Count > 0)
                        {
                            dgvFabricUsed.Rows[e.RowIndex].Cells["Rate"].Value = rateDt.Rows[0][0].ToString();
                        }
                    }
                    else
                    {
                        dgvFabricUsed.Rows[e.RowIndex].Cells["UsedMtr"].Value = "0";
                        dgvFabricUsed.Rows[e.RowIndex].Cells["Rate"].Value = "0";
                    }
                }
                else
                {
                    dgvFabricUsed.Rows[e.RowIndex].Cells["UsedMtr"].Value = "0";
                    dgvFabricUsed.Rows[e.RowIndex].Cells["Rate"].Value = "0";
                }
            }
            CalculateTotals();
        }

        private void dgvItemUsed_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItemUsed.Columns[e.ColumnIndex].Name.ToUpper() == "OTHPRODUCT")
            {
                Operation.BindGridComboBox(dgvItemUsed, dgvItemUsed.Rows[e.RowIndex].Cells["OTHBATCH"], "select * from Batch where Code = '" + dgvItemUsed.Rows[e.RowIndex].Cells[e.ColumnIndex].Value + "'", "BatchNo", "BatchNo", "-- Select Batch --");
            }
            CalculateTotals();
        }

        private void CalculateTotals()
        {
            decimal cuttingGrandTotal = 0, washingGrandTotal = 0, pressingGrandTotal = 0, otherGrandTotal = 0, fabricGrandAmount = 0, otherGrandAmount = 0;
            decimal cuttingCostPrPcs = 0, washingCostPrPcs = 0, pressingCostPrPcs = 0, otherCostPrPcs = 0, usedMtrPrPcs = 0;
            for (var i = 0; i < dgvCuttingProcess.Rows.Count - 1; i++)
            {
                var amount = Convert.ToDecimal(dgvCuttingProcess.Rows[i].Cells["CuttingReceivedQty"] != null ? dgvCuttingProcess.Rows[i].Cells["CuttingReceivedQty"].Value : "0") * Convert.ToDecimal(dgvCuttingProcess.Rows[i].Cells["CuttingRate"] != null ? dgvCuttingProcess.Rows[i].Cells["CuttingRate"].Value : "0");
                dgvCuttingProcess.Rows[i].Cells["CuttingAmount"].Value = Math.Round(amount, 2);
                cuttingGrandTotal += amount;
            }
            for (var i = 0; i < dgvFabricUsed.Rows.Count - 1; i++)
            {
                var amount = Convert.ToDecimal(dgvFabricUsed.Rows[i].Cells["UsedMtr"].Value) * Convert.ToDecimal(dgvFabricUsed.Rows[i].Cells["Rate"].Value);
                dgvFabricUsed.Rows[i].Cells["Amount"].Value = Math.Round(amount, 2);
                cuttingGrandTotal += amount;
                fabricGrandAmount += amount;
                usedMtrPrPcs += Convert.ToDecimal(dgvFabricUsed.Rows[i].Cells["UsedMtr"].Value);
            }
            cuttingGrandTotal += Convert.ToDecimal(string.IsNullOrEmpty(txtCuttingReceivedQty.Text) ? "0" : txtCuttingReceivedQty.Text) * Convert.ToDecimal(string.IsNullOrEmpty(txtCuttingRate.Text) ? "0" : txtCuttingRate.Text);
            txtCuttingTotalAmount.Text = Convert.ToString(Math.Round(cuttingGrandTotal, 2));
            cuttingCostPrPcs = string.IsNullOrEmpty(txtCuttingReceivedQty.Text) || Convert.ToDecimal(txtCuttingReceivedQty.Text) == 0 ? 0 : cuttingGrandTotal / Convert.ToDecimal(txtCuttingReceivedQty.Text);
            txtCuttingCostPerPcs.Text = Convert.ToString(Math.Round(cuttingCostPrPcs, 2));
            txtAverageMtrPerPcs.Text = Convert.ToString(Math.Round(string.IsNullOrEmpty(txtCuttingReceivedQty.Text) || Convert.ToDecimal(txtCuttingReceivedQty.Text) == 0 ? 0 : usedMtrPrPcs / Convert.ToDecimal(txtCuttingReceivedQty.Text), 2));
            txtFabricCostPerPcs.Text = Convert.ToString(Math.Round(string.IsNullOrEmpty(txtCuttingReceivedQty.Text) || Convert.ToDecimal(txtCuttingReceivedQty.Text) == 0 ? 0 : fabricGrandAmount / Convert.ToDecimal(txtCuttingReceivedQty.Text), 2));

            for (var i = 0; i < dgvWashingProcess.Rows.Count - 1; i++)
            {
                var amount = Convert.ToDecimal(dgvWashingProcess.Rows[i].Cells["WashingQty"] != null ? dgvWashingProcess.Rows[i].Cells["WashingQty"].Value : "0") * Convert.ToDecimal(dgvWashingProcess.Rows[i].Cells["WashingRate"] != null ? dgvWashingProcess.Rows[i].Cells["WashingRate"].Value : "0");
                dgvWashingProcess.Rows[i].Cells["WashingAmount"].Value = Math.Round(amount, 2);
                washingGrandTotal += amount;
            }
            washingGrandTotal += Convert.ToDecimal(string.IsNullOrEmpty(txtWashingReceivedQty.Text) ? "0" : txtWashingReceivedQty.Text) * Convert.ToDecimal(string.IsNullOrEmpty(txtWashingRate.Text) ? "0" : txtWashingRate.Text);
            txtWashingTotalAmount.Text = Convert.ToString(Math.Round(washingGrandTotal, 2));
            txtWashingCostPerPcs.Text = Convert.ToString(Math.Round(washingCostPrPcs, 2));

            for (var i = 0; i < dgvPressingProcess.Rows.Count - 1; i++)
            {
                var amount = Convert.ToDecimal(dgvPressingProcess.Rows[i].Cells["PressingQty"] != null ? dgvPressingProcess.Rows[i].Cells["PressingQty"].Value : "0") * Convert.ToDecimal(dgvPressingProcess.Rows[i].Cells["PressingRate"] != null ? dgvPressingProcess.Rows[i].Cells["PressingRate"].Value : "0");
                dgvPressingProcess.Rows[i].Cells["PressingAmount"].Value = Math.Round(amount, 2);
                pressingGrandTotal += amount;
            }
            pressingGrandTotal += Convert.ToDecimal(string.IsNullOrEmpty(txtPressReceivedQty.Text) ? "0" : txtPressReceivedQty.Text) * Convert.ToDecimal(string.IsNullOrEmpty(txtPressingRate.Text) ? "0" : txtPressingRate.Text);
            txtPressingTotalAmount.Text = Convert.ToString(Math.Round(pressingGrandTotal, 2));
            txtPressingCostPerPcs.Text = Convert.ToString(Math.Round(pressingCostPrPcs, 2));

            for (var i = 0; i < dgvItemUsed.Rows.Count - 1; i++)
            {
                var amount = Convert.ToDecimal(dgvItemUsed.Rows[i].Cells["OthQty"] != null ? dgvItemUsed.Rows[i].Cells["OthQty"].Value : "0") * Convert.ToDecimal(dgvItemUsed.Rows[i].Cells["OthRate"] != null ? dgvItemUsed.Rows[i].Cells["OthRate"].Value : "0");
                dgvItemUsed.Rows[i].Cells["OthAmount"].Value = Math.Round(amount, 2);
                otherGrandTotal += amount;
                otherGrandAmount += amount;
            }
            txtOtherExpsPerPcs.Text = Convert.ToString(string.IsNullOrEmpty(txtFinishedQty.Text) || Convert.ToDecimal(txtFinishedQty.Text) == 0 ? 0 : otherGrandAmount / Convert.ToDecimal(txtFinishedQty.Text));
            txtOthTotalAmount.Text = Convert.ToString(Math.Round(otherGrandTotal, 2));
            txtOthCostPrPcs.Text = Convert.ToString(Math.Round(otherCostPrPcs, 2));

            txtCostingPerPcs.Text = Convert.ToString(Math.Round(string.IsNullOrEmpty(txtFinishedQty.Text) || Convert.ToDecimal(txtFinishedQty.Text) == 0 ? 0 : (cuttingGrandTotal + washingGrandTotal + pressingGrandTotal + otherGrandAmount) / Convert.ToDecimal(txtFinishedQty.Text), 2));
        }

        private void txtCuttingRate_Validated(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void dgvCuttingProcess_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCuttingProcess.CurrentCell != null && dgvCuttingProcess.Columns[e.ColumnIndex].Name.ToString().ToUpper() == "CUTTINGJOBBERNAME")
            {
                for (var i = 0; i < dgvCuttingProcess.Rows.Count - 1; i++)
                {
                    if (dgvCuttingProcess.Rows[i].Cells["CuttingJobberName"].EditedFormattedValue.ToString().ToUpper() == dgvCuttingProcess.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString().ToUpper() &&
                        i != dgvCuttingProcess.CurrentCell.RowIndex)
                    {
                        MessageBox.Show("This jobber is already selected, Please select another jobber.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        dgvCuttingProcess.CurrentCell.Value = "0";
                        return;
                    }
                }
            }
            CalculateTotals();
        }

        private void dgvWashingProcess_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalculateTotals();
        }

        private void dgvPressingProcess_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalculateTotals();
        }

        private void txtWashingRate_Validated(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void txtPressingRate_Validated(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isFormValid())
            {
                int washingIssueLink = 0, pressingIssueLink = 0, cuttingReceiveLink = 0, washingReceiveLink = 0, pressingReceiveLink = 0;
                var productName = txtProgramNo.Text.PadLeft(3, '0') + "/" + txtLotSize.Text;
                var productCode = "";
                int mfgIssueLink = 0, mfgReceiveLink = 0;
                List<string> strQueries = new List<string>();
                if (lblId.Text == "U")
                {
                    var links = lblExpertLinks.Text.Split(',');
                    strQueries.Add("Delete from MfgCycle where ProgramNo='" + txtProgramNo.Text + "'");
                    strQueries.Add("Delete from MfgTrans where ProgramNo='" + txtProgramNo.Text + "'");
                    strQueries.Add("Delete from MfgItems where ProgramNo='" + txtProgramNo.Text + "'");
                    productCode = Convert.ToString(Operation.GetDataTable("select CODE from PRODUCT where NAME='" + productName + "'").Rows[0][0]);
                    cuttingReceiveLink = Convert.ToInt32(links[0]);
                    washingIssueLink = Convert.ToInt32(links[1]);
                    washingReceiveLink = Convert.ToInt32(links[2]);
                    pressingIssueLink = Convert.ToInt32(links[3]);
                    pressingReceiveLink = Convert.ToInt32(links[4]);
                    strQueries.Add("Delete from Mfg where LINK='MR" + cuttingReceiveLink + "'");
                    strQueries.Add("Delete from Mfg where LINK='MI" + washingIssueLink + "'");
                    strQueries.Add("Delete from Mfg where LINK='MR" + washingReceiveLink + "'");
                    strQueries.Add("Delete from Mfg where LINK='MI" + pressingIssueLink + "'");
                    strQueries.Add("Delete from Mfg where LINK='MR" + pressingReceiveLink + "'");
                    strQueries.Add("Delete from Mfg2 where LEFT(LINK,8)='MR" + cuttingReceiveLink + "'");
                    strQueries.Add("Delete from Mfg2 where LEFT(LINK,8)='MI" + washingIssueLink + "'");
                    strQueries.Add("Delete from Mfg2 where LEFT(LINK,8)='MR" + washingReceiveLink + "'");
                    strQueries.Add("Delete from Mfg2 where LEFT(LINK,8)='MI" + pressingIssueLink + "'");
                    strQueries.Add("Delete from Mfg2 where LEFT(LINK,8)='MR" + pressingReceiveLink + "'");
                    strQueries.Add("Delete from STOCK where LINK='MR" + cuttingReceiveLink + "'");
                    strQueries.Add("Delete from STOCK where LINK='MI" + washingIssueLink + "'");
                    strQueries.Add("Delete from STOCK where LINK='MR" + washingReceiveLink + "'");
                    strQueries.Add("Delete from STOCK where LINK='MI" + pressingIssueLink + "'");
                    strQueries.Add("Delete from STOCK where LINK='MR" + pressingReceiveLink + "'");
                }
                else
                {
                    productCode = Convert.ToString(Operation.GetDataTable("Select MAX(IIF(ISNULL(CODE),100001,VAL(CODE)))+1 as PCODE from Product").Rows[0][0]);
                    mfgIssueLink = Convert.ToInt32(Operation.GetDataTable("Select MAX(IIF(ISNULL(LINK),100001,RIGHT(LINK,6)))+1 as PCODE from MFG where VTYPE='MI'").Rows[0][0]);
                    mfgReceiveLink = Convert.ToInt32(Operation.GetDataTable("Select MAX(IIF(ISNULL(LINK),100001,RIGHT(LINK,6)))+1 as PCODE from MFG where VTYPE='MR'").Rows[0][0]);
                    strQueries.Add("insert into Product(CODE,NAME,BATCH,UNIT1) values('" + productCode + "','" + productName + "',TRUE,'.')");
                    strQueries.Add("insert into Batch(CODE,BATCHNO) values('" + productCode + "','CUTTING')");
                    strQueries.Add("insert into Batch(CODE,BATCHNO) values('" + productCode + "','WASHING')");
                    strQueries.Add("insert into Batch(CODE,BATCHNO) values('" + productCode + "','PRESSING')");
                    washingIssueLink = mfgIssueLink;
                    pressingIssueLink = washingIssueLink + 1;
                    cuttingReceiveLink = mfgReceiveLink;
                    washingReceiveLink = cuttingReceiveLink + 1;
                    pressingReceiveLink = washingReceiveLink + 1;
                }

                //                #region CUTTING ISSUE ENTRIES

                //                if (!string.IsNullOrEmpty(Convert.ToString(cmbCuttingJobberName.SelectedValue)) &&
                //                        Convert.ToString(cmbCuttingJobberName.SelectedValue) != "0" &&
                //                        !string.IsNullOrEmpty(txtCuttingIssuedQty.Text) &&
                //                        Convert.ToInt32(txtCuttingIssuedQty.Text) > 0)
                //                {
                //                    strQueries.Add("Insert into MFG(LINK,VTYPE,DATE,DOCNO,JCODE) values('MI" + cuttingIssueLink + "','MI','" +
                //                        dtpProgramStartDate.Value.ToString("dd/MM/yyyy") + "','" + txtProgramNo.Text.PadLeft(3, '0') + "/CUTTING','" +
                //                        cmbCuttingJobberName.SelectedValue + "')");
                //                    strQueries.Add("Insert into STOCK(LINK,VTYPE,CODE,BATCHNO,QTY,STK_QTY,UNIT,DOCNO,DATE,AL,JCODE) values('MI" +
                //cuttingIssueLink + "','MI','" + productCode + "','CUTTING','" + txtCuttingIssuedQty.Text + "','" + txtCuttingIssuedQty.Text +
                //"','.','" + txtProgramNo.Text.PadLeft(3, '0') + "/CUTTING','" + dtpCuttingStartDate.Value.ToString("dd/MM/yyyy") + "','L','" +
                //cmbCuttingJobberName.SelectedValue + "')");
                //                }

                //                #endregion

                #region CUTTING RECEIVE ENTRIES

                if (dtpCuttingEndDate.Checked)
                {
                    strQueries.Add("Insert into MFG(LINK,VTYPE,[DATE],DOCNO,JCODE) values('MR" + cuttingReceiveLink + "','MR','" +
                        dtpCuttingEndDate.Value.ToString("dd/MM/yyyy") + "','" + txtProgramNo.Text.PadLeft(3, '0') + "/CUTTING','" +
                        cmbCuttingJobberName.SelectedValue + "')");
                    strQueries.Add("Insert into STOCK(LINK,VTYPE,CODE,BATCHNO,QTY,STK_QTY,UNIT,DOCNO,[DATE],AL,JCODE,BOMNO) values('MR" +
                        cuttingReceiveLink + "','MR','" + productCode + "','CUTTING','" + txtCuttingReceivedQty.Text + "','" + txtCuttingReceivedQty.Text +
                        "','.','" + txtProgramNo.Text.PadLeft(3, '0') + "/CUTTING','" + dtpCuttingEndDate.Value.ToString("dd/MM/yyyy") + "','A','" +
                        cmbCuttingJobberName.SelectedValue + "','XXXX')");
                    if (!string.IsNullOrEmpty(Convert.ToString(cmbWashingJobberName.SelectedValue)) &&
                        Convert.ToString(cmbWashingJobberName.SelectedValue) != "0" &&
                        !string.IsNullOrEmpty(txtWashingIssuedQty.Text) &&
                        Convert.ToInt32(txtWashingIssuedQty.Text) > 0)
                    {
                        strQueries.Add("Insert into MFG(LINK,VTYPE,[DATE],DOCNO,JCODE) values('MI" + washingIssueLink + "','MI','" +
                            dtpProgramStartDate.Value.ToString("dd/MM/yyyy") + "','" + txtProgramNo.Text.PadLeft(3, '0') + "/WASHING','" +
                            cmbWashingJobberName.SelectedValue + "')");
                        strQueries.Add("Insert into STOCK(LINK,VTYPE,CODE,BATCHNO,QTY,STK_QTY,UNIT,DOCNO,[DATE],AL,JCODE) values('MI" +
    washingIssueLink + "','MI','" + productCode + "','WASHING','" + txtWashingIssuedQty.Text + "','" + txtWashingIssuedQty.Text +
    "','.','" + txtProgramNo.Text.PadLeft(3, '0') + "/WASHING','" + dtpWashingStartDate.Value.ToString("dd/MM/yyyy") + "','L','" +
    cmbWashingJobberName.SelectedValue + "')");
                    }
                }

                for (var i = 0; i < dgvFabricUsed.Rows.Count - 1; i++)
                {
                    if (dtpCuttingEndDate.Checked)
                    {
                        strQueries.Add("insert into MFG2(LINK,CODE,BATCHNO,QTY,AL,[DATE],DOCNO,JCODE) values('MR" +
                            cuttingReceiveLink + productCode + "CUTTING','" + dgvFabricUsed.Rows[i].Cells["ProductName"].Value + "','" +
                            dgvFabricUsed.Rows[i].Cells["BatchNo"].Value + "'," + dgvFabricUsed.Rows[i].Cells["UsedMtr"].Value +
                            ",'L','" + dtpCuttingEndDate.Value.ToString("dd/MM/yyyy") + "','" + txtProgramNo.Text.PadLeft(3, '0') +
                            "/CUTTING'," + cmbCuttingJobberName.SelectedValue + ")");
                    }
                    strQueries.Add("Insert into [MfgItems]([PRODUCT],[BATCH],[QTY],[RATE],[AMOUNT],[PROGRAMNO],[TYPE]) values('" +
                         dgvFabricUsed.Rows[i].Cells["ProductName"].Value + "','" + dgvFabricUsed.Rows[i].Cells["BatchNo"].Value +
                         "'," + dgvFabricUsed.Rows[i].Cells["UsedMtr"].Value + "," + dgvFabricUsed.Rows[i].Cells["Rate"].Value +
                         "," + dgvFabricUsed.Rows[i].Cells["Amount"].Value + ",'" + txtProgramNo.Text +
                         "','F')");
                }
                #endregion

                #region WASHING RECEIVE ENTRIES

                if (dtpWashingEndDate.Checked)
                {
                    strQueries.Add("Insert into MFG(LINK,VTYPE,[DATE],DOCNO,JCODE) values('MR" + washingReceiveLink + "','MR','" +
                        dtpWashingEndDate.Value.ToString("dd/MM/yyyy") + "','" + txtProgramNo.Text.PadLeft(3, '0') + "/WASHING','" +
                        cmbWashingJobberName.SelectedValue + "')");
                    strQueries.Add("Insert into STOCK(LINK,VTYPE,CODE,BATCHNO,QTY,STK_QTY,UNIT,DOCNO,[DATE],AL,JCODE,BOMNO) values('MR" +
                        washingReceiveLink + "','MR','" + productCode + "','WASHING','" + txtWashingReceivedQty.Text + "','" + txtWashingReceivedQty.Text +
                        "','.','" + txtProgramNo.Text.PadLeft(3, '0') + "/WASHING','" + dtpWashingEndDate.Value.ToString("dd/MM/yyyy") + "','A','" +
                        cmbWashingJobberName.SelectedValue + "','XXXX')");
                    strQueries.Add("insert into MFG2(LINK,CODE,BATCHNO,QTY,AL,[DATE],DOCNO,JCODE) values('MR" +
                            washingReceiveLink + productCode + "WASHING','" + productCode + "','CUTTING'," + txtWashingReceivedQty.Text +
                            ",'L','" + dtpWashingEndDate.Value.ToString("dd/MM/yyyy") + "','" + txtProgramNo.Text.PadLeft(3, '0') +
                            "/WASHING'," + cmbWashingJobberName.SelectedValue + ")");
                    if (!string.IsNullOrEmpty(Convert.ToString(cmbPressingJobberName.SelectedValue)) &&
                            Convert.ToString(cmbPressingJobberName.SelectedValue) != "0" &&
                            !string.IsNullOrEmpty(txtPressIssuedQty.Text) &&
                            Convert.ToInt32(txtPressIssuedQty.Text) > 0)
                    {
                        strQueries.Add("Insert into MFG(LINK,VTYPE,[DATE],DOCNO,JCODE) values('MI" + pressingIssueLink + "','MI','" +
                            dtpProgramStartDate.Value.ToString("dd/MM/yyyy") + "','" + txtProgramNo.Text.PadLeft(3, '0') + "/PRESSING','" +
                            cmbPressingJobberName.SelectedValue + "')");
                        strQueries.Add("Insert into STOCK(LINK,VTYPE,CODE,BATCHNO,QTY,STK_QTY,UNIT,DOCNO,[DATE],AL,JCODE) values('MI" +
    pressingIssueLink + "','MI','" + productCode + "','PRESSING','" + txtPressIssuedQty.Text + "','" + txtPressIssuedQty.Text +
    "','.','" + txtProgramNo.Text.PadLeft(3, '0') + "/PRESSING','" + dtpPressStartDate.Value.ToString("dd/MM/yyyy") + "','L','" +
    cmbPressingJobberName.SelectedValue + "')");
                    }
                    if (dtpPressEndDate.Checked)
                    {

                    }
                }

                #endregion

                #region PRESSING RECEIVE ENTRY

                if (dtpPressEndDate.Checked)
                {
                    strQueries.Add("Insert into MFG(LINK,VTYPE,[DATE],DOCNO,JCODE) values('MR" + pressingReceiveLink + "','MR','" +
                       dtpPressEndDate.Value.ToString("dd/MM/yyyy") + "','" + txtProgramNo.Text.PadLeft(3, '0') + "/PRESSING','" +
                       cmbPressingJobberName.SelectedValue + "')");
                    strQueries.Add("Insert into STOCK(LINK,VTYPE,CODE,BATCHNO,QTY,STK_QTY,UNIT,DOCNO,[DATE],AL,JCODE,BOMNO) values('MR" +
                        pressingReceiveLink + "','MR','" + productCode + "','PRESSING','" + txtPressReceivedQty.Text + "','" + txtPressReceivedQty.Text +
                        "','.','" + txtProgramNo.Text.PadLeft(3, '0') + "/PRESSING','" + dtpPressEndDate.Value.ToString("dd/MM/yyyy") + "','A','" +
                        cmbPressingJobberName.SelectedValue + "','XXXX')");
                    strQueries.Add("insert into MFG2(LINK,CODE,BATCHNO,QTY,AL,[DATE],DOCNO,JCODE) values('MR" +
                            pressingReceiveLink + cmbFinishedProductName.SelectedValue + "','" + productCode + "','WASHING'," + txtPressReceivedQty.Text +
                            ",'L','" + dtpPressEndDate.Value.ToString("dd/MM/yyyy") + "','" + txtProgramNo.Text.PadLeft(3, '0') +
                            "/PRESSING'," + cmbPressingJobberName.SelectedValue + ")");
                }
                for (var i = 0; i < dgvPressingProcess.Rows.Count - 1; i++)
                {
                    strQueries.Add("Insert into [MfgTrans]([PROGRAMNO],[PROCESS],[JOBBER],[QTY],[RATE],[AMOUNT],[NARRATION],[ISSUEDATE]," +
"[RCVDDATE],[ISSUEDQTY],[RCVDQTY],[LINK]) values('" + txtProgramNo.Text + "','P','" + dgvPressingProcess.Rows[i].Cells["PressingJobber"].Value +
"'," + dgvPressingProcess.Rows[i].Cells["PressingQty"].Value + "," + dgvPressingProcess.Rows[i].Cells["PressingRate"].Value +
"," + dgvPressingProcess.Rows[i].Cells["PressingAmount"].Value + ",'" + dgvPressingProcess.Rows[i].Cells["PressingNarr"].Value +
"',NULL,NULL,0,0," + (i + 1) + ")");

                }

                for (var i = 0; i < dgvItemUsed.Rows.Count - 1; i++)
                {
                    strQueries.Add("Insert into STOCK(LINK,VTYPE,CODE,BATCHNO,QTY,STK_QTY,UNIT,DOCNO,[DATE],AL,JCODE,BOMNO) values('MI" +
                        pressingIssueLink + "','MI','" + dgvItemUsed.Rows[i].Cells["OthProduct"].Value + "','" + dgvItemUsed.Rows[i].Cells["OthBatch"].Value +
                        "','" + dgvItemUsed.Rows[i].Cells["OthQty"].Value + "','" + dgvItemUsed.Rows[i].Cells["OthQty"].Value +
                        "','.','" + txtProgramNo.Text.PadLeft(3, '0') + "/PRESSING','" + dtpPressEndDate.Value.ToString("dd/MM/yyyy") + "','L','" +
                        cmbPressingJobberName.SelectedValue + "','')");

                    strQueries.Add("Insert into [MfgItems]([PRODUCT],[BATCH],[QTY],[RATE],[AMOUNT],[PROGRAMNO],[TYPE]) values('" +
                         dgvItemUsed.Rows[i].Cells["OthProduct"].Value + "','" + dgvItemUsed.Rows[i].Cells["OthBatch"].Value +
                         "'," + dgvItemUsed.Rows[i].Cells["OthQty"].Value + "," + dgvItemUsed.Rows[i].Cells["OthRate"].Value +
                         "," + dgvItemUsed.Rows[i].Cells["OthAmount"].Value + ",'" + txtProgramNo.Text +
                         "','O')");

                    strQueries.Add("insert into MFG2(LINK,CODE,BATCHNO,QTY,AL,[DATE],DOCNO,JCODE) values('MR" +
      pressingReceiveLink + productCode + "PRESSING','" + dgvItemUsed.Rows[i].Cells["OthProduct"].Value + "','" +
      dgvItemUsed.Rows[i].Cells["OthBatch"].Value + "'," + dgvItemUsed.Rows[i].Cells["OthQty"].Value +
      ",'L','" + dtpPressEndDate.Value.ToString("dd/MM/yyyy") + "','" + txtProgramNo.Text.PadLeft(3, '0') +
      "/PRESSING'," + cmbPressingJobberName.SelectedValue + ")");
                }

                #endregion


                strQueries.Add("Insert into [MfgCycle]([PROGRAMNO],[STARTDATE],[ENDDATE],[PRODUCT],[LOTSIZE],[FINISHQTY],[CUTTER],[CSTARTDATE]," +
"[CENDDATE],[CISSUEQTY],[CRCVDQTY],[CCOSTPRPCS],[CTOTALAMT],[AMTRPTPCS],[COSTPRPCS],[FCOSTPRPCS],[OTHEPPRPCS],[WASHER],[WSTARTDATE]," +
"[WENDDATE],[WISSUEQTY],[WRCVDQTY],[WCOSTPRPCS],[WTOTALAMT],[PRESSER],[PSTARTDATE],[PENDDATE],[PISSUEQTY],[PRCVDQTY],[PCOSTPRPCS]," +
"[PTOTALAMT],[ENTRYDATE],[CRATE],[WRATE],[PRATE]) values('" + txtProgramNo.Text + "','" + dtpProgramStartDate.Value.ToString("yyyy-MM-dd") + "','" +
dtpWashingEndDate.Value.ToString("yyyy-MM-dd") + "','" + cmbFinishedProductName.SelectedValue + "'," + txtLotSize.Text + "," +
(string.IsNullOrEmpty(txtFinishedQty.Text) ? "0" : txtFinishedQty.Text) +
",'" + cmbCuttingJobberName.SelectedValue + "','" + dtpCuttingStartDate.Value.ToString("yyyy-MM-dd") + "','" + dtpCuttingEndDate.Value.ToString("yyyy-MM-dd") +
"'," + txtCuttingIssuedQty.Text + "," + (string.IsNullOrEmpty(txtCuttingReceivedQty.Text) ? "0" : txtCuttingReceivedQty.Text) +
"," + txtCuttingCostPerPcs.Text + "," + txtCuttingTotalAmount.Text +
"," + txtAverageMtrPerPcs.Text + "," + txtCostingPerPcs.Text + "," + txtFabricCostPerPcs.Text + "," + txtOthCostPrPcs.Text +
",'" + cmbWashingJobberName.SelectedValue + "','" + dtpWashingStartDate.Value.ToString("yyyy-MM-dd") + "','" + dtpWashingEndDate.Value.ToString("yyyy-MM-dd") +
"'," + (string.IsNullOrEmpty(txtWashingIssuedQty.Text) ? "0" : txtWashingIssuedQty.Text) + "," + (string.IsNullOrEmpty(txtWashingReceivedQty.Text) ? "0" : txtWashingReceivedQty.Text) +
"," + txtWashingCostPerPcs.Text + "," + txtWashingTotalAmount.Text +
",'" + cmbPressingJobberName.SelectedValue + "','" + dtpPressStartDate.Value.ToString("yyyy-MM-dd") + "','" + dtpPressEndDate.Value.ToString("yyyy-MM-dd") +
"'," + (string.IsNullOrEmpty(txtPressIssuedQty.Text) ? "0" : txtPressIssuedQty.Text) + "," + (string.IsNullOrEmpty(txtPressReceivedQty.Text) ? "0" : txtPressReceivedQty.Text) +
"," + txtPressingCostPerPcs.Text + "," + txtPressingTotalAmount.Text + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + txtCuttingRate.Text + ",'" + txtWashingRate.Text + "','" + txtPressingRate.Text + "')");

                for (var i = 0; i < dgvCuttingProcess.Rows.Count - 1; i++)
                {
                    strQueries.Add("Insert into [MfgTrans]([PROGRAMNO],[PROCESS],[JOBBER],[QTY],[RATE],[AMOUNT],[NARRATION],[ISSUEDATE]," +
"[RCVDDATE],[ISSUEDQTY],[RCVDQTY],[LINK]) values('" + txtProgramNo.Text + "','C','" + dgvCuttingProcess.Rows[i].Cells["CuttingJobberName"].Value +
"',0," + (string.IsNullOrEmpty(Convert.ToString(dgvCuttingProcess.Rows[i].Cells["CuttingRate"].Value)) ? "0" : dgvCuttingProcess.Rows[i].Cells["CuttingRate"].Value) +
"," + (string.IsNullOrEmpty(Convert.ToString(dgvCuttingProcess.Rows[i].Cells["CuttingAmount"].Value)) ? "0" : dgvCuttingProcess.Rows[i].Cells["CuttingAmount"].Value) +
",'" + dgvCuttingProcess.Rows[i].Cells["CuttingNarration"].Value +
"'," + (string.IsNullOrEmpty(Convert.ToString(dgvCuttingProcess.Rows[i].Cells["CuttingIssueDate"].Value)) ? "NULL" : "'" + dgvCuttingProcess.Rows[i].Cells["CuttingIssueDate"].Value + "'") +
"," + (string.IsNullOrEmpty(Convert.ToString(dgvCuttingProcess.Rows[i].Cells["CuttingReceivedDate"].Value)) ? "NULL" : "'" + dgvCuttingProcess.Rows[i].Cells["CuttingReceivedDate"].Value + "'") +
"," + (string.IsNullOrEmpty(Convert.ToString(dgvCuttingProcess.Rows[i].Cells["CuttingIssuedQty"].Value)) ? "0" : Convert.ToString(dgvCuttingProcess.Rows[i].Cells["CuttingIssuedQty"].Value)) +
"," + (string.IsNullOrEmpty(Convert.ToString(dgvCuttingProcess.Rows[i].Cells["CuttingReceivedQty"].Value)) ? "0" : Convert.ToString(dgvCuttingProcess.Rows[i].Cells["CuttingReceivedQty"].Value)) +
"," + (i + 1) + ")");
                }

                for (var i = 0; i < dgvWashingProcess.Rows.Count - 1; i++)
                {
                    strQueries.Add("Insert into [MfgTrans]([PROGRAMNO],[PROCESS],[JOBBER],[QTY],[RATE],[AMOUNT],[NARRATION],[ISSUEDATE]," +
"[RCVDDATE],[ISSUEDQTY],[RCVDQTY],[LINK]) values('" + txtProgramNo.Text + "','W','" + dgvWashingProcess.Rows[i].Cells["WashingJobberName"].Value +
"'," + dgvWashingProcess.Rows[i].Cells["WashingQty"].Value + "," + dgvWashingProcess.Rows[i].Cells["WashingRate"].Value +
"," + dgvWashingProcess.Rows[i].Cells["WashingAmount"].Value + ",'" + dgvWashingProcess.Rows[i].Cells["WashingNarration"].Value +
"',NULL,NULL,0,0," + (i + 1) + ")");
                }

                if (Operation.ExecuteTransaction(strQueries))
                {
                    MessageBox.Show("Data Saved Successfully.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAdd_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Error while saving, Please try after sometime.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private bool isFormValid()
        {
            if (string.IsNullOrEmpty(Convert.ToString(cmbFinishedProductName.SelectedValue)) || Convert.ToString(cmbFinishedProductName.SelectedValue) == "0")
            {
                MessageBox.Show("Please select proper finished product.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cmbFinishedProductName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtLotSize.Text))
            {
                MessageBox.Show("Please enter Lot Size.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtLotSize.Focus();
                return false;
            }
            if (dtpProgramFinishedDate.Checked && string.IsNullOrEmpty(txtFinishedQty.Text))
            {
                MessageBox.Show("Please enter finished qty.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtFinishedQty.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(Convert.ToString(cmbCuttingJobberName.SelectedValue)) || Convert.ToString(cmbCuttingJobberName.SelectedValue) == "0")
            {
                MessageBox.Show("Please select proper Cutting Jobber.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cmbCuttingJobberName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCuttingIssuedQty.Text))
            {
                MessageBox.Show("Please enter Cutter Issued Qty.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCuttingIssuedQty.Focus();
                return false;
            }
            if (dtpCuttingEndDate.Checked && string.IsNullOrEmpty(txtCuttingReceivedQty.Text))
            {
                MessageBox.Show("Please enter Cutter Received Qty.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCuttingReceivedQty.Focus();
                return false;
            }
            if (dtpCuttingEndDate.Checked && string.IsNullOrEmpty(txtCuttingRate.Text))
            {
                MessageBox.Show("Please enter Cutter Rate.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCuttingRate.Focus();
                return false;
            }
            if (dtpCuttingEndDate.Checked && string.IsNullOrEmpty(txtWashingIssuedQty.Text))
            {
                MessageBox.Show("Please enter Washing Issued Qty.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cmbFinishedProductName.Focus();
                return false;
            }
            if (dtpWashingEndDate.Checked && string.IsNullOrEmpty(txtWashingReceivedQty.Text))
            {
                MessageBox.Show("Please enter Washing Received Qty.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWashingReceivedQty.Focus();
                return false;
            }
            if (dtpWashingEndDate.Checked && string.IsNullOrEmpty(txtWashingRate.Text))
            {
                MessageBox.Show("Please enter Washing Received Rate.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtWashingRate.Focus();
                return false;
            }
            if (dtpWashingEndDate.Checked && string.IsNullOrEmpty(txtPressIssuedQty.Text))
            {
                MessageBox.Show("Please enter Pressing Issued Qty.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPressIssuedQty.Focus();
                return false;
            }
            if (dtpPressEndDate.Checked && string.IsNullOrEmpty(txtPressReceivedQty.Text))
            {
                MessageBox.Show("Please enter Press Received Qty.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPressReceivedQty.Focus();
                return false;
            }
            if (dtpPressEndDate.Checked && string.IsNullOrEmpty(txtPressingRate.Text))
            {
                MessageBox.Show("Please enter Press Received Rate.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtPressingRate.Focus();
                return false;
            }
            if (Convert.ToDecimal(txtLotSize.Text) < Convert.ToDecimal(txtCuttingIssuedQty.Text))
            {
                MessageBox.Show("You can not issue qty more then lot size to cutter.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCuttingIssuedQty.Focus();
                return false;
            }
            if (dgvCuttingProcess.Rows.Count > 1)
            {
                for (var i = 0; i < dgvCuttingProcess.Rows.Count - 1; i++)
                {
                    if (Convert.ToString(dgvCuttingProcess.Rows[i].Cells["CuttingJobberName"].Value) == "0")
                    {
                        MessageBox.Show("Jobber name can not be empty in cutting data in between.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        dgvCuttingProcess.CurrentCell = dgvCuttingProcess.Rows[i].Cells["CuttingJobberName"];
                        dgvCuttingProcess.Focus();
                        return false;
                    }
                    if (string.IsNullOrEmpty(Convert.ToString(dgvCuttingProcess.Rows[i].Cells["CuttingIssueDate"].Value)))
                    {
                        MessageBox.Show("Cutting issue date can not be empty in cutting data in between.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        dgvCuttingProcess.CurrentCell = dgvCuttingProcess.Rows[i].Cells["CuttingIssueDate"];
                        dgvCuttingProcess.Focus();
                        return false;
                    }
                    if (string.IsNullOrEmpty(Convert.ToString(dgvCuttingProcess.Rows[i].Cells["CuttingIssuedQty"].Value)))
                    {
                        MessageBox.Show("Cutting issue qty can not be empty in cutting data in between.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        dgvCuttingProcess.Focus();
                        return false;
                    }
                    if ((!string.IsNullOrEmpty(Convert.ToString(dgvCuttingProcess.Rows[i].Cells["CuttingReceivedDate"].Value)) && (
                        string.IsNullOrEmpty(Convert.ToString(dgvCuttingProcess.Rows[i].Cells["CuttingReceivedQty"].Value)) ||
                        string.IsNullOrEmpty(Convert.ToString(dgvCuttingProcess.Rows[i].Cells["CuttingRate"].Value)))))
                    {
                        MessageBox.Show("Cutting received date is entered, so you have to enter both qty and rate for cutting data.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        dgvCuttingProcess.Focus();
                        return false;
                    }
                    if (Convert.ToDecimal(Convert.ToString(dgvCuttingProcess.Rows[i].Cells["CuttingIssuedQty"].Value)) < Convert.ToDecimal(Convert.ToString(dgvCuttingProcess.Rows[i].Cells["CuttingReceivedQty"].Value)))
                    {
                        MessageBox.Show("Cutting received qty can not be more then issued qty.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        dgvCuttingProcess.Focus();
                        return false;
                    }
                }
            }
            if (dgvFabricUsed.Rows.Count > 1)
            {
                for (var i = 0; i < dgvFabricUsed.Rows.Count - 1; i++)
                {
                    if (Convert.ToString(dgvFabricUsed.Rows[i].Cells["ProductName"].Value) == "0")
                    {
                        MessageBox.Show("Product name can not be empty in fabric's collection.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        dgvFabricUsed.Focus();
                        return false;
                    }
                    if (string.IsNullOrEmpty(Convert.ToString(dgvFabricUsed.Rows[i].Cells["UsedMtr"].Value)))
                    {
                        MessageBox.Show("Used Mtr can not be empty in fabric's collection.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        dgvFabricUsed.Focus();
                        return false;
                    }
                    if (string.IsNullOrEmpty(Convert.ToString(dgvFabricUsed.Rows[i].Cells["Rate"].Value)))
                    {
                        MessageBox.Show("Rate can not be empty in fabric's collection.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        dgvFabricUsed.Focus();
                        return false;
                    }
                }
            }
            if (dgvWashingProcess.Rows.Count > 1)
            {
                for (var i = 0; i < dgvWashingProcess.Rows.Count - 1; i++)
                {
                    if (Convert.ToString(dgvWashingProcess.Rows[i].Cells["WashingJobberName"].Value) == "0")
                    {
                        MessageBox.Show("Jobber name can not be empty in washing data in between.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        dgvWashingProcess.Focus();
                        return false;
                    }
                    if (string.IsNullOrEmpty(Convert.ToString(dgvWashingProcess.Rows[i].Cells["WashingQty"].Value)))
                    {
                        MessageBox.Show("Washing qty can not be empty in washing data in between.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        dgvWashingProcess.Focus();
                        return false;
                    }
                    if (string.IsNullOrEmpty(Convert.ToString(dgvWashingProcess.Rows[i].Cells["WashingRate"].Value)))
                    {
                        MessageBox.Show("Washing rate can not be empty in washing data in between.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        dgvCuttingProcess.Focus();
                        return false;
                    }
                }
            }
            if (dgvPressingProcess.Rows.Count > 1)
            {
                for (var i = 0; i < dgvPressingProcess.Rows.Count - 1; i++)
                {
                    if (Convert.ToString(dgvPressingProcess.Rows[i].Cells["PressingJobber"].Value) == "0")
                    {
                        MessageBox.Show("Jobber name can not be empty in pressing data in between.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        dgvPressingProcess.Focus();
                        return false;
                    }
                    if (string.IsNullOrEmpty(Convert.ToString(dgvPressingProcess.Rows[i].Cells["PressingQty"].Value)))
                    {
                        MessageBox.Show("Pressing qty can not be empty in pressing data in between.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        dgvPressingProcess.Focus();
                        return false;
                    }
                    if (string.IsNullOrEmpty(Convert.ToString(dgvPressingProcess.Rows[i].Cells["PressingRate"].Value)))
                    {
                        MessageBox.Show("Pressing rate can not be empty in pressing data in between.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        dgvPressingProcess.Focus();
                        return false;
                    }
                }
            }
            if (dgvItemUsed.Rows.Count > 1)
            {
                for (var i = 0; i < dgvItemUsed.Rows.Count - 1; i++)
                {
                    if (Convert.ToString(dgvItemUsed.Rows[i].Cells["OthProduct"].Value) == "0")
                    {
                        MessageBox.Show("Product name can not be empty in items's collection.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        dgvItemUsed.Focus();
                        return false;
                    }
                    if (string.IsNullOrEmpty(Convert.ToString(dgvItemUsed.Rows[i].Cells["OthQty"].Value)))
                    {
                        MessageBox.Show("Qty can not be empty in items's collection.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        dgvItemUsed.Focus();
                        return false;
                    }
                    if (string.IsNullOrEmpty(Convert.ToString(dgvItemUsed.Rows[i].Cells["OthRate"].Value)))
                    {
                        MessageBox.Show("Rate can not be empty in item's collection.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        dgvItemUsed.Focus();
                        return false;
                    }
                }
            }
            return true;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmSearch view = new frmSearch();
            Operation.gViewQuery = "select * from MfgCycle";
            Operation.Bindgrid(Operation.gViewQuery, view.dgvSearch);
            view.dgvSearch.Columns[0].Visible = false;
            view.OrderByColoumn = "ProgramNo";
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
            var dtMain = Operation.GetDataTable("select * from MfgCycle where ProgramNo='" + Operation.ViewID + "'");
            var dtTrans = Operation.GetDataTable("select * from MfgTrans where ProgramNo='" + Operation.ViewID + "'");
            var dtItems = Operation.GetDataTable("select * from MfgItems where ProgramNo='" + Operation.ViewID + "'");

            if (dtMain != null && dtMain.Rows.Count > 0)
            {
                lblId.Text = "U";
                txtProgramNo.Text = dtMain.Rows[0]["ProgramNo"].ToString();
                dtpProgramStartDate.Value = Convert.ToDateTime(dtMain.Rows[0]["StartDate"].ToString());
                dtpProgramFinishedDate.MinDate = dtpProgramStartDate.Value;
                if (string.IsNullOrEmpty(Convert.ToString(dtMain.Rows[0]["EndDate"])))
                {
                    dtpProgramFinishedDate.Checked = false;
                }
                else
                {
                    dtpProgramFinishedDate.Checked = true;
                    dtpProgramFinishedDate.Value = Convert.ToDateTime(dtMain.Rows[0]["EndDate"].ToString());
                }
                cmbFinishedProductName.SelectedValue = Convert.ToString(dtMain.Rows[0]["Product"]);
                txtLotSize.Text = Convert.ToString(dtMain.Rows[0]["LotSize"]);
                txtFinishedQty.Text = Convert.ToString(dtMain.Rows[0]["FinishQty"]);
                cmbCuttingJobberName.SelectedValue = Convert.ToString(dtMain.Rows[0]["Cutter"]);
                dtpCuttingStartDate.Value = Convert.ToDateTime(dtMain.Rows[0]["CStartDate"].ToString());
                if (string.IsNullOrEmpty(Convert.ToString(dtMain.Rows[0]["CEndDate"])))
                {
                    dtpCuttingEndDate.Checked = false;
                    txtCuttingReceivedQty.Text = "0";
                    txtCuttingRate.Text = "0";
                }
                else
                {
                    dtpCuttingEndDate.Checked = true;
                    dtpCuttingEndDate.Value = Convert.ToDateTime(dtMain.Rows[0]["CEndDate"].ToString());
                    dtpCuttingEndDate_Validated(null, null);
                    txtCuttingReceivedQty.Text = Convert.ToString(dtMain.Rows[0]["CRcvdQty"]);
                    txtCuttingRate.Text = Convert.ToString(dtMain.Rows[0]["CRATE"]);
                }
                txtCuttingIssuedQty.Text = Convert.ToString(dtMain.Rows[0]["CIssueQty"]);

                txtCuttingCostPerPcs.Text = Convert.ToString(dtMain.Rows[0]["CCostPrPcs"]);
                txtCuttingTotalAmount.Text = Convert.ToString(dtMain.Rows[0]["CTotalAmt"]);
                txtAverageMtrPerPcs.Text = Convert.ToString(dtMain.Rows[0]["AMTRPTPCS"]);
                txtCostingPerPcs.Text = Convert.ToString(dtMain.Rows[0]["COSTPRPCS"]);
                txtFabricCostPerPcs.Text = Convert.ToString(dtMain.Rows[0]["FCOSTPRPCS"]);
                txtOthCostPrPcs.Text = Convert.ToString(dtMain.Rows[0]["OTHEPPRPCS"]);
                cmbWashingJobberName.SelectedValue = Convert.ToString(dtMain.Rows[0]["WASHER"]);
                if (!string.IsNullOrEmpty(Convert.ToString(dtMain.Rows[0]["WSTARTDATE"])))
                {
                    dtpProgramStartDate.Value = Convert.ToDateTime(Convert.ToString(dtMain.Rows[0]["WSTARTDATE"]));
                }
                if (string.IsNullOrEmpty(Convert.ToString(dtMain.Rows[0]["WENDDATE"])))
                {
                    dtpWashingEndDate.Checked = false;
                    txtWashingReceivedQty.Text = "0";
                    txtWashingRate.Text = "0";
                }
                else
                {
                    dtpWashingEndDate.Checked = true;
                    dtpWashingEndDate.Value = Convert.ToDateTime(Convert.ToString(dtMain.Rows[0]["WENDDATE"]));
                    dtpWashingEndDate_Validated(null, null);
                    txtWashingReceivedQty.Text = Convert.ToString(dtMain.Rows[0]["WRCVDQTY"]);
                    txtWashingRate.Text = Convert.ToString(dtMain.Rows[0]["WRATE"]);
                }
                txtWashingIssuedQty.Text = Convert.ToString(dtMain.Rows[0]["WISSUEQTY"]);
                txtWashingCostPerPcs.Text = Convert.ToString(dtMain.Rows[0]["WCOSTPRPCS"]);
                txtWashingTotalAmount.Text = Convert.ToString(dtMain.Rows[0]["WTOTALAMT"]);
                cmbPressingJobberName.SelectedValue = Convert.ToString(dtMain.Rows[0]["PRESSER"]);
                if (!string.IsNullOrEmpty(Convert.ToString(dtMain.Rows[0]["PSTARTDATE"])))
                {
                    dtpPressStartDate.Value = Convert.ToDateTime(Convert.ToString(dtMain.Rows[0]["PSTARTDATE"]));
                }
                if (string.IsNullOrEmpty(Convert.ToString(dtMain.Rows[0]["PENDDATE"])))
                {
                    dtpPressEndDate.Checked = false;
                    txtPressReceivedQty.Text = "0";
                    txtPressingRate.Text = "0";
                }
                else
                {
                    dtpPressEndDate.Checked = true;
                    dtpPressEndDate.Value = Convert.ToDateTime(Convert.ToString(dtMain.Rows[0]["PENDDATE"]));
                    dtpPressEndDate_Validated(null, null);
                    txtPressReceivedQty.Text = Convert.ToString(dtMain.Rows[0]["PRCVDQTY"]);
                    txtPressingRate.Text = Convert.ToString(dtMain.Rows[0]["PRATE"]);
                }
                txtPressIssuedQty.Text = Convert.ToString(dtMain.Rows[0]["PISSUEQTY"]);
                txtPressingCostPerPcs.Text = Convert.ToString(dtMain.Rows[0]["PCOSTPRPCS"]);
                txtPressingTotalAmount.Text = Convert.ToString(dtMain.Rows[0]["PTOTALAMT"]);
                lblExpertLinks.Text = Convert.ToString(dtMain.Rows[0]["CRCVLINK"]) + "," + Convert.ToString(dtMain.Rows[0]["WISSUELINK"]) + "," + Convert.ToString(dtMain.Rows[0]["WRCVLINK"]) + "," + Convert.ToString(dtMain.Rows[0]["PISSUELINK"]) + "," + Convert.ToString(dtMain.Rows[0]["PRCVLINK"]);
            }
            if (dtTrans.Rows.Count > 0)
            {
                dtTrans.DefaultView.RowFilter = "Process='C'";
                var cuttingRecs = dtTrans.DefaultView.ToTable();
                dgvCuttingProcess.Rows.Clear();
                dgvCuttingProcess.AllowUserToAddRows = false;
                for (var i = 0; i < cuttingRecs.Rows.Count; i++)
                {
                    dgvCuttingProcess.Rows.Add();
                    dgvCuttingProcess.Rows[dgvCuttingProcess.Rows.Count - 1].Cells["CuttingJobberName"].Value = cuttingRecs.Rows[i]["Jobber"].ToString();
                    dgvCuttingProcess.Rows[dgvCuttingProcess.Rows.Count - 1].Cells["CuttingRate"].Value = cuttingRecs.Rows[i]["Rate"].ToString();
                    dgvCuttingProcess.Rows[dgvCuttingProcess.Rows.Count - 1].Cells["CuttingIssueDate"].Value = Convert.ToDateTime(Convert.ToString(cuttingRecs.Rows[i]["IssueDate"])).ToString("dd/MM/yyyy");
                    dgvCuttingProcess.Rows[dgvCuttingProcess.Rows.Count - 1].Cells["CuttingReceivedDate"].Value = Convert.ToDateTime(Convert.ToString(cuttingRecs.Rows[i]["RCVDDATE"])).ToString("dd/MM/yyyy");
                    dgvCuttingProcess.Rows[dgvCuttingProcess.Rows.Count - 1].Cells["CuttingIssuedQty"].Value = cuttingRecs.Rows[i]["ISSUEDQTY"].ToString();
                    dgvCuttingProcess.Rows[dgvCuttingProcess.Rows.Count - 1].Cells["CuttingReceivedQty"].Value = cuttingRecs.Rows[i]["RCVDQTY"].ToString();
                    dgvCuttingProcess.Rows[dgvCuttingProcess.Rows.Count - 1].Cells["CuttingNarration"].Value = cuttingRecs.Rows[i]["NARRATION"].ToString();
                }
                dgvCuttingProcess.AllowUserToAddRows = true;
                dtTrans.DefaultView.RowFilter = "Process='W'";
                var washingRecs = dtTrans.DefaultView.ToTable();
                dgvWashingProcess.Rows.Clear();
                dgvWashingProcess.AllowUserToAddRows = false;
                for (var i = 0; i < washingRecs.Rows.Count; i++)
                {
                    dgvWashingProcess.Rows.Add();
                    dgvWashingProcess.Rows[dgvWashingProcess.Rows.Count - 1].Cells["WashingJobberName"].Value = washingRecs.Rows[i]["Jobber"].ToString();
                    dgvWashingProcess.Rows[dgvWashingProcess.Rows.Count - 1].Cells["WashingQty"].Value = washingRecs.Rows[i]["Qty"].ToString();
                    dgvWashingProcess.Rows[dgvWashingProcess.Rows.Count - 1].Cells["WashingRate"].Value = washingRecs.Rows[i]["Rate"].ToString();
                    dgvWashingProcess.Rows[dgvWashingProcess.Rows.Count - 1].Cells["WashingNarration"].Value = washingRecs.Rows[i]["NARRATION"].ToString();
                }
                dgvWashingProcess.AllowUserToAddRows = true;
                dtTrans.DefaultView.RowFilter = "Process='P'";
                var pressingRecs = dtTrans.DefaultView.ToTable();
                dgvPressingProcess.Rows.Clear();
                dgvPressingProcess.AllowUserToAddRows = false;
                for (var i = 0; i < pressingRecs.Rows.Count; i++)
                {
                    dgvPressingProcess.Rows.Add();
                    dgvPressingProcess.Rows[dgvPressingProcess.Rows.Count - 1].Cells["PressingJobber"].Value = pressingRecs.Rows[i]["Jobber"].ToString();
                    dgvPressingProcess.Rows[dgvPressingProcess.Rows.Count - 1].Cells["PressingQty"].Value = pressingRecs.Rows[i]["Qty"].ToString();
                    dgvPressingProcess.Rows[dgvPressingProcess.Rows.Count - 1].Cells["PressingRate"].Value = pressingRecs.Rows[i]["Rate"].ToString();
                    dgvPressingProcess.Rows[dgvPressingProcess.Rows.Count - 1].Cells["PressingNarr"].Value = pressingRecs.Rows[i]["NARRATION"].ToString();
                }
                dgvPressingProcess.AllowUserToAddRows = true;
            }
            if (dtItems.Rows.Count > 0)
            {
                dtItems.DefaultView.RowFilter = "Type='O'";
                var otherRecs = dtItems.DefaultView.ToTable();
                dgvItemUsed.Rows.Clear();
                dgvItemUsed.AllowUserToAddRows = false;
                for (var i = 0; i < otherRecs.Rows.Count; i++)
                {
                    dgvItemUsed.Rows.Add();
                    dgvItemUsed.Rows[dgvItemUsed.Rows.Count - 1].Cells["OthProduct"].Value = otherRecs.Rows[i]["Product"].ToString();
                    dgvItemUsed.Rows[dgvItemUsed.Rows.Count - 1].Cells["OthBatch"].Value = otherRecs.Rows[i]["Batch"].ToString();
                    dgvItemUsed.Rows[dgvItemUsed.Rows.Count - 1].Cells["OthQty"].Value = otherRecs.Rows[i]["Qty"].ToString();
                    dgvItemUsed.Rows[dgvItemUsed.Rows.Count - 1].Cells["OthRate"].Value = otherRecs.Rows[i]["Rate"].ToString();
                }
                dgvItemUsed.AllowUserToAddRows = true;
                dtItems.DefaultView.RowFilter = "Type='F'";
                var fabricRecs = dtItems.DefaultView.ToTable();
                dgvFabricUsed.Rows.Clear();
                dgvFabricUsed.AllowUserToAddRows = false;
                for (var i = 0; i < fabricRecs.Rows.Count; i++)
                {
                    dgvFabricUsed.Rows.Add();
                    dgvFabricUsed.Rows[dgvFabricUsed.Rows.Count - 1].Cells["ProductName"].Value = fabricRecs.Rows[i]["Product"].ToString();
                    dgvFabricUsed.Rows[dgvFabricUsed.Rows.Count - 1].Cells["BatchNo"].Value = fabricRecs.Rows[i]["Batch"].ToString();
                    dgvFabricUsed.Rows[dgvFabricUsed.Rows.Count - 1].Cells["UsedMtr"].Value = fabricRecs.Rows[i]["Qty"].ToString();
                    dgvFabricUsed.Rows[dgvFabricUsed.Rows.Count - 1].Cells["Rate"].Value = fabricRecs.Rows[i]["Rate"].ToString();
                }
                dgvFabricUsed.AllowUserToAddRows = true;
            }
        }
        string prevCutterValue = "";
        private void cmbCuttingJobberName_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(prevCutterValue))
            {
                if (!string.IsNullOrEmpty(Convert.ToString(cmbCuttingJobberName.SelectedValue)) && dgvFabricUsed.Rows.Count > 1)
                {
                    if (MessageBox.Show("Fabric information will be deleted if cutter is going to be changed, Are you sure want to continue?", Operation.MsgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dgvFabricUsed.Rows.Clear();
                        dgvFabricUsed_RowsAdded(null, null);
                        prevCutterValue = Convert.ToString(cmbCuttingJobberName.SelectedValue);
                    }
                    else
                    {
                        cmbCuttingJobberName.SelectedValue = prevCutterValue;
                    }
                }
                else
                {
                    dgvFabricUsed.Rows.Clear();
                    dgvFabricUsed_RowsAdded(null, null);
                    prevCutterValue = Convert.ToString(cmbCuttingJobberName.SelectedValue);
                }
            }
            else
            {
                dgvFabricUsed.Rows.Clear();
                dgvFabricUsed_RowsAdded(null, null);
                prevCutterValue = Convert.ToString(cmbCuttingJobberName.SelectedValue);
            }
        }

        private void dgvCuttingProcess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete &&
               dgvCuttingProcess.CurrentCell != null &&
               dgvCuttingProcess.CurrentCell.RowIndex >= 0 &&
               dgvCuttingProcess.CurrentCell.ColumnIndex >= 0 &&
               MessageBox.Show("Are you sure want to delete this Record?", Operation.MsgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvCuttingProcess.Rows.RemoveAt(dgvCuttingProcess.CurrentCell.RowIndex);
                CalculateTotals();
            }
        }

        private void cmbWashingJobberName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(cmbWashingJobberName.SelectedIndex)) && cmbWashingJobberName.SelectedIndex != cmbWashingJobberName.Items.Count - 1)
            {
                dtpCuttingEndDate.Enabled = false;
            }
            else
            {
                dtpCuttingEndDate.Enabled = true;
            }
        }
    }
}

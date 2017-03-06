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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dtMain = Operation.GetDataTable("select IIF(ISNULL(MAX(INT(ProgramNo))), 1,MAX(INT(ProgramNo))+1) as NewProgramNo from MfgCycle");
            if (dtMain != null && dtMain.Rows.Count > 0)
            {
                txtProgramNo.Text = Convert.ToString(dtMain.Rows[0]["NewProgramNo"]);
            }
            dtpProgramStartDate.Value = dtpProgramFinishedDate.Value = DateTime.Now;
            dtpProgramFinishedDate.Checked = false;
            Operation.BindGridComboBox(dgvFabricUsed, 0, 1, (DataGridViewComboBoxCell)dgvFabricUsed.Rows[0].Cells[1], "select Code,Name from Product", "Name", "Code", "-- Select Product--");
            Operation.BindGridComboBox(dgvItemUsed, 0, 1, (DataGridViewComboBoxCell)dgvItemUsed.Rows[0].Cells[1], "select Code,Name from Product", "Name", "Code", "-- Select Product --");
            Operation.BindGridComboBox(dgvCuttingProcess, 0, 0, (DataGridViewComboBoxCell)dgvCuttingProcess.Rows[0].Cells[0], "select Code,Name from Jobber WHERE UCASE(LEFT(REMARKS,1))='E' OR UCASE(LEFT(REMARKS,1))='R'", "Name", "Code", "-- Select Cutter Jobber --");
            Operation.BindGridComboBox(dgvWashingProcess, 0, 0, (DataGridViewComboBoxCell)dgvWashingProcess.Rows[0].Cells[0], "select Code,Name from Jobber WHERE UCASE(LEFT(REMARKS,1))='W'", "Name", "Code", "-- Select Washing Jobber --");
            Operation.BindGridComboBox(dgvPressingProcess, 0, 0, (DataGridViewComboBoxCell)dgvPressingProcess.Rows[0].Cells[0], "select Code,Name from Jobber WHERE UCASE(LEFT(REMARKS,1))='P'", "Name", "Code", "-- Select Pressing Jobber --");
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
            CalculateTotals();
        }

        private void frmMfgCycle_Load(object sender, EventArgs e)
        {
            btnAdd_Click(null, null);
            this.WindowState = FormWindowState.Maximized;
        }

        private void dgvCuttingProcess_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Operation.BindGridComboBox(dgvCuttingProcess, dgvCuttingProcess.Rows.Count - 1, 0, (DataGridViewComboBoxCell)dgvCuttingProcess.Rows[dgvCuttingProcess.Rows.Count - 1].Cells[0], "select Code,Name from Jobber WHERE UCASE(LEFT(REMARKS,1))='C'", "Name", "Code", "-- Select --");
        }

        private void dgvFabricUsed_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Operation.BindGridComboBox(dgvFabricUsed, dgvFabricUsed.Rows.Count - 1, 1, (DataGridViewComboBoxCell)dgvFabricUsed.Rows[dgvFabricUsed.Rows.Count - 1].Cells[1], "select Code,Name from Product", "Name", "Code", "-- Select --");
            dgvFabricUsed.Rows[dgvFabricUsed.Rows.Count - 1].Cells[0].Value = dgvFabricUsed.Rows.Count;
        }

        private void dgvWashingProcess_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Operation.BindGridComboBox(dgvWashingProcess, dgvWashingProcess.Rows.Count - 1, 0, (DataGridViewComboBoxCell)dgvWashingProcess.Rows[dgvWashingProcess.Rows.Count - 1].Cells[0], "select Code,Name from Jobber WHERE UCASE(LEFT(REMARKS,1))='W'", "Name", "Code", "-- Select --");
        }

        private void dgvPressingProcess_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Operation.BindGridComboBox(dgvPressingProcess, dgvPressingProcess.Rows.Count - 1, 0, (DataGridViewComboBoxCell)dgvPressingProcess.Rows[dgvPressingProcess.Rows.Count - 1].Cells[0], "select Code,Name from Jobber WHERE UCASE(LEFT(REMARKS,1))='P'", "Name", "Code", "-- Select --");
        }

        private void dgvItemUsed_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Operation.BindGridComboBox(dgvItemUsed, dgvItemUsed.Rows.Count - 1, 1, (DataGridViewComboBoxCell)dgvItemUsed.Rows[dgvItemUsed.Rows.Count - 1].Cells[1], "select Code,Name from Product", "Name", "Code", "-- Select --");
            dgvItemUsed.Rows[dgvItemUsed.Rows.Count - 1].Cells[0].Value = dgvItemUsed.Rows.Count;
        }

        private void dgvCuttingProcess_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvCuttingProcess.Columns[dgvCuttingProcess.CurrentCell.ColumnIndex].Name.ToUpper() == "CUTTINGISSUEDATE" || dgvCuttingProcess.Columns[dgvCuttingProcess.CurrentCell.ColumnIndex].Name.ToUpper() == "CUTTINGRECEIVEDDATE")
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
                dgvCuttingProcess.BeginEdit(true);
            }
        }

        private void dtpCuttingEndDate_Validated(object sender, EventArgs e)
        {
            ((Control)tabProcess.TabPages[1]).Enabled = ((Control)tabProcess.TabPages[2]).Enabled = ((Control)tabProcess.TabPages[3]).Enabled = dtpCuttingEndDate.Checked;
            //if (dtpCuttingEndDate.Checked && dtpCuttingEndDate.Value < dtpCuttingStartDate.Value)
            //{
            //    MessageBox.Show("End Date can not be less then Start date.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    dtpCuttingEndDate.Focus();
            //    return;
            //}
        }

        private void dtpWashingEndDate_Validated(object sender, EventArgs e)
        {
            ((Control)tabProcess.TabPages[2]).Enabled = ((Control)tabProcess.TabPages[3]).Enabled = dtpWashingEndDate.Checked;
            //if (dtpWashingEndDate.Checked && dtpWashingEndDate.Value < dtpWashingStartDate.Value)
            //{
            //    MessageBox.Show("End Date can not be less then Start date.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    dtpWashingEndDate.Focus();
            //    return;
            //}
        }

        private void dtpPressEndDate_Validated(object sender, EventArgs e)
        {
            ((Control)tabProcess.TabPages[3]).Enabled = dtpPressEndDate.Checked;
            //if (dtpPressEndDate.Checked && dtpPressEndDate.Value < dtpPressStartDate.Value)
            //{
            //    MessageBox.Show("End Date can not be less then Start date.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    dtpPressEndDate.Focus();
            //    return;
            //}
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
            if (!string.IsNullOrEmpty(txtPressIssuedQty.Text) && Convert.ToDecimal(txtPressReceivedQty.Text) < Convert.ToDecimal(txtPressIssuedQty.Text))
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
            //if (dtpProgramFinishedDate.Checked && dtpProgramFinishedDate.Value < dtpProgramStartDate.Value)
            //{
            //    MessageBox.Show("Finished Date can not be less then start date.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    dtpProgramFinishedDate.Focus();
            //    return;
            //}
        }

        private void dtpProgramFinishedDate_Validated(object sender, EventArgs e)
        {
            //if (dtpProgramFinishedDate.Checked && dtpProgramFinishedDate.Value < dtpProgramStartDate.Value)
            //{
            //    MessageBox.Show("Finished Date can not be less then start date.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    dtpProgramFinishedDate.Focus();
            //    return;
            //}
        }

        private void dtpWashingStartDate_Validated(object sender, EventArgs e)
        {
            dtpWashingEndDate.MinDate = dtpWashingStartDate.Value;
            //if (dtpWashingEndDate.Checked && dtpWashingEndDate.Value < dtpWashingStartDate.Value)
            //{
            //    MessageBox.Show("End Date can not be less then Start date.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    dtpWashingEndDate.Focus();
            //    return;
            //}
        }

        private void dtpCuttingStartDate_Validated(object sender, EventArgs e)
        {
            var prevChecked = dtpCuttingEndDate.Checked;
            dtpCuttingEndDate.MinDate = dtpCuttingStartDate.Value;
            dtpCuttingEndDate.Checked = prevChecked;
            //if (dtpCuttingEndDate.Checked && dtpCuttingEndDate.Value < dtpCuttingStartDate.Value)
            //{
            //    MessageBox.Show("End Date can not be less then Start date.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    dtpCuttingEndDate.Focus();
            //    return;
            //}
        }

        private void dtpPressStartDate_Validated(object sender, EventArgs e)
        {
            dtpPressEndDate.MinDate = dtpPressStartDate.Value;
            //if (dtpPressEndDate.Checked && dtpPressEndDate.Value < dtpPressStartDate.Value)
            //{
            //    MessageBox.Show("End Date can not be less then Start date.", Operation.MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    dtpPressEndDate.Focus();
            //    return;
            //}
        }

        private void txtLotSize_Validated(object sender, EventArgs e)
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
            if (dgvFabricUsed.Columns[e.ColumnIndex].Name.ToUpper() == "PRODUCTNAME")
            {
                Operation.BindGridComboBox(dgvFabricUsed, e.RowIndex, dgvFabricUsed.Columns["BatchNo"].Index, (DataGridViewComboBoxCell)dgvFabricUsed.Rows[e.RowIndex].Cells["BatchNo"], "select * from Batch where Code = '" + dgvFabricUsed.Rows[e.RowIndex].Cells[e.ColumnIndex].Value + "'", "Name", "Code", "-- Select Batch --");
            }
            CalculateTotals();
        }

        private void dgvItemUsed_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItemUsed.Columns[e.ColumnIndex].Name.ToUpper() == "OTHPRODUCT")
            {
                Operation.BindGridComboBox(dgvItemUsed, e.RowIndex, dgvItemUsed.Columns["OTHBATCH"].Index, (DataGridViewComboBoxCell)dgvItemUsed.Rows[e.RowIndex].Cells["OTHBATCH"], "select * from Batch where Code = '" + dgvItemUsed.Rows[e.RowIndex].Cells[e.ColumnIndex].Value + "'", "Name", "Code", "-- Select Batch --");
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
            cuttingCostPrPcs = string.IsNullOrEmpty(txtCuttingReceivedQty.Text) ? 0 : cuttingGrandTotal / Convert.ToDecimal(txtCuttingReceivedQty.Text);
            txtCuttingCostPerPcs.Text = Convert.ToString(Math.Round(cuttingCostPrPcs, 2));
            txtAverageMtrPerPcs.Text = Convert.ToString(Math.Round(string.IsNullOrEmpty(txtCuttingReceivedQty.Text) ? 0 : usedMtrPrPcs / Convert.ToDecimal(txtCuttingReceivedQty.Text), 2));
            txtFabricCostPerPcs.Text = Convert.ToString(Math.Round(string.IsNullOrEmpty(txtCuttingReceivedQty.Text) ? 0 : fabricGrandAmount / Convert.ToDecimal(txtCuttingReceivedQty.Text), 2));

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
            txtOtherExpsPerPcs.Text = Convert.ToString(string.IsNullOrEmpty(txtFinishedQty.Text) ? 0 : otherGrandAmount / Convert.ToDecimal(txtFinishedQty.Text));
            txtOthTotalAmount.Text = Convert.ToString(Math.Round(otherGrandTotal, 2));
            txtOthCostPrPcs.Text = Convert.ToString(Math.Round(otherCostPrPcs, 2));

            txtCostingPerPcs.Text = Convert.ToString(Math.Round(string.IsNullOrEmpty(txtFinishedQty.Text) ? 0 : (cuttingGrandTotal + washingGrandTotal + pressingGrandTotal + otherGrandAmount) / Convert.ToDecimal(txtFinishedQty.Text), 2));
        }

        private void txtCuttingRate_Validated(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void dgvCuttingProcess_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
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
                List<string> strQueries = new List<string>();
                if (lblId.Text == "I")
                {
                    strQueries.Add("Insert into [MfgCycle]([PROGRAMNO],[STARTDATE],[ENDDATE],[PRODUCT],[LOTSIZE],[FINISHQTY],[CUTTER],[CSTARTDATE]," +
    "[CENDDATE],[CISSUEQTY],[CRCVDQTY],[CCOSTPRPCS],[CTOTALAMT],[AMTRPTPCS],[COSTPRPCS],[FCOSTPRPCS],[OTHEPPRPCS],[WASHER],[WSTARTDATE]," +
    "[WENDDATE],[WISSUEQTY],[WRCVDQTY],[WCOSTPRPCS],[WTOTALAMT],[PRESSER],[PSTARTDATE],[PENDDATE],[PISSUEQTY],[PRCVDQTY],[PCOSTPRPCS]," +
    "[PTOTALAMT],[ENTRYDATE]) values('" + txtProgramNo.Text + "','" + dtpProgramStartDate.Value.ToString("yyyy-MM-dd") + "','" +
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
    "," + txtPressingCostPerPcs.Text + "," + txtPressingTotalAmount.Text + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "')");

                    for (var i = 0; i < dgvCuttingProcess.Rows.Count - 2; i++)
                    {
                        strQueries.Add("Insert into [MfgCycle2]([PROGRAMNO],[PROCESS],[JOBBER],[QTY],[RATE],[AMOUNT],[NARRATION],[ISSUEDATE]," +
"[RCVDDATE],[ISSUEDQTY],[RCVDQTY],[LINK]) values('" + txtProgramNo.Text + "','C','" + dgvCuttingProcess.Rows[i].Cells["CuttingJobberName"].Value +
"','','','" + dgvCuttingProcess.Rows[i].Cells["CuttingAmount"].Value + "','" + dgvCuttingProcess.Rows[i].Cells["CuttingNarration"].Value +
"','" + dgvCuttingProcess.Rows[i].Cells["CuttingIssuedDate"].Value + "','" + dgvCuttingProcess.Rows[i].Cells["CuttingReceivedDate"].Value +
"','" + dgvCuttingProcess.Rows[i].Cells["CuttingIssuedQty"].Value + "','" + dgvCuttingProcess.Rows[i].Cells["CuttingReceivedQty"].Value +
"','" + (i + 1) + "')");
                    }

                    for (var i = 0; i < dgvWashingProcess.Rows.Count - 2; i++)
                    {
                        strQueries.Add("Insert into [MfgCycle2]([PROGRAMNO],[PROCESS],[JOBBER],[QTY],[RATE],[AMOUNT],[NARRATION],[ISSUEDATE]," +
"[RCVDDATE],[ISSUEDQTY],[RCVDQTY],[LINK]) values('" + txtProgramNo.Text + "','W','" + dgvWashingProcess.Rows[i].Cells["WashingJobberName"].Value +
"','" + dgvWashingProcess.Rows[i].Cells["WashingQty"].Value + "','" + dgvWashingProcess.Rows[i].Cells["WashingRate"].Value +
"','" + dgvWashingProcess.Rows[i].Cells["WashingAmount"].Value + "','" + dgvWashingProcess.Rows[i].Cells["WashingNarration"].Value +
"','','','','','" + (i + 1) + "')");
                    }

                    for (var i = 0; i < dgvPressingProcess.Rows.Count - 2; i++)
                    {
                        strQueries.Add("Insert into [MfgCycle2]([PROGRAMNO],[PROCESS],[JOBBER],[QTY],[RATE],[AMOUNT],[NARRATION],[ISSUEDATE]," +
"[RCVDDATE],[ISSUEDQTY],[RCVDQTY],[LINK]) values('" + txtProgramNo.Text + "','P','" + dgvPressingProcess.Rows[i].Cells["PressingJobberName"].Value +
"','" + dgvPressingProcess.Rows[i].Cells["PressingQty"].Value + "','" + dgvPressingProcess.Rows[i].Cells["PressingRate"].Value +
"','" + dgvPressingProcess.Rows[i].Cells["PressingAmount"].Value + "','" + dgvPressingProcess.Rows[i].Cells["PressingNarration"].Value +
"','','','','','" + (i + 1) + "')");
                    }

                    for (var i = 0; i < dgvItemUsed.Rows.Count - 2; i++)
                    {
                        strQueries.Add("Insert into [MfgCycle3]([PRODUCT],[BATCH],[QTY],[RATE],[AMOUNT],[PROGRAMNO],[TYPE]) values('" +
                             dgvItemUsed.Rows[i].Cells["OthProduct"].Value + "','" + dgvItemUsed.Rows[i].Cells["OthBatch"].Value +
                             "','" + dgvItemUsed.Rows[i].Cells["OthQty"].Value + "','" + dgvItemUsed.Rows[i].Cells["OthRate"].Value +
                             "','" + dgvItemUsed.Rows[i].Cells["OthAmount"].Value + "','" + txtProgramNo.Text +
                             "','O')");
                    }

                    for (var i = 0; i < dgvFabricUsed.Rows.Count - 2; i++)
                    {
                        strQueries.Add("Insert into [MfgCycle3]([PRODUCT],[BATCH],[QTY],[RATE],[AMOUNT],[PROGRAMNO],[TYPE]) values('" +
                             dgvItemUsed.Rows[i].Cells["ProductName"].Value + "','" + dgvItemUsed.Rows[i].Cells["BatchNo"].Value +
                             "','" + dgvItemUsed.Rows[i].Cells["Qty"].Value + "','" + dgvItemUsed.Rows[i].Cells["Rate"].Value +
                             "','" + dgvItemUsed.Rows[i].Cells["Amount"].Value + "','" + txtProgramNo.Text +
                             "','F')");
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
            return true;
        }
    }
}

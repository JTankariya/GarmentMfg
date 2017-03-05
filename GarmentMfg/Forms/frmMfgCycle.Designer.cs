namespace GarmentMfg.Forms
{
    partial class frmMfgCycle
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
            this.btnView = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpProductIssueDate = new System.Windows.Forms.DateTimePicker();
            this.txtProgramNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dtpProgramFinishedDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpFabricIssued = new System.Windows.Forms.TabPage();
            this.tpUsedItems = new System.Windows.Forms.TabPage();
            this.tpCuttingProcess = new System.Windows.Forms.TabPage();
            this.tpPressProcess = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFinishedProductName = new System.Windows.Forms.ComboBox();
            this.txtFinishedQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAverageMtrPerPcs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCostingPerPcs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFabricCostPerPcs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOtherExpsPerPcs = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvFabricUsed = new System.Windows.Forms.DataGridView();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BatchNo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UsedMtr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItemUsed = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCuttingProcess = new System.Windows.Forms.DataGridView();
            this.dtpCuttingEndDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpCuttingStartDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCuttingIssuedQty = new System.Windows.Forms.TextBox();
            this.txtCuttingReceivedQty = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCuttingTotalAmount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCuttingCostPerPcs = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtLotSize = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.cmbCuttingJobberName = new System.Windows.Forms.ComboBox();
            this.tpWashingProcess = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbWashingJobberName = new System.Windows.Forms.ComboBox();
            this.txtWashingCostPerPcs = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtWashingTotalAmount = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtWashingReceivedQty = new System.Windows.Forms.TextBox();
            this.txtWashingIssuedQty = new System.Windows.Forms.TextBox();
            this.dtpWashingEndDate = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.dtpWashingStartDate = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.dgvWashingProcess = new System.Windows.Forms.DataGridView();
            this.label24 = new System.Windows.Forms.Label();
            this.cmbPressingJobberName = new System.Windows.Forms.ComboBox();
            this.txtPressingCostPerPcs = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtPressingTotalAmount = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtPressReceivedQty = new System.Windows.Forms.TextBox();
            this.txtPressIssuedQty = new System.Windows.Forms.TextBox();
            this.dtpPressEndDate = new System.Windows.Forms.DateTimePicker();
            this.label30 = new System.Windows.Forms.Label();
            this.dtpPressStartDate = new System.Windows.Forms.DateTimePicker();
            this.label31 = new System.Windows.Forms.Label();
            this.CuttingJobberName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CuttingType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuttingIssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuttingIssuedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuttingReceivedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuttingReceivedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuttingRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuttingAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuttingNarration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label32 = new System.Windows.Forms.Label();
            this.WashingJobberName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.WashingQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WashingRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WashingAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WashingNarration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewComboBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpFabricIssued.SuspendLayout();
            this.tpUsedItems.SuspendLayout();
            this.tpCuttingProcess.SuspendLayout();
            this.tpPressProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabricUsed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemUsed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuttingProcess)).BeginInit();
            this.tpWashingProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWashingProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Location = new System.Drawing.Point(579, 464);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(74, 30);
            this.btnView.TabIndex = 11;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(706, 464);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 30);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(452, 464);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 30);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(325, 464);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 30);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(198, 464);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 30);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtLotSize);
            this.groupBox1.Controls.Add(this.txtFinishedQty);
            this.groupBox1.Controls.Add(this.txtOtherExpsPerPcs);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbFinishedProductName);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.txtFabricCostPerPcs);
            this.groupBox1.Controls.Add(this.dtpProgramFinishedDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpProductIssueDate);
            this.groupBox1.Controls.Add(this.txtCostingPerPcs);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtProgramNo);
            this.groupBox1.Controls.Add(this.txtAverageMtrPerPcs);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(975, 458);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // dtpProductIssueDate
            // 
            this.dtpProductIssueDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpProductIssueDate.CustomFormat = "dd/MM/yyyy";
            this.dtpProductIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpProductIssueDate.Location = new System.Drawing.Point(435, 15);
            this.dtpProductIssueDate.Name = "dtpProductIssueDate";
            this.dtpProductIssueDate.Size = new System.Drawing.Size(127, 27);
            this.dtpProductIssueDate.TabIndex = 4;
            // 
            // txtProgramNo
            // 
            this.txtProgramNo.Location = new System.Drawing.Point(112, 15);
            this.txtProgramNo.Name = "txtProgramNo";
            this.txtProgramNo.Size = new System.Drawing.Size(100, 27);
            this.txtProgramNo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Program Start Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Program No. :";
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(11, 468);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(49, 19);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "label2";
            this.lblId.Visible = false;
            // 
            // dtpProgramFinishedDate
            // 
            this.dtpProgramFinishedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpProgramFinishedDate.Checked = false;
            this.dtpProgramFinishedDate.CustomFormat = "dd/MM/yyyy";
            this.dtpProgramFinishedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpProgramFinishedDate.Location = new System.Drawing.Point(818, 15);
            this.dtpProgramFinishedDate.Name = "dtpProgramFinishedDate";
            this.dtpProgramFinishedDate.ShowCheckBox = true;
            this.dtpProgramFinishedDate.Size = new System.Drawing.Size(141, 27);
            this.dtpProgramFinishedDate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(647, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Program Finished Date :";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpFabricIssued);
            this.tabControl1.Controls.Add(this.tpUsedItems);
            this.tabControl1.Controls.Add(this.tpCuttingProcess);
            this.tabControl1.Controls.Add(this.tpWashingProcess);
            this.tabControl1.Controls.Add(this.tpPressProcess);
            this.tabControl1.Location = new System.Drawing.Point(9, 81);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 332);
            this.tabControl1.TabIndex = 9;
            // 
            // tpFabricIssued
            // 
            this.tpFabricIssued.Controls.Add(this.dgvFabricUsed);
            this.tpFabricIssued.Location = new System.Drawing.Point(4, 28);
            this.tpFabricIssued.Name = "tpFabricIssued";
            this.tpFabricIssued.Padding = new System.Windows.Forms.Padding(3);
            this.tpFabricIssued.Size = new System.Drawing.Size(952, 300);
            this.tpFabricIssued.TabIndex = 1;
            this.tpFabricIssued.Text = "Fabric Used";
            this.tpFabricIssued.UseVisualStyleBackColor = true;
            // 
            // tpUsedItems
            // 
            this.tpUsedItems.Controls.Add(this.dgvItemUsed);
            this.tpUsedItems.Location = new System.Drawing.Point(4, 28);
            this.tpUsedItems.Name = "tpUsedItems";
            this.tpUsedItems.Size = new System.Drawing.Size(952, 300);
            this.tpUsedItems.TabIndex = 2;
            this.tpUsedItems.Text = "Items/Accessories Used";
            this.tpUsedItems.UseVisualStyleBackColor = true;
            // 
            // tpCuttingProcess
            // 
            this.tpCuttingProcess.Controls.Add(this.label29);
            this.tpCuttingProcess.Controls.Add(this.cmbCuttingJobberName);
            this.tpCuttingProcess.Controls.Add(this.txtCuttingCostPerPcs);
            this.tpCuttingProcess.Controls.Add(this.label15);
            this.tpCuttingProcess.Controls.Add(this.txtCuttingTotalAmount);
            this.tpCuttingProcess.Controls.Add(this.label14);
            this.tpCuttingProcess.Controls.Add(this.label13);
            this.tpCuttingProcess.Controls.Add(this.label12);
            this.tpCuttingProcess.Controls.Add(this.txtCuttingReceivedQty);
            this.tpCuttingProcess.Controls.Add(this.txtCuttingIssuedQty);
            this.tpCuttingProcess.Controls.Add(this.dtpCuttingEndDate);
            this.tpCuttingProcess.Controls.Add(this.label10);
            this.tpCuttingProcess.Controls.Add(this.dtpCuttingStartDate);
            this.tpCuttingProcess.Controls.Add(this.label11);
            this.tpCuttingProcess.Controls.Add(this.dgvCuttingProcess);
            this.tpCuttingProcess.Location = new System.Drawing.Point(4, 28);
            this.tpCuttingProcess.Name = "tpCuttingProcess";
            this.tpCuttingProcess.Size = new System.Drawing.Size(952, 300);
            this.tpCuttingProcess.TabIndex = 3;
            this.tpCuttingProcess.Text = "Cutting Process";
            this.tpCuttingProcess.UseVisualStyleBackColor = true;
            // 
            // tpPressProcess
            // 
            this.tpPressProcess.Controls.Add(this.dataGridView1);
            this.tpPressProcess.Controls.Add(this.label24);
            this.tpPressProcess.Controls.Add(this.cmbPressingJobberName);
            this.tpPressProcess.Controls.Add(this.txtPressingCostPerPcs);
            this.tpPressProcess.Controls.Add(this.label25);
            this.tpPressProcess.Controls.Add(this.txtPressingTotalAmount);
            this.tpPressProcess.Controls.Add(this.label26);
            this.tpPressProcess.Controls.Add(this.label27);
            this.tpPressProcess.Controls.Add(this.label28);
            this.tpPressProcess.Controls.Add(this.txtPressReceivedQty);
            this.tpPressProcess.Controls.Add(this.txtPressIssuedQty);
            this.tpPressProcess.Controls.Add(this.dtpPressEndDate);
            this.tpPressProcess.Controls.Add(this.label30);
            this.tpPressProcess.Controls.Add(this.dtpPressStartDate);
            this.tpPressProcess.Controls.Add(this.label31);
            this.tpPressProcess.Location = new System.Drawing.Point(4, 28);
            this.tpPressProcess.Name = "tpPressProcess";
            this.tpPressProcess.Size = new System.Drawing.Size(952, 300);
            this.tpPressProcess.TabIndex = 5;
            this.tpPressProcess.Text = "Pressing Process";
            this.tpPressProcess.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Finished Product Name :";
            // 
            // cmbFinishedProductName
            // 
            this.cmbFinishedProductName.FormattingEnabled = true;
            this.cmbFinishedProductName.Location = new System.Drawing.Point(181, 47);
            this.cmbFinishedProductName.Name = "cmbFinishedProductName";
            this.cmbFinishedProductName.Size = new System.Drawing.Size(361, 27);
            this.cmbFinishedProductName.TabIndex = 5;
            // 
            // txtFinishedQty
            // 
            this.txtFinishedQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFinishedQty.Location = new System.Drawing.Point(875, 49);
            this.txtFinishedQty.Name = "txtFinishedQty";
            this.txtFinishedQty.Size = new System.Drawing.Size(84, 27);
            this.txtFinishedQty.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(610, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lot Size :";
            // 
            // txtAverageMtrPerPcs
            // 
            this.txtAverageMtrPerPcs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtAverageMtrPerPcs.Enabled = false;
            this.txtAverageMtrPerPcs.Location = new System.Drawing.Point(204, 422);
            this.txtAverageMtrPerPcs.Name = "txtAverageMtrPerPcs";
            this.txtAverageMtrPerPcs.Size = new System.Drawing.Size(75, 27);
            this.txtAverageMtrPerPcs.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Average Mtr Per Pcs :";
            // 
            // txtCostingPerPcs
            // 
            this.txtCostingPerPcs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtCostingPerPcs.Enabled = false;
            this.txtCostingPerPcs.Location = new System.Drawing.Point(400, 422);
            this.txtCostingPerPcs.Name = "txtCostingPerPcs";
            this.txtCostingPerPcs.Size = new System.Drawing.Size(75, 27);
            this.txtCostingPerPcs.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Costing Per Pcs :";
            // 
            // txtFabricCostPerPcs
            // 
            this.txtFabricCostPerPcs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtFabricCostPerPcs.Enabled = false;
            this.txtFabricCostPerPcs.Location = new System.Drawing.Point(619, 422);
            this.txtFabricCostPerPcs.Name = "txtFabricCostPerPcs";
            this.txtFabricCostPerPcs.Size = new System.Drawing.Size(75, 27);
            this.txtFabricCostPerPcs.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(477, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Fabric Cost Per Pcs :";
            // 
            // txtOtherExpsPerPcs
            // 
            this.txtOtherExpsPerPcs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtOtherExpsPerPcs.Enabled = false;
            this.txtOtherExpsPerPcs.Location = new System.Drawing.Point(841, 422);
            this.txtOtherExpsPerPcs.Name = "txtOtherExpsPerPcs";
            this.txtOtherExpsPerPcs.Size = new System.Drawing.Size(75, 27);
            this.txtOtherExpsPerPcs.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(696, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Other Exps. Per Pcs :";
            // 
            // dgvFabricUsed
            // 
            this.dgvFabricUsed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFabricUsed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvFabricUsed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFabricUsed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.ProductName,
            this.BatchNo,
            this.UsedMtr,
            this.Rate,
            this.Amount});
            this.dgvFabricUsed.Location = new System.Drawing.Point(7, 7);
            this.dgvFabricUsed.Name = "dgvFabricUsed";
            this.dgvFabricUsed.Size = new System.Drawing.Size(915, 287);
            this.dgvFabricUsed.TabIndex = 0;
            // 
            // SrNo
            // 
            this.SrNo.HeaderText = "SrNo";
            this.SrNo.Name = "SrNo";
            this.SrNo.Width = 64;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 96;
            // 
            // BatchNo
            // 
            this.BatchNo.HeaderText = "Batch No/Bale No";
            this.BatchNo.Name = "BatchNo";
            this.BatchNo.Width = 102;
            // 
            // UsedMtr
            // 
            this.UsedMtr.HeaderText = "Used Mtr";
            this.UsedMtr.Name = "UsedMtr";
            this.UsedMtr.Width = 87;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.Width = 64;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.Width = 84;
            // 
            // dgvItemUsed
            // 
            this.dgvItemUsed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItemUsed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvItemUsed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemUsed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewComboBoxColumn2,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvItemUsed.Location = new System.Drawing.Point(7, 7);
            this.dgvItemUsed.Name = "dgvItemUsed";
            this.dgvItemUsed.Size = new System.Drawing.Size(915, 287);
            this.dgvItemUsed.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "SrNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 64;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.HeaderText = "Product Name";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Width = 106;
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.HeaderText = "Batch No";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Width = 74;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 57;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Rate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 64;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 84;
            // 
            // dgvCuttingProcess
            // 
            this.dgvCuttingProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCuttingProcess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCuttingProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuttingProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CuttingJobberName,
            this.CuttingType,
            this.CuttingIssueDate,
            this.CuttingIssuedQty,
            this.CuttingReceivedDate,
            this.CuttingReceivedQty,
            this.CuttingRate,
            this.CuttingAmount,
            this.CuttingNarration});
            this.dgvCuttingProcess.Location = new System.Drawing.Point(7, 79);
            this.dgvCuttingProcess.Name = "dgvCuttingProcess";
            this.dgvCuttingProcess.Size = new System.Drawing.Size(939, 181);
            this.dgvCuttingProcess.TabIndex = 2;
            // 
            // dtpCuttingEndDate
            // 
            this.dtpCuttingEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCuttingEndDate.Checked = false;
            this.dtpCuttingEndDate.CustomFormat = "dd/MM/yyyy";
            this.dtpCuttingEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCuttingEndDate.Location = new System.Drawing.Point(646, 42);
            this.dtpCuttingEndDate.Name = "dtpCuttingEndDate";
            this.dtpCuttingEndDate.ShowCheckBox = true;
            this.dtpCuttingEndDate.Size = new System.Drawing.Size(141, 27);
            this.dtpCuttingEndDate.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(518, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "Cutting End Date :";
            // 
            // dtpCuttingStartDate
            // 
            this.dtpCuttingStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtpCuttingStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCuttingStartDate.Location = new System.Drawing.Point(145, 42);
            this.dtpCuttingStartDate.Name = "dtpCuttingStartDate";
            this.dtpCuttingStartDate.Size = new System.Drawing.Size(116, 27);
            this.dtpCuttingStartDate.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 19);
            this.label11.TabIndex = 9;
            this.label11.Text = "Cutting Start Date :";
            // 
            // txtCuttingIssuedQty
            // 
            this.txtCuttingIssuedQty.Location = new System.Drawing.Point(357, 42);
            this.txtCuttingIssuedQty.Name = "txtCuttingIssuedQty";
            this.txtCuttingIssuedQty.Size = new System.Drawing.Size(79, 27);
            this.txtCuttingIssuedQty.TabIndex = 13;
            // 
            // txtCuttingReceivedQty
            // 
            this.txtCuttingReceivedQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCuttingReceivedQty.Location = new System.Drawing.Point(870, 42);
            this.txtCuttingReceivedQty.Name = "txtCuttingReceivedQty";
            this.txtCuttingReceivedQty.Size = new System.Drawing.Size(74, 27);
            this.txtCuttingReceivedQty.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(268, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 19);
            this.label12.TabIndex = 15;
            this.label12.Text = "Issued Qty:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(793, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 19);
            this.label13.TabIndex = 16;
            this.label13.Text = "Rcvd Qty:";
            // 
            // txtCuttingTotalAmount
            // 
            this.txtCuttingTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCuttingTotalAmount.Enabled = false;
            this.txtCuttingTotalAmount.Location = new System.Drawing.Point(815, 267);
            this.txtCuttingTotalAmount.Name = "txtCuttingTotalAmount";
            this.txtCuttingTotalAmount.Size = new System.Drawing.Size(128, 27);
            this.txtCuttingTotalAmount.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(650, 271);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 19);
            this.label14.TabIndex = 17;
            this.label14.Text = "Cutting Total Amount :";
            // 
            // txtCuttingCostPerPcs
            // 
            this.txtCuttingCostPerPcs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCuttingCostPerPcs.Enabled = false;
            this.txtCuttingCostPerPcs.Location = new System.Drawing.Point(509, 267);
            this.txtCuttingCostPerPcs.Name = "txtCuttingCostPerPcs";
            this.txtCuttingCostPerPcs.Size = new System.Drawing.Size(128, 27);
            this.txtCuttingCostPerPcs.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(344, 271);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 19);
            this.label15.TabIndex = 19;
            this.label15.Text = "Cutting Cost Per Pcs :";
            // 
            // txtLotSize
            // 
            this.txtLotSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLotSize.Location = new System.Drawing.Point(682, 49);
            this.txtLotSize.Name = "txtLotSize";
            this.txtLotSize.Size = new System.Drawing.Size(84, 27);
            this.txtLotSize.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(770, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 19);
            this.label16.TabIndex = 17;
            this.label16.Text = "Finished Qty :";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(9, 13);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(152, 19);
            this.label29.TabIndex = 21;
            this.label29.Text = "Cutting Jobber Name :";
            // 
            // cmbCuttingJobberName
            // 
            this.cmbCuttingJobberName.FormattingEnabled = true;
            this.cmbCuttingJobberName.Location = new System.Drawing.Point(182, 9);
            this.cmbCuttingJobberName.Name = "cmbCuttingJobberName";
            this.cmbCuttingJobberName.Size = new System.Drawing.Size(539, 27);
            this.cmbCuttingJobberName.TabIndex = 22;
            // 
            // tpWashingProcess
            // 
            this.tpWashingProcess.Controls.Add(this.label17);
            this.tpWashingProcess.Controls.Add(this.cmbWashingJobberName);
            this.tpWashingProcess.Controls.Add(this.txtWashingCostPerPcs);
            this.tpWashingProcess.Controls.Add(this.label18);
            this.tpWashingProcess.Controls.Add(this.txtWashingTotalAmount);
            this.tpWashingProcess.Controls.Add(this.label19);
            this.tpWashingProcess.Controls.Add(this.label20);
            this.tpWashingProcess.Controls.Add(this.label21);
            this.tpWashingProcess.Controls.Add(this.txtWashingReceivedQty);
            this.tpWashingProcess.Controls.Add(this.txtWashingIssuedQty);
            this.tpWashingProcess.Controls.Add(this.dtpWashingEndDate);
            this.tpWashingProcess.Controls.Add(this.label22);
            this.tpWashingProcess.Controls.Add(this.dtpWashingStartDate);
            this.tpWashingProcess.Controls.Add(this.label23);
            this.tpWashingProcess.Controls.Add(this.dgvWashingProcess);
            this.tpWashingProcess.Location = new System.Drawing.Point(4, 28);
            this.tpWashingProcess.Name = "tpWashingProcess";
            this.tpWashingProcess.Size = new System.Drawing.Size(952, 300);
            this.tpWashingProcess.TabIndex = 4;
            this.tpWashingProcess.Text = "Washing Process";
            this.tpWashingProcess.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(161, 19);
            this.label17.TabIndex = 36;
            this.label17.Text = "Washing Jobber Name :";
            // 
            // cmbWashingJobberName
            // 
            this.cmbWashingJobberName.FormattingEnabled = true;
            this.cmbWashingJobberName.Location = new System.Drawing.Point(182, 8);
            this.cmbWashingJobberName.Name = "cmbWashingJobberName";
            this.cmbWashingJobberName.Size = new System.Drawing.Size(539, 27);
            this.cmbWashingJobberName.TabIndex = 37;
            // 
            // txtWashingCostPerPcs
            // 
            this.txtWashingCostPerPcs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWashingCostPerPcs.Enabled = false;
            this.txtWashingCostPerPcs.Location = new System.Drawing.Point(509, 266);
            this.txtWashingCostPerPcs.Name = "txtWashingCostPerPcs";
            this.txtWashingCostPerPcs.Size = new System.Drawing.Size(128, 27);
            this.txtWashingCostPerPcs.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(344, 270);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(157, 19);
            this.label18.TabIndex = 34;
            this.label18.Text = "Washing Cost Per Pcs :";
            // 
            // txtWashingTotalAmount
            // 
            this.txtWashingTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWashingTotalAmount.Enabled = false;
            this.txtWashingTotalAmount.Location = new System.Drawing.Point(815, 266);
            this.txtWashingTotalAmount.Name = "txtWashingTotalAmount";
            this.txtWashingTotalAmount.Size = new System.Drawing.Size(128, 27);
            this.txtWashingTotalAmount.TabIndex = 33;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(645, 270);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(163, 19);
            this.label19.TabIndex = 32;
            this.label19.Text = "Washing Total Amount :";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(793, 44);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 19);
            this.label20.TabIndex = 31;
            this.label20.Text = "Rcvd Qty:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(272, 45);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 19);
            this.label21.TabIndex = 30;
            this.label21.Text = "Issued Qty:";
            // 
            // txtWashingReceivedQty
            // 
            this.txtWashingReceivedQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWashingReceivedQty.Location = new System.Drawing.Point(870, 41);
            this.txtWashingReceivedQty.Name = "txtWashingReceivedQty";
            this.txtWashingReceivedQty.Size = new System.Drawing.Size(74, 27);
            this.txtWashingReceivedQty.TabIndex = 29;
            // 
            // txtWashingIssuedQty
            // 
            this.txtWashingIssuedQty.Location = new System.Drawing.Point(357, 41);
            this.txtWashingIssuedQty.Name = "txtWashingIssuedQty";
            this.txtWashingIssuedQty.Size = new System.Drawing.Size(79, 27);
            this.txtWashingIssuedQty.TabIndex = 28;
            // 
            // dtpWashingEndDate
            // 
            this.dtpWashingEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpWashingEndDate.Checked = false;
            this.dtpWashingEndDate.CustomFormat = "dd/MM/yyyy";
            this.dtpWashingEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWashingEndDate.Location = new System.Drawing.Point(646, 41);
            this.dtpWashingEndDate.Name = "dtpWashingEndDate";
            this.dtpWashingEndDate.ShowCheckBox = true;
            this.dtpWashingEndDate.Size = new System.Drawing.Size(141, 27);
            this.dtpWashingEndDate.TabIndex = 27;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(506, 45);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(136, 19);
            this.label22.TabIndex = 26;
            this.label22.Text = "Washing End Date :";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // dtpWashingStartDate
            // 
            this.dtpWashingStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtpWashingStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWashingStartDate.Location = new System.Drawing.Point(152, 41);
            this.dtpWashingStartDate.Name = "dtpWashingStartDate";
            this.dtpWashingStartDate.Size = new System.Drawing.Size(116, 27);
            this.dtpWashingStartDate.TabIndex = 25;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 45);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(142, 19);
            this.label23.TabIndex = 24;
            this.label23.Text = "Washing Start Date :";
            // 
            // dgvWashingProcess
            // 
            this.dgvWashingProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWashingProcess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvWashingProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWashingProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WashingJobberName,
            this.WashingQty,
            this.WashingRate,
            this.WashingAmount,
            this.WashingNarration});
            this.dgvWashingProcess.Location = new System.Drawing.Point(7, 78);
            this.dgvWashingProcess.Name = "dgvWashingProcess";
            this.dgvWashingProcess.Size = new System.Drawing.Size(939, 181);
            this.dgvWashingProcess.TabIndex = 23;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 12);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(160, 19);
            this.label24.TabIndex = 36;
            this.label24.Text = "Pressing Jobber Name :";
            // 
            // cmbPressingJobberName
            // 
            this.cmbPressingJobberName.FormattingEnabled = true;
            this.cmbPressingJobberName.Location = new System.Drawing.Point(182, 8);
            this.cmbPressingJobberName.Name = "cmbPressingJobberName";
            this.cmbPressingJobberName.Size = new System.Drawing.Size(539, 27);
            this.cmbPressingJobberName.TabIndex = 37;
            // 
            // txtPressingCostPerPcs
            // 
            this.txtPressingCostPerPcs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPressingCostPerPcs.Enabled = false;
            this.txtPressingCostPerPcs.Location = new System.Drawing.Point(509, 266);
            this.txtPressingCostPerPcs.Name = "txtPressingCostPerPcs";
            this.txtPressingCostPerPcs.Size = new System.Drawing.Size(128, 27);
            this.txtPressingCostPerPcs.TabIndex = 35;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(344, 270);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(156, 19);
            this.label25.TabIndex = 34;
            this.label25.Text = "Pressing Cost Per Pcs :";
            // 
            // txtPressingTotalAmount
            // 
            this.txtPressingTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPressingTotalAmount.Enabled = false;
            this.txtPressingTotalAmount.Location = new System.Drawing.Point(815, 266);
            this.txtPressingTotalAmount.Name = "txtPressingTotalAmount";
            this.txtPressingTotalAmount.Size = new System.Drawing.Size(128, 27);
            this.txtPressingTotalAmount.TabIndex = 33;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(646, 270);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(162, 19);
            this.label26.TabIndex = 32;
            this.label26.Text = "Pressing Total Amount :";
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(793, 44);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(71, 19);
            this.label27.TabIndex = 31;
            this.label27.Text = "Rcvd Qty:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(268, 45);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(82, 19);
            this.label28.TabIndex = 30;
            this.label28.Text = "Issued Qty:";
            // 
            // txtPressReceivedQty
            // 
            this.txtPressReceivedQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPressReceivedQty.Location = new System.Drawing.Point(870, 41);
            this.txtPressReceivedQty.Name = "txtPressReceivedQty";
            this.txtPressReceivedQty.Size = new System.Drawing.Size(74, 27);
            this.txtPressReceivedQty.TabIndex = 29;
            // 
            // txtPressIssuedQty
            // 
            this.txtPressIssuedQty.Location = new System.Drawing.Point(357, 41);
            this.txtPressIssuedQty.Name = "txtPressIssuedQty";
            this.txtPressIssuedQty.Size = new System.Drawing.Size(79, 27);
            this.txtPressIssuedQty.TabIndex = 28;
            // 
            // dtpPressEndDate
            // 
            this.dtpPressEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPressEndDate.Checked = false;
            this.dtpPressEndDate.CustomFormat = "dd/MM/yyyy";
            this.dtpPressEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPressEndDate.Location = new System.Drawing.Point(646, 41);
            this.dtpPressEndDate.Name = "dtpPressEndDate";
            this.dtpPressEndDate.ShowCheckBox = true;
            this.dtpPressEndDate.Size = new System.Drawing.Size(141, 27);
            this.dtpPressEndDate.TabIndex = 27;
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(518, 45);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(115, 19);
            this.label30.TabIndex = 26;
            this.label30.Text = "Press End Date :";
            // 
            // dtpPressStartDate
            // 
            this.dtpPressStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtpPressStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPressStartDate.Location = new System.Drawing.Point(145, 41);
            this.dtpPressStartDate.Name = "dtpPressStartDate";
            this.dtpPressStartDate.Size = new System.Drawing.Size(116, 27);
            this.dtpPressStartDate.TabIndex = 25;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(8, 45);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(121, 19);
            this.label31.TabIndex = 24;
            this.label31.Text = "Press Start Date :";
            // 
            // CuttingJobberName
            // 
            this.CuttingJobberName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CuttingJobberName.HeaderText = "Jobber Name";
            this.CuttingJobberName.Name = "CuttingJobberName";
            this.CuttingJobberName.Width = 99;
            // 
            // CuttingType
            // 
            this.CuttingType.HeaderText = "Type";
            this.CuttingType.Name = "CuttingType";
            this.CuttingType.ReadOnly = true;
            this.CuttingType.Width = 64;
            // 
            // CuttingIssueDate
            // 
            this.CuttingIssueDate.HeaderText = "IssueDate";
            this.CuttingIssueDate.Name = "CuttingIssueDate";
            this.CuttingIssueDate.ReadOnly = true;
            this.CuttingIssueDate.Width = 99;
            // 
            // CuttingIssuedQty
            // 
            this.CuttingIssuedQty.HeaderText = "Issued Qty";
            this.CuttingIssuedQty.Name = "CuttingIssuedQty";
            this.CuttingIssuedQty.Width = 103;
            // 
            // CuttingReceivedDate
            // 
            this.CuttingReceivedDate.HeaderText = "Received Date";
            this.CuttingReceivedDate.Name = "CuttingReceivedDate";
            this.CuttingReceivedDate.ReadOnly = true;
            this.CuttingReceivedDate.Width = 128;
            // 
            // CuttingReceivedQty
            // 
            this.CuttingReceivedQty.HeaderText = "Received Qty";
            this.CuttingReceivedQty.Name = "CuttingReceivedQty";
            this.CuttingReceivedQty.ReadOnly = true;
            this.CuttingReceivedQty.Width = 120;
            // 
            // CuttingRate
            // 
            this.CuttingRate.HeaderText = "Rate";
            this.CuttingRate.Name = "CuttingRate";
            this.CuttingRate.ReadOnly = true;
            this.CuttingRate.Width = 64;
            // 
            // CuttingAmount
            // 
            this.CuttingAmount.HeaderText = "Amount";
            this.CuttingAmount.Name = "CuttingAmount";
            this.CuttingAmount.Width = 84;
            // 
            // CuttingNarration
            // 
            this.CuttingNarration.HeaderText = "Narration";
            this.CuttingNarration.Name = "CuttingNarration";
            this.CuttingNarration.ReadOnly = true;
            this.CuttingNarration.Width = 95;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(530, 33);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(111, 19);
            this.label32.TabIndex = 14;
            this.label32.Text = "Mfg,Mfg2,Stock";
            // 
            // WashingJobberName
            // 
            this.WashingJobberName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.WashingJobberName.HeaderText = "Jobber Name";
            this.WashingJobberName.Name = "WashingJobberName";
            this.WashingJobberName.Width = 99;
            // 
            // WashingQty
            // 
            this.WashingQty.HeaderText = "Qty";
            this.WashingQty.Name = "WashingQty";
            this.WashingQty.Width = 57;
            // 
            // WashingRate
            // 
            this.WashingRate.HeaderText = "Rate";
            this.WashingRate.Name = "WashingRate";
            this.WashingRate.ReadOnly = true;
            this.WashingRate.Width = 64;
            // 
            // WashingAmount
            // 
            this.WashingAmount.HeaderText = "Amount";
            this.WashingAmount.Name = "WashingAmount";
            this.WashingAmount.Width = 84;
            // 
            // WashingNarration
            // 
            this.WashingNarration.HeaderText = "Narration";
            this.WashingNarration.Name = "WashingNarration";
            this.WashingNarration.ReadOnly = true;
            this.WashingNarration.Width = 95;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewComboBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView1.Location = new System.Drawing.Point(7, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(939, 181);
            this.dataGridView1.TabIndex = 38;
            // 
            // dataGridViewComboBoxColumn3
            // 
            this.dataGridViewComboBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewComboBoxColumn3.HeaderText = "Jobber Name";
            this.dataGridViewComboBoxColumn3.Name = "dataGridViewComboBoxColumn3";
            this.dataGridViewComboBoxColumn3.Width = 99;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 57;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Rate";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 64;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 84;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Narration";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 95;
            // 
            // frmMfgCycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 500);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblId);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMfgCycle";
            this.Text = "Garment Manufacturing Cycle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpFabricIssued.ResumeLayout(false);
            this.tpUsedItems.ResumeLayout(false);
            this.tpCuttingProcess.ResumeLayout(false);
            this.tpCuttingProcess.PerformLayout();
            this.tpPressProcess.ResumeLayout(false);
            this.tpPressProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabricUsed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemUsed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuttingProcess)).EndInit();
            this.tpWashingProcess.ResumeLayout(false);
            this.tpWashingProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWashingProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpProgramFinishedDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpProductIssueDate;
        private System.Windows.Forms.TextBox txtProgramNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpFabricIssued;
        private System.Windows.Forms.TabPage tpUsedItems;
        private System.Windows.Forms.TabPage tpCuttingProcess;
        private System.Windows.Forms.TabPage tpPressProcess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFinishedProductName;
        private System.Windows.Forms.TextBox txtFinishedQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCostingPerPcs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAverageMtrPerPcs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOtherExpsPerPcs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFabricCostPerPcs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvFabricUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewComboBoxColumn BatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsedMtr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridView dgvItemUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dgvCuttingProcess;
        private System.Windows.Forms.DateTimePicker dtpCuttingEndDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpCuttingStartDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCuttingReceivedQty;
        private System.Windows.Forms.TextBox txtCuttingIssuedQty;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCuttingCostPerPcs;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCuttingTotalAmount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtLotSize;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox cmbCuttingJobberName;
        private System.Windows.Forms.TabPage tpWashingProcess;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbWashingJobberName;
        private System.Windows.Forms.TextBox txtWashingCostPerPcs;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtWashingTotalAmount;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtWashingReceivedQty;
        private System.Windows.Forms.TextBox txtWashingIssuedQty;
        private System.Windows.Forms.DateTimePicker dtpWashingEndDate;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker dtpWashingStartDate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView dgvWashingProcess;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cmbPressingJobberName;
        private System.Windows.Forms.TextBox txtPressingCostPerPcs;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtPressingTotalAmount;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtPressReceivedQty;
        private System.Windows.Forms.TextBox txtPressIssuedQty;
        private System.Windows.Forms.DateTimePicker dtpPressEndDate;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DateTimePicker dtpPressStartDate;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.DataGridViewComboBoxColumn CuttingJobberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuttingType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuttingIssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuttingIssuedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuttingReceivedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuttingReceivedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuttingRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuttingAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuttingNarration;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DataGridViewComboBoxColumn WashingJobberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WashingQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn WashingRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn WashingAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn WashingNarration;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}
namespace GarmentMfg
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
            this.label16 = new System.Windows.Forms.Label();
            this.txtLotSize = new System.Windows.Forms.TextBox();
            this.txtFinishedQty = new System.Windows.Forms.TextBox();
            this.txtOtherExpsPerPcs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFinishedProductName = new System.Windows.Forms.ComboBox();
            this.tabProcess = new System.Windows.Forms.TabControl();
            this.tpCuttingProcess = new System.Windows.Forms.TabPage();
            this.tabCutter = new System.Windows.Forms.TabControl();
            this.tabCutterInfo = new System.Windows.Forms.TabPage();
            this.label32 = new System.Windows.Forms.Label();
            this.txtCuttingRate = new System.Windows.Forms.TextBox();
            this.dgvCuttingProcess = new System.Windows.Forms.DataGridView();
            this.CuttingSrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuttingJobberName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CuttingType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuttingIssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuttingIssuedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuttingReceivedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuttingReceivedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuttingRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuttingAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuttingNarration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label29 = new System.Windows.Forms.Label();
            this.cmbCuttingJobberName = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpCuttingStartDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpCuttingEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtCuttingIssuedQty = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCuttingReceivedQty = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabFabricUsed = new System.Windows.Forms.TabPage();
            this.dgvFabricUsed = new System.Windows.Forms.DataGridView();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BatchNo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UsedMtr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCuttingCostPerPcs = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCuttingTotalAmount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tpWashingProcess = new System.Windows.Forms.TabPage();
            this.label33 = new System.Windows.Forms.Label();
            this.txtWashingRate = new System.Windows.Forms.TextBox();
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
            this.WashingSrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WashingJobberName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.WashingQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WashingRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WashingAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WashingNarration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpPressProcess = new System.Windows.Forms.TabPage();
            this.label34 = new System.Windows.Forms.Label();
            this.txtPressingRate = new System.Windows.Forms.TextBox();
            this.dgvPressingProcess = new System.Windows.Forms.DataGridView();
            this.PressingSrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PressingJobber = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PressingQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PressingRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PressingAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PressingNarr = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tpUsedItems = new System.Windows.Forms.TabPage();
            this.txtOthCostPrPcs = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.txtOthTotalAmount = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.dgvItemUsed = new System.Windows.Forms.DataGridView();
            this.OthSrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OthProduct = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.OthBatch = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.OthQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OthRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OthAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFabricCostPerPcs = new System.Windows.Forms.TextBox();
            this.dtpProgramFinishedDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpProgramStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtCostingPerPcs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProgramNo = new System.Windows.Forms.TextBox();
            this.txtAverageMtrPerPcs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblExpertLinks = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabProcess.SuspendLayout();
            this.tpCuttingProcess.SuspendLayout();
            this.tabCutter.SuspendLayout();
            this.tabCutterInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuttingProcess)).BeginInit();
            this.tabFabricUsed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabricUsed)).BeginInit();
            this.tpWashingProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWashingProcess)).BeginInit();
            this.tpPressProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPressingProcess)).BeginInit();
            this.tpUsedItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemUsed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Location = new System.Drawing.Point(579, 520);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(74, 30);
            this.btnView.TabIndex = 11;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(706, 520);
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
            this.btnDelete.Location = new System.Drawing.Point(452, 520);
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
            this.btnSave.Location = new System.Drawing.Point(325, 520);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 30);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(198, 520);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 30);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtLotSize);
            this.groupBox1.Controls.Add(this.txtFinishedQty);
            this.groupBox1.Controls.Add(this.txtOtherExpsPerPcs);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbFinishedProductName);
            this.groupBox1.Controls.Add(this.tabProcess);
            this.groupBox1.Controls.Add(this.txtFabricCostPerPcs);
            this.groupBox1.Controls.Add(this.dtpProgramFinishedDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpProgramStartDate);
            this.groupBox1.Controls.Add(this.txtCostingPerPcs);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtProgramNo);
            this.groupBox1.Controls.Add(this.txtAverageMtrPerPcs);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(975, 514);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
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
            // txtLotSize
            // 
            this.txtLotSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLotSize.Location = new System.Drawing.Point(682, 49);
            this.txtLotSize.Name = "txtLotSize";
            this.txtLotSize.Size = new System.Drawing.Size(84, 27);
            this.txtLotSize.TabIndex = 4;
            this.txtLotSize.Validated += new System.EventHandler(this.txtLotSize_Validated);
            this.txtLotSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLotSize_KeyPress);
            // 
            // txtFinishedQty
            // 
            this.txtFinishedQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFinishedQty.Location = new System.Drawing.Point(875, 49);
            this.txtFinishedQty.Name = "txtFinishedQty";
            this.txtFinishedQty.Size = new System.Drawing.Size(84, 27);
            this.txtFinishedQty.TabIndex = 5;
            this.txtFinishedQty.Validated += new System.EventHandler(this.txtFinishedQty_Validated);
            this.txtFinishedQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFinishedQty_KeyPress);
            // 
            // txtOtherExpsPerPcs
            // 
            this.txtOtherExpsPerPcs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtOtherExpsPerPcs.Enabled = false;
            this.txtOtherExpsPerPcs.Location = new System.Drawing.Point(841, 478);
            this.txtOtherExpsPerPcs.Name = "txtOtherExpsPerPcs";
            this.txtOtherExpsPerPcs.Size = new System.Drawing.Size(75, 27);
            this.txtOtherExpsPerPcs.TabIndex = 15;
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
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(696, 482);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Other Exps. Per Pcs :";
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
            this.cmbFinishedProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFinishedProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFinishedProductName.FormattingEnabled = true;
            this.cmbFinishedProductName.Location = new System.Drawing.Point(181, 47);
            this.cmbFinishedProductName.Name = "cmbFinishedProductName";
            this.cmbFinishedProductName.Size = new System.Drawing.Size(361, 27);
            this.cmbFinishedProductName.TabIndex = 2;
            // 
            // tabProcess
            // 
            this.tabProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabProcess.Controls.Add(this.tpCuttingProcess);
            this.tabProcess.Controls.Add(this.tpWashingProcess);
            this.tabProcess.Controls.Add(this.tpPressProcess);
            this.tabProcess.Controls.Add(this.tpUsedItems);
            this.tabProcess.Location = new System.Drawing.Point(9, 81);
            this.tabProcess.Name = "tabProcess";
            this.tabProcess.SelectedIndex = 0;
            this.tabProcess.Size = new System.Drawing.Size(960, 388);
            this.tabProcess.TabIndex = 6;
            // 
            // tpCuttingProcess
            // 
            this.tpCuttingProcess.Controls.Add(this.tabCutter);
            this.tpCuttingProcess.Controls.Add(this.txtCuttingCostPerPcs);
            this.tpCuttingProcess.Controls.Add(this.label15);
            this.tpCuttingProcess.Controls.Add(this.txtCuttingTotalAmount);
            this.tpCuttingProcess.Controls.Add(this.label14);
            this.tpCuttingProcess.Location = new System.Drawing.Point(4, 28);
            this.tpCuttingProcess.Name = "tpCuttingProcess";
            this.tpCuttingProcess.Size = new System.Drawing.Size(952, 356);
            this.tpCuttingProcess.TabIndex = 3;
            this.tpCuttingProcess.Text = "Cutting Process";
            this.tpCuttingProcess.UseVisualStyleBackColor = true;
            // 
            // tabCutter
            // 
            this.tabCutter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCutter.Controls.Add(this.tabCutterInfo);
            this.tabCutter.Controls.Add(this.tabFabricUsed);
            this.tabCutter.Location = new System.Drawing.Point(3, 3);
            this.tabCutter.Name = "tabCutter";
            this.tabCutter.SelectedIndex = 0;
            this.tabCutter.Size = new System.Drawing.Size(940, 314);
            this.tabCutter.TabIndex = 0;
            // 
            // tabCutterInfo
            // 
            this.tabCutterInfo.Controls.Add(this.label32);
            this.tabCutterInfo.Controls.Add(this.txtCuttingRate);
            this.tabCutterInfo.Controls.Add(this.dgvCuttingProcess);
            this.tabCutterInfo.Controls.Add(this.label29);
            this.tabCutterInfo.Controls.Add(this.cmbCuttingJobberName);
            this.tabCutterInfo.Controls.Add(this.label11);
            this.tabCutterInfo.Controls.Add(this.dtpCuttingStartDate);
            this.tabCutterInfo.Controls.Add(this.label10);
            this.tabCutterInfo.Controls.Add(this.dtpCuttingEndDate);
            this.tabCutterInfo.Controls.Add(this.txtCuttingIssuedQty);
            this.tabCutterInfo.Controls.Add(this.label13);
            this.tabCutterInfo.Controls.Add(this.txtCuttingReceivedQty);
            this.tabCutterInfo.Controls.Add(this.label12);
            this.tabCutterInfo.Location = new System.Drawing.Point(4, 28);
            this.tabCutterInfo.Name = "tabCutterInfo";
            this.tabCutterInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCutterInfo.Size = new System.Drawing.Size(932, 282);
            this.tabCutterInfo.TabIndex = 0;
            this.tabCutterInfo.Text = "Cutter Info";
            this.tabCutterInfo.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(780, 43);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(47, 19);
            this.label32.TabIndex = 23;
            this.label32.Text = "Rate :";
            // 
            // txtCuttingRate
            // 
            this.txtCuttingRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCuttingRate.Location = new System.Drawing.Point(833, 39);
            this.txtCuttingRate.Name = "txtCuttingRate";
            this.txtCuttingRate.Size = new System.Drawing.Size(93, 27);
            this.txtCuttingRate.TabIndex = 5;
            this.txtCuttingRate.Validated += new System.EventHandler(this.txtCuttingRate_Validated);
            // 
            // dgvCuttingProcess
            // 
            this.dgvCuttingProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCuttingProcess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCuttingProcess.BackgroundColor = System.Drawing.Color.White;
            this.dgvCuttingProcess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCuttingProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuttingProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CuttingSrNo,
            this.CuttingJobberName,
            this.CuttingType,
            this.CuttingIssueDate,
            this.CuttingIssuedQty,
            this.CuttingReceivedDate,
            this.CuttingReceivedQty,
            this.CuttingRate,
            this.CuttingAmount,
            this.CuttingNarration});
            this.dgvCuttingProcess.Location = new System.Drawing.Point(7, 75);
            this.dgvCuttingProcess.Name = "dgvCuttingProcess";
            this.dgvCuttingProcess.RowHeadersVisible = false;
            this.dgvCuttingProcess.Size = new System.Drawing.Size(919, 243);
            this.dgvCuttingProcess.TabIndex = 6;
            this.dgvCuttingProcess.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuttingProcess_CellValueChanged);
            this.dgvCuttingProcess.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvCuttingProcess_RowsAdded);
            this.dgvCuttingProcess.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvCuttingProcess_EditingControlShowing);
            this.dgvCuttingProcess.CurrentCellChanged += new System.EventHandler(this.dgvCuttingProcess_CurrentCellChanged);
            this.dgvCuttingProcess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCuttingProcess_KeyDown);
            // 
            // CuttingSrNo
            // 
            this.CuttingSrNo.HeaderText = "Sr No";
            this.CuttingSrNo.Name = "CuttingSrNo";
            this.CuttingSrNo.ReadOnly = true;
            this.CuttingSrNo.Width = 68;
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
            this.CuttingIssueDate.HeaderText = "Issue Date";
            this.CuttingIssueDate.Name = "CuttingIssueDate";
            this.CuttingIssueDate.ReadOnly = true;
            this.CuttingIssueDate.Width = 103;
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
            this.CuttingReceivedQty.Width = 120;
            // 
            // CuttingRate
            // 
            this.CuttingRate.HeaderText = "Rate";
            this.CuttingRate.Name = "CuttingRate";
            this.CuttingRate.Width = 64;
            // 
            // CuttingAmount
            // 
            this.CuttingAmount.HeaderText = "Amount";
            this.CuttingAmount.Name = "CuttingAmount";
            this.CuttingAmount.ReadOnly = true;
            this.CuttingAmount.Width = 84;
            // 
            // CuttingNarration
            // 
            this.CuttingNarration.HeaderText = "Narration";
            this.CuttingNarration.Name = "CuttingNarration";
            this.CuttingNarration.Width = 95;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(8, 10);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(99, 19);
            this.label29.TabIndex = 21;
            this.label29.Text = "Cutter Name :";
            // 
            // cmbCuttingJobberName
            // 
            this.cmbCuttingJobberName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCuttingJobberName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCuttingJobberName.FormattingEnabled = true;
            this.cmbCuttingJobberName.Location = new System.Drawing.Point(113, 6);
            this.cmbCuttingJobberName.Name = "cmbCuttingJobberName";
            this.cmbCuttingJobberName.Size = new System.Drawing.Size(813, 27);
            this.cmbCuttingJobberName.TabIndex = 0;
            this.cmbCuttingJobberName.Validated += new System.EventHandler(this.cmbCuttingJobberName_Validated);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 19);
            this.label11.TabIndex = 9;
            this.label11.Text = "Start Date :";
            // 
            // dtpCuttingStartDate
            // 
            this.dtpCuttingStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtpCuttingStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCuttingStartDate.Location = new System.Drawing.Point(113, 39);
            this.dtpCuttingStartDate.Name = "dtpCuttingStartDate";
            this.dtpCuttingStartDate.Size = new System.Drawing.Size(116, 27);
            this.dtpCuttingStartDate.TabIndex = 1;
            this.dtpCuttingStartDate.Validated += new System.EventHandler(this.dtpCuttingStartDate_Validated);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(397, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "End Date :";
            // 
            // dtpCuttingEndDate
            // 
            this.dtpCuttingEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCuttingEndDate.Checked = false;
            this.dtpCuttingEndDate.CustomFormat = "dd/MM/yyyy";
            this.dtpCuttingEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCuttingEndDate.Location = new System.Drawing.Point(479, 39);
            this.dtpCuttingEndDate.Name = "dtpCuttingEndDate";
            this.dtpCuttingEndDate.ShowCheckBox = true;
            this.dtpCuttingEndDate.Size = new System.Drawing.Size(141, 27);
            this.dtpCuttingEndDate.TabIndex = 3;
            this.dtpCuttingEndDate.Validated += new System.EventHandler(this.dtpCuttingEndDate_Validated);
            // 
            // txtCuttingIssuedQty
            // 
            this.txtCuttingIssuedQty.Location = new System.Drawing.Point(327, 39);
            this.txtCuttingIssuedQty.Name = "txtCuttingIssuedQty";
            this.txtCuttingIssuedQty.Size = new System.Drawing.Size(60, 27);
            this.txtCuttingIssuedQty.TabIndex = 2;
            this.txtCuttingIssuedQty.Validated += new System.EventHandler(this.txtCuttingIssuedQty_Validated);
            this.txtCuttingIssuedQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuttingIssuedQty_KeyPress);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(630, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 19);
            this.label13.TabIndex = 16;
            this.label13.Text = "Rcvd Qty:";
            // 
            // txtCuttingReceivedQty
            // 
            this.txtCuttingReceivedQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCuttingReceivedQty.Location = new System.Drawing.Point(707, 39);
            this.txtCuttingReceivedQty.Name = "txtCuttingReceivedQty";
            this.txtCuttingReceivedQty.Size = new System.Drawing.Size(62, 27);
            this.txtCuttingReceivedQty.TabIndex = 4;
            this.txtCuttingReceivedQty.Validated += new System.EventHandler(this.txtCuttingReceivedQty_Validated);
            this.txtCuttingReceivedQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuttingReceivedQty_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(238, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 19);
            this.label12.TabIndex = 15;
            this.label12.Text = "Issued Qty:";
            // 
            // tabFabricUsed
            // 
            this.tabFabricUsed.Controls.Add(this.dgvFabricUsed);
            this.tabFabricUsed.Location = new System.Drawing.Point(4, 28);
            this.tabFabricUsed.Name = "tabFabricUsed";
            this.tabFabricUsed.Padding = new System.Windows.Forms.Padding(3);
            this.tabFabricUsed.Size = new System.Drawing.Size(932, 282);
            this.tabFabricUsed.TabIndex = 1;
            this.tabFabricUsed.Text = "Fabric Used";
            this.tabFabricUsed.UseVisualStyleBackColor = true;
            // 
            // dgvFabricUsed
            // 
            this.dgvFabricUsed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFabricUsed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvFabricUsed.BackgroundColor = System.Drawing.Color.White;
            this.dgvFabricUsed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFabricUsed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFabricUsed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.ProductName,
            this.BatchNo,
            this.UsedMtr,
            this.Rate,
            this.Amount});
            this.dgvFabricUsed.Location = new System.Drawing.Point(9, 6);
            this.dgvFabricUsed.Name = "dgvFabricUsed";
            this.dgvFabricUsed.RowHeadersVisible = false;
            this.dgvFabricUsed.Size = new System.Drawing.Size(917, 312);
            this.dgvFabricUsed.TabIndex = 0;
            this.dgvFabricUsed.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFabricUsed_CellValueChanged);
            this.dgvFabricUsed.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvFabricUsed_RowsAdded);
            this.dgvFabricUsed.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvFabricUsed_EditingControlShowing);
            // 
            // SrNo
            // 
            this.SrNo.HeaderText = "SrNo";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
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
            this.Amount.ReadOnly = true;
            this.Amount.Width = 84;
            // 
            // txtCuttingCostPerPcs
            // 
            this.txtCuttingCostPerPcs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCuttingCostPerPcs.Enabled = false;
            this.txtCuttingCostPerPcs.Location = new System.Drawing.Point(509, 323);
            this.txtCuttingCostPerPcs.Name = "txtCuttingCostPerPcs";
            this.txtCuttingCostPerPcs.Size = new System.Drawing.Size(128, 27);
            this.txtCuttingCostPerPcs.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(344, 327);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 19);
            this.label15.TabIndex = 19;
            this.label15.Text = "Cutting Cost Per Pcs :";
            // 
            // txtCuttingTotalAmount
            // 
            this.txtCuttingTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCuttingTotalAmount.Enabled = false;
            this.txtCuttingTotalAmount.Location = new System.Drawing.Point(815, 323);
            this.txtCuttingTotalAmount.Name = "txtCuttingTotalAmount";
            this.txtCuttingTotalAmount.Size = new System.Drawing.Size(128, 27);
            this.txtCuttingTotalAmount.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(650, 327);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 19);
            this.label14.TabIndex = 17;
            this.label14.Text = "Cutting Total Amount :";
            // 
            // tpWashingProcess
            // 
            this.tpWashingProcess.Controls.Add(this.label33);
            this.tpWashingProcess.Controls.Add(this.txtWashingRate);
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
            this.tpWashingProcess.Size = new System.Drawing.Size(952, 356);
            this.tpWashingProcess.TabIndex = 4;
            this.tpWashingProcess.Text = "Washing Process";
            this.tpWashingProcess.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(798, 46);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(47, 19);
            this.label33.TabIndex = 39;
            this.label33.Text = "Rate :";
            // 
            // txtWashingRate
            // 
            this.txtWashingRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWashingRate.Location = new System.Drawing.Point(851, 42);
            this.txtWashingRate.Name = "txtWashingRate";
            this.txtWashingRate.Size = new System.Drawing.Size(93, 27);
            this.txtWashingRate.TabIndex = 5;
            this.txtWashingRate.Validated += new System.EventHandler(this.txtWashingRate_Validated);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 19);
            this.label17.TabIndex = 36;
            this.label17.Text = "Jobber Name :";
            // 
            // cmbWashingJobberName
            // 
            this.cmbWashingJobberName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbWashingJobberName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWashingJobberName.FormattingEnabled = true;
            this.cmbWashingJobberName.Location = new System.Drawing.Point(116, 9);
            this.cmbWashingJobberName.Name = "cmbWashingJobberName";
            this.cmbWashingJobberName.Size = new System.Drawing.Size(828, 27);
            this.cmbWashingJobberName.TabIndex = 0;
            this.cmbWashingJobberName.SelectedIndexChanged += new System.EventHandler(this.cmbWashingJobberName_SelectedIndexChanged);
            // 
            // txtWashingCostPerPcs
            // 
            this.txtWashingCostPerPcs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWashingCostPerPcs.Enabled = false;
            this.txtWashingCostPerPcs.Location = new System.Drawing.Point(509, 322);
            this.txtWashingCostPerPcs.Name = "txtWashingCostPerPcs";
            this.txtWashingCostPerPcs.Size = new System.Drawing.Size(128, 27);
            this.txtWashingCostPerPcs.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(406, 326);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 19);
            this.label18.TabIndex = 34;
            this.label18.Text = "Cost Per Pcs :";
            // 
            // txtWashingTotalAmount
            // 
            this.txtWashingTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWashingTotalAmount.Enabled = false;
            this.txtWashingTotalAmount.Location = new System.Drawing.Point(816, 322);
            this.txtWashingTotalAmount.Name = "txtWashingTotalAmount";
            this.txtWashingTotalAmount.Size = new System.Drawing.Size(128, 27);
            this.txtWashingTotalAmount.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(706, 326);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 19);
            this.label19.TabIndex = 32;
            this.label19.Text = "Total Amount :";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(643, 46);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 19);
            this.label20.TabIndex = 31;
            this.label20.Text = "Rcvd Qty:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(240, 46);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 19);
            this.label21.TabIndex = 30;
            this.label21.Text = "Issued Qty:";
            // 
            // txtWashingReceivedQty
            // 
            this.txtWashingReceivedQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWashingReceivedQty.Location = new System.Drawing.Point(720, 42);
            this.txtWashingReceivedQty.Name = "txtWashingReceivedQty";
            this.txtWashingReceivedQty.Size = new System.Drawing.Size(74, 27);
            this.txtWashingReceivedQty.TabIndex = 4;
            this.txtWashingReceivedQty.Validated += new System.EventHandler(this.txtWashingReceivedQty_Validated);
            this.txtWashingReceivedQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWashingReceivedQty_KeyPress);
            // 
            // txtWashingIssuedQty
            // 
            this.txtWashingIssuedQty.Location = new System.Drawing.Point(328, 42);
            this.txtWashingIssuedQty.Name = "txtWashingIssuedQty";
            this.txtWashingIssuedQty.Size = new System.Drawing.Size(79, 27);
            this.txtWashingIssuedQty.TabIndex = 2;
            this.txtWashingIssuedQty.Validated += new System.EventHandler(this.txtWashingIssuedQty_Validated);
            this.txtWashingIssuedQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWashingIssuedQty_KeyPress);
            // 
            // dtpWashingEndDate
            // 
            this.dtpWashingEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpWashingEndDate.Checked = false;
            this.dtpWashingEndDate.CustomFormat = "dd/MM/yyyy";
            this.dtpWashingEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWashingEndDate.Location = new System.Drawing.Point(496, 42);
            this.dtpWashingEndDate.Name = "dtpWashingEndDate";
            this.dtpWashingEndDate.ShowCheckBox = true;
            this.dtpWashingEndDate.Size = new System.Drawing.Size(141, 27);
            this.dtpWashingEndDate.TabIndex = 3;
            this.dtpWashingEndDate.Validated += new System.EventHandler(this.dtpWashingEndDate_Validated);
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(414, 46);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 19);
            this.label22.TabIndex = 26;
            this.label22.Text = "End Date :";
            // 
            // dtpWashingStartDate
            // 
            this.dtpWashingStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtpWashingStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWashingStartDate.Location = new System.Drawing.Point(116, 42);
            this.dtpWashingStartDate.Name = "dtpWashingStartDate";
            this.dtpWashingStartDate.Size = new System.Drawing.Size(116, 27);
            this.dtpWashingStartDate.TabIndex = 1;
            this.dtpWashingStartDate.Validated += new System.EventHandler(this.dtpWashingStartDate_Validated);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(28, 46);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(82, 19);
            this.label23.TabIndex = 24;
            this.label23.Text = "Start Date :";
            // 
            // dgvWashingProcess
            // 
            this.dgvWashingProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWashingProcess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvWashingProcess.BackgroundColor = System.Drawing.Color.White;
            this.dgvWashingProcess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvWashingProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWashingProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WashingSrNo,
            this.WashingJobberName,
            this.WashingQty,
            this.WashingRate,
            this.WashingAmount,
            this.WashingNarration});
            this.dgvWashingProcess.Location = new System.Drawing.Point(7, 78);
            this.dgvWashingProcess.Name = "dgvWashingProcess";
            this.dgvWashingProcess.RowHeadersVisible = false;
            this.dgvWashingProcess.Size = new System.Drawing.Size(937, 238);
            this.dgvWashingProcess.TabIndex = 6;
            this.dgvWashingProcess.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWashingProcess_CellValueChanged);
            this.dgvWashingProcess.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvWashingProcess_RowsAdded);
            this.dgvWashingProcess.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvWashingProcess_EditingControlShowing);
            // 
            // WashingSrNo
            // 
            this.WashingSrNo.HeaderText = "Sr No";
            this.WashingSrNo.Name = "WashingSrNo";
            this.WashingSrNo.ReadOnly = true;
            this.WashingSrNo.Width = 68;
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
            this.WashingRate.Width = 64;
            // 
            // WashingAmount
            // 
            this.WashingAmount.HeaderText = "Amount";
            this.WashingAmount.Name = "WashingAmount";
            this.WashingAmount.ReadOnly = true;
            this.WashingAmount.Width = 84;
            // 
            // WashingNarration
            // 
            this.WashingNarration.HeaderText = "Narration";
            this.WashingNarration.Name = "WashingNarration";
            this.WashingNarration.Width = 95;
            // 
            // tpPressProcess
            // 
            this.tpPressProcess.Controls.Add(this.label34);
            this.tpPressProcess.Controls.Add(this.txtPressingRate);
            this.tpPressProcess.Controls.Add(this.dgvPressingProcess);
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
            this.tpPressProcess.Size = new System.Drawing.Size(952, 356);
            this.tpPressProcess.TabIndex = 5;
            this.tpPressProcess.Text = "Pressing Process";
            this.tpPressProcess.UseVisualStyleBackColor = true;
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(798, 45);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(47, 19);
            this.label34.TabIndex = 41;
            this.label34.Text = "Rate :";
            // 
            // txtPressingRate
            // 
            this.txtPressingRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPressingRate.Location = new System.Drawing.Point(851, 41);
            this.txtPressingRate.Name = "txtPressingRate";
            this.txtPressingRate.Size = new System.Drawing.Size(93, 27);
            this.txtPressingRate.TabIndex = 5;
            this.txtPressingRate.Validated += new System.EventHandler(this.txtPressingRate_Validated);
            // 
            // dgvPressingProcess
            // 
            this.dgvPressingProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPressingProcess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPressingProcess.BackgroundColor = System.Drawing.Color.White;
            this.dgvPressingProcess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPressingProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPressingProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PressingSrNo,
            this.PressingJobber,
            this.PressingQty,
            this.PressingRate,
            this.PressingAmount,
            this.PressingNarr});
            this.dgvPressingProcess.Location = new System.Drawing.Point(7, 77);
            this.dgvPressingProcess.Name = "dgvPressingProcess";
            this.dgvPressingProcess.RowHeadersVisible = false;
            this.dgvPressingProcess.Size = new System.Drawing.Size(937, 237);
            this.dgvPressingProcess.TabIndex = 6;
            this.dgvPressingProcess.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPressingProcess_CellValueChanged);
            this.dgvPressingProcess.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPressingProcess_RowsAdded);
            this.dgvPressingProcess.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvPressingProcess_EditingControlShowing);
            // 
            // PressingSrNo
            // 
            this.PressingSrNo.HeaderText = "Sr No";
            this.PressingSrNo.Name = "PressingSrNo";
            this.PressingSrNo.ReadOnly = true;
            this.PressingSrNo.Width = 68;
            // 
            // PressingJobber
            // 
            this.PressingJobber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PressingJobber.HeaderText = "Jobber Name";
            this.PressingJobber.Name = "PressingJobber";
            this.PressingJobber.Width = 99;
            // 
            // PressingQty
            // 
            this.PressingQty.HeaderText = "Qty";
            this.PressingQty.Name = "PressingQty";
            this.PressingQty.Width = 57;
            // 
            // PressingRate
            // 
            this.PressingRate.HeaderText = "Rate";
            this.PressingRate.Name = "PressingRate";
            this.PressingRate.Width = 64;
            // 
            // PressingAmount
            // 
            this.PressingAmount.HeaderText = "Amount";
            this.PressingAmount.Name = "PressingAmount";
            this.PressingAmount.ReadOnly = true;
            this.PressingAmount.Width = 84;
            // 
            // PressingNarr
            // 
            this.PressingNarr.HeaderText = "Narration";
            this.PressingNarr.Name = "PressingNarr";
            this.PressingNarr.Width = 95;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 12);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(101, 19);
            this.label24.TabIndex = 36;
            this.label24.Text = "Jobber Name :";
            // 
            // cmbPressingJobberName
            // 
            this.cmbPressingJobberName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPressingJobberName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPressingJobberName.FormattingEnabled = true;
            this.cmbPressingJobberName.Location = new System.Drawing.Point(110, 8);
            this.cmbPressingJobberName.Name = "cmbPressingJobberName";
            this.cmbPressingJobberName.Size = new System.Drawing.Size(834, 27);
            this.cmbPressingJobberName.TabIndex = 0;
            // 
            // txtPressingCostPerPcs
            // 
            this.txtPressingCostPerPcs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPressingCostPerPcs.Enabled = false;
            this.txtPressingCostPerPcs.Location = new System.Drawing.Point(509, 322);
            this.txtPressingCostPerPcs.Name = "txtPressingCostPerPcs";
            this.txtPressingCostPerPcs.Size = new System.Drawing.Size(128, 27);
            this.txtPressingCostPerPcs.TabIndex = 7;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(406, 326);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(97, 19);
            this.label25.TabIndex = 34;
            this.label25.Text = "Cost Per Pcs :";
            // 
            // txtPressingTotalAmount
            // 
            this.txtPressingTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPressingTotalAmount.Enabled = false;
            this.txtPressingTotalAmount.Location = new System.Drawing.Point(816, 322);
            this.txtPressingTotalAmount.Name = "txtPressingTotalAmount";
            this.txtPressingTotalAmount.Size = new System.Drawing.Size(128, 27);
            this.txtPressingTotalAmount.TabIndex = 8;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(707, 326);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(103, 19);
            this.label26.TabIndex = 32;
            this.label26.Text = "Total Amount :";
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(639, 44);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(71, 19);
            this.label27.TabIndex = 31;
            this.label27.Text = "Rcvd Qty:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(232, 45);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(82, 19);
            this.label28.TabIndex = 30;
            this.label28.Text = "Issued Qty:";
            // 
            // txtPressReceivedQty
            // 
            this.txtPressReceivedQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPressReceivedQty.Location = new System.Drawing.Point(716, 41);
            this.txtPressReceivedQty.Name = "txtPressReceivedQty";
            this.txtPressReceivedQty.Size = new System.Drawing.Size(74, 27);
            this.txtPressReceivedQty.TabIndex = 4;
            this.txtPressReceivedQty.Validated += new System.EventHandler(this.txtPressReceivedQty_Validated);
            this.txtPressReceivedQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPressReceivedQty_KeyPress);
            // 
            // txtPressIssuedQty
            // 
            this.txtPressIssuedQty.Location = new System.Drawing.Point(321, 41);
            this.txtPressIssuedQty.Name = "txtPressIssuedQty";
            this.txtPressIssuedQty.Size = new System.Drawing.Size(79, 27);
            this.txtPressIssuedQty.TabIndex = 2;
            this.txtPressIssuedQty.Validated += new System.EventHandler(this.txtPressIssuedQty_Validated);
            this.txtPressIssuedQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPressIssuedQty_KeyPress);
            // 
            // dtpPressEndDate
            // 
            this.dtpPressEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPressEndDate.Checked = false;
            this.dtpPressEndDate.CustomFormat = "dd/MM/yyyy";
            this.dtpPressEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPressEndDate.Location = new System.Drawing.Point(488, 41);
            this.dtpPressEndDate.Name = "dtpPressEndDate";
            this.dtpPressEndDate.ShowCheckBox = true;
            this.dtpPressEndDate.Size = new System.Drawing.Size(141, 27);
            this.dtpPressEndDate.TabIndex = 3;
            this.dtpPressEndDate.Validated += new System.EventHandler(this.dtpPressEndDate_Validated);
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(406, 45);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(76, 19);
            this.label30.TabIndex = 26;
            this.label30.Text = "End Date :";
            // 
            // dtpPressStartDate
            // 
            this.dtpPressStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtpPressStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPressStartDate.Location = new System.Drawing.Point(110, 41);
            this.dtpPressStartDate.Name = "dtpPressStartDate";
            this.dtpPressStartDate.Size = new System.Drawing.Size(116, 27);
            this.dtpPressStartDate.TabIndex = 1;
            this.dtpPressStartDate.Validated += new System.EventHandler(this.dtpPressStartDate_Validated);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(22, 45);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(82, 19);
            this.label31.TabIndex = 24;
            this.label31.Text = "Start Date :";
            // 
            // tpUsedItems
            // 
            this.tpUsedItems.Controls.Add(this.txtOthCostPrPcs);
            this.tpUsedItems.Controls.Add(this.label35);
            this.tpUsedItems.Controls.Add(this.txtOthTotalAmount);
            this.tpUsedItems.Controls.Add(this.label36);
            this.tpUsedItems.Controls.Add(this.dgvItemUsed);
            this.tpUsedItems.Location = new System.Drawing.Point(4, 28);
            this.tpUsedItems.Name = "tpUsedItems";
            this.tpUsedItems.Size = new System.Drawing.Size(952, 356);
            this.tpUsedItems.TabIndex = 2;
            this.tpUsedItems.Text = "Items/Accessories Used";
            this.tpUsedItems.UseVisualStyleBackColor = true;
            // 
            // txtOthCostPrPcs
            // 
            this.txtOthCostPrPcs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOthCostPrPcs.Enabled = false;
            this.txtOthCostPrPcs.Location = new System.Drawing.Point(511, 318);
            this.txtOthCostPrPcs.Name = "txtOthCostPrPcs";
            this.txtOthCostPrPcs.Size = new System.Drawing.Size(128, 27);
            this.txtOthCostPrPcs.TabIndex = 39;
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(408, 322);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(97, 19);
            this.label35.TabIndex = 38;
            this.label35.Text = "Cost Per Pcs :";
            // 
            // txtOthTotalAmount
            // 
            this.txtOthTotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOthTotalAmount.Enabled = false;
            this.txtOthTotalAmount.Location = new System.Drawing.Point(818, 318);
            this.txtOthTotalAmount.Name = "txtOthTotalAmount";
            this.txtOthTotalAmount.Size = new System.Drawing.Size(128, 27);
            this.txtOthTotalAmount.TabIndex = 37;
            // 
            // label36
            // 
            this.label36.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(709, 322);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(103, 19);
            this.label36.TabIndex = 36;
            this.label36.Text = "Total Amount :";
            // 
            // dgvItemUsed
            // 
            this.dgvItemUsed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItemUsed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvItemUsed.BackgroundColor = System.Drawing.Color.White;
            this.dgvItemUsed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvItemUsed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemUsed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OthSrNo,
            this.OthProduct,
            this.OthBatch,
            this.OthQty,
            this.OthRate,
            this.OthAmount});
            this.dgvItemUsed.Location = new System.Drawing.Point(7, 7);
            this.dgvItemUsed.Name = "dgvItemUsed";
            this.dgvItemUsed.RowHeadersVisible = false;
            this.dgvItemUsed.Size = new System.Drawing.Size(939, 305);
            this.dgvItemUsed.TabIndex = 1;
            this.dgvItemUsed.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemUsed_CellValueChanged);
            this.dgvItemUsed.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvItemUsed_RowsAdded);
            this.dgvItemUsed.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvItemUsed_EditingControlShowing);
            // 
            // OthSrNo
            // 
            this.OthSrNo.HeaderText = "SrNo";
            this.OthSrNo.Name = "OthSrNo";
            this.OthSrNo.ReadOnly = true;
            this.OthSrNo.Width = 64;
            // 
            // OthProduct
            // 
            this.OthProduct.HeaderText = "Product Name";
            this.OthProduct.Name = "OthProduct";
            this.OthProduct.Width = 106;
            // 
            // OthBatch
            // 
            this.OthBatch.HeaderText = "Batch No";
            this.OthBatch.Name = "OthBatch";
            this.OthBatch.Width = 74;
            // 
            // OthQty
            // 
            this.OthQty.HeaderText = "Qty";
            this.OthQty.Name = "OthQty";
            this.OthQty.Width = 57;
            // 
            // OthRate
            // 
            this.OthRate.HeaderText = "Rate";
            this.OthRate.Name = "OthRate";
            this.OthRate.Width = 64;
            // 
            // OthAmount
            // 
            this.OthAmount.HeaderText = "Amount";
            this.OthAmount.Name = "OthAmount";
            this.OthAmount.ReadOnly = true;
            this.OthAmount.Width = 84;
            // 
            // txtFabricCostPerPcs
            // 
            this.txtFabricCostPerPcs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtFabricCostPerPcs.Enabled = false;
            this.txtFabricCostPerPcs.Location = new System.Drawing.Point(619, 478);
            this.txtFabricCostPerPcs.Name = "txtFabricCostPerPcs";
            this.txtFabricCostPerPcs.Size = new System.Drawing.Size(75, 27);
            this.txtFabricCostPerPcs.TabIndex = 13;
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
            this.dtpProgramFinishedDate.TabIndex = 3;
            this.dtpProgramFinishedDate.Validated += new System.EventHandler(this.dtpProgramFinishedDate_Validated);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(477, 482);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Fabric Cost Per Pcs :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(610, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Program Finished Date :";
            // 
            // dtpProgramStartDate
            // 
            this.dtpProgramStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpProgramStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtpProgramStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpProgramStartDate.Location = new System.Drawing.Point(415, 15);
            this.dtpProgramStartDate.Name = "dtpProgramStartDate";
            this.dtpProgramStartDate.Size = new System.Drawing.Size(127, 27);
            this.dtpProgramStartDate.TabIndex = 1;
            this.dtpProgramStartDate.Validated += new System.EventHandler(this.dtpProgramStartDate_Validated);
            // 
            // txtCostingPerPcs
            // 
            this.txtCostingPerPcs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtCostingPerPcs.Enabled = false;
            this.txtCostingPerPcs.Location = new System.Drawing.Point(400, 478);
            this.txtCostingPerPcs.Name = "txtCostingPerPcs";
            this.txtCostingPerPcs.Size = new System.Drawing.Size(75, 27);
            this.txtCostingPerPcs.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Costing Per Pcs :";
            // 
            // txtProgramNo
            // 
            this.txtProgramNo.Enabled = false;
            this.txtProgramNo.Location = new System.Drawing.Point(112, 15);
            this.txtProgramNo.Name = "txtProgramNo";
            this.txtProgramNo.Size = new System.Drawing.Size(100, 27);
            this.txtProgramNo.TabIndex = 0;
            // 
            // txtAverageMtrPerPcs
            // 
            this.txtAverageMtrPerPcs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtAverageMtrPerPcs.Enabled = false;
            this.txtAverageMtrPerPcs.Location = new System.Drawing.Point(204, 478);
            this.txtAverageMtrPerPcs.Name = "txtAverageMtrPerPcs";
            this.txtAverageMtrPerPcs.Size = new System.Drawing.Size(75, 27);
            this.txtAverageMtrPerPcs.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Program Start Date :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Average Mtr Per Pcs :";
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
            this.lblId.Location = new System.Drawing.Point(11, 524);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(49, 19);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "label2";
            this.lblId.Visible = false;
            // 
            // lblExpertLinks
            // 
            this.lblExpertLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblExpertLinks.AutoSize = true;
            this.lblExpertLinks.Location = new System.Drawing.Point(794, 524);
            this.lblExpertLinks.Name = "lblExpertLinks";
            this.lblExpertLinks.Size = new System.Drawing.Size(49, 19);
            this.lblExpertLinks.TabIndex = 14;
            this.lblExpertLinks.Text = "label2";
            this.lblExpertLinks.Visible = false;
            // 
            // frmMfgCycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 556);
            this.Controls.Add(this.lblExpertLinks);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblId);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMfgCycle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garment Manufacturing Cycle";
            this.Load += new System.EventHandler(this.frmMfgCycle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabProcess.ResumeLayout(false);
            this.tpCuttingProcess.ResumeLayout(false);
            this.tpCuttingProcess.PerformLayout();
            this.tabCutter.ResumeLayout(false);
            this.tabCutterInfo.ResumeLayout(false);
            this.tabCutterInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuttingProcess)).EndInit();
            this.tabFabricUsed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabricUsed)).EndInit();
            this.tpWashingProcess.ResumeLayout(false);
            this.tpWashingProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWashingProcess)).EndInit();
            this.tpPressProcess.ResumeLayout(false);
            this.tpPressProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPressingProcess)).EndInit();
            this.tpUsedItems.ResumeLayout(false);
            this.tpUsedItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemUsed)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtpProgramStartDate;
        private System.Windows.Forms.TextBox txtProgramNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TabControl tabProcess;
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
        private System.Windows.Forms.DataGridView dgvItemUsed;
        private System.Windows.Forms.TextBox txtCuttingCostPerPcs;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCuttingTotalAmount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtLotSize;
        private System.Windows.Forms.Label label16;
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
        private System.Windows.Forms.DataGridView dgvPressingProcess;
        private System.Windows.Forms.TabControl tabCutter;
        private System.Windows.Forms.TabPage tabCutterInfo;
        private System.Windows.Forms.TabPage tabFabricUsed;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox cmbCuttingJobberName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCuttingReceivedQty;
        private System.Windows.Forms.TextBox txtCuttingIssuedQty;
        private System.Windows.Forms.DateTimePicker dtpCuttingEndDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpCuttingStartDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvCuttingProcess;
        private System.Windows.Forms.DataGridView dgvFabricUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewComboBoxColumn BatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsedMtr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OthSrNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn OthProduct;
        private System.Windows.Forms.DataGridViewComboBoxColumn OthBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn OthQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn OthRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OthAmount;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtCuttingRate;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtWashingRate;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtPressingRate;
        private System.Windows.Forms.TextBox txtOthCostPrPcs;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtOthTotalAmount;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuttingSrNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn CuttingJobberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuttingType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuttingIssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuttingIssuedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuttingReceivedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuttingReceivedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuttingRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuttingAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuttingNarration;
        private System.Windows.Forms.DataGridViewTextBoxColumn WashingSrNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn WashingJobberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WashingQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn WashingRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn WashingAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn WashingNarration;
        private System.Windows.Forms.DataGridViewTextBoxColumn PressingSrNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn PressingJobber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PressingQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn PressingRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PressingAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PressingNarr;
        private System.Windows.Forms.Label lblExpertLinks;
    }
}
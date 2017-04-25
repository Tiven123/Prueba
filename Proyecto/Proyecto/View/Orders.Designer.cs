namespace Proyecto.View
{
    partial class Orders
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
            this.Reparaciones = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nuReplacement = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvReplacements = new System.Windows.Forms.DataGridView();
            this.codeReplacement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalReplacement = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCostReplacement = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbReplacement = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nuRepair = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCostRepair = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEmploye = new System.Windows.Forms.ComboBox();
            this.dgvRepairs = new System.Windows.Forms.DataGridView();
            this.colrepa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colencar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colhora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotalRepair = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbRepair = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.CarYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPerOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRepairs = new System.Windows.Forms.TextBox();
            this.txtTotalReplacements = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalOrder = new System.Windows.Forms.TextBox();
            this.buttonCompleteOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerExit = new System.Windows.Forms.DateTimePicker();
            this.comboBoxVehicle = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePickerDateEntry = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnCalculateTotal = new System.Windows.Forms.Button();
            this.Reparaciones.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuReplacement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReplacements)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuRepair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepairs)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // Reparaciones
            // 
            this.Reparaciones.AccessibleName = "cxc";
            this.Reparaciones.Controls.Add(this.tabPage1);
            this.Reparaciones.Controls.Add(this.tabPage2);
            this.Reparaciones.Controls.Add(this.tabPage3);
            this.Reparaciones.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reparaciones.Location = new System.Drawing.Point(14, 62);
            this.Reparaciones.Name = "Reparaciones";
            this.Reparaciones.SelectedIndex = 0;
            this.Reparaciones.Size = new System.Drawing.Size(749, 364);
            this.Reparaciones.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nuReplacement);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dgvReplacements);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtTotalReplacement);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtCostReplacement);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.cbReplacement);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(741, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Repuestos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // nuReplacement
            // 
            this.nuReplacement.Location = new System.Drawing.Point(11, 94);
            this.nuReplacement.Name = "nuReplacement";
            this.nuReplacement.Size = new System.Drawing.Size(195, 21);
            this.nuReplacement.TabIndex = 19;
            this.nuReplacement.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuReplacement.ValueChanged += new System.EventHandler(this.nuReplacement_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Cantidad";
            // 
            // dgvReplacements
            // 
            this.dgvReplacements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReplacements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeReplacement,
            this.colcan,
            this.colcosto,
            this.coltotal});
            this.dgvReplacements.Location = new System.Drawing.Point(243, 6);
            this.dgvReplacements.Name = "dgvReplacements";
            this.dgvReplacements.Size = new System.Drawing.Size(492, 315);
            this.dgvReplacements.TabIndex = 17;
            this.dgvReplacements.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReplacements_CellClick);
            // 
            // codeReplacement
            // 
            this.codeReplacement.HeaderText = "Repuesto";
            this.codeReplacement.Name = "codeReplacement";
            // 
            // colcan
            // 
            this.colcan.HeaderText = "Cantidad";
            this.colcan.Name = "colcan";
            // 
            // colcosto
            // 
            this.colcosto.HeaderText = "Costo";
            this.colcosto.Name = "colcosto";
            // 
            // coltotal
            // 
            this.coltotal.HeaderText = "Total";
            this.coltotal.Name = "coltotal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Total:";
            // 
            // txtTotalReplacement
            // 
            this.txtTotalReplacement.Location = new System.Drawing.Point(9, 201);
            this.txtTotalReplacement.Name = "txtTotalReplacement";
            this.txtTotalReplacement.ReadOnly = true;
            this.txtTotalReplacement.Size = new System.Drawing.Size(197, 21);
            this.txtTotalReplacement.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Quitar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCostReplacement
            // 
            this.txtCostReplacement.Location = new System.Drawing.Point(9, 148);
            this.txtCostReplacement.Name = "txtCostReplacement";
            this.txtCostReplacement.ReadOnly = true;
            this.txtCostReplacement.Size = new System.Drawing.Size(197, 21);
            this.txtCostReplacement.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Costo";
            // 
            // cbReplacement
            // 
            this.cbReplacement.FormattingEnabled = true;
            this.cbReplacement.Location = new System.Drawing.Point(9, 33);
            this.cbReplacement.Name = "cbReplacement";
            this.cbReplacement.Size = new System.Drawing.Size(197, 24);
            this.cbReplacement.TabIndex = 7;
            this.cbReplacement.SelectedIndexChanged += new System.EventHandler(this.cbReplacement_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Repuesto";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.nuRepair);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtCostRepair);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cbEmploye);
            this.tabPage2.Controls.Add(this.dgvRepairs);
            this.tabPage2.Controls.Add(this.txtTotalRepair);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cbRepair);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(741, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reparaciones";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // nuRepair
            // 
            this.nuRepair.Location = new System.Drawing.Point(10, 160);
            this.nuRepair.Name = "nuRepair";
            this.nuRepair.Size = new System.Drawing.Size(163, 21);
            this.nuRepair.TabIndex = 61;
            this.nuRepair.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 16);
            this.label13.TabIndex = 60;
            this.label13.Text = "Horas";
            // 
            // txtCostRepair
            // 
            this.txtCostRepair.Location = new System.Drawing.Point(6, 115);
            this.txtCostRepair.Name = "txtCostRepair";
            this.txtCostRepair.ReadOnly = true;
            this.txtCostRepair.Size = new System.Drawing.Size(167, 21);
            this.txtCostRepair.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 58;
            this.label9.Text = "Costo por Hora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 57;
            this.label6.Text = "Encargado";
            // 
            // cbEmploye
            // 
            this.cbEmploye.FormattingEnabled = true;
            this.cbEmploye.Location = new System.Drawing.Point(6, 69);
            this.cbEmploye.Name = "cbEmploye";
            this.cbEmploye.Size = new System.Drawing.Size(167, 24);
            this.cbEmploye.TabIndex = 56;
            // 
            // dgvRepairs
            // 
            this.dgvRepairs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepairs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colrepa,
            this.colencar,
            this.dataGridViewTextBoxColumn1,
            this.colhora,
            this.dataGridViewTextBoxColumn2});
            this.dgvRepairs.Location = new System.Drawing.Point(179, 9);
            this.dgvRepairs.Name = "dgvRepairs";
            this.dgvRepairs.Size = new System.Drawing.Size(550, 320);
            this.dgvRepairs.TabIndex = 7;
            // 
            // colrepa
            // 
            this.colrepa.HeaderText = "Reparación";
            this.colrepa.Name = "colrepa";
            // 
            // colencar
            // 
            this.colencar.HeaderText = "Encargado";
            this.colencar.Name = "colencar";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Costo por Hora";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // colhora
            // 
            this.colhora.HeaderText = "Horas";
            this.colhora.Name = "colhora";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Total";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // txtTotalRepair
            // 
            this.txtTotalRepair.Location = new System.Drawing.Point(10, 202);
            this.txtTotalRepair.Name = "txtTotalRepair";
            this.txtTotalRepair.ReadOnly = true;
            this.txtTotalRepair.Size = new System.Drawing.Size(163, 21);
            this.txtTotalRepair.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(51, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Quitar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(51, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Reparación";
            // 
            // cbRepair
            // 
            this.cbRepair.FormattingEnabled = true;
            this.cbRepair.Location = new System.Drawing.Point(6, 23);
            this.cbRepair.Name = "cbRepair";
            this.cbRepair.Size = new System.Drawing.Size(167, 24);
            this.cbRepair.TabIndex = 1;
            this.cbRepair.SelectedIndexChanged += new System.EventHandler(this.cbRepair_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCalculateTotal);
            this.tabPage3.Controls.Add(this.dataGridViewOrders);
            this.tabPage3.Controls.Add(this.txtRepairs);
            this.tabPage3.Controls.Add(this.txtTotalReplacements);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.txtTotalOrder);
            this.tabPage3.Controls.Add(this.buttonCompleteOrder);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(741, 335);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Total";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarYear,
            this.Vehicle,
            this.Employee,
            this.EntryDate,
            this.ExitDate,
            this.BillingDate,
            this.State,
            this.CostPerOrder,
            this.BillNumber});
            this.dataGridViewOrders.Location = new System.Drawing.Point(275, 14);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.Size = new System.Drawing.Size(591, 315);
            this.dataGridViewOrders.TabIndex = 25;
            // 
            // CarYear
            // 
            this.CarYear.DataPropertyName = "CarYear";
            this.CarYear.HeaderText = "Año del vehículo";
            this.CarYear.Name = "CarYear";
            this.CarYear.ReadOnly = true;
            // 
            // Vehicle
            // 
            this.Vehicle.DataPropertyName = "Vehicle";
            this.Vehicle.HeaderText = "Vehículo";
            this.Vehicle.Name = "Vehicle";
            this.Vehicle.ReadOnly = true;
            // 
            // Employee
            // 
            this.Employee.DataPropertyName = "Employee";
            this.Employee.HeaderText = "Empleado";
            this.Employee.Name = "Employee";
            this.Employee.ReadOnly = true;
            // 
            // EntryDate
            // 
            this.EntryDate.DataPropertyName = "EntryDate";
            this.EntryDate.HeaderText = "Fecha de entrada";
            this.EntryDate.Name = "EntryDate";
            this.EntryDate.ReadOnly = true;
            // 
            // ExitDate
            // 
            this.ExitDate.DataPropertyName = "ExitDate";
            this.ExitDate.HeaderText = "Fecha de salida";
            this.ExitDate.Name = "ExitDate";
            this.ExitDate.ReadOnly = true;
            // 
            // BillingDate
            // 
            this.BillingDate.DataPropertyName = "BillingDate";
            this.BillingDate.HeaderText = "Fecha de factura";
            this.BillingDate.Name = "BillingDate";
            this.BillingDate.ReadOnly = true;
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "Estado";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // CostPerOrder
            // 
            this.CostPerOrder.DataPropertyName = "CostPerOrder";
            this.CostPerOrder.HeaderText = "Monto de la orden";
            this.CostPerOrder.Name = "CostPerOrder";
            this.CostPerOrder.ReadOnly = true;
            // 
            // BillNumber
            // 
            this.BillNumber.DataPropertyName = "BillNumber";
            this.BillNumber.HeaderText = "Número de factura";
            this.BillNumber.Name = "BillNumber";
            this.BillNumber.ReadOnly = true;
            // 
            // txtRepairs
            // 
            this.txtRepairs.Location = new System.Drawing.Point(11, 87);
            this.txtRepairs.Name = "txtRepairs";
            this.txtRepairs.ReadOnly = true;
            this.txtRepairs.Size = new System.Drawing.Size(258, 21);
            this.txtRepairs.TabIndex = 7;
            // 
            // txtTotalReplacements
            // 
            this.txtTotalReplacements.Location = new System.Drawing.Point(11, 32);
            this.txtTotalReplacements.Name = "txtTotalReplacements";
            this.txtTotalReplacements.ReadOnly = true;
            this.txtTotalReplacements.Size = new System.Drawing.Size(258, 21);
            this.txtTotalReplacements.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 16);
            this.label16.TabIndex = 5;
            this.label16.Text = "Total por Reparación";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 16);
            this.label15.TabIndex = 4;
            this.label15.Text = "Total por Repuestos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monto Total de la Orden ";
            // 
            // txtTotalOrder
            // 
            this.txtTotalOrder.Location = new System.Drawing.Point(11, 146);
            this.txtTotalOrder.Name = "txtTotalOrder";
            this.txtTotalOrder.ReadOnly = true;
            this.txtTotalOrder.Size = new System.Drawing.Size(258, 21);
            this.txtTotalOrder.TabIndex = 2;
            // 
            // buttonCompleteOrder
            // 
            this.buttonCompleteOrder.Location = new System.Drawing.Point(87, 252);
            this.buttonCompleteOrder.Name = "buttonCompleteOrder";
            this.buttonCompleteOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonCompleteOrder.TabIndex = 1;
            this.buttonCompleteOrder.Text = "Completar ";
            this.buttonCompleteOrder.UseVisualStyleBackColor = true;
            this.buttonCompleteOrder.Click += new System.EventHandler(this.buttonCompleteOrder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Fecha de Salida";
            // 
            // dateTimePickerExit
            // 
            this.dateTimePickerExit.Location = new System.Drawing.Point(197, 26);
            this.dateTimePickerExit.Name = "dateTimePickerExit";
            this.dateTimePickerExit.Size = new System.Drawing.Size(152, 20);
            this.dateTimePickerExit.TabIndex = 58;
            // 
            // comboBoxVehicle
            // 
            this.comboBoxVehicle.FormattingEnabled = true;
            this.comboBoxVehicle.Location = new System.Drawing.Point(372, 25);
            this.comboBoxVehicle.Name = "comboBoxVehicle";
            this.comboBoxVehicle.Size = new System.Drawing.Size(122, 21);
            this.comboBoxVehicle.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Encargado";
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(514, 26);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(127, 21);
            this.comboBoxEmployee.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(372, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "Vehículo";
            // 
            // dateTimePickerDateEntry
            // 
            this.dateTimePickerDateEntry.Location = new System.Drawing.Point(14, 26);
            this.dateTimePickerDateEntry.Name = "dateTimePickerDateEntry";
            this.dateTimePickerDateEntry.Size = new System.Drawing.Size(148, 20);
            this.dateTimePickerDateEntry.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "Fecha de entrada";
            // 
            // btnCalculateTotal
            // 
            this.btnCalculateTotal.Location = new System.Drawing.Point(68, 196);
            this.btnCalculateTotal.Name = "btnCalculateTotal";
            this.btnCalculateTotal.Size = new System.Drawing.Size(112, 23);
            this.btnCalculateTotal.TabIndex = 26;
            this.btnCalculateTotal.Text = "Calcular Total";
            this.btnCalculateTotal.UseVisualStyleBackColor = true;
            this.btnCalculateTotal.Click += new System.EventHandler(this.btnCalculateTotal_Click);
            // 
            // Orders
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 438);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerExit);
            this.Controls.Add(this.comboBoxVehicle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePickerDateEntry);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Reparaciones);
            this.Name = "Orders";
            this.Text = "Reparaciones";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.Reparaciones.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuReplacement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReplacements)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuRepair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepairs)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl Reparaciones;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtCostReplacement;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbReplacement;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbRepair;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalReplacement;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTotalRepair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalOrder;
        private System.Windows.Forms.Button buttonCompleteOrder;
        private System.Windows.Forms.TextBox txtRepairs;
        private System.Windows.Forms.TextBox txtTotalReplacements;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerExit;
        private System.Windows.Forms.ComboBox comboBoxVehicle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateEntry;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvReplacements;
        private System.Windows.Forms.DataGridView dgvRepairs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbEmploye;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCostRepair;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPerOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNumber;
        private System.Windows.Forms.NumericUpDown nuRepair;
        private System.Windows.Forms.NumericUpDown nuReplacement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colrepa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colencar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colhora;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeReplacement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltotal;
        private System.Windows.Forms.Button btnCalculateTotal;
    }
}
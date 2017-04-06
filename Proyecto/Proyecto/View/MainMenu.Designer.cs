namespace Proyecto
{
    partial class MainMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerBilling = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerEntry = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerExit = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonBilling = new System.Windows.Forms.RadioButton();
            this.radioButtonExit = new System.Windows.Forms.RadioButton();
            this.radioButtonEntry = new System.Windows.Forms.RadioButton();
            this.radioButtonState = new System.Windows.Forms.RadioButton();
            this.radioButtonInCharge = new System.Windows.Forms.RadioButton();
            this.radioButtonVehicle = new System.Windows.Forms.RadioButton();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAsk = new System.Windows.Forms.Button();
            this.comboBoxVehicle = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.Consecutive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPerOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.btnRegisterPosition = new System.Windows.Forms.Button();
            this.btnRegisterEmployee = new System.Windows.Forms.Button();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnModel = new System.Windows.Forms.Button();
            this.btnRepairs = new System.Windows.Forms.Button();
            this.btnReplacement = new System.Windows.Forms.Button();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.btnBrands = new System.Windows.Forms.Button();
            this.btnClientRegister = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(941, 521);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dateTimePickerBilling);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dateTimePickerEntry);
            this.tabPage2.Controls.Add(this.dateTimePickerExit);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.buttonShowAll);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.buttonDelete);
            this.tabPage2.Controls.Add(this.buttonAsk);
            this.tabPage2.Controls.Add(this.comboBoxVehicle);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.comboBoxEmployee);
            this.tabPage2.Controls.Add(this.buttonFilter);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.buttonCheck);
            this.tabPage2.Controls.Add(this.buttonFinish);
            this.tabPage2.Controls.Add(this.buttonNew);
            this.tabPage2.Controls.Add(this.dataGridViewOrders);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(933, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Administración de Ordenes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Fecha de Facturación";
            // 
            // dateTimePickerBilling
            // 
            this.dateTimePickerBilling.Location = new System.Drawing.Point(455, 91);
            this.dateTimePickerBilling.Name = "dateTimePickerBilling";
            this.dateTimePickerBilling.Size = new System.Drawing.Size(213, 20);
            this.dateTimePickerBilling.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Fecha de Salida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Fecha de Entrada";
            // 
            // dateTimePickerEntry
            // 
            this.dateTimePickerEntry.Location = new System.Drawing.Point(225, 107);
            this.dateTimePickerEntry.Name = "dateTimePickerEntry";
            this.dateTimePickerEntry.Size = new System.Drawing.Size(213, 20);
            this.dateTimePickerEntry.TabIndex = 50;
            // 
            // dateTimePickerExit
            // 
            this.dateTimePickerExit.Location = new System.Drawing.Point(455, 38);
            this.dateTimePickerExit.Name = "dateTimePickerExit";
            this.dateTimePickerExit.Size = new System.Drawing.Size(213, 20);
            this.dateTimePickerExit.TabIndex = 48;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonBilling);
            this.groupBox1.Controls.Add(this.radioButtonExit);
            this.groupBox1.Controls.Add(this.radioButtonEntry);
            this.groupBox1.Controls.Add(this.radioButtonState);
            this.groupBox1.Controls.Add(this.radioButtonInCharge);
            this.groupBox1.Controls.Add(this.radioButtonVehicle);
            this.groupBox1.Location = new System.Drawing.Point(687, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 90);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por:";
            // 
            // radioButtonBilling
            // 
            this.radioButtonBilling.AutoSize = true;
            this.radioButtonBilling.Location = new System.Drawing.Point(110, 66);
            this.radioButtonBilling.Name = "radioButtonBilling";
            this.radioButtonBilling.Size = new System.Drawing.Size(129, 17);
            this.radioButtonBilling.TabIndex = 8;
            this.radioButtonBilling.TabStop = true;
            this.radioButtonBilling.Text = "Fecha de Facturación";
            this.radioButtonBilling.UseVisualStyleBackColor = true;
            this.radioButtonBilling.Click += new System.EventHandler(this.radioButtonBilling_Click);
            // 
            // radioButtonExit
            // 
            this.radioButtonExit.AutoSize = true;
            this.radioButtonExit.Location = new System.Drawing.Point(110, 43);
            this.radioButtonExit.Name = "radioButtonExit";
            this.radioButtonExit.Size = new System.Drawing.Size(102, 17);
            this.radioButtonExit.TabIndex = 7;
            this.radioButtonExit.TabStop = true;
            this.radioButtonExit.Text = "Fecha de Salida";
            this.radioButtonExit.UseVisualStyleBackColor = true;
            this.radioButtonExit.Click += new System.EventHandler(this.radioButtonExit_Click);
            // 
            // radioButtonEntry
            // 
            this.radioButtonEntry.AutoSize = true;
            this.radioButtonEntry.Location = new System.Drawing.Point(110, 19);
            this.radioButtonEntry.Name = "radioButtonEntry";
            this.radioButtonEntry.Size = new System.Drawing.Size(110, 17);
            this.radioButtonEntry.TabIndex = 6;
            this.radioButtonEntry.TabStop = true;
            this.radioButtonEntry.Text = "Fecha de Entrada";
            this.radioButtonEntry.UseVisualStyleBackColor = true;
            this.radioButtonEntry.Click += new System.EventHandler(this.radioButtonEntry_Click);
            // 
            // radioButtonState
            // 
            this.radioButtonState.AutoSize = true;
            this.radioButtonState.Location = new System.Drawing.Point(21, 67);
            this.radioButtonState.Name = "radioButtonState";
            this.radioButtonState.Size = new System.Drawing.Size(58, 17);
            this.radioButtonState.TabIndex = 5;
            this.radioButtonState.Text = "Estado";
            this.radioButtonState.UseVisualStyleBackColor = true;
            this.radioButtonState.Click += new System.EventHandler(this.radioButtonState_Click);
            // 
            // radioButtonInCharge
            // 
            this.radioButtonInCharge.AutoSize = true;
            this.radioButtonInCharge.Location = new System.Drawing.Point(21, 43);
            this.radioButtonInCharge.Name = "radioButtonInCharge";
            this.radioButtonInCharge.Size = new System.Drawing.Size(77, 17);
            this.radioButtonInCharge.TabIndex = 4;
            this.radioButtonInCharge.Text = "Encargado";
            this.radioButtonInCharge.UseVisualStyleBackColor = true;
            this.radioButtonInCharge.Click += new System.EventHandler(this.radioButtonInCharge_Click);
            // 
            // radioButtonVehicle
            // 
            this.radioButtonVehicle.AutoSize = true;
            this.radioButtonVehicle.Checked = true;
            this.radioButtonVehicle.Location = new System.Drawing.Point(21, 19);
            this.radioButtonVehicle.Name = "radioButtonVehicle";
            this.radioButtonVehicle.Size = new System.Drawing.Size(68, 17);
            this.radioButtonVehicle.TabIndex = 3;
            this.radioButtonVehicle.TabStop = true;
            this.radioButtonVehicle.Text = "Vehículo";
            this.radioButtonVehicle.UseVisualStyleBackColor = true;
            this.radioButtonVehicle.Click += new System.EventHandler(this.radioButtonVehicle_Click);
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(715, 104);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(75, 23);
            this.buttonShowAll.TabIndex = 46;
            this.buttonShowAll.Text = "Ver Todos";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(225, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 21);
            this.comboBox1.TabIndex = 45;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(331, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 44;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAsk
            // 
            this.buttonAsk.Location = new System.Drawing.Point(169, 11);
            this.buttonAsk.Name = "buttonAsk";
            this.buttonAsk.Size = new System.Drawing.Size(75, 23);
            this.buttonAsk.TabIndex = 43;
            this.buttonAsk.Text = "Facturar";
            this.buttonAsk.UseVisualStyleBackColor = true;
            this.buttonAsk.Click += new System.EventHandler(this.buttonAsk_Click);
            // 
            // comboBoxVehicle
            // 
            this.comboBoxVehicle.FormattingEnabled = true;
            this.comboBoxVehicle.Location = new System.Drawing.Point(10, 62);
            this.comboBoxVehicle.Name = "comboBoxVehicle";
            this.comboBoxVehicle.Size = new System.Drawing.Size(198, 21);
            this.comboBoxVehicle.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Encargado";
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(10, 104);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(198, 21);
            this.comboBoxEmployee.TabIndex = 35;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(838, 104);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonFilter.TabIndex = 34;
            this.buttonFilter.Text = "Filtrar";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Vehículo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Estado";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(250, 11);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.TabIndex = 28;
            this.buttonCheck.Text = "Revertir";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(88, 12);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(75, 23);
            this.buttonFinish.TabIndex = 27;
            this.buttonFinish.Text = "Finalizar";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(6, 12);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 25;
            this.buttonNew.Text = "Nueva";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Consecutive,
            this.CarYear,
            this.Vehicle,
            this.Employee,
            this.EntryDate,
            this.ExitDate,
            this.BillingDate,
            this.State,
            this.CostPerOrder,
            this.BillNumber});
            this.dataGridViewOrders.Location = new System.Drawing.Point(6, 144);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.Size = new System.Drawing.Size(921, 344);
            this.dataGridViewOrders.TabIndex = 24;
            this.dataGridViewOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellClick);
            // 
            // Consecutive
            // 
            this.Consecutive.DataPropertyName = "Consecutive";
            this.Consecutive.HeaderText = "Consecutivo";
            this.Consecutive.Name = "Consecutive";
            this.Consecutive.ReadOnly = true;
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.btnRegisterPosition);
            this.tabPage3.Controls.Add(this.btnRegisterEmployee);
            this.tabPage3.Controls.Add(this.buttonChangePassword);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(933, 495);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sistema";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(259, 275);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnRegisterPosition
            // 
            this.btnRegisterPosition.Location = new System.Drawing.Point(259, 219);
            this.btnRegisterPosition.Name = "btnRegisterPosition";
            this.btnRegisterPosition.Size = new System.Drawing.Size(150, 23);
            this.btnRegisterPosition.TabIndex = 2;
            this.btnRegisterPosition.Text = "Registro Puestos";
            this.btnRegisterPosition.UseVisualStyleBackColor = true;
            this.btnRegisterPosition.Click += new System.EventHandler(this.btnRegisterPosition_Click);
            // 
            // btnRegisterEmployee
            // 
            this.btnRegisterEmployee.Location = new System.Drawing.Point(259, 160);
            this.btnRegisterEmployee.Name = "btnRegisterEmployee";
            this.btnRegisterEmployee.Size = new System.Drawing.Size(150, 23);
            this.btnRegisterEmployee.TabIndex = 1;
            this.btnRegisterEmployee.Text = "Registro Empleados";
            this.btnRegisterEmployee.UseVisualStyleBackColor = true;
            this.btnRegisterEmployee.Click += new System.EventHandler(this.btnRegisterEmployee_Click);
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Location = new System.Drawing.Point(259, 100);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(150, 23);
            this.buttonChangePassword.TabIndex = 0;
            this.buttonChangePassword.Text = "Cambio Contraseña";
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnModel);
            this.tabPage1.Controls.Add(this.btnRepairs);
            this.tabPage1.Controls.Add(this.btnReplacement);
            this.tabPage1.Controls.Add(this.btnVehicle);
            this.tabPage1.Controls.Add(this.btnBrands);
            this.tabPage1.Controls.Add(this.btnClientRegister);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(933, 495);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Parámetros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnModel
            // 
            this.btnModel.Location = new System.Drawing.Point(398, 182);
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(158, 23);
            this.btnModel.TabIndex = 7;
            this.btnModel.Text = "Registro Modelos";
            this.btnModel.UseVisualStyleBackColor = true;
            this.btnModel.Click += new System.EventHandler(this.btnModel_Click);
            // 
            // btnRepairs
            // 
            this.btnRepairs.Location = new System.Drawing.Point(119, 294);
            this.btnRepairs.Name = "btnRepairs";
            this.btnRepairs.Size = new System.Drawing.Size(173, 23);
            this.btnRepairs.TabIndex = 6;
            this.btnRepairs.Text = "Registro Catalogo Reparaciones";
            this.btnRepairs.UseVisualStyleBackColor = true;
            this.btnRepairs.Click += new System.EventHandler(this.btnRepairs_Click);
            // 
            // btnReplacement
            // 
            this.btnReplacement.Location = new System.Drawing.Point(398, 294);
            this.btnReplacement.Name = "btnReplacement";
            this.btnReplacement.Size = new System.Drawing.Size(158, 23);
            this.btnReplacement.TabIndex = 3;
            this.btnReplacement.Text = "Registro Catalogo Repuestos";
            this.btnReplacement.UseVisualStyleBackColor = true;
            this.btnReplacement.Click += new System.EventHandler(this.btnReplacement_Click);
            // 
            // btnVehicle
            // 
            this.btnVehicle.Location = new System.Drawing.Point(119, 182);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(173, 23);
            this.btnVehicle.TabIndex = 2;
            this.btnVehicle.Text = "Registro de Vehiculos";
            this.btnVehicle.UseVisualStyleBackColor = true;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click);
            // 
            // btnBrands
            // 
            this.btnBrands.Location = new System.Drawing.Point(398, 89);
            this.btnBrands.Name = "btnBrands";
            this.btnBrands.Size = new System.Drawing.Size(158, 23);
            this.btnBrands.TabIndex = 1;
            this.btnBrands.Text = "Registro Marcas ";
            this.btnBrands.UseVisualStyleBackColor = true;
            this.btnBrands.Click += new System.EventHandler(this.btnBrands_Click);
            // 
            // btnClientRegister
            // 
            this.btnClientRegister.Location = new System.Drawing.Point(118, 89);
            this.btnClientRegister.Name = "btnClientRegister";
            this.btnClientRegister.Size = new System.Drawing.Size(174, 23);
            this.btnClientRegister.TabIndex = 0;
            this.btnClientRegister.Text = "Registro Clientes";
            this.btnClientRegister.UseVisualStyleBackColor = true;
            this.btnClientRegister.Click += new System.EventHandler(this.btnClientRegister_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(933, 495);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Gestión Gerencial";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 542);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnRegisterPosition;
        private System.Windows.Forms.Button btnRegisterEmployee;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.Button btnRepairs;
        private System.Windows.Forms.Button btnReplacement;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Button btnBrands;
        private System.Windows.Forms.Button btnClientRegister;
        private System.Windows.Forms.Button btnModel;
        private System.Windows.Forms.ComboBox comboBoxVehicle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consecutive;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPerOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNumber;
        private System.Windows.Forms.Button buttonAsk;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonState;
        private System.Windows.Forms.RadioButton radioButtonInCharge;
        private System.Windows.Forms.RadioButton radioButtonVehicle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerBilling;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerEntry;
        private System.Windows.Forms.DateTimePicker dateTimePickerExit;
        private System.Windows.Forms.RadioButton radioButtonBilling;
        private System.Windows.Forms.RadioButton radioButtonExit;
        private System.Windows.Forms.RadioButton radioButtonEntry;
    }
}


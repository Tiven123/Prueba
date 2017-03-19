namespace Proyecto.View
{
    partial class Employees
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
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.textBoxEmployeeCod = new System.Windows.Forms.TextBox();
            this.textBoxLastName1 = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxLastName2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxMagnamentManager = new System.Windows.Forms.CheckBox();
            this.checkBoxParameters = new System.Windows.Forms.CheckBox();
            this.checkBoxOrderManager = new System.Windows.Forms.CheckBox();
            this.checkBoxSystemAccess = new System.Windows.Forms.CheckBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxHousePhone = new System.Windows.Forms.TextBox();
            this.textBoxCelPhone = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.buttonClean = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(16, 434);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Agregar";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(123, 39);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(150, 21);
            this.comboBoxPosition.TabIndex = 2;
            // 
            // textBoxEmployeeCod
            // 
            this.textBoxEmployeeCod.Location = new System.Drawing.Point(123, 13);
            this.textBoxEmployeeCod.Name = "textBoxEmployeeCod";
            this.textBoxEmployeeCod.Size = new System.Drawing.Size(150, 20);
            this.textBoxEmployeeCod.TabIndex = 3;
            this.textBoxEmployeeCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEmployeeCod_KeyPress);
            // 
            // textBoxLastName1
            // 
            this.textBoxLastName1.Location = new System.Drawing.Point(123, 92);
            this.textBoxLastName1.Name = "textBoxLastName1";
            this.textBoxLastName1.Size = new System.Drawing.Size(150, 20);
            this.textBoxLastName1.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(123, 66);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(150, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxLastName2
            // 
            this.textBoxLastName2.Location = new System.Drawing.Point(123, 122);
            this.textBoxLastName2.Name = "textBoxLastName2";
            this.textBoxLastName2.Size = new System.Drawing.Size(150, 20);
            this.textBoxLastName2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Codigo de empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Posición";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Primer Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Segundo Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dirección";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telefono de casa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Celular";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Username";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxMagnamentManager);
            this.groupBox1.Controls.Add(this.checkBoxParameters);
            this.groupBox1.Controls.Add(this.checkBoxOrderManager);
            this.groupBox1.Controls.Add(this.checkBoxSystemAccess);
            this.groupBox1.Location = new System.Drawing.Point(20, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 115);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nivel de acceso";
            // 
            // checkBoxMagnamentManager
            // 
            this.checkBoxMagnamentManager.AutoSize = true;
            this.checkBoxMagnamentManager.Location = new System.Drawing.Point(7, 89);
            this.checkBoxMagnamentManager.Name = "checkBoxMagnamentManager";
            this.checkBoxMagnamentManager.Size = new System.Drawing.Size(108, 17);
            this.checkBoxMagnamentManager.TabIndex = 3;
            this.checkBoxMagnamentManager.Text = "Gestion gerencial";
            this.checkBoxMagnamentManager.UseVisualStyleBackColor = true;
            // 
            // checkBoxParameters
            // 
            this.checkBoxParameters.AutoSize = true;
            this.checkBoxParameters.Location = new System.Drawing.Point(6, 42);
            this.checkBoxParameters.Name = "checkBoxParameters";
            this.checkBoxParameters.Size = new System.Drawing.Size(79, 17);
            this.checkBoxParameters.TabIndex = 2;
            this.checkBoxParameters.Text = "Parametros";
            this.checkBoxParameters.UseVisualStyleBackColor = true;
            // 
            // checkBoxOrderManager
            // 
            this.checkBoxOrderManager.AutoSize = true;
            this.checkBoxOrderManager.Location = new System.Drawing.Point(6, 65);
            this.checkBoxOrderManager.Name = "checkBoxOrderManager";
            this.checkBoxOrderManager.Size = new System.Drawing.Size(145, 17);
            this.checkBoxOrderManager.TabIndex = 1;
            this.checkBoxOrderManager.Text = "Administrador de ordenes";
            this.checkBoxOrderManager.UseVisualStyleBackColor = true;
            // 
            // checkBoxSystemAccess
            // 
            this.checkBoxSystemAccess.AutoSize = true;
            this.checkBoxSystemAccess.Location = new System.Drawing.Point(6, 19);
            this.checkBoxSystemAccess.Name = "checkBoxSystemAccess";
            this.checkBoxSystemAccess.Size = new System.Drawing.Size(113, 17);
            this.checkBoxSystemAccess.TabIndex = 0;
            this.checkBoxSystemAccess.Text = "Acceso al Sistema";
            this.checkBoxSystemAccess.UseVisualStyleBackColor = true;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(123, 155);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(150, 20);
            this.textBoxAddress.TabIndex = 19;
            // 
            // textBoxHousePhone
            // 
            this.textBoxHousePhone.Location = new System.Drawing.Point(123, 184);
            this.textBoxHousePhone.Name = "textBoxHousePhone";
            this.textBoxHousePhone.Size = new System.Drawing.Size(150, 20);
            this.textBoxHousePhone.TabIndex = 20;
            this.textBoxHousePhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHousePhone_KeyPress);
            // 
            // textBoxCelPhone
            // 
            this.textBoxCelPhone.Location = new System.Drawing.Point(123, 212);
            this.textBoxCelPhone.Name = "textBoxCelPhone";
            this.textBoxCelPhone.Size = new System.Drawing.Size(150, 20);
            this.textBoxCelPhone.TabIndex = 21;
            this.textBoxCelPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCelPhone_KeyPress);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(123, 238);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(150, 20);
            this.textBoxUserName.TabIndex = 22;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(123, 269);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(150, 20);
            this.textBoxPassword.TabIndex = 23;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(107, 434);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 24;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(198, 434);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 25;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(280, 13);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.ReadOnly = true;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(549, 481);
            this.dataGridViewEmployees.TabIndex = 26;
            this.dataGridViewEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployees_CellClick);
            this.dataGridViewEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployees_CellContentClick);
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(107, 471);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(75, 23);
            this.buttonClean.TabIndex = 27;
            this.buttonClean.Text = "Limpiar";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 506);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.textBoxCelPhone);
            this.Controls.Add(this.textBoxHousePhone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLastName2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxLastName1);
            this.Controls.Add(this.textBoxEmployeeCod);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.btnAddEmployee);
            this.KeyPreview = true;
            this.Name = "Employees";
            this.Text = "Employee";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.TextBox textBoxEmployeeCod;
        private System.Windows.Forms.TextBox textBoxLastName1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxLastName2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxMagnamentManager;
        private System.Windows.Forms.CheckBox checkBoxParameters;
        private System.Windows.Forms.CheckBox checkBoxOrderManager;
        private System.Windows.Forms.CheckBox checkBoxSystemAccess;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxHousePhone;
        private System.Windows.Forms.TextBox textBoxCelPhone;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Button buttonClean;
    }
}
namespace Proyecto.View
{
    partial class Positions
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
            this.dataGridViewPositions = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBoxPositionCod = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxPositionType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPositions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPositions
            // 
            this.dataGridViewPositions.AllowUserToAddRows = false;
            this.dataGridViewPositions.AllowUserToDeleteRows = false;
            this.dataGridViewPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPositions.Location = new System.Drawing.Point(178, 12);
            this.dataGridViewPositions.Name = "dataGridViewPositions";
            this.dataGridViewPositions.ReadOnly = true;
            this.dataGridViewPositions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewPositions.Size = new System.Drawing.Size(383, 263);
            this.dataGridViewPositions.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(47, 214);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBoxPositionCod
            // 
            this.textBoxPositionCod.Location = new System.Drawing.Point(21, 42);
            this.textBoxPositionCod.Name = "textBoxPositionCod";
            this.textBoxPositionCod.Size = new System.Drawing.Size(130, 20);
            this.textBoxPositionCod.TabIndex = 2;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(21, 97);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(130, 20);
            this.textBoxDescription.TabIndex = 3;
            // 
            // textBoxPositionType
            // 
            this.textBoxPositionType.Location = new System.Drawing.Point(21, 156);
            this.textBoxPositionType.Name = "textBoxPositionType";
            this.textBoxPositionType.Size = new System.Drawing.Size(130, 20);
            this.textBoxPositionType.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cod Posición";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo de Posición";
            // 
            // Positions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 288);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPositionType);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxPositionCod);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewPositions);
            this.Name = "Positions";
            this.Text = "Editar Posicion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPositions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPositions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBoxPositionCod;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxPositionType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
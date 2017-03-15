using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;

namespace Proyecto.View
{
    public partial class Employees : Form
    {
        bool systemAccessBool = false;
        bool parametersBool = false;
        bool orderManagerAccessBool = false;
        bool managerMagnamentAccessBool = false;

        public Employees()
        {
            InitializeComponent();
            chargeDataGrid();
            chargeCombo();
        }

        public void chargeDataGrid()
        {
            /*this.dataGridViewPositions.Columns[0].Name = "Cod";
            this.dataGridViewPositions.Columns[1].Name = "Descripción";
            this.dataGridViewPositions.Columns[2].Name = "Tipo";*/

            EmployeeD oEmployeeD = new EmployeeD();
            List<EmployeeE> employees = oEmployeeD.getEmployees();

            this.dataGridViewEmployees.DataSource = employees;

        }

        public void chargeCombo()
        {
            this.comboBoxPosition.Items.Clear();
            PositionD oPositionD = new PositionD();
            List<PositionE> positions = oPositionD.getPositions();

            foreach (PositionE oPositionE in positions)
            {
                this.comboBoxPosition.Items.Add(oPositionE.PositionCod);
            }
        }

        public void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (this.checkBoxMagnamentManager.Checked)
            {
                this.managerMagnamentAccessBool = true;
            }

            if (this.checkBoxOrderManager.Checked)
            {
                orderManagerAccessBool = true;
            }

            if (this.checkBoxParameters.Checked)
            {
                parametersBool = true;
            }

            if (this.checkBoxSystemAccess.Checked)
            {
                systemAccessBool = true;
            }

            if ((this.textBoxAddress.Text == "") || (this.textBoxCelPhone.Text == "") || (this.textBoxHousePhone.Text == "") || 
                (this.textBoxLastName1.Text == "") || (this.textBoxLastName2.Text == "") ||(this.textBoxName.Text == "") || 
                (this.textBoxPassword.Text == "") || (this.textBoxUserName.Text == ""))
            {
                MessageBox.Show("Debe llenar todos los datos requeridos",
                                "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EmployeeD oEmployeeD = new EmployeeD();
                //PositionE oPositionE = (PositionE)this.comboBoxPosition.SelectedItem;
                EmployeeE oEmployeeE = new EmployeeE(this.textBoxName.Text,
                this.textBoxLastName1.Text,
                this.textBoxLastName2.Text,
                int.Parse(this.textBoxHousePhone.Text),
                int.Parse(this.textBoxCelPhone.Text),
                this.textBoxAddress.Text,
                int.Parse(this.textBoxEmployeeCod.Text),
                2,
                this.textBoxUserName.Text, 
                this.textBoxPassword.Text,
                parametersBool,
                systemAccessBool,
                orderManagerAccessBool,
                managerMagnamentAccessBool);

                if (oEmployeeD.Error)
                {
                    MessageBox.Show("Error insertando los datos: " +
                            oEmployeeD.ErrorMsg, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Empleado insertado exitosamente");
                    chargeDataGrid();
                }
            }
        }
    }
}

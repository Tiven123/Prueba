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
        char systemAccess = 'F';
        char parametersAccess = 'F';
        char orderManagerAccess = 'F';
        char managerMagnamentAccess = 'F';

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
                this.managerMagnamentAccess = 'T';
            }

            if (this.checkBoxOrderManager.Checked)
            {
                orderManagerAccess = 'T';
            }

            if (this.checkBoxParameters.Checked)
            {
                parametersAccess = 'T';
            }

            if (this.checkBoxSystemAccess.Checked)
            {
                systemAccess = 'T';
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
                                                    parametersAccess,
                                                    systemAccess,
                                                    orderManagerAccess,
                                                    managerMagnamentAccess);

                oEmployeeD.insertEmployee(oEmployeeE);
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

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            EmployeeD oEmployeeD = new EmployeeD();
            int pEmployeeCod = int.Parse(this.dataGridViewEmployees.CurrentRow.Cells["EmployeeCod"].Value.ToString());
            //this.textBoxPositionCod
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
                                                     parametersAccess,
                                                     systemAccess,
                                                     orderManagerAccess,
                                                     managerMagnamentAccess);

            if (oEmployeeD.updateEmployee(oEmployeeE, pEmployeeCod))
            {
                MessageBox.Show("Empleado modificado correctamente");
                chargeDataGrid();
            }
            else
            {
                MessageBox.Show("Error al modificar empleado: " + oEmployeeD.ErrorMsg);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            EmployeeD oEmployeeD = new EmployeeD();
            int id = int.Parse(this.dataGridViewEmployees.CurrentRow.Cells["EmployeeCod"].Value.ToString());
            if (oEmployeeD.deleteEmployee(id))
            {
                MessageBox.Show("Empleado eliminado exitosamente");
                chargeDataGrid();
            }
            else
            {
                MessageBox.Show("Error al elimimar empleado: " + oEmployeeD.ErrorMsg);
            }
        }

        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBoxAddress.Text = dataGridViewEmployees.CurrentRow.Cells["Address"].Value.ToString();
            this.textBoxCelPhone.Text = dataGridViewEmployees.CurrentRow.Cells["CelPhone"].Value.ToString();
            this.textBoxEmployeeCod.Text = dataGridViewEmployees.CurrentRow.Cells["EmployeeCod"].Value.ToString();
            this.textBoxHousePhone.Text = dataGridViewEmployees.CurrentRow.Cells["HousePhone"].Value.ToString();
            this.textBoxLastName1.Text = dataGridViewEmployees.CurrentRow.Cells["LastName1"].Value.ToString();
            this.textBoxLastName2.Text = dataGridViewEmployees.CurrentRow.Cells["LastName2"].Value.ToString();
            this.textBoxName.Text = dataGridViewEmployees.CurrentRow.Cells["Name"].Value.ToString();
        }
    }
}

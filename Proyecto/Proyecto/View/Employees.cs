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
            EmployeeD oEmployeeD = new EmployeeD();
            List<EmployeeE> employees = oEmployeeD.getEmployees();
            

            this.dataGridViewEmployees.DataSource = employees;

        }

        public void cleanForm()
        {
            this.textBoxAddress.Text = "";
            this.textBoxCelPhone.Text = "";
            this.textBoxEmployeeCod.Text = "";
            this.textBoxHousePhone.Text = "";
            this.textBoxLastName1.Text = "";
            this.textBoxLastName2.Text = "";
            this.textBoxName.Text = "";
            this.textBoxPassword.Text = "";
            this.textBoxUserName.Text = "";
            this.checkBoxMagnamentManager.Checked = false;
            this.checkBoxOrderManager.Checked = false;
            this.checkBoxParameters.Checked = false;
            this.checkBoxSystemAccess.Checked = false;
            this.comboBoxPosition.SelectedIndex = 0;
        }

        public void chargeCombo()
        {
            this.comboBoxPosition.Items.Clear();
            PositionD oPositionD = new PositionD();
            List<PositionE> positions = oPositionD.getPositions();


            foreach (PositionE oPositionE in positions)
            {
                this.comboBoxPosition.Items.Add(oPositionE);
                this.comboBoxPosition.SelectedIndex = 0;
            }
        }


        public void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Validate oValidate = new Validate();
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
                (this.textBoxLastName1.Text == "") || (this.textBoxLastName2.Text == "") || (this.textBoxName.Text == "") ||
                (this.textBoxPassword.Text == "") || (this.textBoxUserName.Text == ""))
            {
                MessageBox.Show("Debe llenar todos los datos requeridos",
                                "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                EmployeeD oEmployeeD = new EmployeeD();
                PositionE oPositionE = (PositionE)this.comboBoxPosition.SelectedItem;
                EmployeeE oEmployeeE = new EmployeeE(this.textBoxName.Text,
                                                    this.textBoxLastName1.Text,
                                                    this.textBoxLastName2.Text,
                                                    int.Parse(this.textBoxHousePhone.Text),
                                                    int.Parse(this.textBoxCelPhone.Text),
                                                    this.textBoxAddress.Text,
                                                    int.Parse(this.textBoxEmployeeCod.Text),
                                                    oPositionE.PositionCod,
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
                    cleanForm();
                }
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            EmployeeD oEmployeeD = new EmployeeD();
            int pEmployeeCod = int.Parse(this.dataGridViewEmployees.CurrentRow.Cells["codigoEmpleado"].Value.ToString());
            PositionE oPositionE = (PositionE)this.comboBoxPosition.SelectedItem;
            EmployeeE oEmployeeE = new EmployeeE(this.textBoxName.Text,
                                                     this.textBoxLastName1.Text,
                                                     this.textBoxLastName2.Text,
                                                     int.Parse(this.textBoxHousePhone.Text),
                                                     int.Parse(this.textBoxCelPhone.Text),
                                                     this.textBoxAddress.Text,
                                                     int.Parse(this.textBoxEmployeeCod.Text),
                                                     oPositionE.PositionCod,
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
                cleanForm();
            }
            else
            {
                MessageBox.Show("Error al modificar empleado: " + oEmployeeD.ErrorMsg);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar este registro ?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EmployeeD oEmployeeD = new EmployeeD();
                int id = int.Parse(this.dataGridViewEmployees.CurrentRow.Cells["codigoEmpleado"].Value.ToString());
                if (oEmployeeD.deleteEmployee(id))
                {
                    MessageBox.Show("Empleado eliminado exitosamente");
                    chargeDataGrid();
                    cleanForm();
                }
                else
                {
                    MessageBox.Show("Error al elimimar empleado: " + oEmployeeD.ErrorMsg);
                }
            }         
        }

        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGridViewEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.cleanForm();
            this.textBoxAddress.Text = dataGridViewEmployees.CurrentRow.Cells["direccion"].Value.ToString();
            this.textBoxCelPhone.Text = dataGridViewEmployees.CurrentRow.Cells["celular"].Value.ToString();
            this.textBoxEmployeeCod.Text = dataGridViewEmployees.CurrentRow.Cells["codigoEmpleado"].Value.ToString();
            this.textBoxHousePhone.Text = dataGridViewEmployees.CurrentRow.Cells["telefono"].Value.ToString();
            this.textBoxLastName1.Text = dataGridViewEmployees.CurrentRow.Cells["apellido1"].Value.ToString();
            this.textBoxLastName2.Text = dataGridViewEmployees.CurrentRow.Cells["apellido2"].Value.ToString();
            this.textBoxName.Text = dataGridViewEmployees.CurrentRow.Cells["nombreEmpleado"].Value.ToString();
            this.textBoxUserName.Text = dataGridViewEmployees.CurrentRow.Cells["usuario"].Value.ToString();
            this.textBoxPassword.Text = dataGridViewEmployees.CurrentRow.Cells["contraseña"].Value.ToString();
            if (this.dataGridViewEmployees.CurrentRow.Cells["sistema"].Value.ToString() == "T")
            {
                this.checkBoxSystemAccess.Checked = true;
            }
            if (this.dataGridViewEmployees.CurrentRow.Cells["parametros"].Value.ToString() == "T")
            {
                this.checkBoxParameters.Checked = true;
            }
            if (this.dataGridViewEmployees.CurrentRow.Cells["ordenes"].Value.ToString() == "T")
            {
                this.checkBoxOrderManager.Checked = true;
            }
            if (this.dataGridViewEmployees.CurrentRow.Cells["gerencial"].Value.ToString() == "T")
            {
                this.checkBoxMagnamentManager.Checked = true;
            }
   
            this.comboBoxPosition.SelectedIndex = int.Parse(this.dataGridViewEmployees.CurrentRow.Cells["codigoPosicion"].Value.ToString()) - 1; 
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            cleanForm();
        }

        private void textBoxEmployeeCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxHousePhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxCelPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}

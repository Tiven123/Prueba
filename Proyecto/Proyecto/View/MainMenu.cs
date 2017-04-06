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
using Proyecto.Controller;
using Proyecto.Model;
using Proyecto.view;
using Proyecto.View;

namespace Proyecto
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            chargeCombo();
            chargeDataGrid();
            enableAndDisableOptions();
        }

        public void chargeDataGrid()
        {
            OrderD oOrderD = new OrderD();
            List<OrderE> orders = oOrderD.getOrders();
            this.dataGridViewOrders.DataSource = orders;
        }

        public void enableAndDisableOptions()
        {
            if (this.radioButtonInCharge.Checked == true)
            {
                this.comboBox1.Enabled = false;
                this.comboBoxVehicle.Enabled = false;
                this.comboBoxEmployee.Enabled = true;
                this.dateTimePickerEntry.Enabled = false;
                this.dateTimePickerExit.Enabled = false;
                this.dateTimePickerBilling.Enabled = false;
            }
            else if (this.radioButtonState.Checked == true)
            {
                this.comboBox1.Enabled = true;
                this.comboBoxVehicle.Enabled = false;
                this.comboBoxEmployee.Enabled = false;
                this.dateTimePickerEntry.Enabled = false;
                this.dateTimePickerExit.Enabled = false;
                this.dateTimePickerBilling.Enabled = false;
            }
            else if (this.radioButtonVehicle.Checked == true)
            {
                this.comboBox1.Enabled = false;
                this.comboBoxVehicle.Enabled = true;
                this.comboBoxEmployee.Enabled = false;
                this.dateTimePickerEntry.Enabled = false;
                this.dateTimePickerExit.Enabled = false;
                this.dateTimePickerBilling.Enabled = false;
            }
            else if (this.radioButtonEntry.Checked == true)
            {
                this.comboBox1.Enabled = false;
                this.comboBoxVehicle.Enabled = false;
                this.comboBoxEmployee.Enabled = false;
                this.dateTimePickerEntry.Enabled = true;
                this.dateTimePickerExit.Enabled = false;
                this.dateTimePickerBilling.Enabled = false;
            }
            else if (this.radioButtonExit.Checked == true)
            {
                this.comboBox1.Enabled = false;
                this.comboBoxVehicle.Enabled = false;
                this.comboBoxEmployee.Enabled = false;
                this.dateTimePickerEntry.Enabled = false;
                this.dateTimePickerExit.Enabled = true;
                this.dateTimePickerBilling.Enabled = false;
            }
            else if (this.radioButtonBilling.Checked == true)
            {
                this.comboBox1.Enabled = false;
                this.comboBoxVehicle.Enabled = false;
                this.comboBoxEmployee.Enabled = false;
                this.dateTimePickerEntry.Enabled = false;
                this.dateTimePickerExit.Enabled = false;
                this.dateTimePickerBilling.Enabled = true;
            }
        }

        public void chargeDataGridPerEmployeeCod(int pEmployeeCod)
        {
            OrderD oOrderD = new OrderD();
            List<OrderE> orders = oOrderD.getOrderVehiclePerEmployee(pEmployeeCod);
            this.dataGridViewOrders.DataSource = orders;
        }

        public void chargeDataGridPerVehicleCod(string pVehicleCod)
        {
            OrderD oOrderD = new OrderD();
            List<OrderE> orders = oOrderD.getOrderVehiclePerVehicle(pVehicleCod);
            this.dataGridViewOrders.DataSource = orders;
        }

        public void chargeDataGridPerState(string pState)
        {
            OrderD oOrderD = new OrderD();
            List<OrderE> orders = oOrderD.getOrderVehiclePerState(pState);
            this.dataGridViewOrders.DataSource = orders;
        }

        public void chargeDataGridPerEntryDate(DateTime pEntryDate)
        {
            OrderD oOrderD = new OrderD();
            List<OrderE> orders = oOrderD.getOrderVehiclePerEntryDate(pEntryDate);
            this.dataGridViewOrders.DataSource = orders;
        }

        public void chargeDataGridPerExitDate(DateTime pExitDate)
        {
            OrderD oOrderD = new OrderD();
            List<OrderE> orders = oOrderD.getOrderVehiclePerExitDate(pExitDate);
            this.dataGridViewOrders.DataSource = orders;
        }

        public void chargeDataGridPerBillingDate(DateTime pBillingDate)
        {
            OrderD oOrderD = new OrderD();
            List<OrderE> orders = oOrderD.getOrderVehiclePerBillingDate(pBillingDate);
            this.dataGridViewOrders.DataSource = orders;
        }

        public void chargeCombo()
        {
            this.comboBoxEmployee.Items.Clear();
            EmployeeD oEmployeeD = new EmployeeD();
            List<EmployeeE> employees = oEmployeeD.getEmployees();
            foreach (EmployeeE oEmployeeE in employees)
            {
                this.comboBoxEmployee.Items.Add(oEmployeeE);
            }
            this.comboBoxEmployee.SelectedIndex = 1;


            this.comboBoxVehicle.Items.Clear();
            VehicleD oVehicleD = new VehicleD();
            List<VehicleE> vehicles = oVehicleD.get();
            foreach (VehicleE oVehicleE in vehicles)
            {
                this.comboBoxVehicle.Items.Add(oVehicleE);
            }
            this.comboBoxVehicle.SelectedIndex = 1;

            this.comboBox1.Items.Clear();
            this.comboBox1.Items.Add("En progreso");
            this.comboBox1.Items.Add("Finalizado");
            this.comboBox1.Items.Add("Facturado");
            this.comboBox1.SelectedIndex = 1;
        }
        private void buttonNew_Click(object sender, EventArgs e)
        {
            Orders oOrders = new Orders();
            oOrders.ShowDialog();
            chargeDataGrid();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            Password oPassword = new Password();
            oPassword.ShowDialog();
        }

        private void btnClientRegister_Click(object sender, EventArgs e)
        {
            Clients oClients = new Clients();
            oClients.ShowDialog();
        }

        private void btnBrands_Click(object sender, EventArgs e)
        {
            Brands oBrands = new Brands();
            oBrands.ShowDialog();
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            Vehicles oVehicles = new Vehicles();
            oVehicles.ShowDialog();
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
            Models oModels = new Models();
            oModels.ShowDialog();
        }

        private void btnRepairs_Click(object sender, EventArgs e)
        {
            Repairs oRepairs = new Repairs();
            oRepairs.ShowDialog();
        }

        private void btnReplacement_Click(object sender, EventArgs e)
        {
            Replacements oReplacements = new Replacements();
            oReplacements.ShowDialog();
        }

        private void btnRegisterEmployee_Click(object sender, EventArgs e)
        {
            Employees oEmployees = new Employees();
            oEmployees.ShowDialog();
        }

        private void btnRegisterPosition_Click(object sender, EventArgs e)
        {
            Positions oPositions = new Positions();
            oPositions.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.comboBoxEmployee.SelectedIndex = int.Parse(this.dataGridViewOrders.CurrentRow.Cells["Employee"].Value.ToString()) - 1;
            //this.comboBoxVehicle.SelectedIndex = int.Parse(this.dataGridViewOrders.CurrentRow.Cells["Vehicle"].Value.ToString()) - 1;
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewOrders.CurrentRow.Cells["State"].Value.ToString() == "Facturado")
            {
                MessageBox.Show("No se puede editar en estado -Facturado-");
            }
            else
            {
                int orderNum = int.Parse(this.dataGridViewOrders.CurrentRow.Cells["Consecutive"].Value.ToString());
                OrderD oOrderD = new OrderD();
                oOrderD.updatedState("Finalizado", orderNum);
                if (oOrderD.Error)
                {
                    MessageBox.Show("Error insertando datos",
                                "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Estado modificado exitosamente");
                    chargeDataGrid();
                }
            }
        }

        private void buttonAsk_Click(object sender, EventArgs e)
        {
            int orderNum = int.Parse(this.dataGridViewOrders.CurrentRow.Cells["Consecutive"].Value.ToString());
            OrderD oOrderD = new OrderD();
            oOrderD.updateDate("Facturado", DateTime.Now, orderNum);
            if (oOrderD.Error)
            {
                MessageBox.Show("Error insertando los datos: " +
                        oOrderD.ErrorMsg, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Estado modificado exitosamente");
                chargeDataGrid();
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {

            if (this.dataGridViewOrders.CurrentRow.Cells["State"].Value.ToString() == "Facturado")
            {
                MessageBox.Show("No se puede editar en estado -Facturado-");
            }
            else
            {
                int orderNum = int.Parse(this.dataGridViewOrders.CurrentRow.Cells["Consecutive"].Value.ToString());
                OrderD oOrderD = new OrderD();
                oOrderD.updatedState("En progreso", orderNum);
                if (oOrderD.Error)
                {
                    MessageBox.Show("Error insertando los datos: " +
                        oOrderD.ErrorMsg, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);                 
                }
                else
                {
                    chargeDataGrid();
                    /*Orders oOrders = new Orders();
                    oOrders.ShowDialog();*/
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar este registro ?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                OrderD oOrderD = new OrderD();
                int consecutive = int.Parse(this.dataGridViewOrders.CurrentRow.Cells["Consecutive"].Value.ToString());
                if (oOrderD.deleteOrder(consecutive))
                {
                    MessageBox.Show("Orden eliminada exitosamente");
                    chargeDataGrid();
                }
                else
                {
                    MessageBox.Show("Error al elimimar orden: " + oOrderD.ErrorMsg);
                }
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (this.radioButtonInCharge.Checked == true)
            {
                EmployeeE oEmployeeE = (EmployeeE)this.comboBoxEmployee.SelectedItem;
                this.chargeDataGridPerEmployeeCod(oEmployeeE.EmployeeCod);              
            }
            else if (this.radioButtonState.Checked == true)
            {
                this.chargeDataGridPerState(this.comboBox1.SelectedItem.ToString());
            }
            else if (this.radioButtonVehicle.Checked == true)
            {
                VehicleE oVehicleE = (VehicleE)this.comboBoxVehicle.SelectedItem;
                this.chargeDataGridPerVehicleCod(oVehicleE.Id);
            }

            else if (this.radioButtonEntry.Checked == true)
            {
                this.chargeDataGridPerEntryDate(DateTime.Parse(this.dateTimePickerEntry.Value.Date.ToString()));
            }
            else if (this.radioButtonExit.Checked == true)
            {
                this.chargeDataGridPerExitDate(DateTime.Parse(this.dateTimePickerExit.Value.Date.ToString()));
            }
            else if (this.radioButtonBilling.Checked == true)
            {
                this.chargeDataGridPerBillingDate(DateTime.Parse(this.dateTimePickerBilling.Value.Date.ToString()));
            }
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            this.chargeDataGrid();
        }

        private void radioButtonVehicle_Click(object sender, EventArgs e)
        {
            enableAndDisableOptions();
        }

        private void radioButtonInCharge_Click(object sender, EventArgs e)
        {
            enableAndDisableOptions();
        }

        private void radioButtonState_Click(object sender, EventArgs e)
        {
            enableAndDisableOptions();
        }

        private void radioButtonEntry_Click(object sender, EventArgs e)
        {
            enableAndDisableOptions();
        }

        private void radioButtonExit_Click(object sender, EventArgs e)
        {
            enableAndDisableOptions();
        }

        private void radioButtonBilling_Click(object sender, EventArgs e)
        {
            enableAndDisableOptions();
        }
    }
}

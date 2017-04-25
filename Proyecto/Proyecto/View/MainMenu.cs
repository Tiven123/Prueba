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
using Proyecto.Logic;
using Proyecto.view;
using Proyecto.View;
using View;

namespace Proyecto
{
    public partial class MainMenu : Form
    {
        private EmployeeE oEmployeeE = new EmployeeE();
        public MainMenu(EmployeeE pEmployeeE)
        {
            InitializeComponent();
            oEmployeeE = pEmployeeE;
            chargeCombo();
            chargeDataGrid();
            enableAndDisableOptions();
            userRights();
        }

        public void userRights()
        {
            if (oEmployeeE.OrderManagerAccess == 'F')
            {
                this.tabControlPages.TabPages.Remove(this.tabPage1);
            }
            if (oEmployeeE.SystemAccess == 'F')
            {
                this.tabControlPages.TabPages.Remove(this.tabPage2);
            }
            if (oEmployeeE.Parameters == 'F')
            {
                this.tabControlPages.TabPages.Remove(this.tabPage3);
            }
            if (oEmployeeE.ManagerMagnamentAccess == 'F')
            {
                this.tabControlPages.TabPages.Remove(this.tabPage4);
            }
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
            this.cbEmployeeReport.Items.Clear();

            EmployeeD oEmployeeD = new EmployeeD();

            List<EmployeeE> employees = oEmployeeD.getEmployees();

            foreach (EmployeeE oEmployeeE in employees)
            {
                this.cbEmployeeReport.Items.Add(oEmployeeE);
                this.comboBoxEmployee.Items.Add(oEmployeeE);
            }
            this.cbEmployeeReport.SelectedIndex = 0;
            this.comboBoxEmployee.SelectedIndex = 0;
            /*--------------------------------------------*/

            this.comboBoxVehicle.Items.Clear();
            VehicleD oVehicleD = new VehicleD();
            List<VehicleE> vehicles = oVehicleD.get();
            foreach (VehicleE oVehicleE in vehicles)
            {
                this.comboBoxVehicle.Items.Add(oVehicleE);
            }
            this.comboBoxVehicle.SelectedIndex = 0;
            /*--------------------------------------------*/
            this.cbOrderReport.Items.Clear();
            OrderD oOrder = new OrderD();
            List<OrderE> orders = oOrder.get();
            foreach (OrderE oOrderE in orders)
            {
                if (oOrderE.State=="Facturado")
                {
                    this.cbOrderReport.Items.Add(oOrderE);
                }
                
            }
            this.cbOrderReport.SelectedIndex = 0;
            /*--------------------------------------------*/
            this.comboBox1.Items.Clear();
            this.comboBox1.Items.Add("En progreso");
            this.comboBox1.Items.Add("Finalizado");
            this.comboBox1.Items.Add("Facturado");
            this.comboBox1.SelectedIndex = 0;
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
                OrderL oOrderL = new OrderL();
                string answer = oOrderL.updateOrderState("Finalizado", orderNum);
                MessageBox.Show (answer);
                chargeDataGrid();
            }
        }

        private void buttonAsk_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewOrders.CurrentRow.Cells["State"].Value.ToString() == "Facturado")
            {
                MessageBox.Show("El estado ya está como -Facturado-");
            }
            else
            {
                int orderNum = int.Parse(this.dataGridViewOrders.CurrentRow.Cells["Consecutive"].Value.ToString());
                OrderL oOrderL = new OrderL();
                string answer = oOrderL.updateOrderState("Facturado", orderNum);
                MessageBox.Show(answer);
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
                OrderL oOrderL = new OrderL();
                string answer = oOrderL.updateOrderState("En progreso", orderNum);
                MessageBox.Show(answer);
                chargeDataGrid();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar este registro ?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                OrderL oOrderL = new OrderL();
                int orderNum = int.Parse(this.dataGridViewOrders.CurrentRow.Cells["Consecutive"].Value.ToString());
                string answer = oOrderL.updateOrderState("En progreso", orderNum);
                MessageBox.Show(answer);
                chargeDataGrid();
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

        private void button7_Click_1(object sender, EventArgs e)
        {
            OrderE orden = (OrderE)cbOrderReport.SelectedItem;
            Reportes reporte = new Reportes(3);
            reporte.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OrderE orden = (OrderE)cbOrderReport.SelectedItem;
            Reportes reporte = new Reportes(orden.Consecutive,1);
            reporte.ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String fechaString = this.dtpOrderF.Value.ToShortDateString();
            DateTime entrada = Convert.ToDateTime(fechaString);
            Reportes reporte = new Reportes(2 , entrada);
            reporte.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String fechaString = this.dtpFechaInicial.Value.ToShortDateString();
            DateTime inicial = Convert.ToDateTime(fechaString);
            fechaString = this.dtpFechaFinal.Value.ToShortDateString();
            DateTime final = Convert.ToDateTime(fechaString);
            Controller.EmployeeE employee = (Controller.EmployeeE)cbEmployeeReport.SelectedItem; ;

            Reportes reporte = new Reportes(4, inicial, final, employee.EmployeeCod );
            reporte.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reportes reporte = new Reportes(5);
            reporte.ShowDialog();
        }
    }
}

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
    public partial class Orders : Form
    {
        private int consecutive;
        private List<ReplacementOrderE> listReplacements;
        private List<RepairPerOrderE> listRepairs;
        private int totalOrder;

        public Orders()
        {
            InitializeComponent();
            listReplacements = new List<ReplacementOrderE>();
            listRepairs = new List<RepairPerOrderE>();
            consecutive = 0;
            totalOrder = 0;
            chargeDataGrid();
            chargeCombo();
        }
        public void chargeDataGrid()
        {
            OrderD oOrderD = new OrderD();
            List<OrderE> orders = oOrderD.getOrders();
            this.dataGridViewOrders.DataSource = orders;
        }

        public void chargeDgvReplacements()
        {
            this.dgvReplacements.Rows.Clear();
            foreach (ReplacementOrderE oReplacementE in listReplacements)
            {
                string[] linea = { oReplacementE.ReplacementName, oReplacementE.Quantity.ToString(),
                    oReplacementE.Cost.ToString(), oReplacementE.Total.ToString() };
                this.dgvReplacements.Rows.Add(linea);
            }
        }

        public void chargeDgvRepairs()
        {
            this.dgvRepairs.Rows.Clear();
            foreach (RepairPerOrderE oRepair in listRepairs)
            {
                int total = oRepair.Hours * oRepair.Cost;
                string[] linea = { oRepair.RepairName, oRepair.EmployeName,
                    oRepair.Cost.ToString(), oRepair.Hours.ToString(), oRepair.Total.ToString() };
                this.dgvRepairs.Rows.Add(linea);
            }
        }

        public void chargeCombo()
        {
            this.comboBoxEmployee.Items.Clear();
            this.cbEmploye.Items.Clear();
            EmployeeD oEmployeeD = new EmployeeD();
            List<EmployeeE> employees = oEmployeeD.getEmployees();
            foreach (EmployeeE oEmployeeE in employees)
            {
                this.comboBoxEmployee.Items.Add(oEmployeeE);
                this.cbEmploye.Items.Add(oEmployeeE);
            }
            this.comboBoxEmployee.SelectedIndex = 0;
            this.cbEmploye.SelectedIndex = 0;


            this.comboBoxVehicle.Items.Clear();
            VehicleD oVehicleD = new VehicleD();
            List<VehicleE> vehicles = oVehicleD.get();
            foreach (VehicleE oVehicleE in vehicles)
            {
                this.comboBoxVehicle.Items.Add(oVehicleE);
            }
            this.comboBoxVehicle.SelectedIndex = 0;

            this.cbReplacement.Items.Clear();
            ReplacementD oReplacementD = new ReplacementD();
            List<ReplacementE> replacements = oReplacementD.get();
            foreach (ReplacementE oReplacementE in replacements)
            {
                this.cbReplacement.Items.Add(oReplacementE);
            }
            this.cbReplacement.SelectedIndex = 0;

            this.cbRepair.Items.Clear();
            RepairD oRepairD = new RepairD();
            List<RepairE> repairs = oRepairD.get();
            foreach (RepairE oRepairE in repairs)
            {
                this.cbRepair.Items.Add(oRepairE);
            }
            this.cbRepair.SelectedIndex = 0;

        }

        private void buttonCompleteOrder_Click(object sender, EventArgs e)
        {       
            String entryDate = this.dateTimePickerDateEntry.Value.Date.ToString();
            DateTime oEntryDate = Convert.ToDateTime(entryDate);
             
            String exitDate = this.dateTimePickerDateEntry.Value.Date.ToString();
            DateTime oExitDate = Convert.ToDateTime(exitDate);

            if (oEntryDate.Date > oExitDate.Date)
            {
                MessageBox.Show("La fecha de entrada no puede ser mayor a la de salida",
                                "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PostgressDataAccess oPostgressDataAccess = PostgressDataAccess.Instance;
                oPostgressDataAccess.startTransaction();
                int costPerOrder = 0;   //importante dar valor
                int bill =+ 1;           //importante dar valor
                OrderD oOrderD = new OrderD();

                //-----------------creación de objetos aquí

                VehicleE oVehicleE = (VehicleE)this.comboBoxVehicle.SelectedItem;
                EmployeeE oEmployeeE = (EmployeeE)this.comboBoxEmployee.SelectedItem;
                OrderE oOrderE = new OrderE(oVehicleE.Year,
                                            oEmployeeE.EmployeeCod,
                                            oVehicleE.Id,
                                            this.dateTimePickerDateEntry.Value,
                                            this.dateTimePickerExit.Value,
                                            this.dateTimePickerExit.Value,
                                            "En progreso",
                                            costPerOrder,
                                            bill);
                consecutive = oOrderD.insertOrder(oOrderE);   // el valor ya está a nivel global
                MessageBox.Show(""+consecutive);
                if (oOrderD.Error)
                {
                    oPostgressDataAccess.rollbackTransaccion();
                    MessageBox.Show("Error insertando los datos: " +
                            oOrderD.ErrorMsg, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //---------------------segundo metodo a agregar y modificar
                RepairOrderD oRepairOrder = new RepairOrderD();
                for (int i = 0; i < this.listRepairs.Count; i++)
                {
                    listRepairs[i].Order = consecutive;
                    oRepairOrder.insert(listRepairs[i]);
                }
                if (oRepairOrder.Error)
                {
                    oPostgressDataAccess.rollbackTransaccion();
                    MessageBox.Show("Error insertando los datos: " +
                            oOrderD.ErrorMsg, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //---------------------tercer metodo a agregar y modificar
                ReplacementOrderD oReplacementOrder = new ReplacementOrderD();
                for (int i = 0; i < this.listReplacements.Count; i++)
                {
                    listReplacements[i].Order = consecutive;
                    oReplacementOrder.insert(listReplacements[i]);
                }
                if (oReplacementOrder.Error)
                {
                    oPostgressDataAccess.rollbackTransaccion();
                    MessageBox.Show("Error insertando los datos: " +
                            oOrderD.ErrorMsg, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                oOrderE.CostPerOrder = totalOrder;
                oOrderD.updateOrder(oOrderE, consecutive);
                if (oOrderD.Error)
                {
                    oPostgressDataAccess.rollbackTransaccion();
                    MessageBox.Show("Error insertando los datos: " +
                            oOrderD.ErrorMsg, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show("Orden insertada exitosamente");
                    oPostgressDataAccess.commitTransaccion();
                }

            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReplacementOrderE oReplacementE = new ReplacementOrderE();
            ReplacementE ore = (ReplacementE)cbReplacement.SelectedItem;
            int costReplacement= int.Parse(txtTotalReplacement.Text);
            int quantyRelacement= (int)nuReplacement.Value;
            oReplacementE.Order = this.consecutive;
            oReplacementE.Cost = costReplacement;
            oReplacementE.Quantity = quantyRelacement;
            oReplacementE.Replacement = ore.Consecutive;
            oReplacementE.ReplacementName = ore.Description;
            oReplacementE.Total = costReplacement * quantyRelacement;

            listReplacements.Add(oReplacementE);
            //MessageBox.Show("F");
            chargeDgvReplacements();
            
        }

        private void Orders_Load(object sender, EventArgs e)
        {

        }

        private void nuReplacement_ValueChanged(object sender, EventArgs e)
        {
            ReplacementE r = (ReplacementE)cbReplacement.SelectedItem;
            txtTotalReplacement.Text = (r.Cost * (int)this.nuReplacement.Value) + "";
        }
        private void costRepair()
        {
            ReplacementE r = (ReplacementE)cbReplacement.SelectedItem;
            txtTotalReplacement.Text = (r.Cost * (int)this.nuReplacement.Value) + "";
            
        }
        private void cbReplacement_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReplacementE r = (ReplacementE)cbReplacement.SelectedItem;
            txtCostReplacement.Text = r.Cost + "";
            costRepair();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RepairPerOrderE oRepairE = new RepairPerOrderE();

            RepairE ore = (RepairE)cbRepair.SelectedItem;
            EmployeeE oemp = (EmployeeE)cbEmploye.SelectedItem;

            int hoursRepair = (int)nuRepair.Value;
            int costRepair = int.Parse(txtCostRepair.Text);

            oRepairE.EmployeName = oemp.ToString();
            oRepairE.RepairName = ore.Description;
            oRepairE.Order = this.consecutive;
            oRepairE.Repair = ore.Consecutive;
            oRepairE.Employe = oemp.EmployeeCod;
            oRepairE.Cost = costRepair;
            oRepairE.Hours = hoursRepair;
            oRepairE.Total = costRepair * hoursRepair;

            listRepairs.Add(oRepairE);

            chargeDgvRepairs();
        }

        private void cbRepair_SelectedIndexChanged(object sender, EventArgs e)
        {
            RepairE r = (RepairE)cbRepair.SelectedItem;
            txtCostRepair.Text = r.Cost + "";
            costReplacement();
        }

        private void costReplacement()
        {
            RepairE r = (RepairE)cbRepair.SelectedItem;
            txtTotalRepair.Text = (r.Cost * (int)this.nuRepair.Value) + "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listReplacements.Count > 0)
            {
                string replacementDelete = dgvReplacements.CurrentRow.Cells["codeReplacement"].Value.ToString();
                for (int i = 0; i < listReplacements.Count; i++)
                {
                    if (listReplacements[i].ReplacementName == replacementDelete)
                    {
                        listReplacements.RemoveAt(i);
                        break;
                    }
                }
                chargeDgvReplacements();
            }
            else
            {
                MessageBox.Show("Debe agregar antes de eliminar");
            }
            
           
        }

        private void dgvReplacements_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listRepairs.Count > 0)
            {
                string delete = dgvRepairs.CurrentRow.Cells["colrepa"].Value.ToString();
                for (int i = 0; i < listRepairs.Count; i++)
                {
                    if (listRepairs[i].RepairName == delete)
                    {
                        listRepairs.RemoveAt(i);
                        break;
                    }
                }
                chargeDgvRepairs();
            }
            else
            {
                MessageBox.Show("Debe agregar antes de eliminar");
            }
        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            int totalRepair = 0;
            int totalReplacement = 0;

            foreach (RepairPerOrderE oRepair in listRepairs)
            {
                totalRepair += oRepair.Total;
            }

            foreach (ReplacementOrderE oReplacement in listReplacements)
            {
                totalReplacement += oReplacement.Total;
            }

            txtRepairs.Text = totalRepair.ToString();
            txtTotalReplacements.Text = totalReplacement.ToString();

            totalOrder = totalRepair + totalReplacement;

            txtTotalOrder.Text = totalOrder.ToString();


        }
    }
}

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
    public partial class Repairs : Form
    {
        RepairD oRepairD;
        public Repairs()
        {
            InitializeComponent();
            oRepairD = new RepairD();
            chargeDataGrid();
        }

        public void chargeDataGrid()
        {

            List<RepairE> Repairs = oRepairD.get();
            this.dataGridView1.DataSource = Repairs;

        }

        private RepairE create()
        {
            RepairE oRepairE = new RepairE();
            //Validate the camps 
            Validate oValidate = new Validate();
            try
            {
                //verify the camps is not null
                if (String.IsNullOrEmpty(txtCode.Text) || String.IsNullOrEmpty(txtDescription.Text) || String.IsNullOrEmpty(txtCost.Text) || String.IsNullOrEmpty(txtHour.Text))
                {
                    MessageBox.Show("Todos los campos son requeridos");

                }
                else
                {
                    //get data at form
                    string code = txtCode.Text;
                    string description = txtDescription.Text;
                    string hour = txtHour.Text;
                    string cost = txtCost.Text;

                    //verify the data 
                    if (oValidate.number(code) && oValidate.text(description) && oValidate.number(hour) && oValidate.number(cost))
                    {
                        //creates new object ClientE
                        oRepairE = new RepairE(int.Parse(code), description, int.Parse(hour), int.Parse(cost));
                    }

                }
            }
            catch
            {
                MessageBox.Show("Error verifique los datos insertados");
            }
            return oRepairE;
        }



        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            RepairE oRepairE = create();
            if (oRepairE != null)
            {
                if (oRepairD.insert(oRepairE))
                {
                    MessageBox.Show("Reparacion insertada correctamente");
                    chargeDataGrid();
                }
                else
                {
                    MessageBox.Show("Error al insertar reparacion: " + oRepairD.ErrorMsg);
                }
            }
            else
            {
                MessageBox.Show("Error en los datos ingresados ");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string code = dataGridView1.CurrentRow.Cells["Consecutive"].Value.ToString();
            if (oRepairD.delete(code))
            {
                MessageBox.Show("Reparacion eliminada exitosamente");
                chargeDataGrid();
            }
            else
            {
                MessageBox.Show("Error al elimimar reparacion: " + oRepairD.ErrorMsg);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string code = dataGridView1.CurrentRow.Cells["Consecutive"].Value.ToString();
            RepairE oRepairE = create();
            if (oRepairE != null)
            {
                if (oRepairD.update(oRepairE))
                {
                    MessageBox.Show("Reparacion modificada correctamente");
                    chargeDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Error al modificar Reparacion: " + oRepairD.ErrorMsg);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = dataGridView1.CurrentRow.Cells["Consecutive"].Value.ToString();
            txtDescription.Text = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
            txtHour.Text = dataGridView1.CurrentRow.Cells["Hours"].Value.ToString();
            txtCost.Text = dataGridView1.CurrentRow.Cells["Cost"].Value.ToString();
        }
    }
}

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
using NpgsqlTypes;
using Npgsql;
using Model;


namespace Proyecto.View
{
    public partial class Vehicles : Form
    {
        VehicleD oVehicleD;
        
        public Vehicles()
        {
            InitializeComponent();
            oVehicleD = new VehicleD();
            chargeDataGrid();
            chargeCombo();
        }

        public void chargeDataGrid()
        {

            List<VehicleE> vehicles = oVehicleD.get();
            this.dataGridView1.DataSource = vehicles;

        }

        private void chargeCombo()
        {
            this.cbModel.Items.Clear();
            ModelD oModelD = new ModelD();
            List<ModelE> listModel = oModelD.get();


            foreach (ModelE oModelE in listModel)
            {
                this.cbModel.Items.Add(oModelE);
            }
            cbModel.SelectedIndex = 0;

            this.cbCliente.Items.Clear();
            ClientD oClientD = new ClientD();
            List<ClientE> listClient = oClientD.getClients();


            foreach (ClientE oClientE in listClient)
            {
                this.cbCliente.Items.Add(oClientE);
            }
            cbCliente.SelectedIndex = 0;
        }

        private VehicleE create()
        {
            VehicleE oVehicleE = new VehicleE();
            //Validate the camps at brand form
            Validate oValidate = new Validate();
            try
            {
                //verify the camps is not null
                if (String.IsNullOrEmpty(txtCode.Text) || String.IsNullOrEmpty(txtEnngine.Text) || String.IsNullOrEmpty(txtCapacity.Text) ||
                    String.IsNullOrEmpty(txtChassis.Text) || String.IsNullOrEmpty(txtType.Text) || String.IsNullOrEmpty(txtYear.Text))
                {
                    if (!rbD.Checked && !rbE.Checked && !rbG.Checked)
                    {
                        MessageBox.Show("Todos los campos son requeridos");
                    }
                    

                }
                else
                {
                    //get data at form
                    string id = txtCode.Text;
                    ModelE model = (ModelE)cbModel.SelectedItem;
                    ClientE client = (ClientE)cbCliente.SelectedItem;
                    string year = txtYear.Text;
                    string engine = txtEnngine.Text;
                    string chassis = txtChassis.Text;
                    string type = txtType.Text;
                    string capacity = txtCapacity.Text;
                    string fuel = "";
                    if (rbD.Checked)
                    {
                        fuel = "Diesel";
                    }
                    if (rbE.Checked)
                    {
                        fuel = "Electrico";
                    }
                    if (rbG.Checked)
                    {
                        fuel = "Gasolina";
                    }

                    //verify the data 
                    if (oValidate.number(id) && oValidate.text(fuel) && oValidate.number(year) && oValidate.number(capacity))
                    {
                        //creates new object ClientE
                        oVehicleE = new VehicleE(id,model.Code,client.Cedula,int.Parse(year),engine,chassis,fuel,type,int.Parse(capacity));

                    }

                }
            }
            catch
            {
                MessageBox.Show("Error verifique los datos insertados");
            }
            return oVehicleE;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            VehicleE oVehicleE = create();
            if (oVehicleE != null)
            {
                if (oVehicleD.insert(oVehicleE))
                {
                    MessageBox.Show("Vehiculo insertado correctamente");
                    chargeDataGrid();
                    clean();
                }
                else
                {
                    MessageBox.Show("Error al insertar Vehiculo: " + oVehicleD.ErrorMsg);
                }
            }
            else
            {
                MessageBox.Show("Error al insertar Vehiculo: " + oVehicleD.ErrorMsg);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string code = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            VehicleE oVehicleE = create();
            if (oVehicleE != null)
            {
                if (oVehicleD.update(oVehicleE))
                {
                    MessageBox.Show("Vehiculo modificado correctamente");
                    chargeDataGrid();
                    clean();
                }
            }
            else
            {
                MessageBox.Show("Error al modificar vehiculo: " + oVehicleD.ErrorMsg);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el vehiculo", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string code = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                if (oVehicleD.delete(code))
                {
                    MessageBox.Show("Vehiculo eliminado exitosamente");
                    chargeDataGrid();
                    clean();
                }
                else
                {
                    MessageBox.Show("Error al elimimar vehiculo: " + oVehicleD.ErrorMsg);
                }
            }
            else
            {
                MessageBox.Show("Eliminacion cancelada", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int model = int.Parse(dataGridView1.CurrentRow.Cells["Model"].Value.ToString());
            string client = dataGridView1.CurrentRow.Cells["Client"].Value.ToString();
            ModelE oModelE = new ModelE();
            for (int i = 0; i < this.cbModel.Items.Count; i++)
            {
                cbModel.SelectedIndex = i;
                oModelE = (ModelE)cbModel.SelectedItem;
                if (oModelE.Code == model)
                {
                    break;
                }
            }
            ClientE oClientE = new ClientE();
            for (int i = 0; i < this.cbCliente.Items.Count; i++)
            {
                cbCliente.SelectedIndex = i;
                oClientE = (ClientE)cbCliente.SelectedItem;
                if (oClientE.Cedula == client)
                {
                    break;
                }
            }
            txtCode.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            txtYear.Text = dataGridView1.CurrentRow.Cells["Year"].Value.ToString();
            txtEnngine.Text = dataGridView1.CurrentRow.Cells["Engine"].Value.ToString();
            txtChassis.Text = dataGridView1.CurrentRow.Cells["Chassis"].Value.ToString();
            txtType.Text = dataGridView1.CurrentRow.Cells["Type"].Value.ToString();
            txtCapacity.Text = dataGridView1.CurrentRow.Cells["Capacity"].Value.ToString();
            string fuel= dataGridView1.CurrentRow.Cells["Fuel"].Value.ToString();
            if (fuel == "Gasolina")
            {
                rbG.Checked = true;
            }
            if(fuel == "Diesel")
            {
                rbD.Checked = true;
            }
            else
            {
                rbE.Checked = true;
            }
        }
        private void clean()
        {
            txtCode.Text = "";
            txtYear.Text = "";
            txtEnngine.Text = "";
            txtChassis.Text = "";
            txtType.Text = "";
            txtCapacity.Text = "";
            rbD.Checked = false;
            rbE.Checked = false;
            rbG.Checked = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            clean();
        }
    }
}

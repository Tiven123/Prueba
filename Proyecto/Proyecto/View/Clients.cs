using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;

namespace Proyecto.View
{
    public partial class Clients : Form
    {
        ClientD oClienteD;

        public Clients()
        {
            InitializeComponent();
            chargeDataGrid();
            oClienteD = new ClientD();
        }

        public void chargeDataGrid()
        {

            ClientD oClients = new ClientD();
            List<ClientE> Clients = oClients.getClients();
            this.dataGridView1.DataSource = Clients;

        }

        
        private void Clients_Load(object sender, EventArgs e)
        {

        }

        private ClientE createClientE()
        {
            ClientE oClientE = new ClientE();
            //Validate the camps at Client form
            Validate oValidate = new Validate();
            try
            {
                //verify the camps is not null
                if (String.IsNullOrEmpty(txtID.Text) || String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtLastName1.Text) ||
                    String.IsNullOrEmpty(txtLastName2.Text) || String.IsNullOrEmpty(txtOfficePhone.Text) || String.IsNullOrEmpty(txtHuosePhone.Text) ||
                    String.IsNullOrEmpty(txtCelphone.Text) || String.IsNullOrEmpty(txtFax.Text) || String.IsNullOrEmpty(txtAddress.Text))
                {
                    MessageBox.Show("Todos los campos son requeridos");
                   
                }
                else
                {
                    //get data at form
                    string id = txtID.Text;
                    string name = txtName.Text;
                    string lastName1 = txtLastName1.Text;
                    string lastName2 = txtLastName2.Text;
                    string officePhone = txtOfficePhone.Text;
                    string housePhone = txtHuosePhone.Text;
                    string celphone = txtCelphone.Text;
                    string fax = txtFax.Text;
                    string address = txtAddress.Text;

                    //verify the data 
                    if (oValidate.number(id) && oValidate.text(name) && oValidate.text(lastName1) && oValidate.text(lastName2) &&
                        oValidate.number(officePhone) && oValidate.number(housePhone) && oValidate.number(celphone) &&
                        oValidate.number(fax) && oValidate.text(address))
                    {
                        //creates new object ClientE
                        oClientE = new ClientE(id, name, lastName1, lastName2, int.Parse(officePhone), int.Parse(housePhone),
                            int.Parse(celphone), int.Parse(fax), address);

                        
                    }

                }
            }
            catch
            {
                MessageBox.Show("Error verifique los datos insertados");
            }
            return oClientE;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
            ClientE oClientE = createClientE();
            if(oClientE != null)
            {
                if (oClienteD.insertClient(oClientE))
                {
                    MessageBox.Show("Cliente insertado correctamente");
                    chargeDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Error al insertar cliente: "+oClienteD.ErrorMsg);
            }
            
                       
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells["Cedula"].Value.ToString();
            if (oClienteD.deleteClient(id))
            {
                MessageBox.Show("Cliente eliminado exitosamente");
                chargeDataGrid();
            }
            else
            {
                MessageBox.Show("Error al elimimar cliente: " + oClienteD.ErrorMsg);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells["Cedula"].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            txtLastName1.Text = dataGridView1.CurrentRow.Cells["LastName1"].Value.ToString();
            txtLastName2.Text = dataGridView1.CurrentRow.Cells["LastName2"].Value.ToString();
            txtOfficePhone.Text = dataGridView1.CurrentRow.Cells["OfficePhone"].Value.ToString();
            txtHuosePhone.Text = dataGridView1.CurrentRow.Cells["HousePhone"].Value.ToString();
            txtCelphone.Text = dataGridView1.CurrentRow.Cells["Celphone"].Value.ToString();
            txtFax.Text = dataGridView1.CurrentRow.Cells["Fax"].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells["Address"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells["Cedula"].Value.ToString();
            ClientE oClientE = createClientE();
            if (oClientE != null)
            {
                if (oClienteD.updateClient(oClientE))
                {
                    MessageBox.Show("Cliente modificado correctamente");
                    chargeDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Error al modificar cliente: " + oClienteD.ErrorMsg);
            }
        }
    }
}

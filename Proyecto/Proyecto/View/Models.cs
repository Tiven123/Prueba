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
    public partial class Models : Form
    {
        ModelD oModelD;

        public Models()
        {
            InitializeComponent();
            oModelD = new ModelD();
            chargeCombo();
            chargeDataGrid();
        }

        public void chargeDataGrid()
        {

            List<ModelE> Models = oModelD.get();
            this.dataGridView1.DataSource = Models;

        }

        private ModelE createModelE()
        {
            ModelE oModelE = new ModelE();
            //Validate the camps at brand form
            Validate oValidate = new Validate();
            try
            {
                string brand = cbBrand.SelectedItem.ToString();
                //verify the camps is not null
                if (String.IsNullOrEmpty(txtID.Text) || String.IsNullOrEmpty(txtDescription.Text) || String.IsNullOrEmpty(brand))
                {
                    MessageBox.Show("Todos los campos son requeridos");

                }
                else
                {
                    //get data at form
                    string id = txtID.Text;
                    string description = txtDescription.Text;
                    BrandE oBrandE = (BrandE) cbBrand.SelectedItem;

                    //verify the data 
                    if (oValidate.number(id) && oValidate.text(description))
                    {
                        //creates new object ClientE
                        oModelE = new ModelE(int.Parse(id), oBrandE.Code, description);

                    }

                }
            }
            catch
            {
                MessageBox.Show("Error verifique los datos insertados");
            }
            return oModelE;
        }


        private void chargeCombo()
        {
            this.cbBrand.Items.Clear();
            BrandD oBrandD = new BrandD();
            List<BrandE> brands = oBrandD.getBrands();


            foreach (BrandE oBrandE in brands)
            {
                this.cbBrand.Items.Add(oBrandE);
            }
            cbBrand.SelectedIndex = 0;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string code = dataGridView1.CurrentRow.Cells["Code"].Value.ToString();
            ModelE oModelE = createModelE();
            if (oModelE != null)
            {
                if (oModelD.update(oModelE))
                {
                    MessageBox.Show("Modelo modificado correctamente");
                    chargeDataGrid();
                    clean();
                }
            }
            else
            {
                MessageBox.Show("Error al modificar modelo: " + oModelD.ErrorMsg);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            ModelE oModelE = createModelE();
            if (oModelE != null)
            {
                if (oModelD.insert(oModelE))
                {
                    MessageBox.Show("Modelo insertado correctamente");
                    chargeDataGrid();
                    clean();
                }
            }
            else
            {
                MessageBox.Show("Error al insertar modelo: " + oModelD.ErrorMsg);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int brand = int.Parse(dataGridView1.CurrentRow.Cells["Brand"].Value.ToString());
            BrandE oBrandE = new BrandE();
            for (int i = 0; i < this.cbBrand.Items.Count; i++)
            {
                cbBrand.SelectedIndex= i;
                oBrandE = (BrandE)cbBrand.SelectedItem;
                if (oBrandE.Code == brand)
                {
                    break;
                }
            }
            txtID.Text = dataGridView1.CurrentRow.Cells["Code"].Value.ToString();
            txtDescription.Text = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el Modelo", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string code = dataGridView1.CurrentRow.Cells["Code"].Value.ToString();
                if (oModelD.delete(code))
                {
                    MessageBox.Show("Modelo eliminado exitosamente");
                    chargeDataGrid();
                    clean();
                }
                else
                {
                    MessageBox.Show("Error al elimimar modelo: " + oModelD.ErrorMsg);
                }
            }
            else
            {
                MessageBox.Show("Eliminacion cancelada", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void clean()
        {
            txtID.Text = "";
            txtDescription.Text = "";
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            clean();
        }
    }
}

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
    public partial class Brands : Form
    {

        BrandD oBreandD;

        public Brands()
        {
            InitializeComponent();
            oBreandD = new BrandD();
            chargeDataGrid();

        }

        public void chargeDataGrid()
        {

            List<BrandE> Brands = oBreandD.getBrands();
            this.dataGridView1.DataSource = Brands;

        }

        private BrandE createBrandE()
        {
            BrandE oBrandE = new BrandE();
            //Validate the camps at brand form
            Validate oValidate = new Validate();
            try
            {
                //verify the camps is not null
                if (String.IsNullOrEmpty(txtCode.Text) || String.IsNullOrEmpty(txtDescription.Text))
                {
                    MessageBox.Show("Todos los campos son requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    //get data at form
                    string code = txtCode.Text;
                    string description = txtDescription.Text;

                    //verify the data 
                    if (oValidate.number(code) && oValidate.text(description))
                    {
                        //creates new object ClientE
                        oBrandE = new BrandE(int.Parse(code), description);

                    }

                }
            }
            catch
            {
                MessageBox.Show("Problema al crear Marca", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return oBrandE;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            BrandE oBrandE = createBrandE();
            if (oBrandE != null)
            {
                if (oBreandD.insertBrand(oBrandE))
                {
                    MessageBox.Show("Marca insertado correctamente","Inserción",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    chargeDataGrid();
                    cleanForm();
                }
                else
                {
                    MessageBox.Show("Error al insertar marca: " + oBreandD.ErrorMsg,"Inserción",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error al crear marca", "Inserción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar la marca", "Eliminación", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string code = dataGridView1.CurrentRow.Cells["Code"].Value.ToString();
                if (oBreandD.deleteBrand(code))
                {
                    MessageBox.Show("Marca eliminado correctamente", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    chargeDataGrid();
                    cleanForm();
                }
                else
                {
                    MessageBox.Show("Error al eliminar marca: " + oBreandD.ErrorMsg, "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Eliminacion cancelada", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = dataGridView1.CurrentRow.Cells["Code"].Value.ToString();
            txtDescription.Text = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string code = dataGridView1.CurrentRow.Cells["Code"].Value.ToString();
            BrandE oBrandE = createBrandE();
            if (oBrandE != null)
            {
                if (oBreandD.updateBrand(oBrandE))
                {
                    MessageBox.Show("Marca modificada correctamente", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    chargeDataGrid();
                    cleanForm();
                }
                else
                {
                    MessageBox.Show("Error al modificar marca: " + oBreandD.ErrorMsg, "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error al crear marca", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cleanForm()
        {
            txtCode.Text = "";
            txtDescription.Text = "";
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            cleanForm();
        }
    }
}

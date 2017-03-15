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
                    MessageBox.Show("Todos los campos son requeridos");

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
                MessageBox.Show("Error verifique los datos insertados");
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
                    MessageBox.Show("Marca insertada correctamente");
                    chargeDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Error al insertar marca: " + oBreandD.ErrorMsg);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string code = dataGridView1.CurrentRow.Cells["Code"].Value.ToString();
            if (oBreandD.deleteBrand(code))
            {
                MessageBox.Show("Marca eliminada exitosamente");
                chargeDataGrid();
            }
            else
            {
                MessageBox.Show("Error al elimimar marca: " + oBreandD.ErrorMsg);
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
                    MessageBox.Show("Marca modificada correctamente");
                    chargeDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Error al modificar marca: " + oBreandD.ErrorMsg);
            }
        }
    }
}

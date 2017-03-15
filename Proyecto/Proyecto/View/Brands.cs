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
    }
}

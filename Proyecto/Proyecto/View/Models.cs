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


        public void chargeCombo()
        {
            this.cbBrand.Items.Clear();
            BrandD oBrandD = new BrandD();
            List<BrandE> brands = oBrandD.getBrands();


            foreach (BrandE oBrandE in brands)
            {
                this.cbBrand.Items.Add(oBrandE.Description);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }
    }
}

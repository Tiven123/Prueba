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
using Proyecto.Model;

namespace Proyecto.View
{
    public partial class Positions : Form
    {
        public Positions()
        {
            InitializeComponent();
            chargeDataGrid();
        }

        public void chargeDataGrid()
        {
            /*this.dataGridViewPositions.Columns[0].Name = "Cod";
            this.dataGridViewPositions.Columns[1].Name = "Descripción";
            this.dataGridViewPositions.Columns[2].Name = "Tipo";*/

            PositionD oPositionD = new PositionD();
            List<PositionE> Positions = oPositionD.getPositions();

            this.dataGridViewPositions.DataSource = Positions;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((this.textBoxPositionCod.Text == "") || (this.textBoxDescription.Text == "") || (this.textBoxPositionType.Text == ""))
            {
                MessageBox.Show("Debe llenar todos los datos requeridos",
                                "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PositionD oPositionD = new PositionD();
                PositionE oPositionE = new PositionE(int.Parse(this.textBoxPositionCod.Text), this.textBoxDescription.Text, this.textBoxPositionType.Text);
                oPositionD.insertPositions(oPositionE);
                if (oPositionD.Error)
                {
                    MessageBox.Show("Error insertando los datos: " +
                            oPositionD.ErrorMsg, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Posición insertada exitosamente");
                    chargeDataGrid();
                }
            }
        }
    }
}

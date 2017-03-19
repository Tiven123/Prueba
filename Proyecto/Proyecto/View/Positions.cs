using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Controller;
using Model;

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
            PositionD oPositionD = new PositionD();
            List<PositionE> Positions = oPositionD.getPositions();

            this.dataGridViewPositions.DataSource = Positions;

        }

        public void cleanForm()
        {
            this.textBoxDescription.Text = "";
            this.textBoxPositionCod.Text = "";
            this.textBoxPositionType.Text = "";
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
                    cleanForm();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar este registro ?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PositionD oPositionD = new PositionD();
                int id = int.Parse(this.dataGridViewPositions.CurrentRow.Cells["PositionCod"].Value.ToString());
                if (oPositionD.deletePosition(id))
                {
                    MessageBox.Show("Posicion eliminada exitosamente");
                    chargeDataGrid();
                    cleanForm();
                }
                else
                {
                    MessageBox.Show("Error al elimimar posición: " + oPositionD.ErrorMsg);
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            PositionD oPositionD = new PositionD();
            int pPositionCod = int.Parse(this.dataGridViewPositions.CurrentRow.Cells["PositionCod"].Value.ToString());
            PositionE oPositionE = new PositionE(int.Parse(this.textBoxPositionCod.Text), this.textBoxDescription.Text, this.textBoxPositionType.Text);
            if (oPositionD.updatePosition(oPositionE, pPositionCod))
            {
                MessageBox.Show("Posición modificada correctamente");
                chargeDataGrid();
                cleanForm();

            }
            else
            {
                MessageBox.Show("Error al modificar posicion: " + oPositionD.ErrorMsg);
            }
        }

        private void dataGridViewPositions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridViewPositions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBoxPositionCod.Text = dataGridViewPositions.CurrentRow.Cells["PositionCod"].Value.ToString();
            this.textBoxDescription.Text = dataGridViewPositions.CurrentRow.Cells["Description"].Value.ToString();
            this.textBoxPositionType.Text = dataGridViewPositions.CurrentRow.Cells["Type"].Value.ToString();
        }

        private void buttonCleanForm_Click(object sender, EventArgs e)
        {
            cleanForm();
        }

        private void textBoxPositionCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}

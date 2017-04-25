using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Controller;
using Model;
using Proyecto.Logic;

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
                PositionL oPositionL = new PositionL();
                string asnwer = oPositionL.addPosition(int.Parse(this.textBoxPositionCod.Text), this.textBoxDescription.Text, this.textBoxPositionType.Text);
                if (asnwer == "")
                {
                    this.chargeDataGrid();
                }
                else
                {
                    MessageBox.Show(asnwer);
                    this.chargeDataGrid();
                }                          
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar este registro ?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = int.Parse(this.dataGridViewPositions.CurrentRow.Cells["PositionCod"].Value.ToString());
                PositionL oPositionL = new PositionL();
                string asnwer = oPositionL.deletePosition(id);
                if (asnwer == "")
                {
                    this.chargeDataGrid();
                }
                else
                {
                    MessageBox.Show(asnwer);
                    this.chargeDataGrid();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int pPositionCod = int.Parse(this.dataGridViewPositions.CurrentRow.Cells["PositionCod"].Value.ToString());
            PositionL oPositionL = new PositionL();
            string asnwer = oPositionL.editPosition(int.Parse(this.textBoxPositionCod.Text), this.textBoxDescription.Text, this.textBoxPositionType.Text, pPositionCod);
            if (asnwer == "")
            {
                this.chargeDataGrid();
            }
            else
            {
                MessageBox.Show(asnwer);
                this.chargeDataGrid();
            }
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

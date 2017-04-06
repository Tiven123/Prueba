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
    public partial class Replacements : Form
    {
        ReplacementD oReplacementD;
        public Replacements()
        {
            InitializeComponent();
            oReplacementD = new ReplacementD();
            chargeDataGrid();
        }

        public void chargeDataGrid()
        {

            List<ReplacementE> Replacements = oReplacementD.get();
            this.dataGridView1.DataSource = Replacements;

        }

        private ReplacementE create()
        {
            ReplacementE oReplacementE = new ReplacementE();
            //Validate the camps 
            Validate oValidate = new Validate();
            try
            {
                //verify the camps is not null
                if (String.IsNullOrEmpty(txtCode.Text) || String.IsNullOrEmpty(txtDescription.Text) || String.IsNullOrEmpty(txtCost.Text) || String.IsNullOrEmpty(txtYear.Text))
                {
                    MessageBox.Show("Todos los campos son requeridos");

                }
                else
                {
                    //get data at form
                    string code = txtCode.Text;
                    string description = txtDescription.Text;
                    string year = txtYear.Text;
                    string cost = txtCost.Text;

                    //verify the data 
                    if (oValidate.number(code) && oValidate.text(description) && oValidate.number(year) && oValidate.number(cost))
                    {
                        //creates new object ClientE
                        oReplacementE = new ReplacementE(int.Parse(code), description, int.Parse(year), int.Parse(cost));
                    }

                }
            }
            catch
            {
                MessageBox.Show("Error verifique los datos insertados");
            }
            return oReplacementE;
        }

        private void Replacements_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = dataGridView1.CurrentRow.Cells["Consecutive"].Value.ToString();
            txtDescription.Text = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
            txtYear.Text = dataGridView1.CurrentRow.Cells["Annio"].Value.ToString();
            txtCost.Text = dataGridView1.CurrentRow.Cells["Cost"].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            ReplacementE oReplacementE = create();
            if (oReplacementE != null)
            {
                if (oReplacementD.insert(oReplacementE))
                {
                    MessageBox.Show("Repuesto insertado correctamente");
                    chargeDataGrid();
                    clean();
                }
                else
                {
                    MessageBox.Show("Error al insertar repuesto: " + oReplacementD.ErrorMsg);
                }
            }
            else
            {
                MessageBox.Show("Error en los datos ingresados ");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el repuesto", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string code = dataGridView1.CurrentRow.Cells["Consecutive"].Value.ToString();
                if (oReplacementD.delete(code))
                {
                    MessageBox.Show("Repuesto eliminado exitosamente");
                    chargeDataGrid();
                    clean();
                }
                else
                {
                    MessageBox.Show("Error al elimimar repuesto: " + oReplacementD.ErrorMsg);
                }
            }
            else
            {
                MessageBox.Show("Eliminacion cancelada", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string code = dataGridView1.CurrentRow.Cells["Consecutive"].Value.ToString();
            ReplacementE oReplacementE = create();
            if (oReplacementE != null)
            {
                if (oReplacementD.update(oReplacementE))
                {
                    MessageBox.Show("Repuesto modificado correctamente");
                    chargeDataGrid();
                    clean();
                }
            }
            else
            {
                MessageBox.Show("Error al modificar Repuesto: " + oReplacementD.ErrorMsg);
            }
        }
        public void clean()
        {
            txtCode.Text = "";
            txtDescription.Text = "";
            txtYear.Text = "";
            txtCost.Text = "";
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            clean();
        }
    }
}

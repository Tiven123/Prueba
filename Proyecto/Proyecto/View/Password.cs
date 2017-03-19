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
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if ((this.textBoxCurrentPassword.Text == "") || (this.textBoxNewPassword1.Text == "") || (this.textBoxNewPassword2.Text == ""))
            {
                MessageBox.Show("Debe llenar todos los datos requeridos",
                                "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EmployeeD oEmployeeD = new EmployeeD();
                if (oEmployeeD.updateEmployeePassword(pOldPassword, pNewPassword))
                {
                    MessageBox.Show("Contraseña modificada correctamente");
                }
                else
                {
                    MessageBox.Show("Error al modificar empleado: " + oEmployeeD.ErrorMsg);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

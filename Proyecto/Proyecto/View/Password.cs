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

        public void cleanTextBoxNewPassword()
        {
            this.textBoxNewPassword1.Text = "";
            this.textBoxNewPassword2.Text = "";
        }

        public void cleanAllTextBoxPassword()
        {
            this.textBoxCurrentPassword.Text = "";
            this.textBoxNewPassword1.Text = "";
            this.textBoxNewPassword2.Text = "";
            this.textBoxUserName.Text = "";
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            EmployeeD oEmployeeD = new EmployeeD();
            //this verify blanc spaces
            if ((this.textBoxCurrentPassword.Text == "") || (this.textBoxNewPassword1.Text == "") || (this.textBoxNewPassword2.Text == "") || (this.textBoxUserName.Text == ""))
            {
                MessageBox.Show("Debe llenar todos los datos requeridos",
                                "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

            } 
            //this verify if it is user
            else if (oEmployeeD.isUser(this.textBoxUserName.Text, this.textBoxCurrentPassword.Text))
            {
                //this verify if the new password is the same
                if (this.textBoxNewPassword1.Text == this.textBoxNewPassword2.Text)
                {

                    oEmployeeD.updateEmployeePassword(this.textBoxUserName.Text, this.textBoxCurrentPassword.Text, this.textBoxNewPassword2.Text);
                    if (oEmployeeD.Error)
                    {
                        MessageBox.Show("Error al ingresar los datos: " + oEmployeeD.ErrorMsg);
                        cleanAllTextBoxPassword();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña modificada correctamente");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Error de Confirmación de contraseña, Por favor ingresela nuevamente!",
                                "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cleanTextBoxNewPassword();
                }
            }
            else
            {
                MessageBox.Show("Error de verificación, porfavor inserte Usuario y contraseña validos.");
                cleanAllTextBoxPassword();
            }
        }
    

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}

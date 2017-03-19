using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Proyecto.View;


namespace Proyecto.view
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            EmployeeD oEmployeeD = new EmployeeD();
            if ((this.textBoxUserName.Text == "") || (this.textBoxPassword.Text == ""))
            {
                MessageBox.Show("Debe llenar todos los datos requeridos",
                                "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (oEmployeeD.isUser(this.textBoxUserName.Text, this.textBoxPassword.Text))
            {
                MessageBox.Show("Bienvenido");
                //this.Close();
                MainMenu oMainMenu = new MainMenu();
                oMainMenu.ShowDialog();
            }
            else if (oEmployeeD.Error)
            {
                MessageBox.Show("Error insertando los datos: " +
                    oEmployeeD.ErrorMsg, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos: " +
                    oEmployeeD.ErrorMsg, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBoxUserName.Text = "";
                this.textBoxPassword.Text = "";
            }
            
        }
    }
}

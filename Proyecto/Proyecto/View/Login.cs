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
using Proyecto.Logic;
using Proyecto.View;


namespace Proyecto.view
{
    public partial class Login : Form
    {
        private LoginOk oLoginOk = new LoginOk();

        public LoginOk OLoginOk
        {
            get
            {
                return oLoginOk;
            }

            set
            {
                oLoginOk = value;
            }
        }

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
            else 
            {
                EmployeeL oEmployeeL = new EmployeeL();
                oLoginOk = oEmployeeL.isUser1(this.textBoxUserName.Text, this.textBoxPassword.Text);
                if (oLoginOk.Answer == "Bienvenido")
                {
                    MessageBox.Show(oLoginOk.Answer);
                    this.oLoginOk.Login = true;
                    //this.oLoginOk.OEmployeeE = this.oEmployeeE;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(oLoginOk.Answer);
                    this.textBoxUserName.Text = "";
                    this.textBoxPassword.Text = "";
                }
            }           
        }
    }
}

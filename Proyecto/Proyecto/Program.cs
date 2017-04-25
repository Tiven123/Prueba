using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.view;

namespace Proyecto
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Login oLogin = new Login();
            oLogin.ShowDialog();
            if (oLogin.OLoginOk.Login)
            {
                MainMenu oMainMenu = new MainMenu(oLogin.OLoginOk.OEmployeeE);
                oMainMenu.ShowDialog();
            }
        }
    }
}

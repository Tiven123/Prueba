using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;

namespace Proyecto.Logic
{
    public class LoginOk
    {
        private bool login;
        private EmployeeE oEmployeeE = new EmployeeE();
        private string answer;

        public LoginOk()
        {

        }

        public LoginOk(bool pLogin, EmployeeE pEmployeeE, string pAsnwer)
        {
            this.Login = pLogin;
            this.OEmployeeE = pEmployeeE;
            this.Answer = pAsnwer;
        }

        public bool Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        public EmployeeE OEmployeeE
        {
            get
            {
                return oEmployeeE;
            }

            set
            {
                oEmployeeE = value;
            }
        }

        public string Answer
        {
            get
            {
                return answer;
            }

            set
            {
                answer = value;
            }
        }
    }
}

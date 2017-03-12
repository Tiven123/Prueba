using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class EmployeeE : PersonE
    {
        private string employeeCod;
        private PositionE position;
        private string userName;
        private string password;
        private bool systemAccess;
        private bool orderManagerAccess;
        private bool managerMagnamentAccess;

        public string EmployeeCod
        {
            get
            {
                return employeeCod;
            }

            set
            {
                employeeCod = value;
            }
        }

        internal PositionE Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public bool SystemAccess
        {
            get
            {
                return systemAccess;
            }

            set
            {
                systemAccess = value;
            }
        }

        public bool OrderManagerAccess
        {
            get
            {
                return orderManagerAccess;
            }

            set
            {
                orderManagerAccess = value;
            }
        }

        public bool ManagerMagnamentAccess
        {
            get
            {
                return managerMagnamentAccess;
            }

            set
            {
                managerMagnamentAccess = value;
            }
        }

        public EmployeeE(string pName, string pLastName1, string pLastName2, int pHousePhones, int pCelphone, string pAddress,
                        string pEmployeeCod, PositionE pPosition, string pUserName, string pPassword, bool pSystemAccess,
                        bool pOrderManagerAccess, bool pManagerMagnamentAccess) : base(pName, pLastName1, pLastName2, pHousePhones, pCelphone, pAddress)
        {
            this.EmployeeCod = pEmployeeCod;
            this.Position = pPosition;
            this.UserName = pUserName;
            this.Password = pPassword;
            this.SystemAccess = pSystemAccess;
            this.OrderManagerAccess = pOrderManagerAccess;
            this.ManagerMagnamentAccess = pManagerMagnamentAccess;
        }

        public override string ToString()
        {
            return base.ToString() +
                "Codigo de empleado: " + this.employeeCod + "\n" +
                "Posición: " + this.position.ToString() + "\n";
        }
    }
}
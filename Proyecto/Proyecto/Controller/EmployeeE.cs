using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class EmployeeE : PersonE
    {
        private int employeeCod;
        private PositionE position;
        private int positionCod;
        private string userName;
        private string password;
        private char parameters;
        private char systemAccess;
        private char orderManagerAccess;
        private char managerMagnamentAccess;

        public int EmployeeCod
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

        public char SystemAccess
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

        public char OrderManagerAccess
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

        public char ManagerMagnamentAccess
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

        public char Parameters
        {
            get
            {
                return parameters;
            }

            set
            {
                parameters = value;
            }
        }

        public int PositionCod
        {
            get
            {
                return positionCod;
            }

            set
            {
                positionCod = value;
            }
        }

        public EmployeeE(string pName,
                        string pLastName1,
                        string pLastName2,
                        int pHousePhones,
                        int pCelphone,
                        string pAddress,
                        int pEmployeeCod,
                        PositionE pPosition,
                        string pUserName,
                        string pPassword,
                        char pParameters,
                        char pSystemAccess,
                        char pOrderManagerAccess,
                        char pManagerMagnamentAccess) :
                        base(pName,
                            pLastName1,
                            pLastName2,
                            pHousePhones,
                            pCelphone,
                            pAddress)
        {
            this.EmployeeCod = pEmployeeCod;
            this.Position = pPosition;
            this.UserName = pUserName;
            this.Password = pPassword;
            this.parameters = pParameters;
            this.SystemAccess = pSystemAccess;
            this.OrderManagerAccess = pOrderManagerAccess;
            this.ManagerMagnamentAccess = pManagerMagnamentAccess;
        }

        public EmployeeE(string pName,
                        string pLastName1,
                        string pLastName2,
                        int pHousePhones,
                        int pCelphone,
                        string pAddress,
                        int pEmployeeCod,
                        int pPositionCod,
                        string pUserName,
                        string pPassword,
                        char pParameters,
                        char pSystemAccess,
                        char pOrderManagerAccess,
                        char pManagerMagnamentAccess) :
                        base(pName,
                            pLastName1,
                            pLastName2,
                            pHousePhones,
                            pCelphone,
                            pAddress)
        {
            this.EmployeeCod = pEmployeeCod;
            this.PositionCod = pPositionCod;
            this.UserName = pUserName;
            this.Password = pPassword;
            this.parameters = pParameters;
            this.SystemAccess = pSystemAccess;
            this.OrderManagerAccess = pOrderManagerAccess;
            this.ManagerMagnamentAccess = pManagerMagnamentAccess;
        }

        public EmployeeE(string pUserName)                      
        {
            this.UserName = pUserName;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
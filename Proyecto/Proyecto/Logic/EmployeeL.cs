using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using Model;

namespace Proyecto.Logic
{
    class EmployeeL
    {
        public EmployeeL()
        {
        }
        public string addEmployee(string pName, string pLastName1, string pLastname2, int pHousePhone,
                                    int pCelphone, string pAddress, int pEmployeeCod, int pPositionCod,
                                    string pUserName, string pPassword, char pParameterAccess, char pSystemAccess,
                                    char pOrderManagerAccess, char pManagerMagnamentAccess)
        {
            string answer = "";
            EmployeeD oEmployeeD = new EmployeeD();
            EmployeeE oEmployeeE = new EmployeeE(pName,
                                                pLastName1,
                                                pLastname2,
                                                pHousePhone,
                                                pCelphone,
                                                pAddress,
                                                pEmployeeCod,
                                                pPositionCod,
                                                pUserName,
                                                pPassword,
                                                pParameterAccess,
                                                pSystemAccess,
                                                pOrderManagerAccess,
                                                pManagerMagnamentAccess);
            oEmployeeD.insertEmployee(oEmployeeE);
            if (oEmployeeD.Error)
            {
                answer = "Error insertando los datos: " + oEmployeeD.ErrorMsg;
            }
            else
            {
                answer = "Empleado insertado exitosamente";
            }
            return answer;
        }

        public string editEmployee(string pName,
                                    string pLastName1,
                                    string pLastname2,
                                    int pHousePhone,
                                    int pCelphone,
                                    string pAddress,
                                    int pEmployeeCod,
                                    int pPositionCod,
                                    string pUserName,
                                    string pPassword,
                                    char pParameterAccess,
                                    char pSystemAccess,
                                    char pOrderManagerAccess,
                                    char pManagerMagnamentAccess,
                                    int parameterEmployeeCod)
        {
            string answer = "";
            EmployeeD oEmployeeD = new EmployeeD();
            EmployeeE oEmployeeE = new EmployeeE(pName,
                                                pLastName1,
                                                pLastname2,
                                                pHousePhone,
                                                pCelphone,
                                                pAddress,
                                                pEmployeeCod,
                                                pPositionCod,
                                                pUserName,
                                                pPassword,
                                                pParameterAccess,
                                                pSystemAccess,
                                                pOrderManagerAccess,
                                                pManagerMagnamentAccess);

            if (oEmployeeD.updateEmployee(oEmployeeE, parameterEmployeeCod))
            {
                answer = "Empleado insertado exitosamente";
            }
            if (oEmployeeD.Error)
            {
                answer = "Error insertando los datos: " + oEmployeeD.ErrorMsg;
            }
            return answer;
        }

        public string deleteEmployee(int id)
        {
            string answer = "";
            EmployeeD oEmployeeD = new EmployeeD();
            if (oEmployeeD.deleteEmployee(id))
            {
                answer = "Empleado eliminado exitosamente";
            }
            else
            {
                answer = "Error al elimimar empleado: " + oEmployeeD.ErrorMsg;
            }
            return answer;
        }

        public string updateEmployeePassword(string userName, string password, string newPassword)
        {
            string answer = "";
            EmployeeD oEmployeeD = new EmployeeD();
            oEmployeeD.updateEmployeePassword(userName, password, newPassword);
            if (oEmployeeD.Error)
            {
                answer = "Error al ingresar los datos: " + oEmployeeD.ErrorMsg;
            }
            else
            {
                answer = "Contraseña modificada correctamente";
            }
            return answer;
        }

        public LoginOk isUser1(string userName, string password)
        {
            string answer = "";
            LoginOk oLoginOk = null;
            EmployeeD oEmployeeD = new EmployeeD();
            EmployeeE oEmployeeE = oEmployeeD.isUser1(userName, password);
            if (oEmployeeD.Error)
            {
                answer = "Error insertando los datos: " + oEmployeeD.ErrorMsg;
                oLoginOk = new LoginOk(false, null, answer);
                              
            }
            else 
            {
                answer = "Bienvenido";
                oLoginOk = new LoginOk(true, oEmployeeE, answer);
            }
            return oLoginOk;
        }

        public string isUser2(string userName, string password)
        {
            string answer = "";
            EmployeeD oEmployeeD = new EmployeeD();
            if (oEmployeeD.isUser2(userName, password))
            {
                answer = "Bienvenido";

            }
            else
            {
                answer = "Error consultando los datos: " + oEmployeeD.ErrorMsg;
            }
            return answer;
        }
    }
}

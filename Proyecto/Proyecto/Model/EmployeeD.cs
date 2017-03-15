using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using NpgsqlTypes;
using Model;

namespace Model
{
    public class EmployeeD
    {
        private PostgressDataAccess connection;

        private bool error;

        public bool Error
        {
            get { return error; }
        }

        private string errorMsg;
        public string ErrorMsg
        {
            get { return errorMsg; }
        }

        public EmployeeD()
        {
            this.connection = PostgressDataAccess.Instance;
            this.errorCleaner();
        }

        public void errorCleaner()
        {
            this.error = false;
            this.errorMsg = "";
        }


        public void insertEmployee(EmployeeE oEmployeeE)
        {
            this.errorCleaner();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "INSERT INTO employee(employeecod, employeeposition, employee_name, employee_last_name1, employee_last_name2, " +
                    "address, housephone, celphone, employeeuser, employeepassword, system_access, parameters_access, ordersadmin_access, management_manager) " +
                    "VALUES (@employeecod, @employeeposition, @employee_name, @employee_last_name1, @employee_last_name2, " +
                    "@address, @housephone, @celphone, @employeeuser, @employeepassword, @system_access, @parameters_access, @ordersadmin_access, @management_manager);";
                oParameters.addParameter("@employeecod", NpgsqlDbType.Integer, oEmployeeE.EmployeeCod);
                oParameters.addParameter("@employeeposition", NpgsqlDbType.Integer, oEmployeeE.PositionCod);
                oParameters.addParameter("@employee_name", NpgsqlDbType.Varchar, oEmployeeE.Name);
                oParameters.addParameter("@employee_last_name1", NpgsqlDbType.Varchar, oEmployeeE.LastName1);
                oParameters.addParameter("@employee_last_name2", NpgsqlDbType.Varchar, oEmployeeE.LastName2);
                oParameters.addParameter("@address", NpgsqlDbType.Varchar, oEmployeeE.Address);
                oParameters.addParameter("@housephone", NpgsqlDbType.Integer, oEmployeeE.HousePhone);
                oParameters.addParameter("@celphone", NpgsqlDbType.Integer, oEmployeeE.Celphone);
                oParameters.addParameter("@employeeuser", NpgsqlDbType.Varchar, oEmployeeE.UserName);
                oParameters.addParameter("@employeepassword", NpgsqlDbType.Varchar, oEmployeeE.Password);
                oParameters.addParameter("@system_access", NpgsqlDbType.Char, oEmployeeE.SystemAccess);
                oParameters.addParameter("@parameters_access", NpgsqlDbType.Char, oEmployeeE.Parameters);
                oParameters.addParameter("@ordersadmin_access", NpgsqlDbType.Char, oEmployeeE.OrderManagerAccess);
                oParameters.addParameter("@management_manager", NpgsqlDbType.Char, oEmployeeE.ManagerMagnamentAccess);

                this.connection.executeSQL(sql, oParameters.getParameter());
                if (this.connection.IsError)
                {
                    error = true;
                    this.errorMsg = this.connection.descriptionError;
                }
            }
            catch (Exception e)
            {
                error = true;
                this.errorMsg = e.Message;
            }
        }

        public List<EmployeeE> getEmployees()
        {
            this.errorCleaner();
            List<EmployeeE> positions = new List<EmployeeE>();
            DataSet dsetEmployees;
            try
            {
                string sql = "select p.employeecod as employeecod_desc, p.employee_name as employeename_desc, p.employee_last_name1 as employeelastname1_desc, " +
                         "p.employee_last_name2 as employeelastname2_desc, p.employeeposition as employeeposition_desc, p.address as address_desc, p.housephone as housephone_desc, " +
                         "p.celphone as celphone_desc, p.employeeuser as employeeuser_desc, p.employeepassword as employeepassword_desc, p.system_access as systemaccess_desc, " +
                         "p.parameters_access as parameters_desc, p.ordersadmin_access as ordersadmin_desc, p.management_manager as managementmanager_desc from employee p;";
                dsetEmployees = this.connection.executeSQLQuery(sql);

                foreach (DataRow tupla in dsetEmployees.Tables[0].Rows)
                {
                    EmployeeE oEmployeeE = new EmployeeE(tupla["employeename_desc"].ToString(),
                        tupla["employeelastname1_desc"].ToString(),
                        tupla["employeelastname2_desc"].ToString(),
                        int.Parse(tupla["housephone_desc"].ToString()),
                        int.Parse(tupla["celphone_desc"].ToString()),
                        tupla["address_desc"].ToString(),
                        int.Parse(tupla["employeecod_desc"].ToString()),
                        int.Parse(tupla["employeeposition_desc"].ToString()),
                        tupla["employeeuser_desc"].ToString(),
                        tupla["employeepassword_desc"].ToString(),
                        char.Parse(tupla["parameters_desc"].ToString()),
                        char.Parse(tupla["systemaccess_desc"].ToString()),
                        char.Parse(tupla["ordersadmin_desc"].ToString()),
                        char.Parse(tupla["managementmanager_desc"].ToString()));
                    positions.Add(oEmployeeE);
                }
            }
            catch (Exception e)
            {
                error = true;
                this.errorMsg = e.Message;
            }
            return positions;
        }

        public Boolean updateEmployee(EmployeeE oEmployeeE, int pEmployeeCod)
        {
            this.errorCleaner();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "UPDATE employee SET employeecod = @employeecod, employeeposition = @employeeposition, address = @address, " +
                    "housephone = @housephone, celphone = @celphone, employeeuser = @employeeuser, employeepassword = @employeepassword, " +
                    "employee_name = @employee_name, employee_last_name1 = @employee_last_name1, employee_last_name2 = @employee_last_name2, " +
                    "parameters_access = @parameters_access, system_access = @system_access, ordersadmin_access = @ordersadmin_access, " +
                    "management_manager = @management_manager WHERE employeecod = @pemployeecod;";

                oParameters.addParameter("@employeecod", NpgsqlDbType.Integer, oEmployeeE.EmployeeCod);
                oParameters.addParameter("@employeeposition", NpgsqlDbType.Integer, oEmployeeE.PositionCod);
                oParameters.addParameter("@address", NpgsqlDbType.Varchar, oEmployeeE.Address);
                oParameters.addParameter("@housephone", NpgsqlDbType.Integer, oEmployeeE.HousePhone);
                oParameters.addParameter("@celphone", NpgsqlDbType.Integer, oEmployeeE.Celphone);
                oParameters.addParameter("@employeeuser", NpgsqlDbType.Varchar, oEmployeeE.UserName);
                oParameters.addParameter("@employeepassword", NpgsqlDbType.Varchar, oEmployeeE.Password);
                oParameters.addParameter("@employee_name", NpgsqlDbType.Varchar, oEmployeeE.Name);
                oParameters.addParameter("@employee_last_name1", NpgsqlDbType.Varchar, oEmployeeE.LastName1);
                oParameters.addParameter("@employee_last_name2", NpgsqlDbType.Varchar, oEmployeeE.LastName2);
                oParameters.addParameter("@parameters_access", NpgsqlDbType.Char, oEmployeeE.Parameters);
                oParameters.addParameter("@system_access", NpgsqlDbType.Char, oEmployeeE.SystemAccess);
                oParameters.addParameter("@ordersadmin_access", NpgsqlDbType.Char, oEmployeeE.OrderManagerAccess);
                oParameters.addParameter("@management_manager", NpgsqlDbType.Char, oEmployeeE.ManagerMagnamentAccess);
                oParameters.addParameter("@pemployeecod", NpgsqlDbType.Integer, pEmployeeCod);

                this.connection.executeSQL(sql, oParameters.getParameter());

                if (this.connection.IsError)
                {
                    error = true;
                    this.errorMsg = this.connection.descriptionError;
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                error = true;
                this.errorMsg = e.Message;
                return false;
            }
        }

        public Boolean deleteEmployee(int pEmployeeCod)
        {
            this.errorCleaner();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "DELETE FROM employee WHERE employeecod = @pemployeecod;";

                oParameters.addParameter("@pemployeecod", NpgsqlDbType.Integer, pEmployeeCod);
                this.connection.executeSQL(sql, oParameters.getParameter());

                if (this.connection.IsError)
                {
                    error = true;
                    this.errorMsg = this.connection.descriptionError;
                    return false;
                }

                return true;
            }
            catch (Exception e)
            {
                error = true;
                this.errorMsg = e.Message;
                return false;
            }
        }
    }
}

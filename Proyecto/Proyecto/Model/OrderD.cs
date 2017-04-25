using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using NpgsqlTypes;
using Controller;

namespace Model
{
    class OrderD
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

        public OrderD()
        {
            this.connection = PostgressDataAccess.Instance;
            this.cleanError();
        }

        public void cleanError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<OrderE> getOrders()
        {
            this.cleanError();
            List<OrderE> orders = new List<OrderE>();
            DataSet dsetOrders;
            try
            {
                string sql = "SELECT o.consecutive AS consecutive_desc, o.caryear AS caryear_desc, o.employee AS employee_desc, o.vehicle AS vehicle_desc, o.entrydate AS entrydate_desc, o.exitdate AS exitdate_desc, " +
                    "o.billingdate AS billingdate_desc, o.state AS state_desc, o.costperorder AS costperorder_desc, o.bill AS bill_desc FROM workorder o;";

                dsetOrders = this.connection.executeSQLQuery(sql);
                foreach (DataRow tuple in dsetOrders.Tables[0].Rows)
                {
                    OrderE oOrdersE = new OrderE(int.Parse(tuple["consecutive_desc"].ToString()),
                                                int.Parse(tuple["caryear_desc"].ToString()), 
                                                int.Parse(tuple["employee_desc"].ToString()), 
                                                tuple["vehicle_desc"].ToString(),
                                                DateTime.Parse(tuple["entrydate_desc"].ToString()),
                                                DateTime.Parse(tuple["exitdate_desc"].ToString()),
                                                DateTime.Parse(tuple["billingdate_desc"].ToString()),
                                                tuple["state_desc"].ToString(), 
                                                int.Parse(tuple["costperorder_desc"].ToString()),
                                                int.Parse(tuple["bill_desc"].ToString()));
                    orders.Add(oOrdersE);
                }
            }
            catch (Exception e)
            {
                error = true;
                this.errorMsg = e.Message;
            }
            return orders;
        }
        public List<OrderE> get()
        {
            this.cleanError();
            List<OrderE> orders = new List<OrderE>();
            DataSet dsetOrders;
            try
            {
                string sql = "SELECT o.consecutive AS consecutive_desc, o.caryear AS caryear_desc, o.employee AS employee_desc, o.vehicle AS vehicle_desc, o.entrydate AS entrydate_desc, o.exitdate AS exitdate_desc, " +
                    "o.billingdate AS billingdate_desc, o.state AS state_desc, o.costperorder AS costperorder_desc, o.bill AS bill_desc FROM workorder o;";

                dsetOrders = this.connection.executeSQLQuery(sql);
                foreach (DataRow tuple in dsetOrders.Tables[0].Rows)
                {
                    OrderE oOrdersE = new OrderE(int.Parse(tuple["consecutive_desc"].ToString()),
                                                int.Parse(tuple["caryear_desc"].ToString()),
                                                int.Parse(tuple["employee_desc"].ToString()),
                                                tuple["vehicle_desc"].ToString(),
                                                DateTime.Today,
                                                DateTime.Today,
                                                DateTime.Today,
                                                tuple["state_desc"].ToString(),
                                                int.Parse(tuple["costperorder_desc"].ToString()),
                                                int.Parse(tuple["bill_desc"].ToString()));
                    orders.Add(oOrdersE);
                }
            }
            catch (Exception e)
            {
                error = true;
                this.errorMsg = e.Message;
            }
            return orders;
        }


        public int insertOrder(OrderE oOrderE)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            string consecutive = "0";
            string sql = "INSERT INTO workorder(caryear, employee, vehicle, entrydate, exitdate, billingdate, state, costperorder, bill)" +
                " VALUES (@caryear, @employee, @vehicle, @entrydate, @exitdate, @billingdate, @state, @costperorder, @bill) returning consecutive;";

            oParameters.addParameter("@caryear", NpgsqlDbType.Numeric, oOrderE.CarYear);
            oParameters.addParameter("@employee", NpgsqlDbType.Numeric, oOrderE.Employee);
            oParameters.addParameter("@vehicle", NpgsqlDbType.Varchar, oOrderE.Vehicle);
            oParameters.addParameter("@entrydate", NpgsqlDbType.Date, oOrderE.EntryDate);
            oParameters.addParameter("@exitdate", NpgsqlDbType.Date, oOrderE.ExitDate);
            oParameters.addParameter("@billingdate", NpgsqlDbType.Date, oOrderE.BillingDate);
            oParameters.addParameter("@state", NpgsqlDbType.Varchar, oOrderE.State);
            oParameters.addParameter("@costperorder", NpgsqlDbType.Numeric, oOrderE.CostPerOrder);
            oParameters.addParameter("@bill", NpgsqlDbType.Numeric, oOrderE.BillNumber);

            this.connection.executeSQL(sql, oParameters.getParameter(), ref consecutive);

            if (this.connection.IsError)
            {
                error = true;
                this.errorMsg = this.connection.descriptionError;
            }
            return int.Parse(consecutive);          
        }

        public Boolean updateOrder(OrderE oOrderE, int pConsecutive)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "UPDATE workorder SET caryear = @caryear, employee = @employee, vehicle = @vehicle, " +
                    "entrydate = @entrydate, exitdate = @exitdate, billingdate = @billingdate, state = @state, " +
                    "costperorder = @costperorder, bill = @bill WHERE consecutive = @consecutive;";

                oParameters.addParameter("@caryear", NpgsqlDbType.Numeric, oOrderE.CarYear);
                oParameters.addParameter("@employee", NpgsqlDbType.Numeric, oOrderE.Employee);
                oParameters.addParameter("@vehicle", NpgsqlDbType.Varchar, oOrderE.Vehicle);
                oParameters.addParameter("@entrydate", NpgsqlDbType.Date, oOrderE.EntryDate);
                oParameters.addParameter("@exitdate", NpgsqlDbType.Date, oOrderE.ExitDate);
                oParameters.addParameter("@billingdate", NpgsqlDbType.Date, oOrderE.BillingDate);
                oParameters.addParameter("@state", NpgsqlDbType.Varchar, oOrderE.State);
                oParameters.addParameter("@costperorder", NpgsqlDbType.Numeric, oOrderE.CostPerOrder);
                oParameters.addParameter("@bill", NpgsqlDbType.Numeric, oOrderE.BillNumber);
                oParameters.addParameter("@pemployeecod", NpgsqlDbType.Integer, pConsecutive);

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

        public Boolean updatedState(string pState, int pConsecutive)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "UPDATE workorder SET state = @state WHERE consecutive = @consecutive;";
                oParameters.addParameter("@state", NpgsqlDbType.Varchar, pState);
                oParameters.addParameter("@consecutive", NpgsqlDbType.Integer, pConsecutive);

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

        public Boolean updateDate(string pState, DateTime pExitDate, int pConsecutive)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "UPDATE workorder SET state = @state, billingdate = @billingdate WHERE consecutive = @consecutive;";
                oParameters.addParameter("@state", NpgsqlDbType.Varchar, pState);
                oParameters.addParameter("@billingdate", NpgsqlDbType.Timestamp, pExitDate);
                oParameters.addParameter("@consecutive", NpgsqlDbType.Integer, pConsecutive);

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

        public Boolean deleteOrder(int pConsecutive)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "DELETE FROM workorder WHERE consecutive = @consecutive;";

                oParameters.addParameter("@consecutive", NpgsqlDbType.Numeric, pConsecutive);
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

        public List<OrderE> getOrderVehiclePerEmployee(int pEmployee)
        {
            this.cleanError();
            List<OrderE> orders = new List<OrderE>();
            DataSet dsetOrders;
            OrderE oOrdersE = null;
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "SELECT o.consecutive AS consecutive_desc, o.caryear AS caryear_desc, o.employee AS employee_desc, o.vehicle AS vehicle_desc, o.entrydate AS entrydate_desc, o.exitdate AS exitdate_desc, " +
                    "o.billingdate AS billingdate_desc, o.state AS state_desc, o.costperorder AS costperorder_desc, o.bill AS bill_desc FROM workorder o WHERE o.employee = @employee;";
                oParameters.addParameter("@employee", NpgsqlDbType.Integer, pEmployee);
                dsetOrders = this.connection.executeSQLQuery(sql, "workorder", oParameters.getParameter());
                foreach (DataRow tuple in dsetOrders.Tables[0].Rows)
                {
                    oOrdersE = new OrderE(int.Parse(tuple["consecutive_desc"].ToString()),
                                                int.Parse(tuple["caryear_desc"].ToString()),
                                                int.Parse(tuple["employee_desc"].ToString()),
                                                tuple["vehicle_desc"].ToString(),
                                                DateTime.Parse(tuple["entrydate_desc"].ToString()),
                                                DateTime.Parse(tuple["exitdate_desc"].ToString()),
                                                DateTime.Parse(tuple["billingdate_desc"].ToString()),
                                                tuple["state_desc"].ToString(),
                                                int.Parse(tuple["costperorder_desc"].ToString()),
                                                int.Parse(tuple["bill_desc"].ToString()));
                    orders.Add(oOrdersE);
                }
            }
            catch (Exception e)
            {
                error = true;
                this.errorMsg = e.Message;
            }
            return orders;
        }

        public List<OrderE> getOrderVehiclePerVehicle(string pVehicle)
        {
            this.cleanError();
            List<OrderE> orders = new List<OrderE>();
            DataSet dsetOrders;
            OrderE oOrdersE = null;
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "SELECT o.consecutive AS consecutive_desc, o.caryear AS caryear_desc, o.employee AS employee_desc, o.vehicle AS vehicle_desc, o.entrydate AS entrydate_desc, o.exitdate AS exitdate_desc, " +
                    "o.billingdate AS billingdate_desc, o.state AS state_desc, o.costperorder AS costperorder_desc, o.bill AS bill_desc FROM workorder o WHERE o.vehicle = @vehicle;";
                oParameters.addParameter("@vehicle", NpgsqlDbType.Varchar, pVehicle);
                dsetOrders = this.connection.executeSQLQuery(sql, "workorder", oParameters.getParameter());
                foreach (DataRow tuple in dsetOrders.Tables[0].Rows)
                {
                    oOrdersE = new OrderE(int.Parse(tuple["consecutive_desc"].ToString()),
                                                int.Parse(tuple["caryear_desc"].ToString()),
                                                int.Parse(tuple["employee_desc"].ToString()),
                                                tuple["vehicle_desc"].ToString(),
                                                DateTime.Parse(tuple["entrydate_desc"].ToString()),
                                                DateTime.Parse(tuple["exitdate_desc"].ToString()),
                                                DateTime.Parse(tuple["billingdate_desc"].ToString()),
                                                tuple["state_desc"].ToString(),
                                                int.Parse(tuple["costperorder_desc"].ToString()),
                                                int.Parse(tuple["bill_desc"].ToString()));
                    orders.Add(oOrdersE);
                }
            }
            catch (Exception e)
            {
                error = true;
                this.errorMsg = e.Message;
            }
            return orders;
        }

        public List<OrderE> getOrderVehiclePerState(string pState)
        {
            this.cleanError();
            List<OrderE> orders = new List<OrderE>();
            DataSet dsetOrders;
            OrderE oOrdersE = null;
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "SELECT o.consecutive AS consecutive_desc, o.caryear AS caryear_desc, o.employee AS employee_desc, o.vehicle AS vehicle_desc, o.entrydate AS entrydate_desc, o.exitdate AS exitdate_desc, " +
                    "o.billingdate AS billingdate_desc, o.state AS state_desc, o.costperorder AS costperorder_desc, o.bill AS bill_desc FROM workorder o WHERE o.state = @state;";
                oParameters.addParameter("@state", NpgsqlDbType.Varchar, pState);
                dsetOrders = this.connection.executeSQLQuery(sql, "workorder", oParameters.getParameter());
                foreach (DataRow tuple in dsetOrders.Tables[0].Rows)
                {
                    oOrdersE = new OrderE(int.Parse(tuple["consecutive_desc"].ToString()),
                                                int.Parse(tuple["caryear_desc"].ToString()),
                                                int.Parse(tuple["employee_desc"].ToString()),
                                                tuple["vehicle_desc"].ToString(),
                                                DateTime.Parse(tuple["entrydate_desc"].ToString()),
                                                DateTime.Parse(tuple["exitdate_desc"].ToString()),
                                                DateTime.Parse(tuple["billingdate_desc"].ToString()),
                                                tuple["state_desc"].ToString(),
                                                int.Parse(tuple["costperorder_desc"].ToString()),
                                                int.Parse(tuple["bill_desc"].ToString()));
                    orders.Add(oOrdersE);
                }
            }
            catch (Exception e)
            {
                error = true;
                this.errorMsg = e.Message;
            }
            return orders;
        }

        public List<OrderE> getOrderVehiclePerEntryDate(DateTime pEntryDate)
        {
            this.cleanError();
            List<OrderE> orders = new List<OrderE>();
            DataSet dsetOrders;
            OrderE oOrdersE = null;
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "SELECT o.consecutive AS consecutive_desc, o.caryear AS caryear_desc, o.employee AS employee_desc, o.vehicle AS vehicle_desc, o.entrydate AS entrydate_desc, o.exitdate AS exitdate_desc, " +
                    "o.billingdate AS billingdate_desc, o.state AS state_desc, o.costperorder AS costperorder_desc, o.bill AS bill_desc FROM workorder o WHERE o.entrydate = @entrydate;";
                oParameters.addParameter("@entrydate", NpgsqlDbType.Date, pEntryDate);
                dsetOrders = this.connection.executeSQLQuery(sql, "workorder", oParameters.getParameter());
                foreach (DataRow tuple in dsetOrders.Tables[0].Rows)
                {
                    oOrdersE = new OrderE(int.Parse(tuple["consecutive_desc"].ToString()),
                                                int.Parse(tuple["caryear_desc"].ToString()),
                                                int.Parse(tuple["employee_desc"].ToString()),
                                                tuple["vehicle_desc"].ToString(),
                                                DateTime.Parse(tuple["entrydate_desc"].ToString()),
                                                DateTime.Parse(tuple["exitdate_desc"].ToString()),
                                                DateTime.Parse(tuple["billingdate_desc"].ToString()),
                                                tuple["state_desc"].ToString(),
                                                int.Parse(tuple["costperorder_desc"].ToString()),
                                                int.Parse(tuple["bill_desc"].ToString()));
                    orders.Add(oOrdersE);
                }
            }
            catch (Exception e)
            {
                error = true;
                this.errorMsg = e.Message;
            }
            return orders;
        }

        public List<OrderE> getOrderVehiclePerExitDate(DateTime pExitDate)
        {
            this.cleanError();
            List<OrderE> orders = new List<OrderE>();
            DataSet dsetOrders;
            OrderE oOrdersE = null;
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "SELECT o.consecutive AS consecutive_desc, o.caryear AS caryear_desc, o.employee AS employee_desc, o.vehicle AS vehicle_desc, o.entrydate AS entrydate_desc, o.exitdate AS exitdate_desc, " +
                    "o.billingdate AS billingdate_desc, o.state AS state_desc, o.costperorder AS costperorder_desc, o.bill AS bill_desc FROM workorder o WHERE o.exitdate = @exitdate;";
                oParameters.addParameter("@exitdate", NpgsqlDbType.Date, pExitDate);
                dsetOrders = this.connection.executeSQLQuery(sql, "workorder", oParameters.getParameter());
                foreach (DataRow tuple in dsetOrders.Tables[0].Rows)
                {
                    oOrdersE = new OrderE(int.Parse(tuple["consecutive_desc"].ToString()),
                                                int.Parse(tuple["caryear_desc"].ToString()),
                                                int.Parse(tuple["employee_desc"].ToString()),
                                                tuple["vehicle_desc"].ToString(),
                                                DateTime.Parse(tuple["entrydate_desc"].ToString()),
                                                DateTime.Parse(tuple["exitdate_desc"].ToString()),
                                                DateTime.Parse(tuple["billingdate_desc"].ToString()),
                                                tuple["state_desc"].ToString(),
                                                int.Parse(tuple["costperorder_desc"].ToString()),
                                                int.Parse(tuple["bill_desc"].ToString()));
                    orders.Add(oOrdersE);
                }
            }
            catch (Exception e)
            {
                error = true;
                this.errorMsg = e.Message;
            }
            return orders;
        }

        public List<OrderE> getOrderVehiclePerBillingDate(DateTime pBillingDate)
        {
            this.cleanError();
            List<OrderE> orders = new List<OrderE>();
            DataSet dsetOrders;
            OrderE oOrdersE = null;
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "SELECT o.consecutive AS consecutive_desc, o.caryear AS caryear_desc, o.employee AS employee_desc, o.vehicle AS vehicle_desc, o.entrydate AS entrydate_desc, o.exitdate AS exitdate_desc, " +
                    "o.billingdate AS billingdate_desc, o.state AS state_desc, o.costperorder AS costperorder_desc, o.bill AS bill_desc FROM workorder o WHERE o.billingdate = @billingdate;";
                oParameters.addParameter("@billingdate", NpgsqlDbType.Date, pBillingDate);
                dsetOrders = this.connection.executeSQLQuery(sql, "workorder", oParameters.getParameter());
                foreach (DataRow tuple in dsetOrders.Tables[0].Rows)
                {
                    oOrdersE = new OrderE(int.Parse(tuple["consecutive_desc"].ToString()),
                                                int.Parse(tuple["caryear_desc"].ToString()),
                                                int.Parse(tuple["employee_desc"].ToString()),
                                                tuple["vehicle_desc"].ToString(),
                                                DateTime.Parse(tuple["entrydate_desc"].ToString()),
                                                DateTime.Parse(tuple["exitdate_desc"].ToString()),
                                                DateTime.Parse(tuple["billingdate_desc"].ToString()),
                                                tuple["state_desc"].ToString(),
                                                int.Parse(tuple["costperorder_desc"].ToString()),
                                                int.Parse(tuple["bill_desc"].ToString()));
                    orders.Add(oOrdersE);
                }
            }
            catch (Exception e)
            {
                error = true;
                this.errorMsg = e.Message;
            }
            return orders;
        }
    }
}

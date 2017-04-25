using Controller;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RepairOrderD
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

        public RepairOrderD()
        {
            this.connection = PostgressDataAccess.Instance;
            this.cleanError();
        }

        public void cleanError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<RepairPerOrderE> get()
        {
            this.cleanError();
            List<RepairPerOrderE> ReplacementOrder = new List<RepairPerOrderE>();
            DataSet dataBD;
            try
            {
                string sql = "SELECT r.workorder AS orden, r.reparationscatalogue AS reparacion, r.employee AS empleado, r.reparationcost AS costo, r.hours AS horas, r.total AS total" +
                    "FROM reparationperorder r;";

                dataBD = this.connection.executeSQLQuery(sql);
                foreach (DataRow tuple in dataBD.Tables[0].Rows)
                {
                    RepairPerOrderE oReplacementOrder = new RepairPerOrderE(int.Parse(tuple["orden"].ToString()), int.Parse(tuple["reparacion"].ToString()),
                        "",int.Parse(tuple["empleado"].ToString()),"", int.Parse(tuple["costo"].ToString()), int.Parse(tuple["horas"].ToString()), int.Parse(tuple["total"].ToString()));
                    ReplacementOrder.Add(oReplacementOrder);
                }
            }
            catch (Exception e)
            {
                error = true;
                this.errorMsg = e.Message;
            }
            return ReplacementOrder;
        }
        public Boolean insert(RepairPerOrderE oRepairOrder)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "INSERT INTO reparationperorder(workorder, reparationscatalogue, employee, reparationcost, hours, total)" +
                    " VALUES (@workorder, @reparationscatalogue, @employee, @reparationcost, @hours, @total);";

                oParameters.addParameter("@workorder", NpgsqlDbType.Numeric, oRepairOrder.Order);
                oParameters.addParameter("@reparationscatalogue", NpgsqlDbType.Numeric, oRepairOrder.Repair);
                oParameters.addParameter("@employee", NpgsqlDbType.Numeric, oRepairOrder.Employe);
                oParameters.addParameter("@reparationcost", NpgsqlDbType.Numeric, oRepairOrder.Cost);
                oParameters.addParameter("@hours", NpgsqlDbType.Numeric, oRepairOrder.Hours);
                oParameters.addParameter("@total", NpgsqlDbType.Numeric, oRepairOrder.Total);

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

        public Boolean update(RepairPerOrderE oRepairOrder)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "UPDATE reparationperorder SET employee = @employee, reparationcost = @reparationcost, hours = @hours, total = @total" +
                    " WHERE workorder = @workorder AND reparationscatalogue = @reparationscatalogue;";

                oParameters.addParameter("@workorder", NpgsqlDbType.Numeric, oRepairOrder.Order);
                oParameters.addParameter("@reparationscatalogue", NpgsqlDbType.Numeric, oRepairOrder.Repair);
                oParameters.addParameter("@employee", NpgsqlDbType.Numeric, oRepairOrder.Employe);
                oParameters.addParameter("@reparationcost", NpgsqlDbType.Numeric, oRepairOrder.Cost);
                oParameters.addParameter("@hours", NpgsqlDbType.Numeric, oRepairOrder.Hours);
                oParameters.addParameter("@total", NpgsqlDbType.Numeric, oRepairOrder.Total);

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
        public Boolean delete(int order, int repair)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "DELETE FROM reparationperorder WHERE workorder = @workorder AND reparationscatalogue = @reparationscatalogue;";

                oParameters.addParameter("@workorder", NpgsqlDbType.Numeric, order);
                oParameters.addParameter("@reparationscatalogue", NpgsqlDbType.Numeric, repair);
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

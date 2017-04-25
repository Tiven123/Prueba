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
    public class ReplacementOrderD
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

        public ReplacementOrderD()
        {
            this.connection = PostgressDataAccess.Instance;
            this.cleanError();
        }

        public void cleanError()
        {
            this.error = false;
            this.errorMsg = "";
        }
        public List<ReplacementOrderE> get()
        {
            this.cleanError();
            List<ReplacementOrderE> ReplacementOrder = new List<ReplacementOrderE>();
            DataSet dataBD;
            try
            {
                string sql = "SELECT r.workorder AS orden, r.replacementcatalogue AS repuesto, r.quantity AS cantidad, r.price AS costo, r.total AS total" +
                    "FROM replacementperorder r;";

                dataBD = this.connection.executeSQLQuery(sql);
                foreach (DataRow tuple in dataBD.Tables[0].Rows)
                {
                    ReplacementOrderE oReplacementOrder = new ReplacementOrderE(int.Parse(tuple["orden"].ToString()), int.Parse(tuple["repuesto"].ToString()),"",
                        int.Parse(tuple["cantidad"].ToString()), int.Parse(tuple["costo"].ToString()), int.Parse(tuple["total"].ToString()));
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
        public Boolean insert(ReplacementOrderE oRepairOrder)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "INSERT INTO replacementperorder(workorder, replacementcatalogue, quantity, price, total)" +
                    " VALUES (@workorder, @replacementcatalogue, @quantity, @price, @total);";

                oParameters.addParameter("@workorder", NpgsqlDbType.Numeric, oRepairOrder.Order);
                oParameters.addParameter("@replacementcatalogue", NpgsqlDbType.Numeric, oRepairOrder.Replacement);
                oParameters.addParameter("@quantity", NpgsqlDbType.Numeric, oRepairOrder.Quantity);
                oParameters.addParameter("@price", NpgsqlDbType.Numeric, oRepairOrder.Cost);
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

        public Boolean update(ReplacementOrderE oRepairOrder)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "UPDATE replacementperorder SET quantity = @quantity, price = @price, total = @total" +
                    " WHERE workorder = @workorder AND replacementcatalogue = @replacementcatalogue;";

                oParameters.addParameter("@workorder", NpgsqlDbType.Numeric, oRepairOrder.Order);
                oParameters.addParameter("@replacementcatalogue", NpgsqlDbType.Numeric, oRepairOrder.Replacement);
                oParameters.addParameter("@quantity", NpgsqlDbType.Numeric, oRepairOrder.Quantity);
                oParameters.addParameter("@price", NpgsqlDbType.Numeric, oRepairOrder.Cost);
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
                string sql = "DELETE FROM replacementperorder WHERE workorder = @workorder AND replacementcatalogue = @replacementcatalogue;";

                oParameters.addParameter("@workorder", NpgsqlDbType.Numeric, order);
                oParameters.addParameter("@replacementcatalogue", NpgsqlDbType.Numeric, repair);
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

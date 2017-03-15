using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using System.Data;
using NpgsqlTypes;
using Npgsql;
using Model;
namespace Model
{
    public class RepairD
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

        public RepairD()
        {
            this.connection = PostgressDataAccess.Instance;
            this.cleanError();
        }

        public void cleanError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<ClienteE> get()
        {
            this.cleanError();
            List<ClienteE> repairs = new List<ClienteE>();
            DataSet dataBD;
            try
            {
                string sql = "SELECT r.consecutive AS codigo, r.description AS descripcion, r.averagehours AS horas, r.reparationcost AS costo " +
                    "FROM reparationscatalogue r;";

                dataBD = this.connection.executeSQLQuery(sql);
                foreach (DataRow tuple in dataBD.Tables[0].Rows)
                {
                    ClienteE oRepairE = new ClienteE(int.Parse(tuple["codigo"].ToString()), tuple["descripcion"].ToString(), int.Parse(tuple["horas"].ToString()),
                        int.Parse(tuple["costo"].ToString()));
                    repairs.Add(oRepairE);
                }
            }
            catch (Exception e)
            {
                error = true;
                this.errorMsg = e.Message;
            }
            return repairs;
        }
        public Boolean insert(ClienteE oRepairE)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "INSERT INTO reparationscatalogue(consecutive, description, averagehours, reparationcost)" +
                    " VALUES (@consecutive, @description, @averagehours, @reparationcost);";

                oParameters.addParameter("@consecutive", NpgsqlDbType.Numeric, oRepairE.Consecutive);
                oParameters.addParameter("@descriptione", NpgsqlDbType.Varchar, oRepairE.Description);
                oParameters.addParameter("@averagehours", NpgsqlDbType.Numeric, oRepairE.Hours);
                oParameters.addParameter("@reparationcost", NpgsqlDbType.Numeric, oRepairE.Cost);
               

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

        public Boolean update(ClienteE oRepairE)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "UPDATE reparationscatalogue SET description = @description, averagehours = @averagehours, reparationcost = @reparationcost" +
                    " WHERE consecutive = @consecutive;";

                oParameters.addParameter("@consecutive", NpgsqlDbType.Numeric, oRepairE.Consecutive);
                oParameters.addParameter("@descriptione", NpgsqlDbType.Varchar, oRepairE.Description);
                oParameters.addParameter("@averagehours", NpgsqlDbType.Numeric, oRepairE.Hours);
                oParameters.addParameter("@reparationcost", NpgsqlDbType.Numeric, oRepairE.Cost);

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
        public Boolean delete(string code)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "DELETE FROM reparationscatalogue WHERE consecutive = @consecutive;";

                oParameters.addParameter("@consecutive", NpgsqlDbType.Numeric, code);
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

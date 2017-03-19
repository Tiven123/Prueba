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
    public class ModelD
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

        public ModelD()
        {
            this.connection = PostgressDataAccess.Instance;
            this.cleanError();
        }

        public void cleanError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<ModelE> get()
        {
            this.cleanError();
            List<ModelE> models = new List<ModelE>();
            DataSet dataBD;
            try
            {
                string sql = "SELECT m.modelcod AS codigo, m.brand AS marca, m.modeldescription AS description " +
                    "FROM model m;";

                dataBD = this.connection.executeSQLQuery(sql);
                foreach (DataRow tuple in dataBD.Tables[0].Rows)
                {
                    ModelE oModelE = new ModelE(int.Parse(tuple["codigo"].ToString()),int.Parse(tuple["marca"].ToString()), tuple["description"].ToString());
                    models.Add(oModelE);
                }
            }
            catch (Exception e)
            {
                error = true;
                this.errorMsg = e.Message;
            }
            return models;
        }

        public Boolean insert(RepairE oRepairE)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "INSERT INTO model (modelcod, brand, modeldescription)" +
                    " VALUES (@modelcod, @brand, @modeldescription);";

                oParameters.addParameter("@modelcod", NpgsqlDbType.Numeric, oRepairE.Consecutive);
                oParameters.addParameter("@brand", NpgsqlDbType.Numeric, oRepairE.Description);
                oParameters.addParameter("@modeldescription", NpgsqlDbType.Numeric, oRepairE.Hours);



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

        /*public Boolean update(RepairE oRepairE)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "UPDATE reparationscatalogue SET description = @description, averagehours = @averagehours, reparationcost = @reparationcost" +
                    " WHERE consecutive = @consecutive;";

                oParameters.addParameter("@consecutive", NpgsqlDbType.Numeric, oRepairE.Consecutive);
                oParameters.addParameter("@description", NpgsqlDbType.Varchar, oRepairE.Description);
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
        }*/
    }
}

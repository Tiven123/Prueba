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
            DataSet datasett;
            try
            {
                string sql = "SELECT m.modelcod AS codigo, m.brand AS marca, m.modeldescription AS descripcion " +
                    "FROM model m;";

                datasett = this.connection.executeSQLQuery(sql);
                foreach (DataRow tuple in datasett.Tables[0].Rows)
                {
                    ModelE oModelE = new ModelE(int.Parse(tuple["codigo"].ToString()), int.Parse(tuple["marca"].ToString()), tuple["descripcion"].ToString());
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


        public Boolean insert(ModelE oModelE)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "INSERT INTO model(modelcod, brand, modeldescription)" +
                    " VALUES (@modelcod, @brand, @modeldescription);";

                oParameters.addParameter("@modelcod", NpgsqlDbType.Numeric, oModelE.Code);
                oParameters.addParameter("@brand", NpgsqlDbType.Numeric, oModelE.Brand);
                oParameters.addParameter("@modeldescription", NpgsqlDbType.Varchar, oModelE.Description);

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

        public Boolean update(ModelE oModelE)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "UPDATE model SET brand = @brand, modeldescription = @modeldescription" +
                    " WHERE modelcod = @modelcod;";

                oParameters.addParameter("@modelcod", NpgsqlDbType.Numeric, oModelE.Code);
                oParameters.addParameter("@brand", NpgsqlDbType.Numeric, oModelE.Brand);
                oParameters.addParameter("@modeldescription", NpgsqlDbType.Varchar, oModelE.Description);

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
        public Boolean delete(string modelcod)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "DELETE FROM model WHERE modelcod = @modelcod;";

                oParameters.addParameter("@modelcod", NpgsqlDbType.Numeric, modelcod);
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

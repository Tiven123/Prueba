using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using System.Data;
using NpgsqlTypes;
using Npgsql;

namespace Model
{
    public class ReplacementD
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

        public ReplacementD()
        {
            this.connection = PostgressDataAccess.Instance;
            this.cleanError();
        }

        public void cleanError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<ReplacementE> get()
        {
            this.cleanError();
            List<ReplacementE> replacements = new List<ReplacementE>();
            DataSet dataBD;
            try
            {
                string sql = "SELECT r.consecutive AS codigo, r.replamentname AS descripcion, r.annio AS anno, r.costperreplacement AS costo " +
                    "FROM replacementcatalogue r;";

                dataBD = this.connection.executeSQLQuery(sql);
                foreach (DataRow tuple in dataBD.Tables[0].Rows)
                {
                    ReplacementE oReplacementE = new ReplacementE(int.Parse(tuple["codigo"].ToString()), tuple["descripcion"].ToString(), int.Parse(tuple["anno"].ToString()),
                        int.Parse(tuple["costo"].ToString()));
                    replacements.Add(oReplacementE);
                }
            }
            catch (Exception e)
            {
                error = true;
                this.errorMsg = e.Message;
            }
            return replacements;
        }
        public Boolean insert(ReplacementE oReplacementE)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "INSERT INTO replacementcatalogue(consecutive, replamentname, annio, costperreplacement)" +
                    " VALUES (@consecutive, @replamentname, @annio, @costperreplacement);";

                oParameters.addParameter("@consecutive", NpgsqlDbType.Numeric, oReplacementE.Consecutive);
                oParameters.addParameter("@replamentname", NpgsqlDbType.Varchar, oReplacementE.Description);
                oParameters.addParameter("@annio", NpgsqlDbType.Numeric, oReplacementE.Annio);
                oParameters.addParameter("@costperreplacement", NpgsqlDbType.Numeric, oReplacementE.Cost);


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

        public Boolean update(ReplacementE oReplacementE)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "UPDATE replacementcatalogue SET replamentname = @replamentname, annio = @annio, costperreplacement = @costperreplacement" +
                    " WHERE consecutive = @consecutive;";

                oParameters.addParameter("@consecutive", NpgsqlDbType.Numeric,oReplacementE.Consecutive);
                oParameters.addParameter("@replamentname", NpgsqlDbType.Varchar, oReplacementE.Description);
                oParameters.addParameter("@annio", NpgsqlDbType.Numeric, oReplacementE.Annio);
                oParameters.addParameter("@costperreplacement", NpgsqlDbType.Numeric, oReplacementE.Cost);

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
                string sql = "DELETE FROM replacementcatalogue WHERE consecutive = @consecutive;";

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

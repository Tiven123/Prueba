using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NpgsqlTypes;
using Npgsql;
using System.Windows.Forms;
using Controller;

namespace Model
{
    public class PositionD
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

        public PositionD()
        {
            this.connection = PostgressDataAccess.Instance;
            this.errorCleaner();
        }

        public void errorCleaner()
        {
            this.error = false;
            this.errorMsg = "";
        }


        public void insertPositions(PositionE oPositionE)
        {
            this.errorCleaner();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "INSERT INTO employeeposition(positioncod, description, positiontype) VALUES (@positioncod, @description, @positiontype);";
                oParameters.addParameter("@positioncod", NpgsqlDbType.Integer, oPositionE.PositionCod);
                oParameters.addParameter("@description", NpgsqlDbType.Varchar, oPositionE.Description);
                oParameters.addParameter("@positiontype", NpgsqlDbType.Varchar, oPositionE.Type);

                this.connection.executeSQL(sql, oParameters.getParameter());
                if (this.connection.IsError)
                {
                    error = true;
                    this.errorMsg = this.connection.descriptionError;
                }
            }
            catch (Exception e) {
                error = true;
                this.errorMsg = e.Message;
            }
        }

        public List<PositionE> getPositions()
        {
            this.errorCleaner();
            List<PositionE> positions = new List<PositionE>();
            DataSet dsetPositions;
            try
            {
                string sql = "select p.positioncod as position_cod, p.description as position_desc, p.positiontype as position_type " +
                         "from employeeposition p;";
                dsetPositions = this.connection.executeSQLQuery(sql);

                foreach (DataRow tupla in dsetPositions.Tables[0].Rows)
                {
                    PositionE oPositionE = new PositionE(int.Parse(tupla["position_cod"].ToString()), tupla["position_desc"].ToString(), tupla["position_type"].ToString());
                    positions.Add(oPositionE);
                }
            }
            catch (Exception e)
            {
                error = true;
                this.errorMsg = e.Message;
            }
            return positions;
        }

        public Boolean updatePosition(PositionE oPositionE, int pPositionCod)
        {
            this.errorCleaner();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "UPDATE employeeposition SET positioncod = @positioncod, description = @description, " +
                    "positiontype = @positiontype WHERE positioncod = @ppositioncod;";

                oParameters.addParameter("@positioncod", NpgsqlDbType.Integer, oPositionE.PositionCod);
                oParameters.addParameter("@description", NpgsqlDbType.Varchar, oPositionE.Description);
                oParameters.addParameter("@positiontype", NpgsqlDbType.Varchar, oPositionE.Type);
                oParameters.addParameter("@ppositioncod", NpgsqlDbType.Integer, pPositionCod);

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

        public Boolean deletePosition(int pPositionCod)
        {
            this.errorCleaner();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "DELETE FROM employeeposition WHERE positioncod = @positioncod;";

                oParameters.addParameter("@positioncod", NpgsqlDbType.Integer, pPositionCod);
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

        //it is funtional but it is not used
        /*public PositionE getPosition(int pPositionCod)
        {
            this.errorCleaner();
            PositionE oPositionE = null;
            Parameters oParameter = new Parameters();
            DataSet dsetPositions;
            try
            {
                string sql = "select positioncod, description, positiontype " +
                         "from employeeposition where positionCod = @positioncod;";
                oParameter.addParameter("@employeeuser", NpgsqlDbType.Integer, pPositionCod);
                dsetPositions = this.connection.executeSQLQuery(sql, "employeeposition", oParameter.getParameter());

                foreach (DataRow tupla in dsetPositions.Tables[0].Rows)
                {
                    oPositionE = new PositionE(int.Parse(tupla["position_cod"].ToString()), tupla["position_desc"].ToString(), tupla["position_type"].ToString());
                }
            }
            catch (Exception e)
            {
                error = true;
                this.errorMsg = e.Message;
            }
            return oPositionE;
        }*/
    }
}

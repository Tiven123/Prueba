using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EmployeeD
    {
        /*private PostgressDataAccess connection;

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
            catch (Exception e)
            {
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
        }*/
    }
}

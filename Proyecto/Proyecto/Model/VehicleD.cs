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
    public class VehicleD
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

        public VehicleD()
        {
            this.connection = PostgressDataAccess.Instance;
            this.cleanError();
        }

        public void cleanError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<VehicleE> get()
        {
            this.cleanError();
            List<VehicleE> vehicles = new List<VehicleE>();
            DataSet dataBD;
            try
            {
                string sql = "SELECT v.vehicleid AS codigo, v.model AS modelo, v.client AS cliente, v.vehicleyear AS anno, "+
                    "v.enginenumber AS motor, v.chassisnumber AS chassis, v.fuel AS combustible, v.vehicletype AS tipo, v.capacity AS capacidad " +
                    "FROM vehicle v;";

                dataBD = this.connection.executeSQLQuery(sql);
                foreach (DataRow tuple in dataBD.Tables[0].Rows)
                {
                    VehicleE oVehicleE = new VehicleE (tuple["codigo"].ToString(), int.Parse(tuple["modelo"].ToString()), tuple["cliente"].ToString(),
                        int.Parse(tuple["anno"].ToString()), tuple["motor"].ToString(), tuple["chassis"].ToString(), tuple["combustible"].ToString(),
                        tuple["tipo"].ToString(), int.Parse(tuple["capacidad"].ToString()));
                    vehicles.Add(oVehicleE);
                }
            }
            catch (Exception e)
            {
                error = true;
                this.errorMsg = e.Message;
            }
            return vehicles;
        }
        public Boolean insert(VehicleE oVehicleE)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "INSERT INTO vehicle(vehicleid, model, client, vehicleyear, enginenumber, chassisnumber, fuel, vehicletype, capacity)" +
                    " VALUES (@vehicleid, @model, @client, @vehicleyear, @enginenumber, @chassisnumber, @fuel, @vehicletype, @capacity);";

                oParameters.addParameter("@vehicleid", NpgsqlDbType.Varchar, oVehicleE.Id);
                oParameters.addParameter("@model", NpgsqlDbType.Numeric, oVehicleE.Model);
                oParameters.addParameter("@client", NpgsqlDbType.Varchar, oVehicleE.Client);
                oParameters.addParameter("@vehicleyear", NpgsqlDbType.Numeric, oVehicleE.Year);
                oParameters.addParameter("@enginenumber", NpgsqlDbType.Varchar, oVehicleE.Engine);
                oParameters.addParameter("@chassisnumber", NpgsqlDbType.Varchar, oVehicleE.Chassis);
                oParameters.addParameter("@fuel", NpgsqlDbType.Varchar, oVehicleE.Fuel);
                oParameters.addParameter("@vehicletype", NpgsqlDbType.Varchar, oVehicleE.Type);
                oParameters.addParameter("@capacity", NpgsqlDbType.Numeric, oVehicleE.Capacity);


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

        public Boolean update(VehicleE oVehicleE)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "UPDATE vehicle SET model = @model, client = @client, vehicleyear = @vehicleyear, enginenumber = @enginenumber,"+
                    " chassisnumber = @chassisnumber, fuel = @fuel, vehicletype = @vehicletype, capacity = @capacity" +
                    " WHERE vehicleid = @vehicleid;";

                oParameters.addParameter("@vehicleid", NpgsqlDbType.Varchar, oVehicleE.Id);
                oParameters.addParameter("@model", NpgsqlDbType.Numeric, oVehicleE.Model);
                oParameters.addParameter("@client", NpgsqlDbType.Varchar, oVehicleE.Client);
                oParameters.addParameter("@vehicleyear", NpgsqlDbType.Numeric, oVehicleE.Year);
                oParameters.addParameter("@enginenumber", NpgsqlDbType.Varchar, oVehicleE.Engine);
                oParameters.addParameter("@chassisnumber", NpgsqlDbType.Varchar, oVehicleE.Chassis);
                oParameters.addParameter("@fuel", NpgsqlDbType.Varchar, oVehicleE.Fuel);
                oParameters.addParameter("@vehicletype", NpgsqlDbType.Varchar, oVehicleE.Type);
                oParameters.addParameter("@capacity", NpgsqlDbType.Numeric, oVehicleE.Capacity);

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
        public Boolean delete(string id)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "DELETE FROM vehicle WHERE vehicleid = @vehicleid;";

                oParameters.addParameter("@vehicleid", NpgsqlDbType.Varchar, id);
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

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
    public class ClientD
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

        public ClientD()
            { 
                this.connection = PostgressDataAccess.Instance;
                this.cleanError();
            }

        public void cleanError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<ClientE> getClients()
        {
            this.cleanError();
            List<ClientE> clients = new List<ClientE>();
            DataSet dsetClients;//= new DataSet();
            try
            {
                string sql = "SELECT c.clientid AS cedula, c.clientname AS nombre, c.lastname1 AS apellido1, c.lastname2 AS apellido2, c.officephone AS telefono_oficina, c.housephone AS telefono_casa, c.celphone AS celular, c.fax AS fax, c.address AS direccion " +
                    "FROM client c;";

                dsetClients = this.connection.executeSQLQuery(sql);
                foreach (DataRow tuple in dsetClients.Tables[0].Rows)
                {
                    ClientE oClient = new ClientE(tuple["cedula"].ToString(), tuple["nombre"].ToString(), tuple["apellido1"].ToString(), 
                        tuple["apellido2"].ToString(), int.Parse(tuple["telefono_oficina"].ToString()), int.Parse(tuple["telefono_casa"].ToString()),
                        int.Parse(tuple["celular"].ToString()), int.Parse(tuple["fax"].ToString()), tuple["direccion"].ToString());
                    clients.Add(oClient);
                }
            }
            catch (Exception e)
            {
                error = true;
                this.errorMsg = e.Message;
            }
            return clients;
        }
        public Boolean insertClient(ClientE oClientN)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "INSERT INTO client(clientid, clientname, lastname1, lastname2, officephone, housephone, celphone, fax, address)"+
                    " VALUES (@clientid, @clientname, @lastname1, @lastname2, @officephone, @housephone, @celphone, @fax, @address);";

                oParameters.addParameter("@clientid", NpgsqlDbType.Varchar, oClientN.Cedula);
                oParameters.addParameter("@clientname", NpgsqlDbType.Varchar, oClientN.Name);
                oParameters.addParameter("@lastname1", NpgsqlDbType.Varchar, oClientN.LastName1);
                oParameters.addParameter("@lastname2", NpgsqlDbType.Varchar, oClientN.LastName2);
                oParameters.addParameter("@officephone", NpgsqlDbType.Numeric, oClientN.OfficePhone);
                oParameters.addParameter("@housephone", NpgsqlDbType.Numeric, oClientN.HousePhone);
                oParameters.addParameter("@celphone", NpgsqlDbType.Numeric, oClientN.Celphone);
                oParameters.addParameter("@fax", NpgsqlDbType.Numeric, oClientN.Fax);
                oParameters.addParameter("@address", NpgsqlDbType.Varchar, oClientN.Address);

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

        public Boolean updateClient(ClientE oClientN)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "UPDATE client SET clientname = @clientname, lastname1 = @lastname1, lastname2 = @lastname2," +
                    " officephone = @officephone, housephone = @housephone, celphone = @celphone, fax = @fax, address = @address"+
                    " WHERE clientid = @clientid;";

                oParameters.addParameter("@clientid", NpgsqlDbType.Varchar, oClientN.Cedula);
                oParameters.addParameter("@clientname", NpgsqlDbType.Varchar, oClientN.Name);
                oParameters.addParameter("@lastname1", NpgsqlDbType.Varchar, oClientN.LastName1);
                oParameters.addParameter("@lastname2", NpgsqlDbType.Varchar, oClientN.LastName2);
                oParameters.addParameter("@officephone", NpgsqlDbType.Numeric, oClientN.OfficePhone);
                oParameters.addParameter("@housephone", NpgsqlDbType.Numeric, oClientN.HousePhone);
                oParameters.addParameter("@celphone", NpgsqlDbType.Numeric, oClientN.Celphone);
                oParameters.addParameter("@fax", NpgsqlDbType.Numeric, oClientN.Fax);
                oParameters.addParameter("@address", NpgsqlDbType.Varchar, oClientN.Address);

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
        public Boolean deleteClient(string id)
        {
            this.cleanError();
            Parameters oParameters = new Parameters();
            try
            {
                string sql = "DELETE FROM client WHERE clientid = @id;";

                oParameters.addParameter("@id", NpgsqlDbType.Varchar, id);
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

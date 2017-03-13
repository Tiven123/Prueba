using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using System.Data;
using NpgsqlTypes;
using Npgsql;
using Proyecto.Model;

namespace Model
{
    public class ClientD
    {
        private PostgressDataAccess conecction;

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
                this.conecction = PostgressDataAccess.Instance;
                this.cleanError();
            }

        public void cleanError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<ClientE> getterClients()
        {
            this.cleanError();
            List<ClientE> clients = new List<ClientE>();
            DataSet dsetClients;//= new DataSet();
            try
            {
                string sql = "select c.clientid as cedula, c.clientname as nombre, c.lastname1 as apellido1, c.lastname2 as apellido2, c.officephone as telefono_oficina, c.housephone as telefono_casa, c.celphone as celular, c.fax as fax, c.address as direccion " +
                    "from client c;";

                dsetClients = this.conecction.executeSQLQuery(sql);
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
        public Boolean insertClient(ClientE clientN)
        {
            return true;
        }

        public Boolean modifyClient(ClientE clientN)
        {
            return true;
        }
        public Boolean deleteClient(ClientE clientN)
        {
            return true;
        }

    }
}

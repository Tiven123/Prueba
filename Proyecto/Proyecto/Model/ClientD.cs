using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using System.Data;

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
            DataSet dsetClients;
            string sql = "select c.clientid as Cedula, p.clientname as Nombre, " +
                         "c.lastname1 as Apellido1 , c.lastname2 as Apellido2,"+
                         "c.officephone as TelefonoOficina, c.housephone as TelefonoCasa,"+
                         "c.celphone as Celular, c.fax as Fax, c.address as Direccion  from client c";

            dsetClients = this.conecction.executeSQLQuery(sql);
            foreach (DataRow tuple in dsetClients.Tables[0].Rows)
            {
                ClientE oClient = new ClientE(tuple["clientname"].ToString(), tuple["lastname1"].ToString(), tuple["lastname2"].ToString()
                    , Int32.Parse( tuple["huosephone"].ToString()), Int32.Parse(tuple["celphone"].ToString()), tuple["address"].ToString()
                    , tuple["clientid"].ToString(), Int32.Parse(tuple["officephone"].ToString()), Int32.Parse(tuple["fax"].ToString()));
                clients.Add(oClient);
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

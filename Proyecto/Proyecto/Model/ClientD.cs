﻿using System;
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

        public ClientD() { 
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
            string sql = "select p.id as id_provincia, p.descripcion as desc_provincia " +
                         "from provincia p";

            dsetClients = this.conecction.executeSQLQuery(sql);
            foreach (DataRow tuple in dsetClients.Tables[0].Rows)
            {
                Provincia oProvincia = new Provincia(tupla["id_provincia"].ToString(), tupla["desc_provincia"].ToString());
                provincias.Add(oProvincia);
            }
            return clients;
        }
    }
}

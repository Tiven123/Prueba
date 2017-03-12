using System;
using System.Collections.Generic;
using Npgsql;
using NpgsqlTypes;

namespace Proyecto.Model
{
    class Parameters
    {
        private List<NpgsqlParameter> parametersList;

        public Parameters()
        {
            this.parametersList = new List<NpgsqlParameter>();
        }

        public void addParameter(string name, NpgsqlDbType type, Object value)
        {
            NpgsqlParameter oParameter = new NpgsqlParameter();
            oParameter.ParameterName = name;
            oParameter.NpgsqlDbType = type;
            oParameter.NpgsqlValue = value;

            this.parametersList.Add(oParameter);
        }

        public NpgsqlParameter[] getParameter()
        {
            NpgsqlParameter[] array = new NpgsqlParameter[this.parametersList.Count];

            for (int i = 0; i < this.parametersList.Count; i++)
            {
                array[i] = this.parametersList[i];
            }


            return array; //this.parametros.ToArray();
        }
    }
}

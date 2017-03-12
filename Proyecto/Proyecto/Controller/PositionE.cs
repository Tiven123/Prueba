using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class PositionE
    {
        private int positionCod;
        private string description;
        private char type;

        public int PositionCod
        {
            get
            {
                return positionCod;
            }

            set
            {
                positionCod = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public char Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public PositionE(int pPositionCod, string pDescription, char pType)
        {
            this.PositionCod = pPositionCod;
            this.Description = pDescription;
            this.Type = pType;
        }
        public virtual string ToString()
        {
            return "Posición: " + this.positionCod + "\n" +
                "Descripción: " + this.description + "\n" +
                "Tipo: " + this.type + "\n";
        }
    }
}

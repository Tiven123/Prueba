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
        private string type;

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

        public string Type
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

        public PositionE(int pPositionCod, string pDescription, string pType)
        {
            this.PositionCod = pPositionCod;
            this.Description = pDescription;
            this.Type = pType;
        }
        public override string ToString()
        {
            return this.Description;
        }
    }
}

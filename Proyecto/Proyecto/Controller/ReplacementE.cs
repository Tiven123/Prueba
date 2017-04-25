using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ReplacementE
    {
        private int consecutive;
        private string description;
        private int annio;
        private int cost;

        public int Consecutive
        {
            get
            {
                return consecutive;
            }

            set
            {
                consecutive = value;
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

        public int Annio
        {
            get
            {
                return annio;
            }

            set
            {
                annio = value;
            }
        }

        public int Cost
        {
            get
            {
                return cost;
            }

            set
            {
                cost = value;
            }
        }

        public ReplacementE()
        {

        }

        public ReplacementE(int consecutive, string description, int annio, int cost)
        {
            this.Consecutive = consecutive;
            this.Description = description;
            this.Annio = annio;
            this.Cost = cost;
        }

        public override string ToString()
        {
            return this.description;
        }
    }
}

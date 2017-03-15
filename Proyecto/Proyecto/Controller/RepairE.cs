using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class RepairE
    {
        int consecutive;
        string description;
        int hours;
        int cost;

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

        public int Hours
        {
            get
            {
                return hours;
            }

            set
            {
                hours = value;
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

        public RepairE()
        {

        }

        public RepairE(int consecutive, string description, int hours, int cost)
        {
            this.Consecutive = consecutive;
            this.Description = description;
            this.Hours = hours;
            this.Cost = cost;
        }

        public override string ToString()
        {
            return base.ToString()+
                "Codigo: " + this.Consecutive + "\n" +
                "Descripcion: " + this.Description + "\n" +
                "Horas Promedio: " + this.Hours + "\n" +
                "Costo: " + this.Cost;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class RepairPerOrderE
    {
        private int order;
        private int repair;
        private string repairName;
        private int employe;
        private string employeName;
        private int cost;
        private int hours;
        private int total;

        public RepairPerOrderE(int order, int repair, string repairName, int employe, string employeName, int cost, int hours, int total)
        {
            this.order = order;
            this.repair = repair;
            this.repairName = repairName;
            this.employe = employe;
            this.employeName = employeName;
            this.cost = cost;
            this.hours = hours;
            this.total = total;
        }

        public RepairPerOrderE()
        {
            this.order = 0;
            this.repair = 0;
            this.repairName = "";
            this.employe = 0;
            this.employeName = "";
            this.cost = 0;
            this.hours = 0;
            this.total = 0;
        }
        public int Order
        {
            get
            {
                return order;
            }

            set
            {
                order = value;
            }
        }

        public int Repair
        {
            get
            {
                return repair;
            }

            set
            {
                repair = value;
            }
        }

        public string RepairName
        {
            get
            {
                return repairName;
            }

            set
            {
                repairName = value;
            }
        }

        public int Employe
        {
            get
            {
                return employe;
            }

            set
            {
                employe = value;
            }
        }

        public string EmployeName
        {
            get
            {
                return employeName;
            }

            set
            {
                employeName = value;
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

        public int Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ReplacementOrderE
    {
        private int order;
        private int replacement;
        private string replacementName;
        private int quantity;
        private int cost;
        private int total;

        public ReplacementOrderE(int order, int replacement, string replacementName, int quantity, int cost, int total)
        {
            this.order = order;
            this.replacement = replacement;
            this.replacementName = replacementName;
            this.quantity = quantity;
            this.cost = cost;
            this.total = total;
        }
        public ReplacementOrderE()
        {
            this.order = 0;
            this.replacement = 0;
            this.replacementName = "";
            this.quantity = 0;
            this.cost = 0;
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

        public int Replacement
        {
            get
            {
                return replacement;
            }

            set
            {
                replacement = value;
            }
        }

        public string ReplacementName
        {
            get
            {
                return replacementName;
            }

            set
            {
                replacementName = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
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

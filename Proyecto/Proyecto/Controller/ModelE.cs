using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ModelE
    {
        private int code;
        private int brand;
        private string description;

        public int Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
            }
        }

        public int Brand
        {
            get
            {
                return brand;
            }

            set
            {
                brand = value;
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

        public ModelE()
        {

        }

        public ModelE(int code, int brand, string description)
        {
            this.Code = code;
            this.Brand = brand;
            this.Description = description;
        }

        public override string ToString()
        {
            return this.description;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class BrandE
    {
        int code;
        string description;

       

        public BrandE()
        {

        }

        public BrandE(int code, string description)
        {
            this.Code = code;
            this.Description = description;
        }

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

        public override string ToString()
        {
            return this.description;
        }
    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    class ClientE : PersonE
    {
        private string cedula;
        private int officePhone;
        private int fax;

        public string Cedula
        {
            get
            {
                return cedula;
            }

            set
            {
                cedula = value;
            }
        }

        public int OfficePhone
        {
            get
            {
                return officePhone;
            }

            set
            {
                officePhone = value;
            }
        }

        public int Fax
        {
            get
            {
                return fax;
            }

            set
            {
                fax = value;
            }
        }

        public ClientE(string pName, string pLastName1, string pLastName2, int pHousePhones, int pCelphone, string pAddress, 
            string pCedula, int pOfficePhone, int pFax):base(pName, pLastName1, pLastName2, pHousePhones, pCelphone, pAddress)
        {
            this.Cedula = pCedula;
            this.OfficePhone = pOfficePhone;
            this.Fax = pFax;
        }

        public override string ToString()
        {
            return base.ToString() +
                "Cedula: " + this.cedula + "\n" +
                "Telefono de oficina: " + this.officePhone + "\n" +
                "Fax: " + this.fax + "\n";
        }
    }
}

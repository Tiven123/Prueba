using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class PersonE
    {
        private string name;
        private string lastName1;
        private string lastName2;
        private int housePhone;
        private int celphone;
        private string address;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string LastName1
        {
            get
            {
                return lastName1;
            }

            set
            {
                lastName1 = value;
            }
        }

        public string LastName2
        {
            get
            {
                return lastName2;
            }

            set
            {
                lastName2 = value;
            }
        }

        public int HousePhone
        {
            get
            {
                return housePhone;
            }

            set
            {
                housePhone = value;
            }
        }

        public int Celphone
        {
            get
            {
                return celphone;
            }

            set
            {
                celphone = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public PersonE(string pName, string pLastName1, string pLastName2, int pHousePhone, int pCelphone, string pAddress)
        {
            this.Name = pName;
            this.LastName1 = pLastName1;
            this.LastName2 = pLastName2;
            this.HousePhone = pHousePhone;
            this.Celphone = pCelphone;
            this.Address = pAddress;
        }
        public virtual string ToString()
        {
            return "Nombre: " + this.name + "\n" +
                "Apellido1: " + this.lastName1 + "\n" +
                "Apellido2: " + this.lastName2 + "\n" +
                "Telefono de casa: " + this.housePhone + "\n" +
                "Celular: " + this.celphone + "\n" +
                "Dirección: " + this.address + "\n";
        }
    }
}

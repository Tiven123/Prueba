using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Controller
{
    class EmployeeE : PersonE
    {
        private string name;
        private string lastName1;
        private string lastName2;
        private int housePhone;
        private int celphone;
        private string address;

        public EmployeeE(string pName, string pLastName1, string pLastName2, int pHousePhone, int pCelphone, string pAddress)
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
            return "Name: " + this.name + "\n" +
                "Last name1: " + this.lastName1 + "\n" +
                "Last name2: " + this.lastName2 + "\n" +
                "House phone: " + this.housePhone + "\n" +
                "Cel phone: " + this.celphone + "\n" +
                "Address: " + this.address + "\n";
        }
        
}

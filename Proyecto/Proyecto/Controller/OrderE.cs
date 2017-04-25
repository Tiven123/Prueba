using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class OrderE
    {
        private int consecutive;
        private int carYear;
        private int employee;
        private string vehicle;
        private DateTime entryDate;
        private DateTime exitDate;
        private DateTime billingDate;
        private string state;
        private int costPerOrder;
        private int billNumber;

        public int CarYear
        {
            get
            {
                return carYear;
            }

            set
            {
                carYear = value;
            }
        }

        public string Vehicle
        {
            get
            {
                return vehicle;
            }

            set
            {
                vehicle = value;
            }
        }

        public DateTime EntryDate
        {
            get
            {
                return entryDate;
            }

            set
            {
                entryDate = value;
            }
        }

        public DateTime ExitDate
        {
            get
            {
                return exitDate;
            }

            set
            {
                exitDate = value;
            }
        }

        public DateTime BillingDate
        {
            get
            {
                return billingDate;
            }

            set
            {
                billingDate = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }

        public int CostPerOrder
        {
            get
            {
                return costPerOrder;
            }

            set
            {
                costPerOrder = value;
            }
        }

        public int BillNumber
        {
            get
            {
                return billNumber;
            }

            set
            {
                billNumber = value;
            }
        }

        public int Employee
        {
            get
            {
                return employee;
            }

            set
            {
                employee = value;
            }
        }

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

        public OrderE(int pConsecutive, int pCarYear, int pEmployee, string pVehicle, DateTime pEntryDate, DateTime pExitDate, DateTime pBillingDate, string pState, int pCostPerOrder, int pBillNumber)
        {
            this.Consecutive = pConsecutive;
            this.CarYear = pCarYear;
            this.Employee = pEmployee;
            this.Vehicle = pVehicle;
            this.EntryDate = pEntryDate;
            this.ExitDate = pExitDate;
            this.BillingDate = pBillingDate;
            this.State = pState;
            this.CostPerOrder = pCostPerOrder;
            this.BillNumber = pBillNumber;
        }
        public OrderE( int pCarYear, int pEmployee, string pVehicle, DateTime pEntryDate, DateTime pExitDate, DateTime pBillingDate, string pState, int pCostPerOrder, int pBillNumber)
        { 
            this.CarYear = pCarYear;
            this.Employee = pEmployee;
            this.Vehicle = pVehicle;
            this.EntryDate = pEntryDate;
            this.ExitDate = pExitDate;
            this.BillingDate = pBillingDate;
            this.State = pState;
            this.CostPerOrder = pCostPerOrder;
            this.BillNumber = pBillNumber;
        }

        public override string ToString()
        {
            return "" + consecutive;
        }
    }
}

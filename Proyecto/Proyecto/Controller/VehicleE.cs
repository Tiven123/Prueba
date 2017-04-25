using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class VehicleE
    {
        private string id;
        private int model;
        private string client;
        private int year;
        private string engine;
        private string chassis;
        private string fuel;
        private string type;
        private int capacity;

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public string Client
        {
            get
            {
                return client;
            }

            set
            {
                client = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public string Engine
        {
            get
            {
                return engine;
            }

            set
            {
                engine = value;
            }
        }

        public string Chassis
        {
            get
            {
                return chassis;
            }

            set
            {
                chassis = value;
            }
        }

        public string Fuel
        {
            get
            {
                return fuel;
            }

            set
            {
                fuel = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }

            set
            {
                capacity = value;
            }
        }

        public VehicleE(string id, int model, string client, int year, string engine, string chassis, string fuel, string type, int capacity)
        {
            this.id = id;
            this.model = model;
            this.client = client;
            this.year = year;
            this.engine = engine;
            this.chassis = chassis;
            this.fuel = fuel;
            this.type = type;
            this.capacity = capacity;
        }

        public VehicleE()
        {

        }

        public override string ToString()
        {
            return this.Id.ToString();
        }
    }
}

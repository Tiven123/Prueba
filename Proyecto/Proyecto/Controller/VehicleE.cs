using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class VehicleE
    {
        string id;
        int model;
        string client;
        int year;
        string engine;
        string chassis;
        char fuel;
        string type;
        int capacity;

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

        public char Fuel
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

        public VehicleE(string id, int model, string client, int year, string engine, string chassis, char fuel, string type, int capacity)
        {
            this.Id = id;
            this.Model = model;
            this.Client = client;
            this.Year = year;
            this.Engine = engine;
            this.Chassis = chassis;
            this.Fuel = fuel;
            this.Type = type;
            this.Capacity = capacity;
        }

        public VehicleE()
        {

        }

        public override string ToString()
        {
            return base.ToString() +
                "Codigo: " + this.id + "\n" +
                "Modelo: " + this.model + "\n" +
                "Cliente: " + this.client + "\n" +
                "Anno: " + this.year + "\n" +
                "Motor: " + this.engine + "\n" +
                "Chasis" + this.chassis + "\n" +
                "Comblustible: " + this.fuel + "\n" +
                "Tipo: " + this.type + "\n" +
                "Capacidad: " + this.capacity;
        }
    }
}

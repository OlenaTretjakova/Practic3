using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic3
{
    internal class Plan
    {
        private string _name { get; set; }
        private string _producer { get; set; }
        private string _type { get; set; }
        private DateTime _yearManufacture { get; set; }

        public Plan() : this("no information", "no information", "no information", DateTime.MinValue) { }

        public Plan(string name, string producer, string type, DateTime yearManufacture)
        {
            _name = name;
            _producer = producer;
            _type = type;
            _yearManufacture = yearManufacture;
        }

        public Plan(string name, string producer, string type, DateTime yearManufacture, string namePilot, int ID) : this(name, producer, type, yearManufacture)
        {
            Pilot pilot = new Pilot(namePilot, ID);
        }

        public void ShowPlan()
        {
            Console.WriteLine($"Name: {_name}; Producer: {_producer}; Type: {_type}; Year of Manufacture: {_yearManufacture}");
        }

        public void ShowPlan(string namePilot, int ID)
        {
            Console.WriteLine($"Name: {_name}; Producer: {_producer}; Type: {_type}; Year of Manufacture: {_yearManufacture}; Pilot's name: {namePilot}; ID: {ID}");
        }

        private class Pilot
        {
            private string _namePilot { get; set; }
            private int _ID { get; set; }

            public Pilot(string namePilot, int ID)
            {
                _namePilot = namePilot;
                _ID = ID;
            }
        }
    }
}

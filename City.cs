using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic3
{
    internal class City
    {
        private string _name { get; set; }
        private string _country { get; set; }
        private int _populationSize { get; set; }
        private string[] _districts { get; set; }

        public City() : this(null, null, 0, null) { }

        public City(string name) : this(name, null, 0, null) { }

        public City(string name, string country) : this(name, country, 0, null) { }

        public City(string name, string country, int populationSize) : this(name, country, populationSize, null) { }

        public City(string name, string country, int populationSize, string[] districts)
        {
            _name = name;
            _country = country;
            _populationSize = populationSize;
            _districts = districts;
        }

        public void ShowInformCity()
        {
            Console.WriteLine($"City: {_name}, Country: {_country}, Population Size: {_populationSize}");

            if (_districts != null && _districts.Length > 0)
            {
                Console.Write($"Districts: ");
                foreach (var district in _districts)
                {
                    Console.Write($"{district} ");
                }
            }
            else
            {
                Console.Write($"there is no information ");
            }
            Console.WriteLine();
        }
    }
}

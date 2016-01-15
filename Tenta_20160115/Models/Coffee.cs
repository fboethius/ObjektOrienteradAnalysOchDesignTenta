using Tenta_20160115.Interface;

namespace Tenta_20160115.Models
    {
    public class Coffee : IDrinkable
        {
        public Coffee(string name, string country, double pricePerUnit, string website)
            {
            CountryOfOrigin = new Country();
            Name = name;
            CountryOfOrigin.Name = country;
            PricePerUnit = pricePerUnit;
            Website = website;
            }
        public string Name { get; set; }
        public Country CountryOfOrigin { get; set; }
        public double PricePerUnit { get; set; }
        public string Website { get; set; }
        }
    }

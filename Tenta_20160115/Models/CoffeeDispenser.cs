using Tenta_20160115.Interface;

namespace Tenta_20160115.Models
    {
    public class CoffeeDispenser : IDispenser
        {
        public IDrinkable Dispense()
            {
            return new Coffee("Zoega", "Colombia", 53.5, "www.zoega.com");
            }
        }
    }

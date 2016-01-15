using Tenta_20160115.Interface;

namespace Tenta_20160115.ClassLibrary.Models
    {
    public class HotwaterDispenser : IDispenser
        {
        public IDrinkable Dispense()
            {
            return new HotWater();
            }
        }
    }

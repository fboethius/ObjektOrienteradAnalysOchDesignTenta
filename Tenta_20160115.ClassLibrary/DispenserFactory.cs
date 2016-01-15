using Tenta_20160115.Interface;
using Tenta_20160115.ClassLibrary.Models;

namespace Tenta_20160115.ClassLibrary
    {
    public class DispenserFactory
        {
        public enum DrinkEnum
            {
            Coffee,
            Hotwater
            }
        public IDispenser CreateDispenser(DrinkEnum drinkType)
            {
            IDispenser dispenser = null;

            if(drinkType == DrinkEnum.Coffee) dispenser = new CoffeeDispenser();
            if(drinkType == DrinkEnum.Hotwater) dispenser = new HotwaterDispenser();

            return dispenser;
            }
        }
    }

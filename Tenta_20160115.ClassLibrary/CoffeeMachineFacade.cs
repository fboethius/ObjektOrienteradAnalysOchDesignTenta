using Tenta_20160115.Interface;

namespace Tenta_20160115.ClassLibrary
    {
    public class CoffeeMachineFacade
        {
        private IDispenser _dispenser;
        public CoffeeMachineFacade(IDispenser dispenser)
            {
            _dispenser = dispenser;
            }
        public IDrinkable GetDrink()
            {
            return _dispenser.Dispense();
            }
        }
    }

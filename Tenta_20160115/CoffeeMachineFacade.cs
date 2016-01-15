using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tenta_20160115.Interface;

namespace Tenta_20160115
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

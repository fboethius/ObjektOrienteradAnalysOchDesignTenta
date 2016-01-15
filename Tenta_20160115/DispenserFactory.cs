using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tenta_20160115.Interface;
using Tenta_20160115.Models;

namespace Tenta_20160115
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

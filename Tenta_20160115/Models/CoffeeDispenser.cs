using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

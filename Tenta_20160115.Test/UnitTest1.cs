using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tenta_20160115.Models;

namespace Tenta_20160115.Test
    {
    [TestClass]
    public class DispenserTest
        {
        [TestMethod]
        public void DispenserFactory_Returns_CoffeeDispenser()
            {
            Assert.IsInstanceOfType(new DispenserFactory().
                CreateDispenser(DispenserFactory.DrinkEnum.Coffee), typeof(CoffeeDispenser));
            }
        [TestMethod]
        public void DispenserFactory_Returns_HotwaterDispenser()
            {
            Assert.IsInstanceOfType(new DispenserFactory().
                CreateDispenser(DispenserFactory.DrinkEnum.Hotwater), typeof(HotwaterDispenser));
            }
        [TestMethod]
        public void CoffeeMachineFacade_Gets_Hotwater()
            {
            var facade = new CoffeeMachineFacade(new DispenserFactory().
                CreateDispenser(DispenserFactory.DrinkEnum.Hotwater));
            Assert.IsInstanceOfType(facade.GetDrink(), typeof(HotWater));
            }
        [TestMethod]
        public void CoffeeMachineFacade_Gets_Coffee()
            {
            var facade = new CoffeeMachineFacade(new DispenserFactory().
                CreateDispenser(DispenserFactory.DrinkEnum.Coffee));
            Assert.IsInstanceOfType(facade.GetDrink(), typeof(Coffee));
            }
        }
    }

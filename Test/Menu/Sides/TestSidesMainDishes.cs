using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizza.Models.Menu.Sides;
using Pizza.Models.Order;
using Pizza.Presenters.PresenterForm1.LoadDishesAndSideDishForm1;
using System.Collections.Generic;

namespace Test.Menu.Sides
{
    [TestClass]
    public class TestSidesMainDishes
    {
        [TestMethod]
        public void TestGetSides()
        {
            IForm1Sides list = new ListSidesMainDishes();
            List<Side> listSides = list.GetSides();

            Assert.AreEqual("Bar sałatkowy", listSides[0].Name);
            Assert.AreEqual("5zł", listSides[0].Price);

            Assert.AreEqual("Zestaw sosów", listSides[1].Name);
            Assert.AreEqual("6zł", listSides[1].Price);
        }
    }
}

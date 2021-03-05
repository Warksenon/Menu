using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizza.Models.Menu.Sides;
using Pizza.Models.Order;
using Pizza.Presenters.PresenterForm1.LoadDishesAndSideDishForm1;
using System.Collections.Generic;

namespace Test.Menu.Sides
{
    [TestClass]
    public class TestSidesPizza
    {
        [TestMethod]
        public void TestMethod1()
        {
            IForm1Sides list = new ListSidesPizza();
            List<Side> listSides = list.GetSides();

            Assert.AreEqual("Podwójny Ser", listSides[0].Name);
            Assert.AreEqual("2zł", listSides[0].Price);

            Assert.AreEqual("Salami", listSides[1].Name);
            Assert.AreEqual("2zł", listSides[1].Price);

            Assert.AreEqual("Szynka", listSides[2].Name);
            Assert.AreEqual("2zł", listSides[2].Price);

            Assert.AreEqual("Pieczarki", listSides[3].Name);
            Assert.AreEqual("2zł", listSides[3].Price);
        }
    }
}

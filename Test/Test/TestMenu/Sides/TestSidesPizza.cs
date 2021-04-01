using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizza;
using Pizza.Presenters.PresenterForm1.LoadDishesAndSideDishForm1;
using System.Collections.Generic;

namespace Test.Menu.Sides
{
    [TestClass]
    public class TestSidesPizza
    {
        [TestMethod]
        public void TestGetLitStringSidesPizza()
        {
            IForm1Sides list = new ListSidesPizza();
            List<string> listSides = list.GetSides();

            Assert.AreEqual("Podwójny Ser -2zł", listSides[0]);
            Assert.AreEqual("Salami -2zł", listSides[1]);
            Assert.AreEqual("Szynka -2zł", listSides[2]);
            Assert.AreEqual("Pieczarki -2zł", listSides[3]);           
        }
    }
}

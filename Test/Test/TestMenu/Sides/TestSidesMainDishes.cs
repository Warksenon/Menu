using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizza;
using Pizza.Presenters.PresenterFormMenu.LoadDishesAndSideDishForm1;
using System.Collections.Generic;

namespace Test.Menu.Sides
{
    [TestClass]
    public class TestSidesMainDishes
    {
        [TestMethod]
        public void TestGetLitStringSidesMainDishes()
        {
            IForm1Sides list = new ListSidesMainDishes();
            List<string> listSides = list.GetSides();

            Assert.AreEqual( "Bar sałatkowy -5zł", listSides [0] );
            Assert.AreEqual( "Zestaw sosów -6zł", listSides [1] );
        }
    }
}

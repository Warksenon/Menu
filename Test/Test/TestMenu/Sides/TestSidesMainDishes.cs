using System.Collections.Generic;

using NUnit.Framework;

using Pizza;
using Pizza.Presenters.PresenterFormMenu.LoadDishesAndSideDishForm1;

namespace Test.Menu.Sides
{
    [TestFixture]
    public class TestSidesMainDishes
    {
        [TestCase( "Bar sałatkowy -5zł", "0" )]
        [TestCase( "Zestaw sosów -6zł", "1" )]
        public void TestGetListSidesMainDishes( string expectationsName, int index )
        { 
            IForm1Sides list = new ListSidesMainDishes();

            List<string> listSides = list.GetSides();
            var currentName = listSides [index];

            Assert.AreEqual( expectationsName, currentName );
        }
    }
}

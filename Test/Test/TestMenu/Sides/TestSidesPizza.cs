using System.Collections.Generic;

using NUnit.Framework;

using Pizza;
using Pizza.Presenters.PresenterFormMenu.LoadDishesAndSideDishForm1;

namespace Test.Menu.Sides
{
    [TestFixture]
    public class TestSidesPizza
    {
        [TestCase( "Podwójny Ser -2zł", "0" )]
        [TestCase( "Salami -2zł", "1" )]
        [TestCase( "Szynka -2zł", "2" )]
        [TestCase( "Pieczarki -2zł", "3" )]
        public void TestGetListSidesPizza( string expectationsName, int index )
        {
            IForm1Sides list = new ListSidesPizza();

            List<string> listSides = list.GetSides();
            var currentName = listSides [index];

            Assert.AreEqual( expectationsName, currentName );
        }
    }
}

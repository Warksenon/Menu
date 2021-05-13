using System.Collections.Generic;

using NUnit.Framework;

using Pizza;
using Pizza.Presenters.PresenterFormMenu.LoadDishesAndSideDishForm1;

namespace Test
{
    [TestFixture]
    public class TestListPizza
    {
        [TestCase( "Margheritta", "20zł", "0" )]
        [TestCase( "Vegetariana", "22zł", "1" )]
        [TestCase( "Tosca", "25zł", "2" )]
        [TestCase( "Venecia", "25zł", "3" )]
        public void TestGetListPizza( string expectationsName, string expectationsPrice, int index )
        {
            Pizza.IList<Dish> list = new ListPizza();

            List<Dish> listPizza = list.GetList();
            var currentName = listPizza [index].Name;
            var currentPrice = listPizza [index].Price;

            Assert.AreEqual( expectationsName, currentName );
            Assert.AreEqual( expectationsPrice, currentPrice );
        }
    }
}

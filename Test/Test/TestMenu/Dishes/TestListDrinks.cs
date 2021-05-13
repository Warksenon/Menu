using System.Collections.Generic;

using NUnit.Framework;

using Pizza;
using Pizza.Presenters.PresenterFormMenu.LoadDishesAndSideDishForm1;

namespace Test
{
    [TestFixture]
    public class TestListDrinks
    {
        [TestCase( "Kawa", "5zł", "0" )]
        [TestCase( "Herbata", "5zł", "1" )]
        [TestCase( "Cola", "5zł", "2" )]
        public void TestGetListDrinks( string expectationsName, string expectationsPrice, int index )
        {
            Pizza.IList<Dish> list = new ListDrinks();

            List<Dish> listDrinks = list.GetList();
            var currentName = listDrinks [index].Name;
            var currentPrice = listDrinks [index].Price;

            Assert.AreEqual( expectationsName, currentName );
            Assert.AreEqual( expectationsPrice, currentPrice );
        }
    }
}

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
            IForm1Dishes list = new ListDrinks();

            List<Dish> listPizza = list.GetDishes();
            var currentName = listPizza [index].Name;
            var currentPrice = listPizza [index].Price;

            Assert.AreEqual( expectationsName, currentName );
            Assert.AreEqual( expectationsPrice, currentPrice );
        }
    }
}

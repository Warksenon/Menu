using System.Collections.Generic;

using NUnit.Framework;

using Pizza;
using Pizza.Presenters.PresenterFormMenu.LoadDishesAndSideDishForm1;


namespace Test
{
    [TestFixture]
    public class TestListSoups
    {
        [TestCase( "Pomidorowa", "12zł", "0" )]
        [TestCase( "Rosół", "10zł", "1" )]
        public void TestGetListDrinks( string expectationsName, string expectationsPrice, int index )
        {   
            IForm1Dishes list = new ListSoups();
            List<Dish> listSoup = list.GetDishes();
            var currentName = listSoup [index].Name;
            var currentPrice = listSoup [index].Price;

            Assert.AreEqual( expectationsName, currentName );
            Assert.AreEqual( expectationsPrice, currentPrice );
        }
    }
}

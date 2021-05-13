using System.Collections.Generic;

using NUnit.Framework;

using Pizza;
using Pizza.Presenters.PresenterFormMenu.LoadDishesAndSideDishForm1;

namespace Test
{
    [TestFixture]
    public class TestListMainDishes
    {
        [TestCase( "Schabowy z frytkami/ryżem/ziemniakami", "30zł", "0" )]
        [TestCase( "Ryba z frytkami", "28zł", "1" )]
        [TestCase( "Placek po węgiersku", "27zł", "2" )]
        public void TestGetListMainDishes( string expectationsName, string expectationsPrice, int index )
        {
            Pizza.IList<Dish> list = new ListMainDishes();

            List<Dish> listMainDishes = list.GetList();
            var currentName = listMainDishes [index].Name;
            var currentPrice = listMainDishes [index].Price;

            Assert.AreEqual( expectationsName, currentName );
            Assert.AreEqual( expectationsPrice, currentPrice );
        }
    }
}

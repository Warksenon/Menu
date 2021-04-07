using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizza;
using Pizza.Presenters.PresenterForm1.LoadDishesAndSideDishForm1;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class TestListDrinks
    {
        [TestMethod]
        public void TestDishes()
        {
            IForm1Dishes list = new ListDrinks();
            List<Dish> listPizza = list.GetDishes();

            Assert.AreEqual( "Kawa", listPizza [0].Name );
            Assert.AreEqual( "5zł", listPizza [0].Price );

            Assert.AreEqual( "Herbata", listPizza [1].Name );
            Assert.AreEqual( "5zł", listPizza [1].Price );

            Assert.AreEqual( "Cola", listPizza [2].Name );
            Assert.AreEqual( "5zł", listPizza [2].Price );
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizza;
using Pizza.Presenters.PresenterFormMenu.LoadDishesAndSideDishForm1;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class TestListMainDishes
    {
        [TestMethod]
        public void TestDishes()
        {
            IForm1Dishes list = new ListMainDishes();
            List<Dish> listPizza = list.GetDishes();

            Assert.AreEqual( "Schabowy z frytkami/ryżem/ziemniakami", listPizza [0].Name );
            Assert.AreEqual( "30zł", listPizza [0].Price );

            Assert.AreEqual( "Ryba z frytkami", listPizza [1].Name );
            Assert.AreEqual( "28zł", listPizza [1].Price );

            Assert.AreEqual( "Placek po węgiersku", listPizza [2].Name );
            Assert.AreEqual( "27zł", listPizza [2].Price );

        }
    }
}

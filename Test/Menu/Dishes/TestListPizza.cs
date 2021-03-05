using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizza;
using Pizza.Models.Menu;
using Pizza.Presenters.PresenterForm1.LoadDishesAndSideDishForm1;
using System.Collections.Generic;


namespace Test
{
    [TestClass]
    public class TestListPizza
    {


        [TestMethod]
        public void TestDishes()
        {
            IForm1Dishes list = new ListPizza();
            List<Dish> listPizza = list.GetDishes();

            Assert.AreEqual("Margheritta", listPizza[0].Name);
            Assert.AreEqual("20zł", listPizza[0].Price);

            Assert.AreEqual("Vegetariana", listPizza[1].Name);
            Assert.AreEqual("22zł", listPizza[1].Price);

            Assert.AreEqual("Tosca", listPizza[2].Name);
            Assert.AreEqual("25zł", listPizza[2].Price);

            Assert.AreEqual("Venecia", listPizza[3].Name);
            Assert.AreEqual("25zł", listPizza[3].Price);

        }
    }
}

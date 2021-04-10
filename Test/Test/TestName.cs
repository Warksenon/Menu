using NUnit.Framework;
using Pizza;
using Pizza.Presenters;

namespace Test
{
    [TestFixture]
    public class TestName
    {

        FormMenu form = new FormMenu();
        OnEvent eevent = new OnEvent();

        [TestCase("Kawa", "0")]
        [TestCase("Herbata", "1")]
        [TestCase("Cola", "2")]
        public void TestMethod1(string expectationsName, int index)
        {
            eevent.SetLogic(new ButtonDriksLogic(form));

            Assert.AreEqual(expectationsName, form.ListViewDishes.Items[index].SubItems[0].Text);
            Assert.AreEqual("5zł", form.ListViewDishes.Items[index].SubItems[1].Text);
        }



        [TestCase("pizza", "Pizza")]
        [TestCase("denmark", "Dania główne")]
        [TestCase("soups", "Zupy")]
        [TestCase("drinks", "Napoje -5zł")]
        public void TestNameGeter(string key, string expectationsName)
        {
            var name = Name.GetNameConfig(key);
            Assert.AreEqual(expectationsName, name);
        }

        [TestCase("lMenuInfoPizza", "Pizza")]
        [TestCase("lMenuInfoMainDish", "Dania główne")]
        [TestCase("lMenuInfoSoups", "Zupy")]
        [TestCase("lMenuInfoDrinks", "Napoje")]
        public void TestNameGeterForlMenuInfo(string key, string expectationsName)
        {
            var name = Name.GetNameConfig(key);
            Assert.AreEqual(expectationsName, name);
        }

        [TestCase("priceAll", "PriceAll")]
        [TestCase("dishes", "Dishes")]
        [TestCase("idPrice", "idPrice")]
        [TestCase("comments", "Comments")]
        [TestCase("id", "id")]
        [TestCase("sidesDishes", "SidesDishes")]
        [TestCase("date", "Data")]
        [TestCase("price", "Price")]
        [TestCase("dish", "Dish")]
        public void TestNameGeterForlSqlNameColumns(string key, string expectationsName)
        {
            var name = Name.GetNameConfig(key);
            Assert.AreEqual(expectationsName, name);
        }
    }
}

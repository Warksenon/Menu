using NUnit.Framework;
using Pizza;
using Pizza.Presenters;

namespace Test.Test.TestFormMenu.PresenterFormMenu.ButtonMenuLogic
{
    [TestFixture]
    public class TestButtonMenuLogic 
    {
        FormMenu form = new FormMenu();
        OnEvent eevent = new OnEvent();

        [TestCase("Margheritta","20zł", "0")]
        [TestCase("Vegetariana", "22zł", "1")]
        [TestCase("Tosca", "25zł", "2")]
        [TestCase("Venecia", "25zł", "3")]
        public void TestGetListPizzaFromListViewDishes(string name, string price , int index)
        {
            eevent.SetLogic(new ButtonPizzaLogic(form));

            Assert.AreEqual(name, form.ListViewDishes.Items[index].SubItems[0].Text);
            Assert.AreEqual(price, form.ListViewDishes.Items[index].SubItems[1].Text);
        }


        [TestCase("Schabowy z frytkami/ryżem/ziemniakami", "30zł", "0")]
        [TestCase("Ryba z frytkami", "28zł", "1")]
        public void TestButtonMainDishesLogic(string name, string price, int index)
        {
            eevent.SetLogic(new ButtonMainDishesLogic(form));

            Assert.AreEqual(name, form.ListViewDishes.Items[index].SubItems[0].Text);
            Assert.AreEqual(price, form.ListViewDishes.Items[index].SubItems[1].Text);
        }

        [TestCase("Kawa", "0")]
        [TestCase("Herbata", "1")]
        [TestCase("Cola", "2")]
        public void TestMethod1(string expectationsName, int index)
        {
            eevent.SetLogic(new ButtonDriksLogic(form));

            Assert.AreEqual(expectationsName, form.ListViewDishes.Items[index].SubItems[0].Text);
            Assert.AreEqual("5zł", form.ListViewDishes.Items[index].SubItems[1].Text);
        }

    

    }
}

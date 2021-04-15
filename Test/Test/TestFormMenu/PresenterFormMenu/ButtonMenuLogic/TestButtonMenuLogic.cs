using NUnit.Framework;

using Pizza;
using Pizza.Presenters;

namespace Test.Test.TestFormMenu.PresenterFormMenu.ButtonMenuLogic
{
    [TestFixture]
    public class TestButtonMenuLogic
    {
        private readonly FormMenu form = new FormMenu();
        private readonly OnEvent eevent = new OnEvent();

        [TestCase( "Margheritta", "20zł", "0" )]
        [TestCase( "Vegetariana", "22zł", "1" )]
        [TestCase( "Tosca", "25zł", "2" )]
        [TestCase( "Venecia", "25zł", "3" )]
        public void TestGetListPizzasFromListViewDishes( string expectationsName, string expectationsPrice, int index )
        {
            eevent.SetLogic( new Pizza.Presenters.PresenterFormMenu.Logic.ButtonPizzaLogic( form ) );
            var  currentName  = form.ListViewDishes.Items [index].SubItems [0].Text;
            var  currentPrice = form.ListViewDishes.Items [index].SubItems [1].Text;

            Assert.AreEqual( expectationsName, currentName );
            Assert.AreEqual( expectationsPrice, currentPrice );
        }

        [TestCase( "Schabowy z frytkami/ryżem/ziemniakami", "30zł", "0" )]
        [TestCase( "Ryba z frytkami", "28zł", "1" )]
        [TestCase( "Placek po węgiersku", "27zł", "2" )]
        public void TestGetListMainDishesFromListViewDishes( string expectationsName, string price, int index )
        {
            eevent.SetLogic( new Pizza.Presenters.PresenterFormMenu.Logic.ButtonMainDishesLogic( form ) );
            var  currentName  = form.ListViewDishes.Items [index].SubItems [0].Text;
            var  currentPrice = form.ListViewDishes.Items [index].SubItems [1].Text;

            Assert.AreEqual( expectationsName, currentName );
            Assert.AreEqual( price, currentPrice );
        }

        [TestCase( "Kawa", "0" )]
        [TestCase( "Herbata", "1" )]
        [TestCase( "Cola", "2" )]
        public void TestGetListDrinksFromListViewDishes( string expectationsName, int index )
        {
            eevent.SetLogic( new Pizza.Presenters.PresenterFormMenu.Logic.ButtonDriksLogic( form ) );
            var  currentName  = form.ListViewDishes.Items [index].SubItems [0].Text;
            var  currentPrice = form.ListViewDishes.Items [index].SubItems [1].Text;

            Assert.AreEqual( expectationsName, currentName );
            Assert.AreEqual( "5zł", currentPrice );
        }

        [TestCase( "Pomidorowa", "12zł", "0" )]
        [TestCase( "Rosół", "10zł", "1" )]
        public void TestGetListSoupsFromListViewDishes( string expectationsName, string expectationsPrice, int index )
        {
            eevent.SetLogic( new Pizza.Presenters.PresenterFormMenu.Logic.ButtonSoupsLogic( form ) );
            var  currentName  = form.ListViewDishes.Items [index].SubItems [0].Text;
            var  currentPrice = form.ListViewDishes.Items [index].SubItems [1].Text;

            Assert.AreEqual( expectationsName, currentName );
            Assert.AreEqual( expectationsPrice, currentPrice );
        }

        [TestCase( "Bar sałatkowy -5zł", "0" )]
        [TestCase( "Zestaw sosów -6zł", "1" )]
        public void TestGetListSidesFromMainDishes( string expectationsName, int index )
        {
            eevent.SetLogic( new Pizza.Presenters.PresenterFormMenu.Logic.ButtonMainDishesLogic( form ) );
            var  currentName  = form.CheckedListBoxSide.Items [index].ToString();

            Assert.AreEqual( expectationsName, currentName );
        }

        [TestCase( "Podwójny Ser -2zł", "0" )]
        [TestCase( "Salami -2zł", "1" )]
        [TestCase( "Szynka -2zł", "2" )]
        [TestCase( "Pieczarki -2zł", "3" )]
        public void TestGetListSidesFromPizzas( string expectationsName, int index )
        {
            eevent.SetLogic( new Pizza.Presenters.PresenterFormMenu.Logic.ButtonPizzaLogic( form ) );
            var  currentName  = form.CheckedListBoxSide.Items [index].ToString();

            Assert.AreEqual( expectationsName, currentName );
        }
    }
}

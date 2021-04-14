
using NUnit.Framework;

using Pizza;

namespace Test.Test.TestFormMenu.PresenterFormMenu
{
    [TestFixture]
    public class TestFormMenuListDishes
    {
        [TestCase( "Margheritta", "20zł", "", "0" )]
        [TestCase( "Vegetariana", "22zł", "", "1" )]
        [TestCase( "Tosca", "25zł", "", "2" )]
        [TestCase( "Venecia", "25zł", "", "3" )]
        public void TestAddOrderToFormMenuListViewOrderAndCheckingDownloadOfEachPizza( string expectationsName, string expectationsPrice, string expectationsSides, int simulationChoosingDish )
        {
            FormMenu form = new FormMenu();
            OnEventTest  onEvent = new OnEventTest();
            onEvent.SetLogic( new ButtonPizzaLogic( form ) );
            form.QTextbox.Text = "1";

            onEvent.SetLogic( new FormMenuAddOrderListViewTest( form, simulationChoosingDish ) );
            var currentName = form.ListViewOrder.Items [0].SubItems [0].Text;
            var currentSides = form.ListViewOrder.Items [0].SubItems [1].Text;
            var currentPrice = form.ListViewOrder.Items [0].SubItems [2].Text;

            Assert.AreEqual( expectationsName, currentName );
            Assert.AreEqual( expectationsPrice, currentPrice );
            Assert.AreEqual( expectationsSides, currentSides );
        }


        [TestCase( "Schabowy z frytkami/ryżem/ziemniakami", "30zł", "", "0" )]
        [TestCase( "Ryba z frytkami", "28zł", "", "1" )]
        [TestCase( "Placek po węgiersku", "27zł", "", "2" )]
        public void TestAddOrderToFormMenuListViewOrderAndCheckingDownloadOfEachMainDishes( string expectationsName, string expectationsPrice, string expectationsSides, int simulationChoosingDish )
        {
            FormMenu form = new FormMenu();
            OnEventTest  onEvent = new OnEventTest();
            onEvent.SetLogic( new ButtonMainDishesLogic( form ) );
            form.QTextbox.Text = "1";

            onEvent.SetLogic( new FormMenuAddOrderListViewTest( form, simulationChoosingDish ) );
            var currentName = form.ListViewOrder.Items [0].SubItems [0].Text;
            var currentSides = form.ListViewOrder.Items [0].SubItems [1].Text;
            var currentPrice = form.ListViewOrder.Items [0].SubItems [2].Text;

            Assert.AreEqual( expectationsName, currentName );
            Assert.AreEqual( expectationsPrice, currentPrice );
            Assert.AreEqual( expectationsSides, currentSides );
        }

        [TestCase( "Pomidorowa", "12zł", "", "0" )]
        [TestCase( "Rosół", "10zł", "", "1" )]
        public void TestAddOrderToFormMenuListViewOrderAndCheckingDownloadOfEachSoups( string expectationsName, string expectationsPrice, string expectationsSides, int simulationChoosingDish )
        {
            FormMenu form = new FormMenu();
            OnEventTest  onEvent = new OnEventTest();
            onEvent.SetLogic( new ButtonSoupsLogic( form ) );
            form.QTextbox.Text = "1";

            onEvent.SetLogic( new FormMenuAddOrderListViewTest( form, simulationChoosingDish ) );
            var currentName = form.ListViewOrder.Items [0].SubItems [0].Text;
            var currentSides = form.ListViewOrder.Items [0].SubItems [1].Text;
            var currentPrice = form.ListViewOrder.Items [0].SubItems [2].Text;

            Assert.AreEqual( expectationsName, currentName );
            Assert.AreEqual( expectationsPrice, currentPrice );
            Assert.AreEqual( expectationsSides, currentSides );
        }

        [TestCase( "Kawa", "5zł", "", "0" )]
        [TestCase( "Herbata", "5zł", "", "1" )]
        [TestCase( "Cola", "5zł", "", "2" )]
        public void TestAddOrderToFormMenuListViewOrderAndCheckingDownloadOfEachDrinks( string expectationsName, string expectationsPrice, string expectationsSides, int simulationChoosingDish )
        {
            FormMenu form = new FormMenu();
            OnEventTest  onEvent = new OnEventTest();
            onEvent.SetLogic( new ButtonDriksLogic( form ) );
            form.QTextbox.Text = "1";

            onEvent.SetLogic( new FormMenuAddOrderListViewTest( form, simulationChoosingDish ) );
            var currentName = form.ListViewOrder.Items [0].SubItems [0].Text;
            var currentSides = form.ListViewOrder.Items [0].SubItems [1].Text;
            var currentPrice = form.ListViewOrder.Items [0].SubItems [2].Text;

            Assert.AreEqual( expectationsName, currentName );
            Assert.AreEqual( expectationsPrice, currentPrice );
            Assert.AreEqual( expectationsSides, currentSides );
        }

        [TestCase( "Margheritta", "20zł","", "0" )]
        [TestCase( "Margheritta", "20zł", "", "1" )]
        [TestCase( "Margheritta", "20zł", "", "2" )]
        public void TestAddOrderToFormMenuListViewOrderFromThreeRepeatsProduct( string expectationsName, string expectationsPrice, string expectationsSides, int index )
        {
            FormMenu form = new FormMenu();           
            OnEventTest  onEvent = new OnEventTest();
            onEvent.SetLogic( new ButtonPizzaLogic( form ) );
            form.QTextbox.Text = "3";
            int selectedItem = 0;

            onEvent.SetLogic( new FormMenuAddOrderListViewTest( form, selectedItem ) );
            var currentName = form.ListViewOrder.Items [index].SubItems [0].Text;
            var currentSides = form.ListViewOrder.Items [index].SubItems [1].Text;
            var currentPrice = form.ListViewOrder.Items [index].SubItems [2].Text;

            Assert.AreEqual( expectationsName, currentName );
            Assert.AreEqual( expectationsPrice, currentPrice );
            Assert.AreEqual( expectationsSides, currentSides );
        }

        [TestCase( "a" )]
        [TestCase( "b" )]
        [TestCase( "c" )]
        [TestCase( "" )]
        [TestCase( "1b" )]
        public void TestAddOrderToFormMenuListViewOrderAndWronglyEnteredProductAmount( string productQuantity )
        {
            FormMenu form = new FormMenu();
            OnEventTest  onEvent = new OnEventTest();
            onEvent.SetLogic( new ButtonPizzaLogic( form ) );
            form.QTextbox.Text = productQuantity;
            int selectedItem = 0;
            int expectationsListViewOrderCount = 0;

            onEvent.SetLogic( new FormMenuAddOrderListViewTest( form, selectedItem ) );
            var currentListViewOrderCount = form.ListViewOrder.Items.Count;


            Assert.AreEqual( expectationsListViewOrderCount, form.ListViewOrder.Items.Count);
        }
    }
}

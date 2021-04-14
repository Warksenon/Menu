using System;
using NUnit.Framework;
using Pizza;

namespace Test.Test.TestFormMenu.PresenterFormMenu
{
    [TestFixture]
    public class TestFormMenuCreatingOrder
    {
        [TestCase( "Margheritta", "20zł", "", "0" )]
        [TestCase( "Vegetariana", "22zł", "", "1" )]
        [TestCase( "Tosca", "25zł", "", "2" )]
        [TestCase( "Venecia", "25zł", "", "3" )]
        public void TestAddOrderToFormMenuListViewOrderAndCheckingDownloadOfEachPizza ( string expectationsName, string expectationsPrice, string expectationsSides, int indexListDishes  )
        {
            FormMenu form = new FormMenu();
            OnEventTest  onEvent = new OnEventTest();
            onEvent.SetLogic( new ButtonPizzaLogic( form ) );
            form.QTextbox.Text = "1";
            CreateAllOrderPizzaWithListViewDiehesWithoutSides( onEvent, form );

            FormMenuCreatingOrderTest   createOrder = new FormMenuCreatingOrderTest(form);
            Order order = createOrder.GetOrderFromListView();
            var currentName = order.ListDishes[indexListDishes].Name;
            var currentSides = order.ListDishes[indexListDishes].Sides;
            var currentPrice = order.ListDishes[indexListDishes].Price;
            var currentPriceAll = order.PriceAll.Price;

            Assert.AreEqual( expectationsName, currentName );
            Assert.AreEqual( expectationsPrice, currentPrice );
            Assert.AreEqual( expectationsSides, currentSides );
            Assert.AreEqual( "92zł", currentPriceAll );
        }

        void CreateAllOrderPizzaWithListViewDiehesWithoutSides ( OnEventTest onEvent, FormMenu form  )
        {
            int [] simulationChoosingDish = {0,1,2,3};
            foreach(int i in simulationChoosingDish)
            {
                onEvent.SetLogic( new FormMenuAddOrderListViewTest( form, simulationChoosingDish [i] ) );
            }
           
        }
    }
}

using NUnit.Framework;

using Pizza;
using Pizza.Presenters.PresenterFormMenu;

namespace Test.Test.TestFormMenu.PresenterFormMenu
{
    //[TestFixture]
    //public class TestFormMenuCreatingOrder
    //{
    //    [TestCase( "Margheritta", "20zł", "", "0" )]
    //    [TestCase( "Vegetariana", "22zł", "", "1" )]
    //    [TestCase( "Tosca", "25zł", "", "2" )]
    //    [TestCase( "Venecia", "25zł", "", "3" )]
    //    public void TestAddOrderToFormMenuListViewOrderAndCheckingDownloadOfEachPizza( string expectationsName, string expectationsPrice, string expectationsSides, int indexListDishes )
    //    {
    //        FormMenu form = new FormMenu();
    //        OnEventTest  onEvent = new OnEventTest();
    //        onEvent.SetLogic( new LogicMenuButtonTest( form, ButtonLoadMenu.Pizza ) );
    //        form.QTextbox.Text = "1";
    //        DishesListViewTest.SelectionSimulation = indexListDishes;
    //        int []simulationSelectionSides={};
    //        new AddOrderListViewTest( form, simulationSelectionSides ).LogicSettings();

    //        var order = new OrderListView(form).GetElement();
    //        var dish = order.ListDishes[0];

    //        var currentName = dish.Name;
    //        var currentSides = dish.Sides;
    //        var currentPrice = dish.Price;
    //        var currentPriceAll = order.PriceAll.Price;

    //        Assert.AreEqual( expectationsName, currentName );
    //        Assert.AreEqual( expectationsPrice, currentPrice );
    //        Assert.AreEqual( expectationsSides, currentSides );
    //        Assert.AreEqual( currentPrice, currentPriceAll );
    //    }

    //}
}

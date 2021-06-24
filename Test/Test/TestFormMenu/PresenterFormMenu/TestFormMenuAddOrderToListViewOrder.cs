using NUnit.Framework;

using Pizza;
using Pizza.Presenters.PresenterFormMenu;

namespace Test.Test.TestFormMenu.PresenterFormMenu
{
    //[TestFixture]
    //public class TestFormMenuAddOrderToListViewOrder
    //{
    //    [TestCase( "Margheritta", "20zł", "", "0" )]
    //    [TestCase( "Vegetariana", "22zł", "", "1" )]
    //    [TestCase( "Tosca", "25zł", "", "2" )]
    //    [TestCase( "Venecia", "25zł", "", "3" )]
    //    public void TestAddOrderToFormMenuListViewOrderAndCheckingDownloadOfEachPizza( string expectationsName, string expectationsPrice, string expectationsSides, int simulationChoosingDish )
    //    {
    //        FormMenu form = new FormMenu();
    //        OnEventTest  onEvent = new OnEventTest();
    //        onEvent.SetLogic( new LogicMenuButtonTest( form, ButtonLoadMenu.Pizza ) );
    //        form.QTextbox.Text = "1";
    //        DishesListViewTest.SelectionSimulation = simulationChoosingDish;
    //        int[] simulationSelectionSides = { };
    //        new AddOrderListViewTest( form, simulationSelectionSides ).LogicSettings();

    //        var order = new OrderListView(form).GetElement();
    //        var dish = order.ListDishes[0];

    //        var currentName = dish.Name;
    //        var currentSides = dish.Sides;
    //        var currentPrice = dish.Price;

    //        Assert.AreEqual( expectationsName, currentName );
    //        Assert.AreEqual( expectationsPrice, currentPrice );
    //        Assert.AreEqual( expectationsSides, currentSides );
    //    }

    //    [TestCase( "Margheritta - 20zł", "28zł", "Podwójny Ser -2zł,Salami -2zł,Szynka -2zł,Pieczarki -2zł.", "0" )]
    //    [TestCase( "Vegetariana - 22zł", "30zł", "Podwójny Ser -2zł,Salami -2zł,Szynka -2zł,Pieczarki -2zł.", "1" )]
    //    [TestCase( "Tosca - 25zł", "33zł", "Podwójny Ser -2zł,Salami -2zł,Szynka -2zł,Pieczarki -2zł.", "2" )]
    //    [TestCase( "Venecia - 25zł", "33zł", "Podwójny Ser -2zł,Salami -2zł,Szynka -2zł,Pieczarki -2zł.", "3" )]
    //    public void TestAddOrderToFormMenuListViewOrderAndCheckingDownloadOfEachPizzaWithSidesAll( string expectationsName, string expectationsPrice, string expectationsSides, int simulationChoosingDish )
    //    {
    //        FormMenu form = new FormMenu();
    //        OnEventTest  onEvent = new OnEventTest();
    //        onEvent.SetLogic( new LogicMenuButtonTest( form, ButtonLoadMenu.Pizza ) );
    //        form.QTextbox.Text = "1";
    //        DishesListViewTest.SelectionSimulation = simulationChoosingDish;
    //        int[] tab = {0,1,2,3 };
    //        new AddOrderListViewTest( form, tab ).LogicSettings();
    //        var order = new OrderListView(form).GetElement();
    //        var dish = order.ListDishes[0];

    //        var currentName = dish.Name;
    //        var currentSides = dish.Sides;
    //        var currentPrice = dish.Price;

    //        Assert.AreEqual( expectationsName, currentName );
    //        Assert.AreEqual( expectationsPrice, currentPrice );
    //        Assert.AreEqual( expectationsSides, currentSides );
    //    }

    //    [TestCase( "0", "Margheritta", "20zł", "" )]
    //    [TestCase( "1", "Margheritta - 20zł", "22zł", "Podwójny Ser -2zł." )]
    //    [TestCase( "2", "Margheritta - 20zł", "22zł", "Salami -2zł." )]
    //    [TestCase( "3", "Margheritta - 20zł", "24zł", "Podwójny Ser -2zł,Salami -2zł." )]
    //    [TestCase( "4", "Margheritta - 20zł", "22zł", "Szynka -2zł." )]
    //    [TestCase( "5", "Margheritta - 20zł", "24zł", "Podwójny Ser -2zł,Szynka -2zł." )]
    //    [TestCase( "6", "Margheritta - 20zł", "24zł", "Salami -2zł,Szynka -2zł." )]
    //    [TestCase( "7", "Margheritta - 20zł", "26zł", "Podwójny Ser -2zł,Salami -2zł,Szynka -2zł." )]
    //    [TestCase( "8", "Margheritta - 20zł", "22zł", "Pieczarki -2zł." )]
    //    [TestCase( "9", "Margheritta - 20zł", "24zł", "Podwójny Ser -2zł,Pieczarki -2zł." )]
    //    [TestCase( "10", "Margheritta - 20zł", "24zł", "Salami -2zł,Pieczarki -2zł." )]
    //    [TestCase( "11", "Margheritta - 20zł", "26zł", "Podwójny Ser -2zł,Salami -2zł,Pieczarki -2zł." )]
    //    [TestCase( "12", "Margheritta - 20zł", "24zł", "Szynka -2zł,Pieczarki -2zł." )]
    //    [TestCase( "13", "Margheritta - 20zł", "26zł", "Podwójny Ser -2zł,Szynka -2zł,Pieczarki -2zł." )]
    //    [TestCase( "14", "Margheritta - 20zł", "26zł", "Salami -2zł,Szynka -2zł,Pieczarki -2zł." )]
    //    [TestCase( "15", "Margheritta - 20zł", "28zł", "Podwójny Ser -2zł,Salami -2zł,Szynka -2zł,Pieczarki -2zł." )]
    //    public void TestAddOrderToFormMenuListViewOrderAndCheckingDownloadOfEachPizzaWithSidesSelectedSides( int simulationSelectionSides, string expectationsName, string expectationsPrice, string expectationsSides )
    //    {
    //        FormMenu form = new FormMenu();
    //        OnEventTest  onEvent = new OnEventTest();
    //        onEvent.SetLogic( new LogicMenuButtonTest( form, ButtonLoadMenu.Pizza ) );
    //        form.QTextbox.Text = "1";
    //        DishesListViewTest.SelectionSimulation = 0;
    //        int[] tab  = SimulationSelectionSides( simulationSelectionSides );
    //        new AddOrderListViewTest( form, tab ).LogicSettings();

    //        var order = new OrderListView(form).GetElement();
    //        var dish = order.ListDishes[0];

    //        var currentName = dish.Name;
    //        var currentSides = dish.Sides;
    //        var currentPrice = dish.Price;

    //        Assert.AreEqual( expectationsName, currentName );
    //        Assert.AreEqual( expectationsPrice, currentPrice );
    //        Assert.AreEqual( expectationsSides, currentSides );
    //    }

    //    private int [] SimulationSelectionSides( int i )
    //    {
    //        int []  simulationSelectionSides;
    //        switch (i)
    //        {
    //            case 1:
    //            simulationSelectionSides = new int [] { 0 };
    //            break;
    //            case 2:
    //            simulationSelectionSides = new int [] { 1 };
    //            break;
    //            case 3:
    //            simulationSelectionSides = new int [] { 0, 1 };
    //            break;
    //            case 4:
    //            simulationSelectionSides = new int [] { 2 };
    //            break;
    //            case 5:
    //            simulationSelectionSides = new int [] { 0, 2 };
    //            break;
    //            case 6:
    //            simulationSelectionSides = new int [] { 1, 2 };
    //            break;
    //            case 7:
    //            simulationSelectionSides = new int [] { 0, 1, 2 };
    //            break;
    //            case 8:
    //            simulationSelectionSides = new int [] { 3 };
    //            break;
    //            case 9:
    //            simulationSelectionSides = new int [] { 0, 3 };
    //            break;
    //            case 10:
    //            simulationSelectionSides = new int [] { 1, 3 };
    //            break;
    //            case 11:
    //            simulationSelectionSides = new int [] { 0, 1, 3 };
    //            break;
    //            case 12:
    //            simulationSelectionSides = new int [] { 2, 3 };
    //            break;
    //            case 13:
    //            simulationSelectionSides = new int [] { 0, 2, 3 };
    //            break;
    //            case 14:
    //            simulationSelectionSides = new int [] { 1, 2, 3 };
    //            break;
    //            case 15:
    //            simulationSelectionSides = new int [] { 0, 1, 2, 3 };
    //            break;
    //            default:
    //            simulationSelectionSides = new int [] { };
    //            break;
    //        }

    //        return simulationSelectionSides;
    //    }


    //    [TestCase( "0", "Schabowy z frytkami/ryżem/ziemniakami", "30zł", "" )]
    //    [TestCase( "1", "Schabowy z frytkami/ryżem/ziemniakami - 30zł", "35zł", "Bar sałatkowy -5zł." )]
    //    [TestCase( "2", "Schabowy z frytkami/ryżem/ziemniakami - 30zł", "36zł", "Zestaw sosów -6zł." )]
    //    [TestCase( "3", "Schabowy z frytkami/ryżem/ziemniakami - 30zł", "41zł", "Bar sałatkowy -5zł,Zestaw sosów -6zł." )]

    //    public void TestAddOrderToFormMenuListViewOrderAndCheckingDownloadOfEachMainDidhesWithSidesSelectedSides( int simulationSelectionSides, string expectationsName, string expectationsPrice, string expectationsSides )
    //    {
    //        FormMenu form = new FormMenu();
    //        OnEventTest  onEvent = new OnEventTest();
    //        onEvent.SetLogic( new LogicMenuButtonTest( form, ButtonLoadMenu.MainDishes ) );
    //        form.QTextbox.Text = "1";
    //        DishesListViewTest.SelectionSimulation = 0;
    //        new AddOrderListViewTest( form, SimulationSelectionSides( simulationSelectionSides ) ).LogicSettings();

    //        var order = new OrderListView(form).GetElement();
    //        var dish = order.ListDishes[0];

    //        var currentName = dish.Name;
    //        var currentSides = dish.Sides;
    //        var currentPrice = dish.Price;

    //        Assert.AreEqual( expectationsName, currentName );
    //        Assert.AreEqual( expectationsPrice, currentPrice );
    //        Assert.AreEqual( expectationsSides, currentSides );
    //    }

    //    [TestCase( "Schabowy z frytkami/ryżem/ziemniakami", "30zł", "", "0" )]
    //    [TestCase( "Ryba z frytkami", "28zł", "", "1" )]
    //    [TestCase( "Placek po węgiersku", "27zł", "", "2" )]
    //    public void TestAddOrderToFormMenuListViewOrderAndCheckingDownloadOfEachMainDishes( string expectationsName, string expectationsPrice, string expectationsSides, int simulationChoosingDish )
    //    {
    //        FormMenu form = new FormMenu();
    //        OnEventTest  onEvent = new OnEventTest();
    //        onEvent.SetLogic( new LogicMenuButtonTest( form, ButtonLoadMenu.MainDishes ) );
    //        form.QTextbox.Text = "1";
    //        DishesListViewTest.SelectionSimulation = simulationChoosingDish;
    //        int []simulationSelectionSides={};
    //        new AddOrderListViewTest( form, simulationSelectionSides ).LogicSettings();

    //        var order = new OrderListView(form).GetElement();
    //        var dish = order.ListDishes[0];

    //        var currentName = dish.Name;
    //        var currentSides = dish.Sides;
    //        var currentPrice = dish.Price;

    //        Assert.AreEqual( expectationsName, currentName );
    //        Assert.AreEqual( expectationsPrice, currentPrice );
    //        Assert.AreEqual( expectationsSides, currentSides );
    //    }

    //    [TestCase( "Schabowy z frytkami/ryżem/ziemniakami - 30zł", "41zł", "Bar sałatkowy -5zł,Zestaw sosów -6zł.", "0" )]
    //    [TestCase( "Ryba z frytkami - 28zł", "39zł", "Bar sałatkowy -5zł,Zestaw sosów -6zł.", "1" )]
    //    [TestCase( "Placek po węgiersku - 27zł", "38zł", "Bar sałatkowy -5zł,Zestaw sosów -6zł.", "2" )]
    //    public void TestAddOrderToFormMenuListViewOrderAndCheckingDownloadOfEachMainDishesWithSidesAll( string expectationsName, string expectationsPrice, string expectationsSides, int simulationChoosingDish )
    //    {
    //        FormMenu form = new FormMenu();
    //        OnEventTest  onEvent = new OnEventTest();
    //        onEvent.SetLogic( new LogicMenuButtonTest( form, ButtonLoadMenu.MainDishes ) );
    //        form.QTextbox.Text = "1";
    //        DishesListViewTest.SelectionSimulation = simulationChoosingDish;
    //        int [] simulationSelectionSides ={ 0,1 };
    //        new AddOrderListViewTest( form, simulationSelectionSides ).LogicSettings();

    //        var order = new OrderListView(form).GetElement();
    //        var dish = order.ListDishes[0];

    //        var currentName = dish.Name;
    //        var currentSides = dish.Sides;
    //        var currentPrice = dish.Price;

    //        Assert.AreEqual( expectationsName, currentName );
    //        Assert.AreEqual( expectationsPrice, currentPrice );
    //        Assert.AreEqual( expectationsSides, currentSides );
    //    }

    //    [TestCase( "Pomidorowa", "12zł", "", "0" )]
    //    [TestCase( "Rosół", "10zł", "", "1" )]
    //    public void TestAddOrderToFormMenuListViewOrderAndCheckingDownloadOfEachSoups( string expectationsName, string expectationsPrice, string expectationsSides, int simulationChoosingDish )
    //    {
    //        FormMenu form = new FormMenu();
    //        OnEventTest  onEvent = new OnEventTest();
    //        onEvent.SetLogic( new LogicMenuButtonTest( form, ButtonLoadMenu.Soups ) );
    //        form.QTextbox.Text = "1";
    //        DishesListViewTest.SelectionSimulation = simulationChoosingDish;
    //        int []simulationSelectionSides={};
    //        new AddOrderListViewTest( form, simulationSelectionSides ).LogicSettings();

    //        var order = new OrderListView(form).GetElement();
    //        var dish = order.ListDishes[0];

    //        var currentName = dish.Name;
    //        var currentSides = dish.Sides;
    //        var currentPrice = dish.Price;

    //        Assert.AreEqual( expectationsName, currentName );
    //        Assert.AreEqual( expectationsPrice, currentPrice );
    //        Assert.AreEqual( expectationsSides, currentSides );
    //    }

    //    [TestCase( "Kawa", "5zł", "", "0" )]
    //    [TestCase( "Herbata", "5zł", "", "1" )]
    //    [TestCase( "Cola", "5zł", "", "2" )]
    //    public void TestAddOrderToFormMenuListViewOrderAndCheckingDownloadOfEachDrinks( string expectationsName, string expectationsPrice, string expectationsSides, int simulationChoosingDish )
    //    {
    //        FormMenu form = new FormMenu();
    //        OnEventTest  onEvent = new OnEventTest();
    //        onEvent.SetLogic( new LogicMenuButtonTest( form, ButtonLoadMenu.Drinks ) );
    //        form.QTextbox.Text = "1";
    //        DishesListViewTest.SelectionSimulation = simulationChoosingDish;
    //        int []simulationSelectionSides={};
    //        new AddOrderListViewTest( form, simulationSelectionSides ).LogicSettings();

    //        var order = new OrderListView(form).GetElement();
    //        var dish = order.ListDishes[0];

    //        var currentName = dish.Name;
    //        var currentSides = dish.Sides;
    //        var currentPrice = dish.Price;

    //        Assert.AreEqual( expectationsName, currentName );
    //        Assert.AreEqual( expectationsPrice, currentPrice );
    //        Assert.AreEqual( expectationsSides, currentSides );
    //    }

    //    [TestCase( "Margheritta", "20zł", "", "0" )]
    //    [TestCase( "Margheritta", "20zł", "", "1" )]
    //    [TestCase( "Margheritta", "20zł", "", "2" )]
    //    public void TestAddOrderToFormMenuListViewOrderFromThreeRepeatsProduct( string expectationsName, string expectationsPrice, string expectationsSides, int index )
    //    {
    //        FormMenu form = new FormMenu();
    //        OnEventTest  onEvent = new OnEventTest();
    //        onEvent.SetLogic( new LogicMenuButtonTest( form, ButtonLoadMenu.Pizza ) );
    //        form.QTextbox.Text = "1";
    //        DishesListViewTest.SelectionSimulation = 0;
    //        int []simulationSelectionSides={};
    //        new AddOrderListViewTest( form, simulationSelectionSides ).LogicSettings();

    //        var order = new OrderListView(form).GetElement();
    //        var dish = order.ListDishes[0];

    //        var currentName = dish.Name;
    //        var currentSides = dish.Sides;
    //        var currentPrice = dish.Price;

    //        Assert.AreEqual( expectationsName, currentName );
    //        Assert.AreEqual( expectationsPrice, currentPrice );
    //        Assert.AreEqual( expectationsSides, currentSides );
    //    }

    //    [TestCase( "a" )]
    //    [TestCase( "b" )]
    //    [TestCase( "c" )]
    //    [TestCase( "" )]
    //    [TestCase( "1b" )]
    //    public void TestAddOrderToFormMenuListViewOrderAndWronglyEnteredProductAmount( string productQuantity )
    //    {
    //        FormMenu form = new FormMenu();
    //        OnEventTest  onEvent = new OnEventTest();
    //        onEvent.SetLogic( new LogicMenuButtonTest( form, ButtonLoadMenu.MainDishes ) );
    //        form.QTextbox.Text = productQuantity;
    //        DishesListViewTest.SelectionSimulation = 0;
    //        int []simulationSelectionSides={};
    //        new AddOrderListViewTest( form, simulationSelectionSides ).LogicSettings();

    //        var expectationsListViewOrderCount = 0;
    //        var currentListViewOrderCount = form.ListViewOrder.Items.Count;

    //        Assert.AreEqual( expectationsListViewOrderCount, currentListViewOrderCount );
    //    }
    //}
}

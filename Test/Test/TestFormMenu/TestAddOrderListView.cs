using System;
using System.Collections.Generic;
using NUnit.Framework;
using Pizza;

namespace Test.Test.TestFormMenu
{
    [TestFixture]
    public class TestAddOrderListView
    {

        FormMenu CreateFormMenu ()
        {
            var form =  new FormMenu();
            form.QTextbox.Text = "1";
            return form;
        }

        FormMenu CreateFormMenu (string number)
        {
            var form =  new FormMenu();
            form.QTextbox.Text = number;
            return form;
        }

        [TestCase]
        public void SetPrice_CheckCalculationPriceWithSides_RetrunPriceFourAndNameWithPriceDish ()
        {
            var form = CreateFormMenu();
            var listDishes = new FakeListDishes();
            var addOrder = new AddOrder(form,listDishes);
            var priceCalculation = new FakeCalculationsPrice();
            addOrder.SetPrice( priceCalculation );
            var getDish = new FakeCreateDishes();
            var getSides = new FakeCreateThreeSides();
            addOrder.SetOrder( getDish, getSides );
            var dish = listDishes.DishesList;

            var  currentPrice  = dish[0].Price;
            var  currentDishName = dish[0].Name; 

            Assert.AreEqual( "4zł", currentPrice );
            Assert.AreEqual( "Margheritta - 22zł", currentDishName );
        }

        [TestCase]
        public void SetPrice_CheckCalculationPriceEmptySides_RetrunPriceTwentyTwoAndNameWithoutPrice ()
        {
            var form = CreateFormMenu();
            var listDishes = new FakeListDishes();
            var addOrder = new AddOrder(form,listDishes);
            var priceCalculation = new FakeCalculationsPrice();
            addOrder.SetPrice( priceCalculation );
            var getDish = new FakeCreateDishes();
            var getSides = new FakeCreateEmptySides();
            addOrder.SetOrder( getDish, getSides );
            var dish = listDishes.DishesList;

            var  currentPrice  =dish[0].Price;
            var  currentDishName = dish[0].Name;

            Assert.AreEqual( "22zł", currentPrice );
            Assert.AreEqual( "Margheritta", currentDishName );
        }

        [TestCase( "1" )]
        [TestCase( "2" )]
        [TestCase( "3" )]
        [TestCase( "4" )]
        [TestCase( "5" )]
        [TestCase( "6" )]
        [TestCase( "7" )]
        [TestCase( "8" )]
        [TestCase( "9" )]
        [TestCase( "10" )]
        [TestCase( "20" )]
        [TestCase( "120" )]
        [TestCase( "1323" )]
        public void SetOrder_ChangeOrderQuantity_RetrunCountListIsIdenticalQuantity ( string number)
        {
            var form = CreateFormMenu(number);
            var listDishes = new FakeListDishes();
            var addOrder = new AddOrder(form,listDishes);
            var priceCalculation = new FakeCalculationsPrice();
            addOrder.SetPrice( priceCalculation );
            var getDish = new FakeCreateDishes();
            var getSides = new FakeCreateEmptySides();
            addOrder.SetOrder( getDish, getSides );
            

            var  currentLenght = listDishes.DishesList.Count;
            var expectationsNumber = Convert.ToInt32(number);

            Assert.AreEqual( expectationsNumber, currentLenght );
        }

    }

    internal class FakeListDishes : IListSet<Dish>
    {
        public List<Dish> DishesList { get; private set; }

        public void SetList ( List<Dish> elements )
        {
            DishesList = elements;
        }
    }

    internal class FakeCalculationsPrice : IPrice
    {
        public double FindPriceAndConvertToDoubel ( string dish )
        {
           return 1;
        }

        public double GetPricaAll ()
        {
           return 1;
        }
    }

    internal class FakeCreateDishes : IElementGet<Dish>
    {
        public Dish GetElement ()
        {
          return  new Dish 
          {
            Name = "Margheritta",
            Price = "22zł"
          };
        }
    }

    internal class FakeCreateThreeSides : IListGet<string>
    {
        public List<string> GetList ()
        {
            return new List<string> {"pieczarki", "salami", "szynka" };
        }
    }

    internal class FakeCreateEmptySides : IListGet<string>
    {
        public List<string> GetList ()
        {
            return new List<string>();
        }
    }

    internal class DialogBox : IDialogService
    {
        public string Message { get; private set; }
        public void ShowMessage ( string message )
        {
            Message = message;
        }
    }
}

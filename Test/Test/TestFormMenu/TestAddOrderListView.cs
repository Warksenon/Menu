using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizza;

namespace Test.Test.TestFormMenu
{
    [TestClass]
    public class TestAddOrderListView
    {

        FormMenu CreateFormMenu ()
        {
           return new FormMenu();
        } 

        [TestMethod]
        public void TestMethod1 ()
        {
            var form = CreateFormMenu();
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
          return  new Dish {
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

}

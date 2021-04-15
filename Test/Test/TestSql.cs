using System;
using System.Collections.Generic;

using NUnit.Framework;

using Pizza;
using Pizza.Presenters;

using Test.SimulatingClassesMainProject.ModelsTest;

namespace Test.Test
{
    [TestFixture]
    public class TestSql
    {



        [TestCase( "0", "Margheritta - 20zł", "28zł", "Podwójny Ser -2zł,Salami -2zł,Szynka -2zł,Pieczarki -2zł." )]
        [TestCase( "1", "Margheritta", "20zł","")]
        public void TestFirstAddOneOrderToSqlAndLoadTestListDishes( int index, string expectationsName, string expectationsPrice, string expectationsSides )
        {
            DeleteData();
            Order  orderToSave =  CreateOrderFirst();
            SaveOrder save = new SaveOrder();
            save.AddOrder( new SaveOrderSQLTest( orderToSave ) );

            LoadOrder load = new LoadOrder();
            List<Order>  orderToLoad = load.LoadOrderList(new LoadHistorySQLTest());

            var expectationIdDish = 1;

            var currentNameDish =  orderToLoad[0].ListDishes[index].Name;
            var currentPriceDish = orderToLoad[0].ListDishes[index].Price;
            var currentSidesDish = orderToLoad[0].ListDishes[index].Sides;
            var currentIdDish =  orderToLoad[0].ListDishes[index].Id;

            Assert.AreEqual( expectationsName, currentNameDish );
            Assert.AreEqual( expectationsPrice, currentPriceDish );
            Assert.AreEqual( expectationsSides, currentSidesDish );
            Assert.AreEqual( expectationIdDish, currentIdDish );
        }

        void DeleteData()
        {
            IDataCleansing data=new SaveHistorySQLTest();
            data.DeleteData();
        }

        Order CreateOrderFirst()
        {
            Order  order = new Order();
            Dish dishWithSides = new Dish()
            {
                Name = "Margheritta - 20zł",
                Price="28zł",
                Sides="Podwójny Ser -2zł,Salami -2zł,Szynka -2zł,Pieczarki -2zł."
            };

            Dish dishWithoutSides = new Dish()
            {
                Name = "Margheritta",
                Price="20zł",
                Sides=""
            };

            PriceAll priceAll = new PriceAll()
            {
                Price = "48zł",
                Date = "05.04.2021 00:10:54",
                Comments = "one sauce"
            };
            order.AddDishToListDisch( dishWithSides );
            order.AddDishToListDisch( dishWithoutSides );
            order.PriceAll = priceAll;

            return order;
        }

        Order CreateOrderSecond()
        {
            Order  order = new Order();
            Dish dishWithSides = new Dish()
            {
                Name = "Margheritta - 20zł",
                Price="28zł",
                Sides="Podwójny Ser -2zł,Salami -2zł,Szynka -2zł,Pieczarki -2zł."
            };

            Dish dishWithoutSides = new Dish()
            {
                Name = "Margheritta",
                Price="20zł",
                Sides=""
            };

            PriceAll priceAll = new PriceAll()
            {
                Price = "48zł",
                Date = "05.04.2021 00:10:54",
                Comments = "one sauce"
            };
            order.AddDishToListDisch( dishWithSides );
            order.AddDishToListDisch( dishWithoutSides );
            order.PriceAll = priceAll;

            return order;
        }


        [TestCase( "1", "48zł", "05.04.2021 00:10:54", "one sauce", "0" )]
        public void TestAddTwoOrderToSqlAndLoadTestPrice( int expectationId, string expectationsPrice, string expectationDate, string expectationComments, int index )
        {
            DeleteData();
            Order  orderToSave =  CreateOrderFirst();
            SaveOrder save = new SaveOrder();
            save.AddOrder( new SaveOrderSQLTest( orderToSave ) );
            orderToSave = CreateOrderSecond();
            save.AddOrder( new SaveOrderSQLTest( orderToSave ) );
            LoadOrder load = new LoadOrder();
            List<Order>  orderToLoad = load.LoadOrderList(new LoadHistorySQLTest());

            var currentnPricePriceAll = orderToLoad[index].PriceAll.Price;
            var currentDatePriceAll =   orderToLoad[index].PriceAll.Date;
            var currentCommentsPriceAll = orderToLoad[index].PriceAll.Comments;
            var currentIdPriceAll = orderToLoad[index].PriceAll.ID;


            Assert.AreEqual( expectationsPrice, currentnPricePriceAll );
            Assert.AreEqual( expectationDate, currentDatePriceAll );
            Assert.AreEqual( expectationComments, currentCommentsPriceAll );
            Assert.AreEqual( expectationId, currentIdPriceAll );
        }


    }
}

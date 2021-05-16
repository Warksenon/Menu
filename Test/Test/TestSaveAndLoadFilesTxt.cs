using System.Collections.Generic;

using NUnit.Framework;

using Pizza;

using Test.SimulatingClassesMainProject.ModelsTest;

namespace Test.Test
{
    [TestFixture]
    public class TestSaveAndLoadFilesTxt
    {
        [TestCase( "0", "Margheritta - 20zł", "28zł", "Podwójny Ser -2zł,Salami -2zł,Szynka -2zł,Pieczarki -2zł." )]
        [TestCase( "1", "Margheritta", "20zł", "" )]
        public void TestFirstAddOneOrderToFilesTxtAndLoadTestListDishes( int index, string expectationsName, string expectationsPrice, string expectationsSides )
        {
            DeleteData();
            Order  orderToSave =  CreateOrderFirst();
            new SaveFilesOrderTest( orderToSave );

            Pizza.IListGet<Order> load = new LoadingFilesTxtTest();
            var  orderToLoad = load.GetList();
            var currentNameDish =  orderToLoad[0].ListDishes[index].Name;
            var currentPriceDish = orderToLoad[0].ListDishes[index].Price;
            var currentSidesDish = orderToLoad[0].ListDishes[index].Sides;


            Assert.AreEqual( expectationsName, currentNameDish );
            Assert.AreEqual( expectationsPrice, currentPriceDish );
            Assert.AreEqual( expectationsSides, currentSidesDish );
        }

        private void DeleteData()
        {
            IDataCleansing data=new SaveFilesHistoryOrderTest();
            data.DeleteData();
        }

        private Order CreateOrderFirst()
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

        private Order CreateOrderSecond()
        {
            Order  order = new Order();
            Dish dishWithSides = new Dish()
            {
                Name = "Venecia - 25zł",
                Price="27zł",
                Sides="Salami -2zł."
            };

            Dish dishWithoutSides = new Dish()
            {
                Name = "Schabowy z frytkami/ryżem/ziemniakami",
                Price="30zł",
                Sides=""
            };

            PriceAll priceAll = new PriceAll()
            {
                Price = "57zł",
                Date = "05.03.2021 00:10:54",
                Comments = "two sauce"
            };

            order.AddDishToListDisch( dishWithSides );
            order.AddDishToListDisch( dishWithoutSides );
            order.PriceAll = priceAll;

            return order;
        }

        [TestCase( "48zł", "05.04.2021 00:10:54", "one sauce", "0" )]
        [TestCase( "57zł", "05.03.2021 00:10:54", "two sauce", "1" )]
        public void TestAddTwoOrderToFilesTxtAndLoadTestPrice( string expectationsPrice, string expectationDate, string expectationComments, int index )
        {
            DeleteData();
            Order  orderToSave =  CreateOrderFirst();
            new SaveFilesOrderTest( orderToSave );
            orderToSave = CreateOrderSecond();
            new SaveFilesOrderTest( orderToSave );

            Pizza.IListGet<Order> load =  new LoadingFilesTxtTest();
            var orderToLoad = load.GetList();
            var currentnPricePriceAll = orderToLoad[index].PriceAll.Price;
            var currentDatePriceAll =   orderToLoad[index].PriceAll.Date;
            var currentCommentsPriceAll = orderToLoad[index].PriceAll.Comments;

            Assert.AreEqual( expectationsPrice, currentnPricePriceAll );
            Assert.AreEqual( expectationDate, currentDatePriceAll );
            Assert.AreEqual( expectationComments, currentCommentsPriceAll );
        }

        [TestCase( "48zł", "05.04.2021 00:10:54", "one sauce", "0" )]
        [TestCase( "57zł", "05.03.2021 00:10:54", "two sauce", "1" )]
        public void TestSaveListOrderToFilesTxtAndLoadTestPrice( string expectationsPrice, string expectationDate, string expectationComments, int index )
        {
            Order  orderFirst =  CreateOrderFirst();
            Order  orderSecond = CreateOrderSecond();
            List<Order> orderList = new List<Order>
            {
                orderFirst,
                orderSecond
            };
            SaveFilesHistoryOrderTest save = new SaveFilesHistoryOrderTest();
            save.SaveHistoryOrders( orderList );

            Pizza.IListGet<Order> load =  new LoadingFilesTxtTest();
            var orderToLoad = load.GetList();
            var currentnPricePriceAll = orderToLoad[index].PriceAll.Price;
            var currentDatePriceAll =   orderToLoad[index].PriceAll.Date;
            var currentCommentsPriceAll = orderToLoad[index].PriceAll.Comments;

            Assert.AreEqual( expectationsPrice, currentnPricePriceAll );
            Assert.AreEqual( expectationDate, currentDatePriceAll );
            Assert.AreEqual( expectationComments, currentCommentsPriceAll );
        }

        [TestCase( "0", "Margheritta - 20zł", "28zł", "Podwójny Ser -2zł,Salami -2zł,Szynka -2zł,Pieczarki -2zł.", "0", "0" )]
        [TestCase( "0", "Margheritta", "20zł", "", "0", "1" )]
        [TestCase( "0", "Venecia - 25zł", "27zł", "Salami -2zł.", "1", "0" )]
        [TestCase( "0", "Schabowy z frytkami/ryżem/ziemniakami", "30zł", "", "1", "1" )]
        public void TestSaveListOrderToFilesTxtAndLoadTestDishes( int expectationId, string expectationsName, string expectationPrice, string expectationSides, int idexOrder, int indexDish )
        {
            Order  orderFirst =  CreateOrderFirst();
            Order  orderSecond = CreateOrderSecond();
            List<Order> orderList = new List<Order>
            {
                orderFirst,
                orderSecond
            };
            SaveFilesHistoryOrderTest save = new SaveFilesHistoryOrderTest();
            save.SaveHistoryOrders( orderList );

            Pizza.IListGet<Order> load =  new LoadingFilesTxtTest();
            var orderToLoad = load.GetList();
            var currentNameDish =  orderToLoad[idexOrder].ListDishes[indexDish].Name;
            var currentPriceDish = orderToLoad[idexOrder].ListDishes[indexDish].Price;
            var currentSidesDish = orderToLoad[idexOrder].ListDishes[indexDish].Sides;
            var currentIdDish =  orderToLoad[idexOrder].ListDishes[indexDish].Id;

            Assert.AreEqual( expectationsName, currentNameDish );
            Assert.AreEqual( expectationPrice, currentPriceDish );
            Assert.AreEqual( expectationSides, currentSidesDish );
            Assert.AreEqual( expectationId, currentIdDish );
        }
    }
}

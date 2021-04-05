using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizza;

namespace Test.Test
{
    [TestClass]
    public class TestEmailMessage
    {
        Order order = new Order();
        EmailMessage emailMessage;


        [TestMethod]
        public void TestMethod1()
        {
            order.ListDishes.Add(CreateDishwWthoutSides());
            emailMessage = new EmailMessage(order);

            string message = "###################################################\r\n"+
                             "#\r\n"+
                             "#               05.04.2021 00:10:54                \n" +
                             "#                     Cena: 20zł                  \n" +
                             "#\r\n" +
                             "###################################################\r\n"+
                             "###################################################\r\n"+
                             "#\r\n"+
                             "# Margheritta\n"+
                             "# Cenna za danie: 20zł\n"+
                             "#\r\n"+
                             "###################################################\r\n"+
                             "Uwagi do zamówienia: \n";
           
            Assert.AreEqual(message, emailMessage.WriteBill());
        }

        Dish CreateDishwWthoutSides()
        {
            return new Dish
            {
                Name = "Margheritta",
                Sides = "",
                Price = "20zł"
            };
        }

        PriceAll CreatePriceAllWthoutSides()
        {
            return new PriceAll
            {
                Price = "20zł",
                Comments = "",
                Date = "05.04.2021 00:10:54"
            };
        }


        [TestMethod]
        public void TestMethod2()
        {
            order.ListDishes.Add(CreateDishwWithSides());
            order.PriceAll = CreatePriceAllWithSides();
            emailMessage = new EmailMessage(order);

            string message =    "###################################################\r\n" +
                                "#\r\n" +
                                "#               05.04.2021 00:10:54                \n" +
                                "#                     Cena: 28zł                  \n" +
                                "#\r\n"+
                                "###################################################\r\n"+
                                "###################################################\r\n" +
                                "#\r\n" +
                                "# Margheritta\n" +
                                "# Podwójny Ser -2zł\r\n"+
                                "# Salami -2zł\r\n"+
                                "# Szynka -2zł\r\n"+
                                "# Pieczarki -2zł\r\n"+
                                "# Cenna za danie: 20zł\n"+
                                "#\r\n"+
                                "###################################################\r\n"+
                                "Uwagi do zamówienia: \n";
 
            Assert.AreEqual(message, emailMessage.WriteBill());
        }

        Dish CreateDishwWithSides()
        {
            return new Dish
            {
                Name = "Margheritta",
                Sides = "Podwójny Ser -2zł,Salami -2zł,Szynka -2zł,Pieczarki -2zł,",
                Price = "20zł"
            };
        }

        PriceAll CreatePriceAllWithSides()
        {
            return new PriceAll
            {
                Price = "28zł",
                Comments = "",
                Date = "05.04.2021 00:10:54"
            };
        }
    }
}

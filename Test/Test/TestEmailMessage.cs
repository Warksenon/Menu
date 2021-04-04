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
                             "#                                                  \n"+
                             "#                     Cena:                       \n"+
                             "#\r\n"+
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


        [TestMethod]
        public void TestMethod2()
        {
            order.ListDishes.Add(CreateDishwWithSides());
            emailMessage = new EmailMessage(order);

            string message =    "###################################################\r\n" +
                                "#\r\n" +
                                "#                                                  \n" +
                                "#                     Cena:                       \n" +
                                "#\r\n###################################################\r\n"+
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

    }
}

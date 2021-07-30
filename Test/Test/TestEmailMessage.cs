using Microsoft.VisualStudio.TestTools.UnitTesting;

using Pizza;

namespace Test.Test
{
    //[TestClass]
    //public class TestEmailMessage
    //{
    //    private Order order;
    //    private EmailMessage emailMessage;

    //    [TestMethod]
    //    public void TestCreateMessageWithOneDishWithoutSides ()
    //    {
    //        order = CreateOrderWthoutSides();
    //        emailMessage = new EmailMessage( order );

    //        string expectationsMessage = "###################################################\r\n" +
    //                         "#\r\n" +
    //                         "#               05.04.2021 00:10:54                \n" +
    //                         "#                     Cena: 20zł                  \n" +
    //                         "#\r\n" +
    //                         "###################################################\r\n" +
    //                         "###################################################\r\n" +
    //                         "#\r\n" +
    //                         "# Margheritta\n" +
    //                         "# Cenna za danie: 20zł\n" +
    //                         "#\r\n" +
    //                         "###################################################\r\n" +
    //                         "Uwagi do zamówienia: \n";

    //        string result = emailMessage.WriteBill();

    //        Assert.AreEqual( expectationsMessage, result );
    //    }

    //    private Order CreateOrderWthoutSides ()
    //    {
    //        Order order = new Order();
    //        order.ListDishes.Add( CreateDishwWthoutSides() );
    //        order.PriceAll = CreatePriceAllWthoutSides();
    //        return order;
    //    }

    //    private Dish CreateDishwWthoutSides ()
    //    {
    //        return new Dish
    //        {
    //            Name = "Margheritta",
    //            Sides = "",
    //            Price = "20zł"
    //        };
    //    }

    //    private PriceAll CreatePriceAllWthoutSides ()
    //    {
    //        return new PriceAll
    //        {
    //            Price = "20zł",
    //            Comments = "",
    //            Date = "05.04.2021 00:10:54"
    //        };
    //    }


    //    [TestMethod]
    //    public void TestCreateMessageWithOneDishAndSides ()
    //    {
    //        order = CreateorderWithSides();
    //        emailMessage = new EmailMessage( order );

    //        string expectationsMessage = "###################################################\r\n" +
    //                            "#\r\n" +
    //                            "#               05.04.2021 00:10:54                \n" +
    //                            "#                     Cena: 28zł                  \n" +
    //                            "#\r\n" +
    //                            "###################################################\r\n" +
    //                            "###################################################\r\n" +
    //                            "#\r\n" +
    //                            "# Margheritta\n" +
    //                            "# Podwójny Ser -2zł\r\n" +
    //                            "# Salami -2zł\r\n" +
    //                            "# Szynka -2zł\r\n" +
    //                            "# Pieczarki -2zł\r\n" +
    //                            "# Cenna za danie: 20zł\n" +
    //                            "#\r\n" +
    //                            "###################################################\r\n" +
    //                            "Uwagi do zamówienia: \n";

    //        string result = emailMessage.WriteBill();

    //        Assert.AreEqual( expectationsMessage, result );
    //    }

    //    private Order CreateorderWithSides ()
    //    {
    //        Order order = new Order();
    //        order.ListDishes.Add( CreateDishwWithSides() );
    //        order.PriceAll = CreatePriceAllWithSides();

    //        return order;
    //    }

    //    private Dish CreateDishwWithSides ()
    //    {
    //        return new Dish
    //        {
    //            Name = "Margheritta",
    //            Sides = "Podwójny Ser -2zł,Salami -2zł,Szynka -2zł,Pieczarki -2zł,",
    //            Price = "20zł"
    //        };
    //    }

    //    private PriceAll CreatePriceAllWithSides ()
    //    {
    //        return new PriceAll
    //        {
    //            Price = "28zł",
    //            Comments = "",
    //            Date = "05.04.2021 00:10:54"
    //        };
    //    }
    //}
}

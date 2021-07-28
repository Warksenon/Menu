using System;
using NUnit.Framework;
using Pizza;
using Pizza.Presenters.PresenterFormMenu;

namespace Test.Test.TestFormMenu
{
    [TestFixture]
    public class TestOrderListView
    {
        [TestCase( "200 zł","200"  )]
        [TestCase( "10 zł", "10" )]
        [TestCase( "1 zł", "1" )]
        [TestCase( "0 zł", "0" )]
        [TestCase( "0 ", "0" )]
        [TestCase( "", "0" )]
        [TestCase( "101  zł", "101" )]
        [TestCase( "1  0  3  zł", "103" )]
        [TestCase( "1  0 aa 1  zł", "0" )]
        [TestCase( "zł", "0" )]
        [TestCase( "bbbb", "0" )]
        [TestCase( "3300 ", "3300" )]
        public void FindPriceAndConvertToDoubel_SetPriceText_ReturnDoubel (string textPrice, double expectePrice)
        {
            var form = FormTest.CreateFormMenu();
            var lvOrder = new OrderListView(form);

            var currentPrice = lvOrder.FindPriceAndConvertToDoubel(textPrice);

            Assert.AreEqual( expectePrice, currentPrice );
        }
    }
}

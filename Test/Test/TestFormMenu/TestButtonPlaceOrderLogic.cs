using System;
using NUnit.Framework;
using Pizza;
using Pizza.Presenters;
using Pizza.Presenters.PresenterFormMenu;

namespace Test.Test.TestFormMenu
{
    [TestFixture]
    public class TestButtonPlaceOrderLogic
    {
         FormMenu CreateForm ()
        {
            return new FormMenu();
        }

        [TestCase ("false", "Wysłanie wiadomości nie powiodło się. Problem z adres e-mail lub z połaczeniem internetowym" )]
        [TestCase( "true", "Zamówienie zostało złożone" )]
        public void SendOrder_CheckDialogForFlagSendMessage_ReturnDialog ( bool flag, string expectationsDialog )
        {
            var form = CreateForm();
            var dialog = new FakeDialog();
            ButtonPlaceOrderLogic button = new ButtonPlaceOrderLogic(form,dialog);
            var order = new FakeCreateOrder();
            var sendMessage = new FakeSenderMessage();
            sendMessage.Flag = flag;
            button.SetOrder( order, sendMessage );

            var currentDialog = dialog.Message;

            Assert.AreEqual( expectationsDialog, currentDialog );
        }

        [TestCase()]
        public void RunPlaceOrder_CheckDialog_ReturnDialogListIsNot ()
        {
            var form = CreateForm();
            var dialog = new FakeDialog();
            ButtonPlaceOrderLogic button = new ButtonPlaceOrderLogic(form,dialog);
            var order = new FakeCreateOrderEmpty();
            var sendMessage = new FakeSenderMessage();            
            button.SetOrder( order, sendMessage );
           
            var currentDialog = dialog.Message;

            Assert.AreEqual( "Proszę wybrać produkt", currentDialog );
        }

        [TestCase()]
        public void RunPlaceOrder_CheckDialogTwoPressButton_ReturnDialogListIsNot ()
        {
            var form = CreateForm();
            var dialog = new FakeDialog();
            ButtonPlaceOrderLogic button = new ButtonPlaceOrderLogic(form,dialog);
            var order = new FakeCreateOrder();
            var sendMessage = new FakeSenderMessage();
            button.SetOrder( order, sendMessage );
            button.SetOrder( order, sendMessage );         

            var currentDialog = dialog.Message;

            Assert.AreEqual( "Przetwarzanie danych proszę czekać", currentDialog );
        }

        [TestCase( "false","","" )]
        [TestCase( "true", "Margheritta", "22zł" )]
        public void SaveOrder ( bool flag, string name, string price)
        {
            var form = CreateForm();
            var dialog = new FakeDialog();
            ButtonPlaceOrderLogic button = new ButtonPlaceOrderLogic(form,dialog);
            var order = new FakeCreateOrder();
            var sendMessage = new FakeSenderMessage();
            sendMessage.Flag = flag;
            button.SetOrder( order, sendMessage );
            var saveData = new FakeSaveData();
            button.SaveOrder( saveData );

            var currentName = saveData.Order.ListDishes[0].Name;
            var currentPrice = saveData.Order.ListDishes[0].Price;

            Assert.AreEqual( name, currentName );
            Assert.AreEqual( price, currentPrice );
        }
    }

    internal class FakeDialog : IDialogService
    {
        public string Message { get; private set; }

        public void ShowMessage ( string message )
        {
            Message = message;
        }
    }

    internal class FakeSenderMessage : ISendOrder
    {
        public  bool Flag { get; set; }

        public bool SendMessag ( IElementGet<Order> element )
        {
            return Flag;
        }
    }

    internal class FakeSaveData : IElementSet<Order>
    {
        public Order Order { get; private set; }

        public void SetElement ( Order elements )
        {
            Order = elements;
        }
    }

    internal class FakeCreateOrderEmpty : IElementGet<Order>
    {
        public Order GetElement ()
        {
            return new Order();
        }
    }

    internal class FakeCreateOrder : IElementGet<Order>
    {
        public Order GetElement ()
        {
            var dish = new Dish
            {
                Name = "Margheritta",
                Price = "22zł"
            };
            var order = new Order();
            order.ListDishes.Add( dish );
            return order;
           
        }
    }
}

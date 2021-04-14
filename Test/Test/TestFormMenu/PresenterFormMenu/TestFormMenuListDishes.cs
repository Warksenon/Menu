using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizza;
using Pizza.Presenters;

namespace Test.Test.TestFormMenu.PresenterFormMenu
{
    [TestClass]
    public class TestFormMenuListDishes
    {
        [TestMethod]
        public void TestMethod1 ()
        {
            FormMenu form = new FormMenu();
            form.QTextbox.Text = "3";
            OnEventTest  onEvent = new OnEventTest();
            onEvent.SetLogic( new ButtonPizzaLogic( form ) );
            onEvent.SetLogic( new FormMenuAddOrderListViewTest( form ) );
        }
    }
}

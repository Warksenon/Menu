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
            OnEventTest  onEvent = new OnEventTest();
            onEvent.SetLogic( new ButtonPizzaLogic( form ) );
            form.QTextbox.Text = "3";
            //todo Przerobic na  TestCase
            onEvent.SetLogic( new FormMenuAddOrderListViewTest( form,0 ) );
            var Name1 = form.ListViewOrder.Items [0].SubItems [0].Text;
            var Sides1 = form.ListViewOrder.Items [0].SubItems [1].Text;
            var Price1 = form.ListViewOrder.Items [0].SubItems [2].Text;

            var Name2 = form.ListViewOrder.Items [0].SubItems [0].Text;
            var Sides2 = form.ListViewOrder.Items [0].SubItems [1].Text;
            var Price2 = form.ListViewOrder.Items [0].SubItems [2].Text;

            var Name3 = form.ListViewOrder.Items [0].SubItems [0].Text;
            var Sides3 = form.ListViewOrder.Items [0].SubItems [1].Text;
            var Price3 = form.ListViewOrder.Items [0].SubItems [2].Text;

            Assert.AreEqual( "Margheritta", Name1);
            Assert.AreEqual( "", Sides1 );
            Assert.AreEqual( "20zł", Price1 );

            Assert.AreEqual( Name1, Name2 );
            Assert.AreEqual( Sides1, Sides2 );
            Assert.AreEqual( Price1, Price2 );

            Assert.AreEqual( Name1, Name3 );
            Assert.AreEqual( Sides1, Sides3 );
            Assert.AreEqual( Price1, Price3 );

        }
    }
}

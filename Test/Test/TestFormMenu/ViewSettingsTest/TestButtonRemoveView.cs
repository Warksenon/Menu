using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Test.Form1.ViewSettings
{
    [TestClass]
    public class TestButtonRemoveView : Form1Test
    {

        [TestMethod]
        public void TestViewOnClickButtonRemoveOneWithEmptyListViewOrder()
        {
            bool EmptyListViewOrder = true;
            ButtonRemoveOne buttonRemoveOne = new ButtonRemoveOne(form, EmptyListViewOrder);
            buttonRemoveOne.ButtonRemoveOne = true;
            buttonRemoveOne.ButtonRemoveAll = true;

            eevent.SetView( buttonRemoveOne );

            Assert.AreEqual( false, buttonRemoveOne.ButtonRemoveOne );
            Assert.AreEqual( false, buttonRemoveOne.ButtonRemoveAll );
        }

        [TestMethod]
        public void TestViewOnClickButtonRemoveOneWithDishesPizzaListViewOrder()
        {
            bool EmptyListViewOrder = false;
            ButtonRemoveOne buttonRemoveOne = new ButtonRemoveOne(form, EmptyListViewOrder);
            buttonRemoveOne.ButtonRemoveOne = true;
            buttonRemoveOne.ButtonRemoveAll = true;

            eevent.SetView( buttonRemoveOne );

            Assert.AreEqual( false, buttonRemoveOne.ButtonRemoveOne );
            Assert.AreEqual( true, buttonRemoveOne.ButtonRemoveAll );
        }

        [TestMethod]
        public void TestViewOnClickButtonRemoveAll()
        {
            ButtonRemoveAll buttonRemoveAll = new ButtonRemoveAll(form);
            buttonRemoveAll.ButtonRemoveOne = true;
            buttonRemoveAll.ButtonRemoveAll = true;

            eevent.SetView( buttonRemoveAll );

            Assert.AreEqual( false, buttonRemoveAll.ButtonRemoveOne );
            Assert.AreEqual( false, buttonRemoveAll.ButtonRemoveAll );
        }
    }
}

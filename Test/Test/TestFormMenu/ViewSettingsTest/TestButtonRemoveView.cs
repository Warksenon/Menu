using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Test.Form1.ViewSettings
{
    [TestClass]
    public class TestButtonRemoveView : Form1Test
    {

        [TestMethod]
        public void TestViewOnClickButtonRemoveOneWithEmptyListViewOrder()
        {
            bool checkingListOrderIfEmpty = true;
            ButtonRemoveOne buttonRemoveOne = new ButtonRemoveOne(form, checkingListOrderIfEmpty);
            buttonRemoveOne.ButtonRemoveOneVisibility = true;
            buttonRemoveOne.ButtonRemoveAllVisibility = true;
            bool expectedVisibilityRemoveOne = false;
            bool expectedVisibilityRemoveAll = false;

            eevent.SetView( buttonRemoveOne );
            var  current  = buttonRemoveOne;

            Assert.AreEqual( expectedVisibilityRemoveOne, current.ButtonRemoveOneVisibility );
            Assert.AreEqual( expectedVisibilityRemoveAll, current.ButtonRemoveAllVisibility );
        }

        [TestMethod]
        public void TestViewOnClickButtonRemoveOneWithDishesPizzaListViewOrder()
        {
            bool checkingListOrderIfEmpty = false;
            ButtonRemoveOne buttonRemoveOne = new ButtonRemoveOne(form, checkingListOrderIfEmpty);
            buttonRemoveOne.ButtonRemoveOneVisibility = true;
            buttonRemoveOne.ButtonRemoveAllVisibility = true;
            bool expectedVisibilityRemoveOne = false;
            bool expectedVisibilityRemoveAll = true;

            eevent.SetView( buttonRemoveOne );
            var  current  = buttonRemoveOne;

            Assert.AreEqual( expectedVisibilityRemoveOne, current.ButtonRemoveOneVisibility );
            Assert.AreEqual( expectedVisibilityRemoveAll, current.ButtonRemoveAllVisibility );
        }

        [TestMethod]
        public void TestViewOnClickButtonRemoveAll()
        {
            ButtonRemoveAll buttonRemoveAll = new ButtonRemoveAll(form);
            bool expectedVisibilityRemoveOne = false;
            bool expectedVisibilityRemoveAll = false;

            eevent.SetView( buttonRemoveAll );
            var  current  = buttonRemoveAll;

            Assert.AreEqual( expectedVisibilityRemoveOne, current.ButtonRemoveOneVisibility );
            Assert.AreEqual( expectedVisibilityRemoveAll, current.ButtonRemoveAllVisibility );
        }
    }
}

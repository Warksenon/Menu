using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizza;
using System.Windows.Forms;

namespace Test.Test.Form1.ViewSettings
{
    [TestClass]
    public class TestButtonRemove : Form1Test
    {
        Button buttonTestRemoveOne = new Button();
        Button buttonTestRemoveAll = new Button();
        Button buttonTestSendOrder = new Button();
        ListView listViewOrder = new ListView();

        [TestMethod]
        public void TestViewOnClickButtonRemoveOneWithEmptyListViewOrder()
        {
            buttonTestRemoveOne.Visible = false;
            buttonTestRemoveAll.Visible = false;
            ButtonRemoveOne buttonRemoveOne = new ButtonRemoveOne(form);

            eevent.SetView(buttonRemoveOne);

            Assert.AreEqual(buttonTestRemoveOne.Visible, buttonRemoveOne.ButtonRemoveOne);
            Assert.AreEqual(buttonTestRemoveAll.Visible, buttonRemoveOne.ButtonRemoveAll);
        }

        [TestMethod]
        public void TestViewOnClickButtonRemoveOneWithDishesPizzaListViewOrder()
        {
            buttonTestRemoveOne.Visible = false;
            buttonTestRemoveAll.Visible = false;
            ButtonRemoveOne buttonRemoveOne = new ButtonRemoveOne(form);
            

            eevent.SetView(buttonRemoveOne);

            Assert.AreEqual(buttonTestRemoveOne.Visible, buttonRemoveOne.ButtonRemoveOne);
            Assert.AreEqual(buttonTestRemoveAll.Visible, buttonRemoveOne.ButtonRemoveAll);
        }

        [TestMethod]
        public void TestViewOnClickButtonRemoveAll()
        {
            buttonTestRemoveOne.Visible = false;
            buttonTestRemoveAll.Visible = false;
            ButtonRemoveOne buttonRemoveOne = new ButtonRemoveOne(form);

            eevent.SetView(buttonRemoveOne);

            Assert.AreEqual(buttonTestRemoveOne.Visible, buttonRemoveOne.ButtonRemoveOne);
            Assert.AreEqual(buttonTestRemoveAll.Visible, buttonRemoveOne.ButtonRemoveAll);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Test.Form1.ViewSettings
{
    [TestClass]
    public class TestButtonOk : Form1Test
    {
        [TestMethod]
        public void TestVisableButtonRemoveOneAndButtonRemoveAllFromOnClickButtonOkWhenGivenQuantityAreZeros ()
        {
            ButtonOkView buttonOk = new ButtonOkView(form);
            form.QTextbox.Text = "0";
            buttonOk.ButtonRemoveOne = true;
            buttonOk.ButtonRemoveAll = true;


            eevent.SetView(buttonOk);

            Assert.AreEqual(false, buttonOk.ButtonRemoveOne);
            Assert.AreEqual(false, buttonOk.ButtonRemoveAll);
        }

        [TestMethod]
        public void TestVisableButtonRemoveOneAndButtonRemoveAllFromOnClickButtonOkWhenGivenQuantityIsNotNumber ()
        {
            ButtonOkView buttonOk = new ButtonOkView(form);
            form.QTextbox.Text = "ddd";
            buttonOk.ButtonRemoveOne = true;
            buttonOk.ButtonRemoveAll = true;


            eevent.SetView( buttonOk );

            Assert.AreEqual( false, buttonOk.ButtonRemoveOne );
            Assert.AreEqual( false, buttonOk.ButtonRemoveAll );
        }

        [TestMethod]
        public void TestVisableButtonRemoveOneAndButtonRemoveAllFromOnClickButtonOkWhenGivenQuantityAreOne ()
        {
            ButtonOkView buttonOk = new ButtonOkView(form);
            form.QTextbox.Text = "1";
            buttonOk.ButtonRemoveOne = true;
            buttonOk.ButtonRemoveAll = false;

            eevent.SetView(buttonOk);

            Assert.AreEqual(false, buttonOk.ButtonRemoveOne);
            Assert.AreEqual(true, buttonOk.ButtonRemoveAll);
        }
    }
}

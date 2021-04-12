using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Test.Form1.ViewSettings
{
    [TestClass]
    public class TestButtonOk : Form1Test
    {
        [TestMethod]
        public void TestVisableButtonRemoveOneAndButtonRemoveAllFromOnClickButtonOkWhenGivenQuantityAreZeros()
        {
            ButtonOkView buttonOk = new ButtonOkView(form);
            form.QTextbox.Text = "0";
            buttonOk.ButtonRemoveOneVisibility = true;
            buttonOk.ButtonRemoveAllVisibility = true;


            eevent.SetView( buttonOk );

            Assert.AreEqual( false, buttonOk.ButtonRemoveOneVisibility );
            Assert.AreEqual( false, buttonOk.ButtonRemoveAllVisibility );
        }

        [TestMethod]
        public void TestVisableButtonRemoveOneAndButtonRemoveAllFromOnClickButtonOkWhenGivenQuantityIsNotNumber()
        {
            ButtonOkView buttonOk = new ButtonOkView(form);
            form.QTextbox.Text = "ddd";
            buttonOk.ButtonRemoveOneVisibility = true;
            buttonOk.ButtonRemoveAllVisibility = true;


            eevent.SetView( buttonOk );

            Assert.AreEqual( false, buttonOk.ButtonRemoveOneVisibility );
            Assert.AreEqual( false, buttonOk.ButtonRemoveAllVisibility );
        }

        [TestMethod]
        public void TestVisableButtonRemoveOneAndButtonRemoveAllFromOnClickButtonOkWhenGivenQuantityAreOne()
        {
            ButtonOkView buttonOk = new ButtonOkView(form);
            form.QTextbox.Text = "1";
            buttonOk.ButtonRemoveOneVisibility = true;
            buttonOk.ButtonRemoveAllVisibility = false;

            eevent.SetView( buttonOk );

            Assert.AreEqual( false, buttonOk.ButtonRemoveOneVisibility );
            Assert.AreEqual( true, buttonOk.ButtonRemoveAllVisibility );
        }
    }
}

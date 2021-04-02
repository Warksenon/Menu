using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace Test.Test.Form1.ViewSettings
{
    [TestClass]
    public class TestButtonOk : Form1Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            Button buttonRemoveOne = new Button();
            Button buttonRemoveAll = new Button();
            ButtonOkView buttonOk = new ButtonOkView(form);
            form.QTextbox.Text = "0";
            buttonRemoveOne.Visible = false;
            buttonRemoveAll.Visible = false;
            
            eevent.SetView(buttonOk);

            Assert.AreEqual(buttonRemoveOne.Visible, buttonOk.ButtonRemoveOne);
            Assert.AreEqual(buttonRemoveAll.Visible, buttonOk.ButtonRemoveAll);
        }


        [TestMethod]
        public void TestMethod2()
        {
            Button buttonRemoveOne = new Button();
            Button buttonRemoveAll = new Button();
            ButtonOkView buttonOk = new ButtonOkView(form);
            buttonRemoveOne.Visible = false;
            form.QTextbox.Text = "1";

            eevent.SetView(buttonOk);

            Assert.AreEqual(buttonRemoveOne.Visible, buttonOk.ButtonRemoveOne);
            Assert.AreEqual(buttonRemoveAll.Visible, buttonOk.ButtonRemoveAll);
        }
    }
}

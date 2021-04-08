using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizza;
using System.Windows.Forms;

namespace Test
{
    [TestClass]
    public class TestFormMailPresenters : IFormMail
    {
        TextBox tSender = new TextBox();
        TextBox tRecipient = new TextBox();
        TextBox tPassword = new TextBox();
        TextBox tSmtp = new TextBox();
        TextBox tPort = new TextBox();

        public TextBox TextBoxSender { get => tSender; set => tSender = value; }
        public TextBox TextBoxRecipient { get => tRecipient; set => tRecipient = value; }
        public TextBox TextBoxPassword { get => tPassword; set => tPassword = value; }
        public TextBox TextBoxSmtp { get => tSmtp; set => tSmtp = value; }
        public TextBox TextBoxPort { get => tPort; set => tPort = value; }

        //TFormMailPresenters presenter;

        //[TestMethod]
        //public void TestSaveDataEmialAndSetTextView()
        //{
        //    presenter = new TFormMailPresenters(this);       
        //    TRegistry registry = new TRegistry();
        //    registry.ClearTRegistry();
        //    tSender.Text = "aaa@gmail.com";
        //    tRecipient.Text = "aaa@gmail.com";
        //    tPassword.Text = "password";
        //    tSmtp.Text = "smtp.ggggggmail.com";
        //    tPort.Text = "506";

        //    presenter.SaveDataEmial();
        //    tSender.Text = "";
        //    tRecipient.Text = "";
        //    tPassword.Text = "";
        //    tSmtp.Text = "";
        //    tPort.Text = "";
        //    presenter.SetTextView();

        //    Assert.AreEqual("aaa@gmail.com", tSender.Text);
        //    Assert.AreEqual("aaa@gmail.com", tRecipient.Text);
        //    Assert.AreEqual("password", tPassword.Text);
        //    Assert.AreEqual("smtp.ggggggmail.com", tSmtp.Text);
        //    Assert.AreEqual("506", tPort.Text);
        //}

        //[TestMethod]
        //public void TestDefaultSettings()
        //{
        //    presenter = new TFormMailPresenters(this);
        //    TRegistry registry = new TRegistry();
        //    registry.ClearTRegistry();

        //    presenter.SetTextView();


        //    Assert.AreEqual("587", tPort.Text);
        //}
    }
}

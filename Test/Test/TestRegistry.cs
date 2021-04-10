using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizza;

namespace Test
{
    [TestClass]
    public class TestRegistry
    {
        IOnEventTest eevent = new OnEventTest();
        FormMail form = new FormMail();
        ISaveEmailData save = new SaveRegistry();
        ILoadEmailData load = new LoadRegistry();

        [TestMethod]
        public void TestSaveRegisrtyAndLoad()
        {
            EmailData emailSave = CreateEmailData();
            save.Save(emailSave);

            EmailData emailLoad = load.Load();

            Assert.AreEqual("orders39@gmail.com", emailLoad.Sender);
            Assert.AreEqual("oooorders39@gmail.com", emailLoad.Recipient);
            Assert.AreEqual("password", emailLoad.Password);
            Assert.AreEqual("smtp.wp.com", emailLoad.Smtp);
            Assert.AreEqual("537", emailLoad.Port);
        }

        EmailData CreateEmailData()
        {
            EmailData email = new EmailData();
            email.Sender = "orders39@gmail.com";
            email.Recipient = "oooorders39@gmail.com";
            email.Password = "password";
            email.Smtp = "smtp.wp.com";
            email.Port = "537";
            return email;
        }

        [TestMethod]
        public void TestSetTextBoxWithFormMailAndLoadRegistry()
        {
            EmailData emailSave = CreateEmailData();
            save.Save(emailSave);

            eevent.SetLogic(new FormMailLoad(form));

            Assert.AreEqual("orders39@gmail.com", form.TextBoxSender.Text);
            Assert.AreEqual("oooorders39@gmail.com", form.TextBoxRecipient.Text);
            Assert.AreEqual("password", form.TextBoxPassword.Text);
            Assert.AreEqual("smtp.wp.com", form.TextBoxSmtp.Text);
            Assert.AreEqual("537", form.TextBoxPort.Text);
        }

        [TestMethod]
        public void TestGetTextBoxWithFormMailAndSaveRegistry()
        {
            form.TextBoxSender.Text = "aaorders39@gmail.com";
            form.TextBoxRecipient.Text = "aaoooorders39@gmail.com";
            form.TextBoxPassword.Text = "aapassword";
            form.TextBoxSmtp.Text = "aasmtp.wp.com";
            form.TextBoxPort.Text = "527";
            eevent.SetLogic(new FormMailSavePresenters(form));

            EmailData emailLoad = load.Load();

            Assert.AreEqual("aaorders39@gmail.com", emailLoad.Sender);
            Assert.AreEqual("aaoooorders39@gmail.com", emailLoad.Recipient);
            Assert.AreEqual("aapassword", emailLoad.Password);
            Assert.AreEqual("aasmtp.wp.com", emailLoad.Smtp);
            Assert.AreEqual("527", emailLoad.Port);
        }
    }
}

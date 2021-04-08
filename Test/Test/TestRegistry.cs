using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pizza;

namespace Test
{
    [TestClass]
    public class TestRegistry
    {
        IAction eevent = new Aktion();
        FormMail form = new FormMail();
        ISaveEmailData save = new SaveRegistry();
        ILoadEmailData load = new LoadRegistry();

        [TestMethod]
        public void TestSaveRegisrty()
        {
            EmailData emailSave = CreateEmailData();
            save.Save( emailSave );
            EmailData emailLoad = load.Load();

            Assert.AreEqual( emailLoad.Sender, emailSave.Sender );
            Assert.AreEqual( emailLoad.Recipient, emailSave.Recipient );
            Assert.AreEqual( emailLoad.Password, emailSave.Password );
            Assert.AreEqual( emailLoad.Smtp, emailSave.Smtp );
            Assert.AreEqual( emailLoad.Port, emailSave.Port );
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
            EmailData emailLoad = load.Load();
            eevent.SetLogic( new FormMailLoad( form ) );

            Assert.AreEqual( emailLoad.Sender, form.TextBoxSender.Text );
            Assert.AreEqual( emailLoad.Recipient, form.TextBoxRecipient.Text );
            Assert.AreEqual( emailLoad.Password, form.TextBoxPassword.Text );
            Assert.AreEqual( emailLoad.Smtp, form.TextBoxSmtp.Text );
            Assert.AreEqual( emailLoad.Port, form.TextBoxPort.Text );
        }

        [TestMethod]
        public void TestGetTextBoxWithFormMailAndSaveRegistry()
        {
            EmailData emailSave = CreateEmailData2();
            form.TextBoxSender.Text = emailSave.Sender;
            form.TextBoxRecipient.Text = emailSave.Recipient;
            form.TextBoxPassword.Text = emailSave.Password;
            form.TextBoxSmtp.Text = emailSave.Smtp;
            form.TextBoxPort.Text = emailSave.Port;

            eevent.SetLogic( new FormMailSavePresenters( form ) );
            EmailData emailLoad = load.Load();

            Assert.AreEqual( emailLoad.Sender, form.TextBoxSender.Text );
            Assert.AreEqual( emailLoad.Recipient, form.TextBoxRecipient.Text );
            Assert.AreEqual( emailLoad.Password, form.TextBoxPassword.Text );
            Assert.AreEqual( emailLoad.Smtp, form.TextBoxSmtp.Text );
            Assert.AreEqual( emailLoad.Port, form.TextBoxPort.Text );
        }

        EmailData CreateEmailData2()
        {
            EmailData email = new EmailData();
            email.Sender = "aaorders39@gmail.com";
            email.Recipient = "aaoooorders39@gmail.com";
            email.Password = "aapassword";
            email.Smtp = "aasmtp.wp.com";
            email.Port = "527";
            return email;
        }
    }
}

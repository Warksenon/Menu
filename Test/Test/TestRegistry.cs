using Microsoft.VisualStudio.TestTools.UnitTesting;

using Pizza;

namespace Test
{
    [TestClass]
    public class TestRegistry
    {
        private readonly IOnEventTest eevent = new OnEventTest();
        private readonly FormMail form = new FormMail();
        private readonly ISaveEmailData save = new SaveRegistry();
        private readonly ILoadEmailData load = new LoadRegistry();

        [TestMethod]
        public void TestSaveRegisrtyAndLoad()
        {
            EmailData emailSave = CreateEmailData();
            save.Save( emailSave );

            EmailData emailLoad = load.Load();
            var currentSender = emailLoad.Sender;
            var currentRecipient = emailLoad.Recipient;
            var currentPassword = emailLoad.Password;
            var currentSmtp = emailLoad.Smtp;
            var currentPort = emailLoad.Port;

            Assert.AreEqual( "orders39@gmail.com", currentSender );
            Assert.AreEqual( "oooorders39@gmail.com", currentRecipient );
            Assert.AreEqual( "password", currentPassword );
            Assert.AreEqual( "smtp.wp.com", currentSmtp );
            Assert.AreEqual( "537", currentPort );
        }

        private EmailData CreateEmailData()
        {
            EmailData email = new EmailData
            {
                Sender = "orders39@gmail.com",
                Recipient = "oooorders39@gmail.com",
                Password = "password",
                Smtp = "smtp.wp.com",
                Port = "537"
            };

            return email;
        }

        [TestMethod]
        public void TestSetTextBoxWithFormMailAndLoadRegistry()
        {
            EmailData emailSave = CreateEmailData();
            save.Save( emailSave );

            eevent.SetLogic( new FormMailLoad( form ) );
            var currentSender = form.TextBoxSender.Text;
            var currentRecipient = form.TextBoxRecipient.Text;
            var currentPassword = form.TextBoxPassword.Text;
            var currentSmtp = form.TextBoxSmtp.Text;
            var currentPort = form.TextBoxPort.Text;

            Assert.AreEqual( "orders39@gmail.com", currentSender );
            Assert.AreEqual( "oooorders39@gmail.com", currentRecipient );
            Assert.AreEqual( "password", currentPassword );
            Assert.AreEqual( "smtp.wp.com", currentSmtp );
            Assert.AreEqual( "537", currentPort );
        }

        [TestMethod]
        public void TestGetTextBoxWithFormMailAndSaveRegistry()
        {
            form.TextBoxSender.Text = "aaorders39@gmail.com";
            form.TextBoxRecipient.Text = "aaoooorders39@gmail.com";
            form.TextBoxPassword.Text = "aapassword";
            form.TextBoxSmtp.Text = "aasmtp.wp.com";
            form.TextBoxPort.Text = "527";
            eevent.SetLogic( new FormMailSavePresenters( form ) );

            EmailData emailLoad = load.Load();
            var currentSender = emailLoad.Sender;
            var currentRecipient = emailLoad.Recipient;
            var currentPassword = emailLoad.Password;
            var currentSmtp = emailLoad.Smtp;
            var currentPort = emailLoad.Port;

            Assert.AreEqual( "aaorders39@gmail.com", currentSender );
            Assert.AreEqual( "aaoooorders39@gmail.com", currentRecipient );
            Assert.AreEqual( "aapassword", currentPassword );
            Assert.AreEqual( "aasmtp.wp.com", currentSmtp );
            Assert.AreEqual( "527", currentPort );
        }
    }
}

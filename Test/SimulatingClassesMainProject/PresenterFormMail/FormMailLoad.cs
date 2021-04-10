using Pizza;

namespace Test
{
    public class FormMailLoad : FormMailPresenter
    {
        public FormMailLoad(FormMail mail) : base(mail) { }

        public override void LogicSettings()
        {
            SetTextForTextBox();
        }

        private void SetTextForTextBox()
        {
            ILoadEmailData loadEmailData = new LoadRegistry();
            EmailData emailData = loadEmailData.Load();
            mail.TextBoxSender.Text = emailData.Sender;
            mail.TextBoxPassword.Text = emailData.Password;
            mail.TextBoxPort.Text = emailData.Port;
            mail.TextBoxSmtp.Text = emailData.Smtp;
            mail.TextBoxRecipient.Text = emailData.Recipient;
        }
    }
}

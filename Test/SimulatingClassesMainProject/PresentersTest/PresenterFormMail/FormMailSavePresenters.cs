using System.Windows.Forms;

using Pizza;


namespace Test
{
    internal class FormMailSavePresenters : FormMailPresenter
    {
        public FormMailSavePresenters( FormMail mail ) : base( mail ) { }

        public override void LogicSettings()
        {
            bool saveSuccess = SaveDataEmial();
            if (saveSuccess)
                mail.Close();
        }

        public bool SaveDataEmial()
        {
            EmailData emailData = new EmailData();
            emailData.Sender = mail.TextBoxSender.Text;
            emailData.Password = mail.TextBoxPassword.Text;
            emailData.Port = mail.TextBoxPort.Text;
            emailData.Smtp = mail.TextBoxSmtp.Text;
            emailData.Recipient = mail.TextBoxRecipient.Text;

            ISaveEmailData saveEmail = new SaveRegistry();
            bool saveIsOk = saveEmail.Save(emailData);

            if (saveIsOk)
            {
                return true;
            }
            else
            {
                MessageBox.Show( "Nieprawidłowe dane. Upewni się że wprowadzone dane: andresów e-mail, hasło, smtp, port są prawidłowe ", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return false;
            }
        }
    }
}

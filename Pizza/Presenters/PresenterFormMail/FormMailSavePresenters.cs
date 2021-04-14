using System.Windows.Forms;

using Pizza.Models.Registry;
using Pizza.Presenters.Email;
using Pizza.Presenters.PresenterFormMail;

namespace Pizza.Presenters
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
            EmailData emailData = new EmailData
            {
                Sender = mail.TextBoxSender.Text,
                Password = mail.TextBoxPassword.Text,
                Port = mail.TextBoxPort.Text,
                Smtp = mail.TextBoxSmtp.Text,
                Recipient = mail.TextBoxRecipient.Text
            };

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

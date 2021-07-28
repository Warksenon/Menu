using System.Windows.Forms;

using Pizza.Models.Registry;

namespace Pizza.Presenters
{
    internal class FormMailSavePresenters
    {
        private readonly FormMail _form;
        public FormMailSavePresenters ( FormMail form )
        {
            _form = form;
        }

        public void SaveDataEmial ( ISaveEmailData saveEmail )
        {
            EmailData emailData = new EmailData
            {
                Sender = _form.TextBoxSender.Text,
                Password = _form.TextBoxPassword.Text,
                Port = _form.TextBoxPort.Text,
                Smtp = _form.TextBoxSmtp.Text,
                Recipient = _form.TextBoxRecipient.Text
            };

            bool saveIsOk = saveEmail.Save(emailData);

            if (!saveIsOk)
            {
                MessageBox.Show( "Nieprawidłowe dane. Upewni się że wprowadzone dane: andresów e-mail, hasło, smtp, port są prawidłowe ", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }

        }
    }
}

using System;
using System.Net;
using System.Net.Mail;

using Pizza.Models.Registry;

namespace Pizza.Presenters.Email
{
    public class EmailSend : ISendOrder 
    {
        readonly string _message;

        public EmailSend ( IElementGet<Order> setOrder )
        {
            var order = setOrder.GetElement();
            var emailMessage = new EmailMessage(order);
            _message = emailMessage.WriteBill();
        }

        public bool SendMessag ()
        {
           return SendEmail( _message );
        }

        ILoadEmailData _loadEmail = new LoadRegistry();

        private bool SendEmail ( string message )
        {
            bool flag = false;
           
            EmailData registry = _loadEmail.Load();
            using (MailMessage send = new MailMessage())
            {
                using (SmtpClient client = new SmtpClient())
                {
                    try
                    {
                        client.Credentials = new NetworkCredential( registry.Sender, registry.Password );
                        client.Host = registry.Smtp;
                        client.Port = Convert.ToInt32( registry.Port );
                        client.EnableSsl = true;
                        try
                        {
                            send.From = new MailAddress( registry.Sender );
                            send.Subject = "Zamówienie Pizza";
                            send.Body = message;
                            send.To.Add( registry.Recipient );
                        }
                        catch (Exception ex)
                        {
                            RecordOfExceptions.Save( Convert.ToString( ex ), "SendEmail" );
                        }
                        client.Send( send );
                        flag = true;
                    }
                    catch (Exception ex)
                    {
                        RecordOfExceptions.Save( Convert.ToString( ex ), "SendEmail" );
                    }
                }
            }

            return flag;
        }

        public void SetSettingsEmial ( ILoadEmailData loadEmail )
        {
            _loadEmail = loadEmail;
        }
    }
}

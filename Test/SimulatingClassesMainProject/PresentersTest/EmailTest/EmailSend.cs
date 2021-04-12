using System;
using System.Net;
using System.Net.Mail;

using Pizza;

namespace Test
{
    public class EmailSend
    {
        public bool SendEmail( string message )
        {
            bool flag = false;
            ILoadEmailData loadEmail = new LoadRegistry();
            EmailData registry = loadEmail.Load();
            MailMessage send = new MailMessage();
            SmtpClient client = new SmtpClient();
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
            return flag;
        }
    }
}

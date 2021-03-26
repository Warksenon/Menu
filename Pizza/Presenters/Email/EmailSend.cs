using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Presenters.Email
{
    public class EmailSend
    {
        public bool SendEmail(string message)
        {
            bool flag = false;           
            Registry registry = new Registry();            
            MailMessage send = new MailMessage();
            SmtpClient client = new SmtpClient();
            try
            {               
                client.Credentials = new NetworkCredential(registry.Sender, registry.Password);
                client.Host = registry.Smtp;
                client.Port = Convert.ToInt32(registry.Port);
                client.EnableSsl = true;
                try
                {
                    send.From = new MailAddress(registry.Sender);
                    send.Subject = "Zamówienie Pizza";
                    send.Body = message;
                    send.To.Add(registry.Recipient);
                    
                }
                catch (Exception ex)
                {
                    RecordOfExceptions.Save(Convert.ToString(ex), "SendEmail");
                }
                client.Send(send);
                flag = true;
            }
            catch (Exception ex)
            {
                RecordOfExceptions.Save(Convert.ToString(ex), "SendEmail");
            }
            return flag;

        }
    }
}

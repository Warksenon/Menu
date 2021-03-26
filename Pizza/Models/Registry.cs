using Microsoft.Win32;
using System;

namespace Pizza
{
    public class Registry
    {
        const string subKey = "Password99";

        public Registry()
        {
            ReadingRegistry();
        }

        private string sender;
        private string password;
        private string port;
        private string smtp;
        private string recipient;
        
        public string Sender
        {
            get
            {
                if (HelpFinding.CheckStringIsEmpty(sender)) return "listorders39@gmail.com";
                else return sender;
            }
            set { sender = HelpFinding.CheckIsNotNull(value); }
        }

        public string Password
        {
            get
            {
                if (HelpFinding.CheckStringIsEmpty(password)) return "Testy2020!";
                else return password;
            }
            set { password = HelpFinding.CheckIsNotNull(value); }
        }

        public string Port
        {
            get
            {
                if (HelpFinding.CheckStringIsEmpty(port)) return "587";
                else return port;
            }
            set { port = HelpFinding.CheckIsNotNull(value); }
        }

        public string Smtp
        {
            get
            {
                if (HelpFinding.CheckStringIsEmpty(smtp)) return "smtp.gmail.com";
                else return smtp;
            }
            set { smtp = HelpFinding.CheckIsNotNull(value); }
        }

        public string Recipient
        {
            get
            {
                if (HelpFinding.CheckStringIsEmpty(recipient)) return "listorders39@gmail.com";
                else return recipient;
            }
            set { recipient = HelpFinding.CheckIsNotNull(value); }
        }

        public void ReadingRegistry()
        {
            try
            {
                RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(subKey);
                sender = (string)key.GetValue(Name.Sender);
                password = (string)key.GetValue(Name.Password);
                port = (string)key.GetValue(Name.Port);
                smtp = (string)key.GetValue(Name.Smtp);
                recipient = (string)key.GetValue(Name.Recipient);
                key.Close();
            }
            catch (Exception ex)
            {
                RecordOfExceptions.Save(Convert.ToString(ex), "ReadingRegistry");
            }


        }

        public bool SaveRegistry()
        {
            bool flag = false;
            RegistryKey key = Microsoft.Win32.Registry.CurrentUser;
            try
            {
                key.CreateSubKey(subKey);
                key = key.OpenSubKey(subKey, true);

                if (IsValidEmail(Recipient))
                {
                    if (DataSender(key))
                    {
                        key.SetValue(Name.Recipient, Recipient);
                        flag = true;
                    }
                }
            }
            catch (Exception ex)
            {
                RecordOfExceptions.Save(Convert.ToString(ex), "SaveRegistry");
                return flag;
            }
            key.Close();
            return flag;
        }

        bool DataSender(RegistryKey key)
        {
            bool flag = false;
            try
            {
                if (IsValidEmail(Sender))
                {
                    key.SetValue(Name.Sender, Sender);
                    key.SetValue(Name.Password, Password);
                    key.SetValue(Name.Smtp, Smtp);

                    bool success = Int32.TryParse(Port, out int i);
                    if (success)
                    {
                        key.SetValue(Name.Port, Port);
                        flag = true;
                    }
                }
            }
            catch (Exception ex)
            {
                RecordOfExceptions.Save(Convert.ToString(ex), "DataSender");
                flag = false;
            }
            return flag;
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}

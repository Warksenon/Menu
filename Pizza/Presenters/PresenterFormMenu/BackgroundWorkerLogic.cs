using Pizza.Models.SqlLite;
using Pizza.Presenters.Email;
using Pizza.View.Form1View;
using System.Drawing;
using System.Windows.Forms;

namespace Pizza.Presenters.PresenterFormMenu
{
    class BackgroundWorkerLogic : ViewFormMenu, ILogic
    {
        Order order;
        string message;

        public BackgroundWorkerLogic(FormMenu form) : base(form) { }
      

        private void GetOrderFromListView()
        {
            FormMenuCreatingOrder creatingOrder = new FormMenuCreatingOrder(form);
            order = creatingOrder.GetOrderFromListView();
        }

        private void GetMessage()
        {
            EmailMessage emailMessage = new EmailMessage(order);
            message = emailMessage.WriteBill();
        }


        public void LogicSettings()
        {
            form.ButtonSubmitOrder.BackColor = Color.Firebrick;
            GetOrderFromListView();
            GetMessage();
            EmailSend emailSend = new EmailSend();
            bool checkSendEmail = emailSend.SendEmail(message);
            checkSendEmail = true;
            if (checkSendEmail)
            {
                SaveOrder(order);
            }
            else
            {
                MessageBox.Show("Wysłanie wiadomości nie powiodło się. Problem z adres e-mail lub z połaczeniem internetowym");
            }
            form.ButtonSubmitOrder.BackColor = Color.LawnGreen;
        }

        private void SaveOrder(Order order)
        {
            Save save = new Save();
            save.AddOrderToHistory(new AddOrderSQL(order));
            save.AddOrderToHistory(new SaveFiles(order));
        }

    }
}

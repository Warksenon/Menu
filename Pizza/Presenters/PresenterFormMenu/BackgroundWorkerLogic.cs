using Pizza.Models.SqlLite;
using Pizza.Presenters.Email;
using Pizza.View.Form1View;
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
            GetOrderFromListView();
            GetMessage();
            EmailSend emailSend = new EmailSend();
            bool checkSendEmail = emailSend.SendEmail(message);
            if (checkSendEmail)
            {
                SaveOrder(order);
            }
            else
            {
                MessageBox.Show("Wysłanie wiadomości nie powiodło się. Problem z adres e-mail lub z połaczeniem internetowym");
            }
        }

        private void SaveOrder(Order order)
        {
            Save save = new Save();
            save.AddOrderToHistory(new AddOrderSQL(order));
            save.AddOrderToHistory(new SaveFiles(order));
        }

    }
}

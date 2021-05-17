using System.Windows.Forms;

using Pizza.Models.FilesTXT;
using Pizza.Models.SqlLite;
using Pizza.Presenters.Email;
using Pizza.View.Form1View;

namespace Pizza.Presenters.PresenterFormMenu.OrderGetSet
{
    internal class BackgroundWorkerLogic : ViewFormMenu, ILogic
    {
        private Order order;
        private string message;

        public BackgroundWorkerLogic( FormMenu form ) : base( form ) { }

        private void GetOrderFromListView()
        {
            IElementGet<Order> creatingOrder = new OrderListView(_form);
            order = creatingOrder.GetElement();
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
                SaveOrder( order );
                MessageBox.Show( "Zamówienie zostało złożone" );
            }
            else
            {
                MessageBox.Show( "Wysłanie wiadomości nie powiodło się. Problem z adres e-mail lub z połaczeniem internetowym" );
            }
        }

        private void SaveOrder( Order order )
        {
            new SaveOrderSQL( order );
            new SaveFilesOrder( order );
        }
    }
}

using System.Windows.Forms;

using Pizza.Models.FilesTXT;
using Pizza.Models.SqlLite;
using Pizza.Presenters.Email;
using Pizza.View.Form1View;

namespace Pizza.Presenters.PresenterFormMenu
{
    internal class ButtonPlaceOrderLogic : ViewFormMenu
    {
        public ButtonPlaceOrderLogic( FormMenu form ) : base( form ) { }

        public void LogicSettings( IElementGet<Order> creatingOrder )
        {
            var order = creatingOrder.GetElement();
            RunPlaceOrder( order );
        }

        private void RunPlaceOrder(Order order)
        {
            if (ChceckListViewOrderIsNotEpmty())
            {
                if (_form.BackgroundWorker.IsBusy != true)
                {
                    _form.BackgroundWorker.RunWorkerAsync();
                    SendOrderAndSave( order );
                }
                else
                {
                    MessageBox.Show( "Przetwarzanie danych proszę czekać" );
                }
            }
            else
            {
                MessageBox.Show( "Proszę wybrać produkt" );
            }
        }

        private bool ChceckListViewOrderIsNotEpmty ()
        {
            if (_form.ListViewOrder.Items.Count > 0)
                return true;
            else
                return false;
        }

        private void SendOrderAndSave (Order order )
        {
            var _order = order;
            var emailMessage = new EmailMessage(_order);
            var message = emailMessage.WriteBill();
            EmailSend emailSend = new EmailSend();
            bool checkSendEmail = emailSend.SendEmail(message);

            if (checkSendEmail)
            {
                SaveOrder( _order );
                MessageBox.Show( "Zamówienie zostało złożone" );
            }
            else
            {
                MessageBox.Show( "Wysłanie wiadomości nie powiodło się. Problem z adres e-mail lub z połaczeniem internetowym" );
            }
        }

        private void SaveOrder ( Order order )
        {
            new SaveOrderSQL( order );
            new SaveFilesOrder( order );
        }

    }
}

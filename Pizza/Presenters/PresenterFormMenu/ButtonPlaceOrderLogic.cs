using System.Windows.Forms;

using Pizza.Presenters.Email;

namespace Pizza.Presenters.PresenterFormMenu
{
    internal class ButtonPlaceOrderLogic
    {
        private  IElementGet<Order>  _order;
        private readonly FormMenu _form;

        public ButtonPlaceOrderLogic( FormMenu form ) 
        {
            _form = form;
        }

        public void SetOrder( IElementGet<Order> creatingOrder )
        {
            _order = creatingOrder;
            RunPlaceOrder();
        }

        private void RunPlaceOrder()
        {
            if (ChceckListViewOrderIsNotEpmty())
            {
                if (_form.BackgroundWorker.IsBusy != true)
                {
                    _form.BackgroundWorker.RunWorkerAsync();
                    SendOrder();
                }
                else
                {
                    DialogBox.Show( "Przetwarzanie danych proszę czekać" );
                }
            }
            else
            {
                DialogBox.Show( "Proszę wybrać produkt" );
            }
        }

        private bool ChceckListViewOrderIsNotEpmty ()
        {
            if (_form.ListViewOrder.Items.Count > 0)
                return true;
            else
                return false;
        }

        bool _checkSend;
        private void SendOrder ( )
        {
            EmailSend emailSend = new EmailSend(_order);
            _checkSend = emailSend.SendMessag();

            if (_checkSend)
            {
                DialogBox.Show( "Zamówienie zostało złożone" );
            }
            else
            {
                DialogBox.Show( "Wysłanie wiadomości nie powiodło się. Problem z adres e-mail lub z połaczeniem internetowym" );
            }
        }

        private IElementSet<Order> _saveOrder;
        public void SaveOrder ( IElementSet<Order> saveOrder)
        {
            if (_checkSend)
            {
                _saveOrder = saveOrder;
                var order = _order.GetElement();
                _saveOrder.SetElement( order );
            } 
        }

    }
}

using System.Windows.Forms;

using Pizza.Presenters.Email;

namespace Pizza.Presenters.PresenterFormMenu
{
    internal class ButtonPlaceOrderLogic
    {
        private  IElementGet<Order>  _order;
        private readonly FormMenu _form;
        IDialogService _dialogService;

        public ButtonPlaceOrderLogic( FormMenu form, IDialogService dialogService ) 
        {
            _form = form;
            _dialogService = dialogService;
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
                    _dialogService.ShowMessage( "Przetwarzanie danych proszę czekać" );
                }
            }
            else
            {
                _dialogService.ShowMessage( "Proszę wybrać produkt" );
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
                _dialogService.ShowMessage( "Zamówienie zostało złożone" );
            }
            else
            {
                _dialogService.ShowMessage( "Wysłanie wiadomości nie powiodło się. Problem z adres e-mail lub z połaczeniem internetowym" );
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

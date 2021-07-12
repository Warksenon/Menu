using System.Windows.Forms;

using Pizza.Presenters.Email;

namespace Pizza.Presenters.PresenterFormMenu
{
    internal class ButtonPlaceOrderLogic
    {
        private  IElementGet<Order>  _order;
        private readonly FormMenu _form;
        IDialogService _dialogService;
        ISendOrder _send; 

        public ButtonPlaceOrderLogic( FormMenu form, IDialogService dialogService ) 
        {
            _form = form;
            _dialogService = dialogService;
        }

       
        public void SaveOrder ( IElementSet<Order> element )
        {
            if (_checkSend)
            {
                var saveOrder = element;
                var order = _order.GetElement();
                saveOrder.SetElement( order );
            }
        }


        public void SetOrder( IElementGet<Order> creatingOrder, ISendOrder send )
        {
            _order = creatingOrder;
            _send = send;
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
            _checkSend = _send.SendMessag( _order );

            if (_checkSend)
            {
                _dialogService.ShowMessage( "Zamówienie zostało złożone" );
            }
            else
            {
                _dialogService.ShowMessage( "Wysłanie wiadomości nie powiodło się. Problem z adres e-mail lub z połaczeniem internetowym" );
            }
        }

    }
}

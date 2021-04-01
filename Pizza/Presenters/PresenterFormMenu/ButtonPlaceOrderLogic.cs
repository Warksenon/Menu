using Pizza.View.Form1View;
using System.Windows.Forms;

namespace Pizza.Presenters.PresenterFormMenu
{
    class ButtonPlaceOrderLogic : ViewFormMenu, ILogic
    {    
        public ButtonPlaceOrderLogic(FormMenu form) :base(form) { }

        public void LogicSettings()
        {
            RunPlaceOrder();
        }

        private void RunPlaceOrder()
        {
            if (ChceckListViewOrderIsNotEpmty())
            {
                if (form.BackgroundWorker.IsBusy != true)
                {
                    form.BackgroundWorker.RunWorkerAsync();
                    eevent.SetLogic(new BackgroundWorkerLogic(form));
                }
                else
                {
                    MessageBox.Show("Przetwarzanie danych proszę czekać");
                }
            }
            else
            {
                MessageBox.Show("Proszę wybrać produkt");
            }
        }

        private bool ChceckListViewOrderIsNotEpmty()
        {
            if (form.ListViewOrder.Items.Count > 0) return true;
            else return false;
        }
    }
}

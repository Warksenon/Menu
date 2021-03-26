using Pizza.View.Form1View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

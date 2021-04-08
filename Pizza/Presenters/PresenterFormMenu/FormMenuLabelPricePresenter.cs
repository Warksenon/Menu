using Pizza.Presenters.PresenterFormMenu.OrderGetSet;
using Pizza.View.Form1;

namespace Pizza.Presenters.PresenterFormMenu
{
    class Form1LabelPricePresenter : ILogic
    {
        IPriceAll price;
        IFormMenuLabelPrice label;
        //TODO zmienić na logike
        public Form1LabelPricePresenter( FormMenu form1 )
        {
            price = new FormMenuAddOrderListView( form1 );
            label = form1;
        }

        public void LogicSettings()
        {
            SetTextLabelPrice();
        }

        private void SetTextLabelPrice()
        {
            label.LabelPrice.Text = "Cena: " + price.GetPricaAll() + " zł";
        }
    }
}

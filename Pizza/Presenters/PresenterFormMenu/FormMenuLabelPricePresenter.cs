using Pizza.Presenters.PresenterFormMenu.OrderGetSet;
using Pizza.View.Form1;

namespace Pizza.Presenters.PresenterFormMenu
{
    internal class Form1LabelPricePresenter : ILogic
    {
        private readonly IPriceAll price;
        private readonly IFormMenuLabelPrice label;
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

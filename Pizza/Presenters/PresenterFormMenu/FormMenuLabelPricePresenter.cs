using Pizza.Presenters.PresenterFormMenu.OrderGetSet;
using Pizza.View.Form1;

namespace Pizza.Presenters.PresenterFormMenu
{
    internal class Form1LabelPricePresenter : ILogic
    {
        private readonly IPriceAll price;
        private readonly IFormMenuLabelPrice label;
        
        public Form1LabelPricePresenter( FormMenu form )
        {
            price = new FormMenuAddOrderListView( form );
            label = form;
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

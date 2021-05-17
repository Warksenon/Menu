using Pizza.View.Form1;

namespace Pizza.Presenters.PresenterFormMenu
{
    internal class Form1LabelPricePresenter : ILogic
    {
        private readonly IPrice price;
        private readonly IFormMenuLabelPrice label;

        public Form1LabelPricePresenter( FormMenu form )
        {
            price = new OrderListView( form );
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

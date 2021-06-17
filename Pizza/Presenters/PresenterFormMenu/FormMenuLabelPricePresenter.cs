using Pizza.View.Form1;

namespace Pizza.Presenters.PresenterFormMenu
{
    internal class Form1LabelPricePresenter : ILogic
    {
        private readonly IPrice _price;
        private readonly IFormMenuLabelPrice label;

        public Form1LabelPricePresenter( FormMenu form, IPrice price )
        {
            _price = price;
            label = form;
        }

        public void LogicSettings()
        {
            SetTextLabelPrice();
        }

        private void SetTextLabelPrice()
        {
            label.LabelPrice.Text = "Cena: " + _price.GetPricaAll() + " zł";
        }
    }
}

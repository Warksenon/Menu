using Pizza.View.Form1;

namespace Pizza.Presenters.PresenterFormMenu
{
    internal class Form1LabelPricePresenter 
    {
        private readonly IFormMenuLabelPrice label;

        public Form1LabelPricePresenter( FormMenu form  )
        {
            label = form;
        }

        public void SetTextLabelPrice( IPrice price )
        {
            label.LabelPrice.Text = "Cena: " + price.GetPricaAll() + " zł";
        }
    }
}

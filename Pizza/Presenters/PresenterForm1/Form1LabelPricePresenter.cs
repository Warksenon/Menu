using Pizza.Presenters.PresenterForm1.Order;
using Pizza.View.Form1;

namespace Pizza.Presenters.PresenterForm1
{
    class Form1LabelPricePresenter
    {
        IPriceAll price;
        IForm1LabelPrice label;

        public Form1LabelPricePresenter(Form1 form1)
        {
            price = new Form1OrderPresenters(form1);
            label = form1;
        }

        public void SetTextLabelPrice()
        {
            label.LabelPrice.Text = "Cena: "+ price.GetPricaAll() + " zł";
        }
    }
}

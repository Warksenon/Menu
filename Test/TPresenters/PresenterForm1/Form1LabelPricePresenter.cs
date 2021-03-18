using Pizza.Presenters.PresenterForm1.Order;
using Pizza.View.Form1;

namespace Test
{
    class Form1LabelPricePresenter : IView
    {
        IPriceAll price;
        IForm1LabelPrice label;

        public Form1LabelPricePresenter(Form1Test form1)
        {
            price = new Form1AddOrderListViewPresenters(form1);
            label = form1;
        }

        public void SetTextLabelPrice()
        {
            label.LabelPrice.Text = "Cena: "+ price.GetPricaAll() + " zł";
        }

        public void ViewSetting()
        {
            SetTextLabelPrice();
        }
    }
}

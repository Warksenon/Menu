using Pizza.View.Form1View;
using System;

namespace Pizza.Presenters.PresenterFormMenu.OrderGetSet
{
    public abstract class Form1ListViewOrder : ViewFormMenu, IPriceAll
    {
        protected Form1ListViewOrder(FormMenu form) : base(form) { }

        public double GetPricaAll()
        {
            double priceAll = 0;
            double price;
            string textPrice;
            try
            {
                for (int i = 0; i < form.ListViewOrder.Items.Count; i++)
                {
                    textPrice = form.ListViewOrder.Items[i].SubItems[2].Text;
                    price = FindPrice(textPrice);
                    priceAll += price;
                }
            }
            catch (Exception e)
            {
                RecordOfExceptions.Save(Convert.ToString(e), "Form1OrderPresenter - FindPrice");
            }
            return priceAll;
        }

        protected double FindPrice(string text)
        {
            double price = 0;
            try
            {
                string textPrice = HelpFinding.FindPrice(text);
                textPrice = textPrice.Replace("zł", "");
                price = Convert.ToDouble(textPrice);
            }
            catch (Exception e)
            {
                RecordOfExceptions.Save(Convert.ToString(e), "Form1OrderPresenter - FindPrice");
            }
            return price;
        }

    }
}

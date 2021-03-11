using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Presenters.PresenterForm1.Order
{
    abstract class Form1ListViewOrder: IPriceAll
    {
        protected IForm1ListViewOrder lvOrder;

        protected Form1ListViewOrder(Form1 form1)
        {
            lvOrder = form1;
        }

        public double GetPricaAll()
        {
            double priceAll = 0;
            double price;
            string textPrice;
            try
            {
                for (int i = 0; i < lvOrder.ListViewOrder.Items.Count; i++)
                {
                    textPrice = lvOrder.ListViewOrder.Items[i].SubItems[2].Text;
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

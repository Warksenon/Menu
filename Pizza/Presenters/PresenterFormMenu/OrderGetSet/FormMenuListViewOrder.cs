using System;
using System.Text;

using Pizza.View.Form1View;

namespace Pizza.Presenters.PresenterFormMenu.OrderGetSet
{
    public abstract class FormMenuListViewOrder : ViewFormMenu, IPriceAll
    {
        protected FormMenuListViewOrder( FormMenu form ) : base( form ) { }

        public double GetPricaAll()
        {
            double priceAll = 0;
            double price;
            StringBuilder textPrice = new StringBuilder();
            try
            {
                for (int i = 0; i < form.ListViewOrder.Items.Count; i++)
                {
                    textPrice.Clear();
                    textPrice.Append( form.ListViewOrder.Items [i].SubItems [2].Text );
                    price = FindPrice( textPrice.ToString() );
                    priceAll += price;
                }
            }
            catch (Exception e)
            {
                RecordOfExceptions.Save( Convert.ToString( e ), "Form1OrderPresenter - GetPricaAll" );
            }
            return priceAll;
        }

        protected double FindPrice( string text )
        {
            double price = 0;
            try
            {
                string textPrice = HelpFinding.FindPrice(text);
                textPrice = textPrice.Replace( "zł", "" );
                price = Convert.ToDouble( textPrice );
            }
            catch (Exception e)
            {
                RecordOfExceptions.Save( Convert.ToString( e ), "Form1OrderPresenter - FindPrice" );
            }
            return price;
        }

    }
}

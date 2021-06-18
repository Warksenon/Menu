using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Pizza.Models.SqlLite;
using Pizza.Presenters.PresenterFormHistory;

namespace Pizza
{
    public class LoadHistoryPresenter 
    {
        private readonly FormHistory _form;
        private static List<Order> orderList = new List<Order>();

        public LoadHistoryPresenter( FormHistory form) 
        {
            _form = form;
        }

        public void LoadHistoryFrom ( IListGet<Order> list )
        {
            ClearAllList();          
            LoadLVPriceAll( list );
        }

        private void ClearAllList()
        {
            _form.ListViewDishes.Items.Clear();
            _form.ListViewPrice.Items.Clear();
            orderList.Clear();
        }

        private void LoadLVPriceAll( IListGet<Order> list )
        {
            orderList = list.GetList();
            foreach (var price in orderList)
            {
                ListViewItem lvi = new ListViewItem(Convert.ToString(price.PriceAll.ID));
                lvi.SubItems.Add( price.PriceAll.Date );
                lvi.SubItems.Add( price.PriceAll.Price );
                lvi.SubItems.Add( price.PriceAll.Comments );
                _form.ListViewPrice.Items.Add( lvi );
            }
        }

    }
}

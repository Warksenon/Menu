using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Pizza.View.Form1View;

namespace Pizza.Presenters.PresenterFormMenu
{
    public class OrderListView : ViewFormMenu, IListSet<Dish>, IElementGet<Order>
    {
        public OrderListView( FormMenu form ) : base( form ) { }

        public Order GetElement()
        {
            throw new NotImplementedException();
        }

        public void SetList( List<Dish> elements )
        {
            AddOrderToListView( elements );
        }

        private void AddOrderToListView( List<Dish> listDishes )
        {
            foreach (var element in listDishes)
            {
                ListViewItem lvi;
                lvi = new ListViewItem( element.Name );
                lvi.SubItems.Add( element.Sides );
                lvi.SubItems.Add( element.Price );

                _form.ListViewOrder.Items.Add( lvi );
            }
        }
    }
}

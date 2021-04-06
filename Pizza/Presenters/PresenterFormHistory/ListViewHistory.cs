using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza.Presenters.PresenterFormHistory
{
    abstract class ListViewHistory : ILogic
    {
        protected FormHistory form;
        protected static List<Order> orderList = new List<Order>();
        protected readonly LoadOrder load = new LoadOrder();

        public ListViewHistory(FormHistory form)
        {
            this.form = form;
        }

        public abstract void LogicSettings();

        protected void ClearAllList()
        {
            form.ListViewDishes.Items.Clear();
            form.ListViewPrice.Items.Clear();
            orderList.Clear();
        }

        protected void LoadLVPriceAll()
        {
            foreach (var price in orderList)
            {
                ListViewItem lvi = new ListViewItem(Convert.ToString(price.PriceAll.ID));
                lvi.SubItems.Add(price.PriceAll.Date);
                lvi.SubItems.Add(price.PriceAll.Price);
                lvi.SubItems.Add(price.PriceAll.Comments);
                form.ListViewPrice.Items.Add(lvi);
            }
        }

        protected void LoadLVDishes()
        {
            form.ListViewDishes.Items.Clear();
            foreach (var dish in orderList[form.ListViewPrice.FocusedItem.Index].ListDishes)
            {
                ListViewItem lvi = new ListViewItem(Convert.ToString(dish.Id));
                lvi.SubItems.Add(dish.Name);
                lvi.SubItems.Add(dish.Price);
                lvi.SubItems.Add(dish.Sides);
                form.ListViewDishes.Items.Add(lvi);
            }
        }
    }
}

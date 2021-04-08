using System;
using System.Windows.Forms;

namespace Pizza.Presenters.PresenterFormHistory
{
    class HistorySelect : ListViewHistory
    {
        public HistorySelect( FormHistory form ) : base( form ) { }

        public override void LogicSettings()
        {
            LoadLVDishes();
        }

        private void LoadLVDishes()
        {
            form.ListViewDishes.Items.Clear();
            foreach (var dish in orderList [form.ListViewPrice.FocusedItem.Index].ListDishes)
            {
                ListViewItem lvi = new ListViewItem(Convert.ToString(dish.Id));
                lvi.SubItems.Add( dish.Name );
                lvi.SubItems.Add( dish.Price );
                lvi.SubItems.Add( dish.Sides );
                form.ListViewDishes.Items.Add( lvi );
            }
        }
    }
}

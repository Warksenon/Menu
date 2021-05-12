using System;
using System.Windows.Forms;

namespace Pizza.Presenters.PresenterFormHistory
{
    internal class HistorySelect: ListViewHistory
    {       
        public HistorySelect( FormHistory form ) : base( form ){}

        private void LoadLVDishes()
        {
            _form.ListViewDishes.Items.Clear();

            foreach (var dish in orderList [_form.ListViewPrice.FocusedItem.Index].ListDishes)
            {
                ListViewItem lvi = new ListViewItem(Convert.ToString(dish.Id));
                lvi.SubItems.Add( dish.Name );
                lvi.SubItems.Add( dish.Price );
                lvi.SubItems.Add( dish.Sides );
                _form.ListViewDishes.Items.Add( lvi );
            }
        }

        public override void LogicSettings()
        {
            LoadLVDishes();
        }
    }
}

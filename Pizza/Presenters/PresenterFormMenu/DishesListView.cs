using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Pizza.View.Form1View;

namespace Pizza.Presenters.PresenterFormMenu
{
    public class DishesListView : ViewFormMenu, IElementGet<Dish>, IListSet<Dish>
    {
        public DishesListView( FormMenu form ) : base( form ) { }

        public Dish GetElement()
        {
            return GetListSelektedDishes();
        }

        private Dish GetListSelektedDishes()
        {
            int x = CheckListDishesSelectedItem();

            Dish dish = new Dish
            {
                Name = _form.ListViewDishes.Items[x].SubItems[0].Text,
                Price = _form.ListViewDishes.Items[x].SubItems[1].Text
            };

            return dish;
        }

        private int CheckListDishesSelectedItem()
        {
            return _form.ListViewDishes.FocusedItem.Index;
        }

        public void SetList( List<Dish> listDisch )
        {
            AddDishesToListView( listDisch );
        }

        private void AddDishesToListView( List<Dish> listDisch )
        {
            _form.ListViewDishes.Items.Clear();
            foreach (var disch in listDisch)
            {
                ListViewItem lvi = new ListViewItem(Convert.ToString(disch.Name));
                lvi.SubItems.Add( disch.Price );
                _form.ListViewDishes.Items.Add( lvi );
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pizza.Presenters.PresenterFormMenu
{
    public class DishesListView : IElementGet<Dish>, IListSet<Dish>
    {
        private readonly FormMenu _form;
        public DishesListView( FormMenu form ) 
        {
            _form = form;
        }

        public Dish GetElement()
        {
            return GetSelektedDish();
        }

        private Dish GetSelektedDish()
        {
            int x = ChecktDishSelectedItem();

            Dish dish = new Dish
            {
                Name = _form.ListViewDishes.Items[x].SubItems[0].Text,
                Price = _form.ListViewDishes.Items[x].SubItems[1].Text
            };

            return dish;
        }

        private int ChecktDishSelectedItem()
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

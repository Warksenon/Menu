using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Pizza.View.Form1View;

namespace Pizza
{
    public class Form1LoadDishesPresenters : ViewFormMenu
    {
        public Form1LoadDishesPresenters( FormMenu form1 ) : base( form1 ) { }

        public void AddDishesToListView( IList<Dish> loadList )
        {
            List<Dish> listDisch = loadList.GetList();
            form.ListViewDishes.Items.Clear();
            foreach (var disch in listDisch)
            {
                ListViewItem lvi = new ListViewItem(Convert.ToString(disch.Name));
                lvi.SubItems.Add( disch.Price );
                form.ListViewDishes.Items.Add( lvi );
            }
        }
    }
}

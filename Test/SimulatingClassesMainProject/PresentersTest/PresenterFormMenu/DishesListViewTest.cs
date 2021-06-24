using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Pizza;
using Pizza.View.Form1View;

namespace Test
{
    //public class DishesListViewTest : ViewFormMenu, IListGet<Dish>, IListSet<Dish>
    //{
    //    public static int SelectionSimulation { get; set; }

    //    public DishesListViewTest( FormMenu form ) : base( form ) { }

    //    public Dish GetElement()
    //    {
    //        return GetListSelektedDishes();
    //    }

    //    private Dish GetListSelektedDishes()
    //    {
    //        int x = CheckListDishesSelectedItem();

    //        Dish dish = new Dish
    //        {
    //            Name = _form.ListViewDishes.Items[x].SubItems[0].Text,
    //            Price = _form.ListViewDishes.Items[x].SubItems[1].Text
    //        };

    //        return dish;
    //    }

    //    public int CheckListDishesSelectedItem()
    //    {
    //        return SelectionSimulation;
    //    }

    //    public void SetList( List<Dish> listDisch )
    //    {
    //        AddDishesToListView( listDisch );
    //    }

    //    private void AddDishesToListView( List<Dish> listDisch )
    //    {
    //        _form.ListViewDishes.Items.Clear();
    //        foreach (var disch in listDisch)
    //        {
    //            ListViewItem lvi = new ListViewItem(Convert.ToString(disch.Name));
    //            lvi.SubItems.Add( disch.Price );
    //            _form.ListViewDishes.Items.Add( lvi );
    //        }
    //    }

    //}
}

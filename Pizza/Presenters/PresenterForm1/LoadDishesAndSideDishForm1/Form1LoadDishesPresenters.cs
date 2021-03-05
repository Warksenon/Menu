using Pizza.Models.Menu;
using Pizza.Models.Menu.Sides;
using Pizza.Models.Order;
using Pizza.Presenters.PresenterForm1.LoadDishesAndSideDishForm1;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pizza.Presenters
{
    class Form1LoadDishesPresenters
    {

       private readonly IForm1ListViewDishesAndCheckedListBoxSideDish form1;

       public Form1LoadDishesPresenters(IForm1ListViewDishesAndCheckedListBoxSideDish view)
        {
            form1 = view;
        }

        public void LoadPizza()
        {
            AddDishesToListView(new ListPizza());
            LoadCheckListBoxSideDishe(new ListSidesPizza());
        }

        public void LoadMainDish()
        {
           AddDishesToListView(new ListMainDishes());
           LoadCheckListBoxSideDishe(new ListSidesMainDishes());
        }

        public void LoadSoups()
        {
           AddDishesToListView(new ListSoups());
           ClearCheckedListBox();
        }

        public void LoadDrinks()
        {
           AddDishesToListView(new ListDrinks());
           ClearCheckedListBox();
        }

        private void AddDishesToListView(IForm1Dishes loadList)
        {
            List<Dish> listDisch= loadList.GetDishes();
            form1.ListViewDishes.Items.Clear();
            foreach (var disch in listDisch)
            {
                ListViewItem lvi = new ListViewItem(Convert.ToString(disch.Name));
                lvi.SubItems.Add(disch.Price);
                form1.ListViewDishes.Items.Add(lvi);
            }
        }

        private  void  LoadCheckListBoxSideDishe(IForm1Sides listSides)
        {
            ClearCheckedListBox();
            List<Side> list = listSides.GetSides();
            foreach (var side in list)
            {
                string add = side.Name +" - "+ side.Price;
                form1.CheckedListBoxSideDish.Items.Add(add);
            }          
        }

        private void ClearCheckedListBox()
        {
            form1.CheckedListBoxSideDish.Items.Clear();
        }
    }
}

using Pizza.Models.Menu;
using Pizza.Presenters.PresenterForm1.LoadDishesAndSideDishForm1;
using Pizza.View.Form1View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pizza.Presenters
{
    public class Form1LoadDishesPresenters : ViewFormMenu
    {
        int index = 0;
        public Form1LoadDishesPresenters(FormMenu form, int index) : base(form) { }


        public List<Dish> GetListSelektedDishes()
        {
            List<Dish> list = new List<Dish>();
            int numbersRepetitions = CheckNumberTextViewDishes();
            if (numbersRepetitions > 0)
            {
                int x = CheckListDishesSelectedItem();
                for (int i = 0; i < numbersRepetitions; i++)
                {
                    Dish dish = new Dish
                    {
                        Name = form.ListViewDishes.Items[x].SubItems[0].Text,
                        Price = form.ListViewDishes.Items[x].SubItems[1].Text
                    };
                    list.Add(dish);
                }
            }

            return list;
        }

        private int CheckListDishesSelectedItem()
        {
            return index;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pizza;
using Pizza.Presenters.PresenterForm1.GetDishesAndSideDishForm1;

namespace Test.TPresenters
{
    public class TForm1ListDishes : Form1Quantity
    {
        int index = 0;
        public TForm1ListDishes(FormMenu form, int index) : base(form) { }
       

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

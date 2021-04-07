using System.Collections.Generic;

namespace Pizza.Presenters.PresenterForm1.GetDishesAndSideDishForm1
{
    public class Form1ListDishes : Form1Quantity
    {
        public Form1ListDishes( FormMenu form ) : base( form ) { }


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
                    list.Add( dish );
                }
            }

            return list;
        }

        private int CheckListDishesSelectedItem()
        {
            return form.ListViewDishes.FocusedItem.Index;
        }

    }
}

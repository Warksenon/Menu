using System.Collections.Generic;

using Pizza.View.Form1View;

namespace Pizza.Presenters
{
    public class Form1LoadDishesPresenters : ViewFormMenu
    {
        private readonly int index = 0;
        private readonly int numbersRepetitions;
        public Form1LoadDishesPresenters( FormMenu form, int index, int numbersRepetitions ) : base( form )
        {
            this.index = index;
            this.numbersRepetitions = numbersRepetitions;
        }


        public List<Dish> GetListSelektedDishes()
        {
            List<Dish> list = new List<Dish>();
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
            return index;
        }

    }
}

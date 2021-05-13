using System.Collections.Generic;

namespace Pizza
{
    public class ListDishesFactory : IList<Dish>
    {
        private ButtonLoadMenu buttonMenu;

        public ListDishesFactory ( ButtonLoadMenu buttonMenu )
        {
            this.buttonMenu = buttonMenu;
        }

        private List<Dish> SetButttonMenu()
        {
            var listDishes = new List<Dish>();

            switch (buttonMenu)
            {
                case ButtonLoadMenu.Pizza:
                listDishes = new ListPizza().GetList();
                break;
                case ButtonLoadMenu.MainDishes:
                listDishes = new ListMainDishes().GetList();
                break;
                case ButtonLoadMenu.Soups:
                listDishes = new ListSoups().GetList();
                break;
                case ButtonLoadMenu.Drinks:
                listDishes = new ListDrinks().GetList();
                break;
            }

            return listDishes;
        }

        public List<Dish> GetList()
        {
           return SetButttonMenu();
        }

    }
}

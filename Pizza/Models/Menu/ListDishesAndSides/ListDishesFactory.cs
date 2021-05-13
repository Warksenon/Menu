using System.Collections.Generic;

namespace Pizza
{
    public class ListDishesFactory : IList<Dish>
    {
        private readonly ButtonLoadMenu buttonMenu;

        public ListDishesFactory ( ButtonLoadMenu buttonMenu )
        {
            this.buttonMenu = buttonMenu;
        }

        private List<Dish> SetButttonMenu()
        {
            var listDishes = new ListDishes();

            switch (buttonMenu)
            {
                case ButtonLoadMenu.Pizza:
                listDishes = new ListPizza();
                break;
                case ButtonLoadMenu.MainDishes:
                listDishes = new ListMainDishes();
                break;
                case ButtonLoadMenu.Soups:
                listDishes = new ListSoups();
                break;
                case ButtonLoadMenu.Drinks:
                listDishes = new ListDrinks();
                break; 
            }

            return listDishes.GetList();
        }

        public List<Dish> GetList()
        {
           return SetButttonMenu();
        }

    }
}

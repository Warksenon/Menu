using System.Collections.Generic;

namespace Pizza
{
    public class ListDishesFactory : IForm1Dishes
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
                listDishes = new ListPizza().GetDishes();
                break;
                case ButtonLoadMenu.MainDishes:
                listDishes = new ListMainDishes().GetDishes();
                break;
                case ButtonLoadMenu.Soups:
                listDishes = new ListSoups().GetDishes();
                break;
                case ButtonLoadMenu.Drinks:
                listDishes = new ListDrinks().GetDishes();
                break;
            }

            return listDishes;
        }

        public List<Dish> GetDishes()
        {
           return SetButttonMenu();
        }

    }
}

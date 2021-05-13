using System.Collections.Generic;

namespace Pizza
{
    public class ListSidesFactory : IList<string>
    {
        private readonly ButtonLoadMenu buttonMenu;

        public ListSidesFactory( ButtonLoadMenu buttonMenu )
        {
            this.buttonMenu = buttonMenu;
        }

        private List<string> SetButttonMenu()
        {
            var listSides = new  ListSides();

            switch (buttonMenu)
            {
                case ButtonLoadMenu.Pizza:
                listSides = new ListSidesPizza();
                break;
                case ButtonLoadMenu.MainDishes:
                listSides = new ListSidesMainDishes();
                break;
            }

            return listSides.GetList();
        }

        public List<string> GetList()
        {
            return SetButttonMenu();
        }
    }
}

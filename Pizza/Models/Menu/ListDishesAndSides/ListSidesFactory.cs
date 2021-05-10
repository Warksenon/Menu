using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pizza.Presenters.PresenterFormMenu.LoadDishesAndSideDishForm1;

namespace Pizza
{
    public class ListSidesFactory : IForm1Sides
    {
        private ButtonLoadMenu buttonMenu;

        public ListSidesFactory( ButtonLoadMenu buttonMenu )
        {
            this.buttonMenu = buttonMenu;
        }

        private List<string> SetButttonMenu()
        {
            var listSides = new  ListSidesPizza().GetSides();

            switch (buttonMenu)
            {
                case ButtonLoadMenu.Pizza:
                var listDishes = new  ListSidesPizza().GetSides();
                break;
                case ButtonLoadMenu.MainDishes:
                listSides = new ListSidesMainDishes().GetSides();
                break;
                default:
                listSides = new List<string>();
                break;
            }

            return listSides;
        }

        public List<string> GetSides()
        {
            return SetButttonMenu();
        }
    }
}

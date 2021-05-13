using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Pizza.Presenters.PresenterFormMenu.LoadDishesAndSideDishForm1;

namespace Pizza
{
    public class ListSidesFactory : IList<string>
    {
        private ButtonLoadMenu buttonMenu;

        public ListSidesFactory( ButtonLoadMenu buttonMenu )
        {
            this.buttonMenu = buttonMenu;
        }

        private List<string> SetButttonMenu()
        {
            var listSides = new  ListSidesPizza().GetList();

            switch (buttonMenu)
            {
                case ButtonLoadMenu.Pizza:
                var listDishes = new  ListSidesPizza().GetList();
                break;
                case ButtonLoadMenu.MainDishes:
                listSides = new ListSidesMainDishes().GetList();
                break;
                default:
                listSides = new List<string>();
                break;
            }

            return listSides;
        }

        public List<string> GetList()
        {
            return SetButttonMenu();
        }
    }
}

using Pizza.Models.Order;
using Pizza.Presenters.PresenterForm1.LoadDishesAndSideDishForm1;
using System;
using System.Collections.Generic;

namespace Pizza.Models.Menu.Sides
{
    public class ListSidesMainDishes : ListSides, IForm1Sides
    {
        private List<Side> LoadSideMainDish()
        {
            List<string> key = new List<string> { "barPrice", "setOfSaucesPrice" };
            AddTolist(key);
            return sides;
        }

        public List<Side> GetSides()
        {
            return LoadSideMainDish();
        }
    }
}

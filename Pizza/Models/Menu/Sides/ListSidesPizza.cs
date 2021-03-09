using Pizza.Models.Order;
using Pizza.Presenters.PresenterForm1.LoadDishesAndSideDishForm1;
using System;
using System.Collections.Generic;

namespace Pizza.Models.Menu.Sides
{
    public class ListSidesPizza : ListSides, IForm1Sides
    {

        public List<Side> LoadSidePizza()
        {
            List<string> listKey = new List<string> { "doubelCheesePrice", "salamiPrice", "hamPrice", "mushroomsPrice" };
            AddTolist(listKey);
            return listSides;
        }

        public List<Side> GetSides()
        {
            return LoadSidePizza();
        }
    }
}

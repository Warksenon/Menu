using Pizza.Models.Menu.ListDishesAndSides;
using Pizza.Presenters.PresenterFormMenu.LoadDishesAndSideDishForm1;
using System.Collections.Generic;

namespace Pizza
{
    public abstract class ListSides : ListName, IForm1Sides
    {
        protected List<string> listSides = new List<string>();

        public abstract List<string> GetSides();

        protected void AddTolist(List<string> listKey)
        {
            foreach (var k in listKey)
            {
                string side = Name.GetNameConfig(k);
                listSides.Add(side);
            }
        }
    }
}

using Pizza.Presenters.PresenterFormMenu.LoadDishesAndSideDishForm1;
using System.Collections.Generic;

namespace Pizza
{
    public class ListSidesPizza : ListSides
    {
        public List<string> LoadSidePizza()
        {
            List<string> listKey = new List<string> { "doubelCheesePrice", "salamiPrice", "hamPrice", "mushroomsPrice" };
            AddTolist( listKey );

            return listSides;
        }

        public override List<string> GetSides()
        {
            return LoadSidePizza();
        }
    }
}

using System.Collections.Generic;

namespace Pizza
{
    public class ListSidesMainDishes : ListSides
    {
        private List<string> LoadSideMainDish()
        {
            List<string> listKey = new List<string> { "barPrice", "setOfSaucesPrice" };
            AddTolist(listKey);

            return listSides;
        }

        public override List<string> GetSides()
        {
            return LoadSideMainDish();
        }
    }
}

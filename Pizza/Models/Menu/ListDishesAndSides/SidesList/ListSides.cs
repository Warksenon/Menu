using System.Collections.Generic;

using Pizza.Models.Menu.ListDishesAndSides;
using Pizza.Presenters.PresenterFormMenu.LoadDishesAndSideDishForm1;

namespace Pizza
{
    public class ListSides : ListName, IList<string>
    {
        protected List<string> listSides = new List<string>();

        public virtual List<string> GetList ()
        {
            return new List<string>();
        }

        protected void AddTolist( List<string> listKey )
        {
            foreach (var k in listKey)
            {
                string side = Name.GetNameConfig(k);
                listSides.Add( side );
            }
        }
    }
}

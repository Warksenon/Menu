using System.Collections.Generic;

using Pizza.Models.Menu.ListDishesAndSides;

namespace Pizza
{
    public class ListSides : ListName, IListGet<string>, IListSet<string>
    {
        protected List<string> listSides = new List<string>();

        protected void AddTolist( List<string> listKey )
        {
            foreach (var k in listKey)
            {
                string side = Name.GetNameConfig(k);
                listSides.Add( side );
            }
        }

        public void SetList ( List<string> listKey )
        {
            foreach (var k in listKey)
            {
                string side = Name.GetNameConfig(k);
                listSides.Add( side );
            }
        }

        public virtual List<string> GetList ()
        {
            var list = listSides;
 //           listSides.Clear();
            return list; 
        }

    }
}

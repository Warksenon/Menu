using System.Collections.Generic;

using Pizza.Models.Menu.ListDishesAndSides;

namespace Pizza
{
    public class ListDishes : ListName, IListGet<Dish>
    {
        protected List<Dish> listDisches;
        protected Dish disch = new Dish();

        protected void AddDishesToList( List<string> key )
        {
            listDisches = new List<Dish>();

            foreach (var k in key)
            {
                disch = new Dish();
                string dishAndPrice = Name.GetNameConfig(k);
                string name = FindName(dishAndPrice);
                string price = HelpFinding.FindPrice(dishAndPrice);
                disch.Name = name;
                disch.Price = price;
                listDisches.Add( disch );
            }
        }

        public virtual List<Dish> GetList()
        {
            return new List<Dish>();
        }
    }
}

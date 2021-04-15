using System.Collections.Generic;

using Pizza.Models.Menu.ListDishesAndSides;
using Pizza.Presenters.PresenterFormMenu.LoadDishesAndSideDishForm1;

namespace Pizza
{
    public abstract class ListDishes : ListName, IForm1Dishes
    {
        protected List<Dish> listDisches;
        protected Dish disch = new Dish();

        public abstract List<Dish> GetDishes();

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

    }
}

using System.Collections.Generic;

namespace Pizza
{
    public class ListDrinks : ListDishes
    {
        public List<Dish> LoadListDrinks()
        {
            List<string> key = new List<string> { "coffeePrice", "teaPrice", "colaPrice" };
            AddDishesToList( key );

            return listDisches;
        }

        public override List<Dish> GetDishes()
        {
            return LoadListDrinks();
        }

    }
}

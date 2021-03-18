using System.Collections.Generic;

namespace Test
{
    public class ListDrinks : ListDishes, IForm1Dishes
    {
        public List<Dish> LoadListDrinks()
        {
            List<string> key = new List<string> { "coffeePrice", "teaPrice", "colaPrice" };
            AddDishesToList(key);
            return listDisches;
        }

        public List<Dish> GetDishes()
        {
            return LoadListDrinks();
        }
    }
}

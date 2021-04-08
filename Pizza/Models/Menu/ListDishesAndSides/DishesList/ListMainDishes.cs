using Pizza.Presenters.PresenterFormMenu.LoadDishesAndSideDishForm1;
using System.Collections.Generic;

namespace Pizza
{
    public class ListMainDishes : ListDishes, IForm1Dishes
    {
        private List<Dish> LoadListMainDish()
        {
            List<string> key = new List<string> { "schnitzelPrice", "fishPrice", "potatoPrice" };
            AddDishesToList( key );
            return listDisches;
        }

        public override List<Dish> GetDishes()
        {
            return LoadListMainDish();
        }
    }
}

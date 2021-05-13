using System.Collections.Generic;

using Pizza.Presenters.PresenterFormMenu.LoadDishesAndSideDishForm1;

namespace Pizza
{
    public class ListPizza : ListDishes
    {
        private List<Dish> LoadListPizza()
        {
            List<string> key = new List<string> { "marghPrice", "vegetPrice", "toscaPrice", "venecPrice" };
            AddDishesToList( key );

            return listDisches;
        }

        public override List<Dish> GetList()
        {
            return LoadListPizza();
        }
    }
}

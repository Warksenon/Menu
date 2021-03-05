using Pizza.Models.Menu.Dishes;
using Pizza.Presenters.PresenterForm1.LoadDishesAndSideDishForm1;
using System;
using System.Collections.Generic;

namespace Pizza.Models.Menu
{
    public class ListPizza : ListDishes, IForm1Dishes
    {
        private List<Dish> LoadListPizza()
        {
            List<string> key = new List<string> { "marghPrice", "vegetPrice", "toscaPrice", "venecPrice" };
            AddDishesToList(key);
            return listDisches;
        }

        public List<Dish> GetDishes()
        {
            return LoadListPizza();
        }
    }
}

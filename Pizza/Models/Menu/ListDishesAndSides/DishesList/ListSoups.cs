﻿using Pizza.Presenters.PresenterFormMenu.LoadDishesAndSideDishForm1;
using System.Collections.Generic;

namespace Pizza
{
    public class ListSoups : ListDishes
    {
        private List<Dish> LoadListSoups()
        {
            List<string> key = new List<string> { "tomatoPrice", "chickenSoupPrice" };
            AddDishesToList( key );
            return listDisches;
        }

        public override List<Dish> GetDishes()
        {
            return LoadListSoups();
        }
    }
}
using Pizza.Models.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Presenters.PresenterForm1.LoadDishesAndSideDishForm1
{
    interface IForm1Dishes
    {
        List<Dish> Dishes();
    }
}

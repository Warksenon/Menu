using Pizza.Models.Order;
using System.Collections.Generic;

namespace Pizza.Presenters.PresenterForm1.LoadDishesAndSideDishForm1
{
    public interface IForm1Sides
    {
        List<Side> GetSides();
    }
}

using Pizza.Models.Order;
using System;
using System.Collections.Generic;

namespace Pizza.Models.Menu.Sides
{
    public abstract class ListSides
    {
        protected  List<Side> sides = new List<Side>();

        protected void AddTolist(List<string> key)
        {
            foreach (var k in key)
            {
                Side side = new Side();
                string sideAndPrice= Name.GetNameConfig(k);
                string name = HelpFinding.FindName(sideAndPrice);
                string price = HelpFinding.FindPrice(sideAndPrice);
                side.Name = name;
                side.Price = price;
                sides.Add(side);
            }
        }
    }
}

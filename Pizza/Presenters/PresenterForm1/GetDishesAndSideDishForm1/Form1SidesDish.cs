using Pizza.Models.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Presenters.PresenterForm1.GetDishesAndSideDishForm1
{
    public class Form1SidesDish : Form1Quantity
    {
        private readonly IForm1ChecedListBoxSides loadSides;

        public Form1SidesDish(Form1 form1) : base(form1)
        {
            loadSides = form1;
        }

        public List<Side> GetListSides()
        {
            List<Side> list = new List<Side>();
            foreach (object item in loadSides.CheckedListBoxSide.CheckedItems)
            {
                Side side = new Side();
                string textItem = item.ToString();
                string name = HelpFinding.FindName(textItem);
                string price = HelpFinding.FindPrice(textItem);
                side.Name = name;
                side.Price = price;                
                list.Add(side);
            }
            return list;
        }
    }
}

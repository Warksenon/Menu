using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Presenters.PresenterForm1.GetDishesAndSideDishForm1
{
    class Form1SidesDish : Form1Quantity
    {
        private readonly IForm1ChecedListBoxSides loadSides;

        public Form1SidesDish(Form1 form1) : base(form1)
        {
            loadSides = form1;
        }

        public void AddDishesToListViewOrder()
        {
            foreach (object item in loadSides.CheckedListBoxSide.CheckedItems)
            {
                if (side.Equals(""))
                {
                    side += item.ToString();
                }
                else
                {
                    side += ", ";
                    side += item.ToString();
                }
            }
        }
    }
}

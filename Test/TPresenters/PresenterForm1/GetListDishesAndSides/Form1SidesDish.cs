using Pizza.Models.Menu.Sides;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Form1SidesDish : Form1Quantity
    {
        private readonly IForm1ChecedListBoxSides loadSides;

        public Form1SidesDish(Form1Test form1) : base(form1)
        {
            loadSides = form1;
        }

        public List<string> GetListSides()
        {
            List<string> list = new List<string>();
            foreach (object item in loadSides.CheckedListBoxSide.CheckedItems)
            {               
                string side = item.ToString();               
                list.Add(side);
            }
            return list;
        }
    }
}

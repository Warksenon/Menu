using Pizza.Models.Order;
using System.Collections.Generic;

namespace Pizza
{
    public class Dish
    {        
        private string name;
        private string price;
        private List<Side> listSides;

        public Dish()
        {
            listSides = new List<Side>();
        }

        public string Name
        {
            get { return HelpFinding.CheckIsNotNull(name); }
            set { name = HelpFinding.CheckIsNotNull(value); }
        }

        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        public List<Side> ListSides
        {
            get { return listSides; }
            set { listSides = value; }
        }

        public void AddSideToList(Side s)
        {
            listSides.Add(s);
        }

    }
}



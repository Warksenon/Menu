using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Models.Order
{
    public class Side
    {        
        private string name;
        private string price;

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
    }
}

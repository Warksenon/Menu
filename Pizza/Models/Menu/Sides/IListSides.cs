using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Models.Menu.Sides
{
    interface IListSides
    {
        void AddSideToList(List<String> listSides, string sideText);     
    }
}

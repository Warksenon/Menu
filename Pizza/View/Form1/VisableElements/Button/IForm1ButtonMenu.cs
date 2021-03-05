using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public interface IForm1ButtonMenu
    {
        Button PizzzaButton { get; set; }
        Button MainButton { get; set; }
        Button SoupButton { get; set; }
        Button DrinksButton { get; set; }       
    }
}

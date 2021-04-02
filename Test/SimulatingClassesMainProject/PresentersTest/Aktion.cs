using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizza.View;

namespace Test
{
    public class Aktion : IAction
    {
        public Aktion() { }


        public void SetLogic(ILogic logic)
        {
            logic.LogicSettings();
        }

        public void SetView(IView view)
        {
            view.ViewSetting();
        }
    }
}

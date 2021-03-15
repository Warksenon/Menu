using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizza.View;

namespace Pizza.Presenters
{
    class Event : IEvent
    {
        public Event() { }


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

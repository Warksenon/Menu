using Pizza.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public interface IEvent
    {
        void SetView(IView view);

        void SetLogic(ILogic logic);
    }
}

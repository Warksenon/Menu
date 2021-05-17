using System.Collections.Generic;

namespace Pizza.Presenters.PresenterFormHistory
{
    public abstract class ListViewHistory : ILogic
    {
        protected FormHistory _form;
        protected static List<Order> orderList = new List<Order>();      

        public ListViewHistory( FormHistory form )
        {
            _form = form;
        }

        public abstract void LogicSettings();
    }
}

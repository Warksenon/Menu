using System.Collections.Generic;

namespace Pizza
{
    public  class LoadOrder
    {
        public List<Order> LoadOrderList(ILoadHistoryOrders load)
        {                     
            return load.LoadHistory();
        }
    }
}

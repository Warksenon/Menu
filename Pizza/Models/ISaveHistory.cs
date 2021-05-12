using System.Collections.Generic;

namespace Pizza
{
    public interface ISaveHistory
    {
        void SaveHistoryOrders(List<Order> listOrders);
    }
}

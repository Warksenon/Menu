using Pizza.Presenters;

namespace Pizza
{
    class Save
    {
        public void SaveOrderList(ISaveHistory save)
        {
            save.SaveHistoryOrders();
        }

        public void AddOrderToHistory(IAddOrder save)
        {
            save.AddOrder();
        }
    }
}
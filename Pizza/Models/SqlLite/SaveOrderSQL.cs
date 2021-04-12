using Pizza.Presenters;

namespace Pizza.Models.SqlLite
{
    class SaveOrderSQL : OrderSQL, IAddOrder
    {
        Order order;

        public SaveOrderSQL(Order order)
        {
            this.order = order;
        }

        public void AddOrder()
        {
            AddNewTaskOrder(order);
        }
    }
}

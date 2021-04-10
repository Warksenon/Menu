using Pizza;
using Pizza.Presenters;

namespace Test
{
    class AddOrderSQL : OrderSQL, IAddOrder
    {
        Order order;

        public AddOrderSQL(Order order)
        {
            this.order = order;
        }

        public void AddOrder()
        {
            AddNewTaskOrder(order);
        }
    }
}

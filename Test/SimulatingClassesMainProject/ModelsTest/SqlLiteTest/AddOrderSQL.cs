using Pizza;
using Pizza.Presenters;

namespace Test
{
    internal class AddOrderSQL : OrderSQL, IAddOrder
    {
        private readonly Order order;

        public AddOrderSQL( Order order )
        {
            this.order = order;
        }

        public void AddOrder()
        {
            AddNewTaskOrder( order );
        }
    }
}

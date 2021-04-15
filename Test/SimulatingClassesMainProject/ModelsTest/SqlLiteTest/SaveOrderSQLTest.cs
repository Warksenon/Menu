using Pizza;
using Pizza.Presenters;

namespace Test
{
    internal class SaveOrderSQLTest : OrderSQLTest, IAddOrder
    {
        private readonly Order order;

        public SaveOrderSQLTest( Order order )
        {
            this.order = order;
        }

        public void AddOrder()
        {
            AddNewTaskOrder( order );
        }
    }
}

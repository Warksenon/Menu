using Pizza;
using Pizza.Presenters;

namespace Test
{
    internal class SaveOrderSQLTest : OrderSQLTest 
    {
        private readonly Order order;

        public SaveOrderSQLTest( Order order )
        {
            this.order = order;
            AddNewTaskOrder( order );
        }
    }
}

using Pizza;
using Pizza.Presenters;

namespace Test
{
    internal class SaveOrderSQLTest : OrderSQLTest 
    {
        public SaveOrderSQLTest( Order order )
        {
            AddNewTaskOrder( order );
        }
    }
}

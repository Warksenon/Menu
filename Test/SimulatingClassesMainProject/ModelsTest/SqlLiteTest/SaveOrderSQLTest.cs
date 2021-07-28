using Pizza;

namespace Test
{
    internal class SaveOrderSQLTest : OrderSQLTest
    {
        public SaveOrderSQLTest ( Order order )
        {
            AddNewTaskOrder( order );
        }
    }
}

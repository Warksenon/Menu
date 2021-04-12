using Pizza.Presenters;

namespace Pizza.Models.SqlLite
{
    internal class SaveOrderSQL : OrderSQL, IAddOrder
    {
        private readonly Order order;

        public SaveOrderSQL( Order order )
        {
            this.order = order;
        }

        public void AddOrder()
        {
            AddNewTaskOrder( order );
        }
    }
}

using Pizza.Presenters;

namespace Pizza.Models.SqlLite
{
    internal class SaveOrderSQL : OrderSQL
    {
        public SaveOrderSQL( Order order )
        {
            AddNewTaskOrder( order );
        }
    }
}

using System.Collections.Generic;

using Pizza;

namespace Test
{
    internal class JsonHelperTest
    {
        private List<Order> list;

        public JsonHelperTest ()
        {
            list = new List<Order>();
        }

        public List<Order> List
        {
            get { return list; }
            set
            {
                if (value != null)
                {
                    list = value;
                }
            }
        }

        public void AddOrder ( Order order )
        {
            List.Add( order );
        }
    }
}

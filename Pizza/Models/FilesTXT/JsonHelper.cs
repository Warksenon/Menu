using System.Collections.Generic;

namespace Pizza.Models.FilesTXT
{
    class JsonHelper
    {
        List<Order> list;

        public JsonHelper()
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

        public void AddOrder(Order order)
        {
            List.Add(order);
        }
    }
}

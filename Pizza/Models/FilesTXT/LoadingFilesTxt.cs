using Newtonsoft.Json;
using Pizza.Models.FilesTXT;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Pizza
{
    public class LoadingFilesTxt : ILoadHistoryOrders
    {
        const string _path = @"c:\SQL\Konsola\sqlite\Historia zamówień.txt";

        private List<Order> LoadOrderListFromTxt()
        {
            List<Order> orderList = new List<Order>();
       
            try
            {
                string jsonFromFile;
                using (var reader = new StreamReader(_path))
                {
                    jsonFromFile = reader.ReadToEnd();
                }

              var order = JsonConvert.DeserializeObject<ListOrder>(jsonFromFile);
              orderList = order.List;
            }
            catch (Exception ex)
            {
                // ignored
            }

            return orderList;
        }

        public List<Order> LoadHistory()
        {
            return LoadOrderListFromTxt();
        }
    }
}

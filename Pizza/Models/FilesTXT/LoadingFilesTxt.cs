using Newtonsoft.Json;
using Pizza.Models.FilesTXT;
using System;
using System.Collections.Generic;
using System.IO;

namespace Pizza
{
    class LoadingFilesTxt : Files, ILoadHistoryOrders
    {
        private List<Order> LoadOrderListFromTxt()
        {

            try
            {
                string jsonFromFile;
                using (var reader = new StreamReader(_path))
                {
                    jsonFromFile = reader.ReadToEnd();
                }

                var order = JsonConvert.DeserializeObject<JsonHelper>(jsonFromFile);
                listOrder = order.List;
            }
            catch (Exception e)
            {
                RecordOfExceptions.Save(e.ToString(), "LoadOrderListFromTxt");
            }

            return listOrder;
        }

        public List<Order> LoadHistory()
        {
            return LoadOrderListFromTxt();
        }
    }
}

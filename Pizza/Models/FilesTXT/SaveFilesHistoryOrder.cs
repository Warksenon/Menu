using System;
using System.Collections.Generic;
using System.IO;

using Newtonsoft.Json;

using Pizza.Models.FilesTXT;

namespace Pizza
{

    class SaveFilesHistoryOrder : Files, ISaveHistory
    { 
         public SaveFilesHistoryOrder(List<Order> listOrder)
        {
            this.listOrder= listOrder;
        }

        private void SaveListOrder()
        {
            try
            {
               JsonHelper jsonHelper = new JsonHelper();
               jsonHelper.List = listOrder;
               var customer = jsonHelper;

                var jsonToWrite = JsonConvert.SerializeObject(customer, Formatting.Indented);

                using (var writer = new StreamWriter(_path))
                {
                    writer.Write(jsonToWrite);
                }
            }
            catch (Exception ex)
            {
                RecordOfExceptions.Save(Convert.ToString(ex), "SaveListOrder");
            }
        }

        public void SaveHistoryOrders()
        {
            SaveListOrder();
        }
    }
}


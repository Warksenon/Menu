using System;
using System.Collections.Generic;
using System.IO;

using Newtonsoft.Json;

using Pizza.Models.FilesTXT;

namespace Pizza
{
    internal class SaveFilesHistoryOrder : Files, ISaveHistory
    {
        public SaveFilesHistoryOrder( List<Order> listOrder )
        {
            CreateFolder();
            this.listOrder = listOrder;
        }

        private void SaveListOrder()
        {
            try
            {
                JsonHelper jsonHelper = new JsonHelper
                {
                    List = listOrder
                };
                var customer = jsonHelper;

                var jsonToWrite = JsonConvert.SerializeObject(customer, Formatting.Indented);

                using (var writer = new StreamWriter( fileName ))
                {
                    writer.Write( jsonToWrite );
                }
            }
            catch (Exception ex)
            {
                RecordOfExceptions.Save( Convert.ToString( ex ), "SaveListOrder" );
            }
        }

        public void SaveHistoryOrders()
        {
            SaveListOrder();
        }
    }
}


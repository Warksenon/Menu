using System;
using System.Collections.Generic;
using System.IO;

using Newtonsoft.Json;

using Pizza;

namespace Test
{
    internal class SaveFilesHistoryOrderTest : FilesTest, ISaveHistory
    {
        public SaveFilesHistoryOrderTest( List<Order> listOrder )
        {
            this.listOrder = listOrder;
        }

        private void SaveListOrder()
        {
            try
            {
                JsonHelperTest jsonHelper = new JsonHelperTest
                {
                    List = listOrder
                };
                var customer = jsonHelper;

                var jsonToWrite = JsonConvert.SerializeObject(customer, Formatting.Indented);

                using (var writer = new StreamWriter( _path ))
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


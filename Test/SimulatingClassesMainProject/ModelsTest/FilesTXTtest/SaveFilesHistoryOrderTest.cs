using System;
using System.Collections.Generic;
using System.IO;

using Newtonsoft.Json;

using Pizza;

using Test.SimulatingClassesMainProject.ModelsTest;

namespace Test
{
    internal class SaveFilesHistoryOrderTest : FilesTest, ISaveHistory<Order>, IDataCleansing
    {
        public SaveFilesHistoryOrderTest()
        {
            CreateFolder();

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

        public void SaveHistoryOrders( List<Order> listOrder )
        {
            this.listOrder = listOrder;
            SaveListOrder();
        }

        public void DeleteData()
        {
            try
            {
                using (var writer = new StreamWriter( fileName ))
                {
                    writer.Write( "" );
                }
            }
            catch (Exception ex)
            {
                RecordOfExceptions.Save( Convert.ToString( ex ), "DeleteData" );
            }
        }
    }
}


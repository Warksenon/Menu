using System;
using System.Collections.Generic;
using System.IO;

using Newtonsoft.Json;

using Pizza;

namespace Test
{
    internal class LoadingFilesTxtTest : FilesTest, Pizza.IList<Order>
    {
        private List<Order> LoadOrderListFromTxt()
        {
            try
            {
                string jsonFromFile;

                using (var reader = new StreamReader( fileName ))
                {
                    jsonFromFile = reader.ReadToEnd();
                }
                var order = JsonConvert.DeserializeObject<JsonHelperTest>(jsonFromFile);
                listOrder = order.List;
            }
            catch (Exception e)
            {
                RecordOfExceptions.Save( e.ToString(), "LoadOrderListFromTxt" );
            }

            return listOrder;
        }

        public List<Order> GetList()
        {
            return LoadOrderListFromTxt();
        }
    }
}

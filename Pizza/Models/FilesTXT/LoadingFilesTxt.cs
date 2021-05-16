using System;
using System.Collections.Generic;
using System.IO;

using Newtonsoft.Json;

using Pizza.Models.FilesTXT;

namespace Pizza
{
    internal class LoadingFilesTxt : Files, IListGet<Order>
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

                var order = JsonConvert.DeserializeObject<JsonHelper>(jsonFromFile);
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

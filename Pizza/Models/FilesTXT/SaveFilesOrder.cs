using System;
using System.IO;
using Newtonsoft.Json;
using Pizza.Presenters;

namespace Pizza.Models.FilesTXT
{
    class SaveFilesOrder  : Files  , IAddOrder
    {
        Order order;

        public SaveFilesOrder( Order order)
        {
            this.order = order;
        }

        private void Save()
        {
            try
            {
                LoadHistoryToListOrder();
                listOrder.Add( order );
                SaveFilesHistoryOrder saveList = new SaveFilesHistoryOrder(listOrder);
                saveList.SaveHistoryOrders();
              
                //var customer = listOrder;
                //var jsonToWrite = JsonConvert.SerializeObject(customer, Formatting.Indented);

                //using (StreamWriter writer = new StreamWriter( (_path) ))
                //{
                //    writer.Write( jsonToWrite );
                //}
            }
            catch (Exception ex)
            {
                RecordOfExceptions.Save( Convert.ToString( ex ), "Save" );
            }
        }

        private void LoadHistoryToListOrder()
        {
            LoadingFilesTxt load = new LoadingFilesTxt();
            listOrder = load.LoadHistory();
        }

        public void AddOrder()
        {
            Save();
        }
    }
}

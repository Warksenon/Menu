using System;

using Pizza;
using Pizza.Presenters;

namespace Test
{
    internal class SaveFilesOrderTest : FilesTest, IAddOrder
    {
        private readonly Order order;

        public SaveFilesOrderTest( Order order )
        {
            this.order = order;
        }

        private void Save()
        {
            try
            {
                LoadHistoryToListOrder();
                listOrder.Add( order );
                SaveFilesHistoryOrderTest saveList = new SaveFilesHistoryOrderTest(listOrder);
                saveList.SaveHistoryOrders();
            }
            catch (Exception ex)
            {
                RecordOfExceptions.Save( Convert.ToString( ex ), "Save" );
            }
        }

        private void LoadHistoryToListOrder()
        {
            LoadingFilesTxtTest load = new LoadingFilesTxtTest();
            listOrder = load.LoadHistory();
        }

        public void AddOrder()
        {
            Save();
        }
    }
}

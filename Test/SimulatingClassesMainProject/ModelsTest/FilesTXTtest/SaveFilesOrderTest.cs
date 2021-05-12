using System;

using Pizza;
using Pizza.Presenters;

namespace Test
{
    internal class SaveFilesOrderTest : FilesTest
    {
        private readonly Order order;

        public SaveFilesOrderTest( Order order )
        {
            this.order = order;
            Save();
        }

        private void Save()
        {
            try
            {
                LoadHistoryToListOrder();
                listOrder.Add( order );
                SaveFilesHistoryOrderTest saveList = new SaveFilesHistoryOrderTest();
                saveList.SaveHistoryOrders( listOrder );
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
    }
}

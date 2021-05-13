using System;

namespace Pizza.Models.FilesTXT
{
    internal class SaveFilesOrder : Files
    {
        private readonly Order order;

        public SaveFilesOrder( Order order )
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
                var saveList = new SaveFilesHistoryOrder();
                saveList.SaveHistoryOrders( listOrder );
            }
            catch (Exception ex)
            {
                RecordOfExceptions.Save( Convert.ToString( ex ), "Save" );
            }
        }

        private void LoadHistoryToListOrder()
        {
            var load = new LoadingFilesTxt();
            listOrder = load.GetList();
        }

    }
}

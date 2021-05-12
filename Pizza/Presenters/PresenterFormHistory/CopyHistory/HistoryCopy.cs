namespace Pizza.Presenters.PresenterFormHistory.CopyHistory
{
    public class HistoryCopy 
    {
        public HistoryCopy( ILoadHistoryOrders load, ISaveHistory save )
        {
            CopyHistory( load, save );
        }

        private void CopyHistory ( ILoadHistoryOrders load, ISaveHistory save )
        {
            var copyListOrder = load.LoadHistory();
            save.SaveHistoryOrders( copyListOrder );
        }
    }
}

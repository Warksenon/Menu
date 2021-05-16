namespace Pizza.Presenters.PresenterFormHistory.CopyHistory
{
    public class HistoryCopy
    {
        public HistoryCopy( IListGet<Order> load, ISaveHistory<Order> save )
        {
            CopyHistory( load, save );
        }

        private void CopyHistory( IListGet<Order> load, ISaveHistory<Order> save )
        {
            var copyListOrder = load.GetList();
            save.SaveHistoryOrders( copyListOrder );
        }
    }
}

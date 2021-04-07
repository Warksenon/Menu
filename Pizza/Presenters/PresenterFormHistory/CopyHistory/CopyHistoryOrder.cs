using System.Collections.Generic;
namespace Pizza.Presenters.PresenterFormHistory.CopyHistory
{
    abstract class CopyHistoryOrder : ListViewHistory
    {
        protected SaveHistory save = new SaveHistory();
        protected List<Order> copyListOrder = new List<Order>();

        public CopyHistoryOrder( FormHistory form ) : base( form ) { }
    }
}

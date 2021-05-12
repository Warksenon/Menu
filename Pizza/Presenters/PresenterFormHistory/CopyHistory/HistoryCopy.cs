using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Presenters.PresenterFormHistory.CopyHistory
{
    public class HistoryCopy  <L,S> where L : ILoadHistoryOrders where S : ISaveHistory   
    {
        public void CopyHistory ( L load, S save )
        {
            var copyListOrder = load.LoadHistory();
            save.SaveHistoryOrders( copyListOrder );
        }
    }
}

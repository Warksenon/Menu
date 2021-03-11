using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Presenters.PresenterForm1
{
    class RemoveOrder
    {
        IForm1ListViewOrder lvOrder;
        public RemoveOrder(Form1 form1)
        {
            lvOrder = form1;
        }

        public void RemoveOne()
        {
            lvOrder.ListViewOrder.SelectedItems[0].Remove();
        }

        public void RemoveAll()
        {
            lvOrder.ListViewOrder.Items.Clear();
        }
    }
}

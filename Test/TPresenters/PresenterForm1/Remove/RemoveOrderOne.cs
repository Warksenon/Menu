using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class RemoveOrderOne : RemoveOrder
    {
        public RemoveOrderOne(Form1Test form1) : base(form1) { }

        public override void LogicSettings()
        {
            lvOrder.ListViewOrder.SelectedItems[0].Remove();
        }
    }
}

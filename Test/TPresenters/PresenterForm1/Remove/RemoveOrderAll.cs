using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test 
{
    class RemoveOrderAll  : RemoveOrder
    {
        public RemoveOrderAll (Form1Test form1) : base(form1) { }

        public override void LogicSettings()
        {
            lvOrder.ListViewOrder.Items.Clear();
        }
    }
}

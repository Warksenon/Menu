using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizza.View.Form1;


namespace Pizza
{
    class ButtonRemoveAll : ButtonRemove
    {
        public ButtonRemoveAll(FormMenu form1) : base(form1) { }

        public override void ViewSetting()
        {
            RemoveAll();
        }
    }
}

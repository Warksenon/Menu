using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class ButtonRemoveOne : ButtonRemove
    {
        public ButtonRemoveOne(Form1Test form1) : base(form1) { }

        public override void ViewSetting()
        {
            SetSettingsButton();
        }

        private void SetSettingsButton()
        {
            if (CheckingListOrderIfEmpty())
            {
                RemoveAll();
            }
            else
            {
                remove.ButtonRemoveOne.Visible = false;
            }

        }

        private bool CheckingListOrderIfEmpty()
        {
            if (lvOrder.ListViewOrder.Items.Count < 1) return true;
            else return false;
        }
    }
}

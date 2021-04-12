﻿using Pizza;

namespace Test
{
    public class ButtonRemoveOne : ButtonRemove
    {
        private readonly bool checkingListOrderIfEmpty;
        public ButtonRemoveOne( FormMenu form, bool checkingListOrderIfEmpty ) : base( form )
        {
            this.checkingListOrderIfEmpty = checkingListOrderIfEmpty;
        }

        public override void ViewSetting()
        {
            SetSettingsButton();
        }

        private void SetSettingsButton()
        {
            if (checkingListOrderIfEmpty)
            {
                RemoveAll();
            }
            else
            {
                form.ButtonRemoveOne.Visible = false;
                ButtonRemoveOneVisibility = false;
                ButtonRemoveAllVisibility = true;
            }
        }
        //Todo usunać
        //private bool CheckingListOrderIfEmpty()
        //{
        //    if (form.ListViewOrder.Items.Count < 1)
        //        return true;
        //    else
        //        return false;
        //}
    }
}

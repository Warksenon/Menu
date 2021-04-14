using Pizza;

namespace Test
{
    public class ButtonRemoveOne : ButtonRemove
    {
        bool checkingListOrderIfEmpty;
        public ButtonRemoveOne(FormMenu form, bool checkingListOrderIfEmpty) : base(form)
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
                ButtonRemoveOne = false;
                ButtonRemoveAll = true;
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

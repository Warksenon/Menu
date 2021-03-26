using Pizza.Presenters.PresenterForm1;

namespace Pizza
{
    public class ButtonRemoveOne : ButtonRemove
    {
        public ButtonRemoveOne(FormMenu form) : base(form) { }

        public override void ViewSetting()
        {
            SetSettingsButton();
            eevent.SetView(new Form1LabelPricePresenter(form));
        }

        private void SetSettingsButton()
        {
            if (CheckingListOrderIfEmpty())
            {
                RemoveAll();
            }
            else
            {
                form.ButtonRemoveOne.Visible = false;
                ButtonRemoveOne = false;
            }
        }

        private bool CheckingListOrderIfEmpty()
        {
            if (form.ListViewOrder.Items.Count < 1) return true;
            else return false;
        }
    }
}

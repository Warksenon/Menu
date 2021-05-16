using System.Drawing;

namespace Pizza
{
    public class ButtonRemoveView : IView
    {
        private readonly RemoveFormMenu _bRemove;
        private readonly FormMenu _form;
        public ButtonRemoveView( FormMenu form, RemoveFormMenu bRemove )
        {
            _bRemove = bRemove;
            _form = form;
        }

        public void ViewSetting()
        {
            Remove();
        }

        private void Remove()
        {
            switch (_bRemove)
            {
                case RemoveFormMenu.One:
                SetSettingsButton();
                break;
                case RemoveFormMenu.All:
                RemoveAll();
                break;
            }
        }

        private void SetSettingsButton()
        {
            if (CheckingListOrderIfEmpty())
            {
                RemoveAll();
            }
            else
            {
                _form.ButtonRemoveOne.Visible = false;
            }
        }

        private bool CheckingListOrderIfEmpty()
        {
            if (_form.ListViewOrder.Items.Count < 1)
                return true;
            else
                return false;
        }

        private void RemoveAll()
        {
            _form.ButtonSubmitOrder.BackColor = SystemColors.Control;
            _form.ButtonRemoveAll.Visible = false;
            _form.ButtonRemoveOne.Visible = false;
        }
    }
}

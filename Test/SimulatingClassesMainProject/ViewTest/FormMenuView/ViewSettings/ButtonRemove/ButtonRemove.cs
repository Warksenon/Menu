using Pizza;
using System.Drawing;

namespace Test
{
    public abstract class ButtonRemove : ViewFormMenu, IView
    {
        protected ButtonRemove(FormMenu form) : base(form) { }

        public abstract void ViewSetting();

        protected void RemoveAll()
        {
            form.ButtonSubmitOrder.BackColor = SystemColors.Control;
            form.ButtonRemoveAll.Visible = false;
            ButtonRemoveAll = false;
            form.ButtonRemoveOne.Visible = false;
            ButtonRemoveOne = false;

        }
    }
}

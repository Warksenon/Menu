using System.Drawing;

using Pizza;

namespace Test
{
    public abstract class ButtonRemove : ViewFormMenu, IView
    {
        protected ButtonRemove( FormMenu form ) : base( form ) { }

        public abstract void ViewSetting();

        protected void RemoveAll()
        {
            form.ButtonSubmitOrder.BackColor = SystemColors.Control;
            form.ButtonRemoveAll.Visible = false;
            ButtonRemoveAllVisibility = false;
            form.ButtonRemoveOne.Visible = false;
            ButtonRemoveOneVisibility = false;

        }
    }
}

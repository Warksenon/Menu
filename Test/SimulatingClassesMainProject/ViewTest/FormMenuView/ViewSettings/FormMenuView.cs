using Pizza;
using Pizza.View.Form1View;

namespace Test
{
    class FormMenuView : ViewFormMenu, IView
    {
        public FormMenuView(FormMenu form) : base(form) { }

        public void ViewSetting()
        {
            eevent.SetView(new ButtonPizzaView(form));
            eevent.SetView(new ButtonRemoveAll(form));
        }
    }
}

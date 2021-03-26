using Pizza.Presenters.PresenterForm1.VisableElements.Button;
using Pizza.View.Form1View;

namespace Pizza.View.FormMenuView.ViewSettings
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

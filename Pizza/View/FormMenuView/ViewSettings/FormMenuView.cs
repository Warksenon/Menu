using Pizza.Presenters.PresenterFormMenu.VisableElements.Button;
using Pizza.View.Form1View;

namespace Pizza.View.FormMenuView.ViewSettings
{
    internal class FormMenuView : ViewFormMenu, IView
    {
        public FormMenuView( FormMenu form ) : base( form ) { }

        public void ViewSetting()
        {
            eevent.SetView( new ButtonPizzaView( form ) );
            eevent.SetView( new ButtonRemoveAll( form ) );
        }
    }
}

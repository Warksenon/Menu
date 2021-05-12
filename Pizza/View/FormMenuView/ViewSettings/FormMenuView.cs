using Pizza.View.Form1View;
using Pizza.View.Form1View.ViewSettings.ButtonMenu;

namespace Pizza.View.FormMenuView.ViewSettings
{
    internal class FormMenuView : ViewFormMenu, IView
    {
        public FormMenuView( FormMenu form ) : base( form ) { }

        public void ViewSetting()
        {
            eevent.SetView( new ButtonMenuView( form, ButtonLoadMenu.Pizza )  );
            eevent.SetView( new ButtonRemoveAll( form ) );
        }
    }
}

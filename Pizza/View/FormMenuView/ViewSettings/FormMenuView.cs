using Pizza.View.Form1View;
using Pizza.View.Form1View.ViewSettings.ButtonMenu;

namespace Pizza.View.FormMenuView.ViewSettings
{
    internal class FormMenuView : ViewFormMenu, IView
    {
        public FormMenuView( FormMenu form ) : base( form ) { }

        public void ViewSetting()
        {
            new ButtonMenuView( _form).PizzaButtonSettings();
            eevent.SetView( new ButtonRemoveView( _form, RemoveFormMenu.All ) );
        }
    }
}

using Pizza.SqlLite;
using Pizza.View.Form1View;

namespace Pizza.Presenters.PresenterFormMenu
{
    internal class FormMenuLogic : ViewFormMenu, ILogic
    {
        public FormMenuLogic( FormMenu form ) : base( form ) { }

        public void LogicSettings()
        {
            eevent.SetLogic( new LogicMenuButton( form, ButtonLoadMenu.Pizza ) );
            eevent.SetLogic( new CreateSQLiteTables() );
        }
    }
}

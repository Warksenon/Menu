using Pizza.Presenters.PresenterFormMenu.Logic;
using Pizza.SqlLite;
using Pizza.View.Form1View;

namespace Pizza.Presenters.PresenterFormMenu
{
    class FormMenuLogic : ViewFormMenu, ILogic
    {
        public FormMenuLogic( FormMenu form ) : base( form ) { }

        public void LogicSettings()
        {
            eevent.SetLogic( new ButtonPizzaLogic( form ) );
            eevent.SetLogic( new CreateSQLiteTables() );
        }
    }
}

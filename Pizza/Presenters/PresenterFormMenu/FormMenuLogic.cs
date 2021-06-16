using Pizza.SqlLite;
using Pizza.View.Form1View;

namespace Pizza.Presenters.PresenterFormMenu
{
    internal class FormMenuLogic : ViewFormMenu, ILogic
    {
        public FormMenuLogic( FormMenu form ) : base( form ) { }

        public void LogicSettings()
        {
            MenuDishes.CreateMenuPizza( new DishesListView( _form ), new SidesCheckListBox( _form ) );
            eevent.SetLogic( new CreateSQLiteTables() );
        }
    }
}

using Pizza;
using Pizza.Presenters.PresenterFormMenu;

namespace Test
{
    public abstract class MenuButton : ILogic
    {
        protected Form1LoadSidesPresenter loadSidesToCheckedListBox;
        protected DishesListView loadDishesToListView;

        protected MenuButton( FormMenu form1 )
        {
            loadSidesToCheckedListBox = new Form1LoadSidesPresenter( form1 );
            loadDishesToListView = new DishesListView( form1 );
        }

        public abstract void LogicSettings();
    }
}

using Pizza;
using Pizza.Presenters.PresenterFormMenu;


namespace Test
{
    public class LogicMenuButtonTest : ILogic
    {
        private readonly SidesCheckListBoxTest loadSidesToCheckedListBox;
        private readonly DishesListViewTest loadDishesToListView;
        private readonly ButtonLoadMenu buttonMenu;

        public LogicMenuButtonTest( FormMenu form1, ButtonLoadMenu buttonMenu )
        {
            this.buttonMenu = buttonMenu;
            loadSidesToCheckedListBox = new SidesCheckListBoxTest( form1 );
            loadDishesToListView = new DishesListViewTest( form1 );
        }

        public void LogicSettings()
        {
            var listSides = new ListSidesFactory( buttonMenu ).GetList();
            var listDishes = new ListDishesFactory( buttonMenu ).GetList();           
            loadSidesToCheckedListBox.SetList( listSides );
            loadDishesToListView.SetList( listDishes );
        }
    }
}

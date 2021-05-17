using Pizza.Presenters.PresenterFormMenu;


namespace Pizza
{
    public class LogicMenuButton : ILogic
    {
        private readonly SidesCheckListBox loadSidesToCheckedListBox;
        private readonly DishesListView loadDishesToListView;
        private readonly ButtonLoadMenu buttonMenu;

        public LogicMenuButton( FormMenu form1, ButtonLoadMenu buttonMenu )
        {
            this.buttonMenu = buttonMenu;
            loadSidesToCheckedListBox = new SidesCheckListBox( form1 );
            loadDishesToListView = new DishesListView( form1 );
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

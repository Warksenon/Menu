using Pizza.Presenters.PresenterFormMenu.LoadDishesAndSideDishForm1;

namespace Pizza
{
    public class LogicMenuButton : ILogic
    {
        private Form1LoadSidesPresenter loadSidesToCheckedListBox;
        private Form1LoadDishesPresenters loadDishesToListView;
        private ButtonLoadMenu buttonMenu;

        public LogicMenuButton( FormMenu form1, ButtonLoadMenu buttonMenu )
        {
            this.buttonMenu = buttonMenu;
            loadSidesToCheckedListBox = new Form1LoadSidesPresenter( form1 );
            loadDishesToListView = new Form1LoadDishesPresenters( form1 );
        }

        private void SetConversionStrategy(  )
        {
            switch (buttonMenu)
            {
                case ButtonLoadMenu.Pizza:
                loadSidesToCheckedListBox.LoadCheckListBoxSideDishe( new ListSidesPizza() );
                loadDishesToListView.AddDishesToListView( new ListPizza() );
                break;
                case ButtonLoadMenu.MainDishes:
                loadSidesToCheckedListBox.LoadCheckListBoxSideDishe( new ListSidesMainDishes() );
                loadDishesToListView.AddDishesToListView( new ListMainDishes() );
                break;
                case ButtonLoadMenu.Soups:
                loadSidesToCheckedListBox.ClearCheckedListBox();
                loadDishesToListView.AddDishesToListView( new ListSoups() );
                break;
                case ButtonLoadMenu.Drinks:
                loadSidesToCheckedListBox.ClearCheckedListBox();
                loadDishesToListView.AddDishesToListView( new ListDrinks() );
                break;
            }
        }

        public void LogicSettings()
        {
            SetConversionStrategy();
        }
    }
}

using Pizza.Presenters.PresenterFormMenu.Logic.ButtonMenu;

namespace Pizza.Presenters.PresenterFormMenu.Logic
{
    public class ButtonMainDishesLogic : MenuButton
    {
        public ButtonMainDishesLogic( FormMenu form1 ) : base( form1 ) { }

        public override void LogicSettings()
        {
            loadSidesToCheckedListBox.LoadCheckListBoxSideDishe(new ListSidesMainDishes());
            loadDishesToListView.AddDishesToListView( new ListMainDishes() );
        }
    }
}

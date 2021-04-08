using Pizza.Presenters.PresenterFormMenu.Logic.ButtonMenu;

namespace Pizza.Presenters.PresenterFormMenu.Logic
{
    class ButtonDriksLogic : MenuButton
    {
        public ButtonDriksLogic( FormMenu form1 ) : base( form1 ) { }

        public override void LogicSettings()
        {
            loadDishesToListView.LoadDrinks();
            loadSidesToCheckedListBox.ClearCheckedListBox();
        }
    }
}

using Pizza.Presenters.PresenterForm1.Logic.ButtonMenu;

namespace Pizza.Presenters.PresenterForm1.Logic
{
    class ButtonSoupsLogic : MenuButton
    {
        public ButtonSoupsLogic( FormMenu form1 ) : base( form1 ) { }

        public override void LogicSettings()
        {
            loadSidesToCheckedListBox.ClearCheckedListBox();
            loadDishesToListView.LoadSoups();
        }
    }
}

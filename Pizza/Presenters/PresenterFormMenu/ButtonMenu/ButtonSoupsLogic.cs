using Pizza.Presenters.PresenterFormMenu.Logic.ButtonMenu;

namespace Pizza.Presenters.PresenterFormMenu.Logic
{
    public class ButtonSoupsLogic : MenuButton
    {
        public ButtonSoupsLogic( FormMenu form1 ) : base( form1 ) { }

        public override void LogicSettings()
        {
            loadSidesToCheckedListBox.ClearCheckedListBox();
            loadDishesToListView.LoadSoups();
        }
    }
}

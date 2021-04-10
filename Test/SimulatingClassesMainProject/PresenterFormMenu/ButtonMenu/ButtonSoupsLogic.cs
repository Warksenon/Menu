using Pizza.Presenters.PresenterFormMenu.Logic.ButtonMenu;
using Pizza;

namespace Pizza
{
    class ButtonSoupsLogic : MenuButton
    {
        public ButtonSoupsLogic(FormMenu form1) : base(form1) { }

        public override void LogicSettings()
        {
            loadSidesToCheckedListBox.ClearCheckedListBox();
            loadDishesToListView.LoadSoups();
        }
    }
}

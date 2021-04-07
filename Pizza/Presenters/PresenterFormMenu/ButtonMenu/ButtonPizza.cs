using Pizza.Presenters.PresenterForm1.Logic.ButtonMenu;

namespace Pizza.Presenters.PresenterForm1.Logic
{
    public class ButtonPizzaLogic : MenuButton
    {
        public ButtonPizzaLogic( FormMenu form1 ) : base( form1 ) { }

        public override void LogicSettings()
        {
            loadSidesToCheckedListBox.LoadSidesPizza();
            loadDishesToListView.LoadPizza();
        }
    }
}

using Pizza.Presenters.PresenterForm1.Logic.ButtonMenu;

namespace Pizza.Presenters.PresenterForm1.Logic
{
    class ButtonMainDishesLogic : MenuButton
    {
        public ButtonMainDishesLogic(Form1 form1) : base(form1) { }

        public override void LogicSettings()
        {
            loadSidesToCheckedListBox.LoadSidesMainDishes();
            loadDishesToListView.LoadMainDish();
        }
    }
}

using Pizza.Presenters.PresenterForm1.Logic.ButtonMenu;

namespace Test
{
    class ButtonMainDishesLogic : MenuButton
    {
        public ButtonMainDishesLogic(Form1Test form1) : base(form1) { }

        public override void LogicSettings()
        {
            loadSidesToCheckedListBox.LoadSidesMainDishes();
            loadDishesToListView.LoadMainDish();
        }
    }
}

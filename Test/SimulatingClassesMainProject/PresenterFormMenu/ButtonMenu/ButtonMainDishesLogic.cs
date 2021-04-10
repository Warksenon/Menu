using Pizza.Presenters.PresenterFormMenu.Logic.ButtonMenu;
using Pizza;

namespace Pizza
{
    class ButtonMainDishesLogic : MenuButton
    {
        public ButtonMainDishesLogic(FormMenu form1) : base(form1) { }

        public override void LogicSettings()
        {
            loadSidesToCheckedListBox.LoadSidesMainDishes();
            loadDishesToListView.LoadMainDish();
        }
    }
}

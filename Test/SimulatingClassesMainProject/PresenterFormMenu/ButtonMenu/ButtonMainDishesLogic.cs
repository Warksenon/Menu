namespace Pizza
{
    internal class ButtonMainDishesLogic : MenuButton
    {
        public ButtonMainDishesLogic( FormMenu form1 ) : base( form1 ) { }

        public override void LogicSettings()
        {
            loadSidesToCheckedListBox.LoadSidesMainDishes();
            loadDishesToListView.LoadMainDish();
        }
    }
}

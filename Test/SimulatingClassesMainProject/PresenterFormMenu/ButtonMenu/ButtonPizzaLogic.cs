namespace Pizza
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

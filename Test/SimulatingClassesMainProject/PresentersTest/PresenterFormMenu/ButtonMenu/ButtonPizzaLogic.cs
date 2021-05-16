using Pizza;

namespace Test
{
    public class ButtonPizzaLogic : MenuButton
    {
        public ButtonPizzaLogic( FormMenu form1 ) : base( form1 ) { }

        public override void LogicSettings()
        {
            loadSidesToCheckedListBox.LoadSidesPizza();
            loadDishesToListView.SetList( new ListPizza().GetList() );
        }
    }
}

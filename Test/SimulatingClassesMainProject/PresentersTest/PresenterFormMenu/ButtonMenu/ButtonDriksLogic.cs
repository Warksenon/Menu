using Pizza;

namespace Test
{
    internal class ButtonDriksLogic : MenuButton
    {
        public ButtonDriksLogic( FormMenu form1 ) : base( form1 ) { }

        public override void LogicSettings()
        {
            loadDishesToListView.AddDishesToListView( new ListDrinks() );
            loadSidesToCheckedListBox.ClearCheckedListBox();
        }
    }
}

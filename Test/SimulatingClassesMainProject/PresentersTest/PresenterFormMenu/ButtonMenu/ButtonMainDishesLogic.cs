using Pizza;

namespace Test
{
    internal class ButtonMainDishesLogic : MenuButton
    {
        public ButtonMainDishesLogic( FormMenu form1 ) : base( form1 ) { }

        public override void LogicSettings()
        {
            loadSidesToCheckedListBox.LoadSidesMainDishes();
            loadDishesToListView.SetList( new ListMainDishes().GetList() );
        }
    }
}

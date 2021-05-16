using Pizza;

namespace Test
{
    internal class ButtonSoupsLogic : MenuButton
    {
        public ButtonSoupsLogic( FormMenu form1 ) : base( form1 ) { }

        public override void LogicSettings()
        {
            loadSidesToCheckedListBox.ClearCheckedListBox();
            loadDishesToListView.SetList( new ListSoups().GetList() );
        }
    }
}

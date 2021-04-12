namespace Pizza
{
    internal class ButtonSoupsLogic : MenuButton
    {
        public ButtonSoupsLogic( FormMenu form1 ) : base( form1 ) { }

        public override void LogicSettings()
        {
            loadSidesToCheckedListBox.ClearCheckedListBox();
            loadDishesToListView.LoadSoups();
        }
    }
}

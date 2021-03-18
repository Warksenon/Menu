using Pizza.Presenters.PresenterForm1.Logic.ButtonMenu;

namespace Test
{
    class ButtonDriksLogic : MenuButton
    {        
        public ButtonDriksLogic(Form1Test form1):base(form1){}

        public override void LogicSettings()
        {
            loadDishesToListView.LoadDrinks();
            loadSidesToCheckedListBox.ClearCheckedListBox();
        }
    }
}

using System.Drawing;

namespace Test
{
    class ButtonMainDishesView :ButtonMenu
    {
        public ButtonMainDishesView(Form1Test form1) : base(form1) { }

        public override void ViewSetting()
        {
            ClearColorButton();
            MainDishButtonSettings();
        }

        private void MainDishButtonSettings()
        {
            ChengeNameLabelMenuInfo("Dania główne");
            ButtonSeting();
            bMenu.MainButton.BackColor = Color.LawnGreen;
        }
    }
}

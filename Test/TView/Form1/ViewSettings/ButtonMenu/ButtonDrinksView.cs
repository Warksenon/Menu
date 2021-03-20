using System.Drawing;

namespace Test
{
    class ButtonDrinksView : ButtonMenu
    {
        public ButtonDrinksView(Form1Test form1) : base(form1) { }

        public override void ViewSetting()
        {
            ClearColorButton();
            DrinkseButtonSettings();
        }

        private void DrinkseButtonSettings()
        {
            ChengeNameLabelMenuInfo("Napoje");
            ButtonSeting();
            bMenu.DrinksButton.BackColor = Color.LawnGreen;
        }
    }
}

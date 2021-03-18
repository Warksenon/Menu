using System.Drawing;

namespace Test
{
    class ButtonDrinksSettings : ButtonMenu
    {
        public ButtonDrinksSettings(Form1Test form1) : base(form1) { }

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

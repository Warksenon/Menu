using System.Drawing;

namespace Pizza
{
    class ButtonDrinksSettings : ButtonMenu,  IView
    {
        public ButtonDrinksSettings(Form1 form1) : base(form1) { }

        public void ViewSetting()
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

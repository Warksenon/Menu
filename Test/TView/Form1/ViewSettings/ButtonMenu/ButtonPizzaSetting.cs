using System.Drawing;

namespace Test
{
    class ButtonPizzaSetting : ButtonMenu
    {
        public ButtonPizzaSetting(Form1Test form1) : base(form1) { }

        public override void ViewSetting()
        {
            ClearColorButton();
            PizzaButtonSettings();
        }

        private void PizzaButtonSettings()
        {          
            ChengeNameLabelMenuInfo("Pizza");
            ButtonSeting();
            bMenu.PizzzaButton.BackColor = Color.LawnGreen;
        }
    }
}

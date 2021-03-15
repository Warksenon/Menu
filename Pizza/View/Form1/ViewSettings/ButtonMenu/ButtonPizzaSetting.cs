using System.Drawing;

namespace Pizza
{
    class ButtonPizzaSetting : ButtonMenu
    {
        public ButtonPizzaSetting(Form1 form1) : base(form1) { }

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

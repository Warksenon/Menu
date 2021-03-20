using System.Drawing;

namespace Test
{
    class ButtonPizzaView : ButtonMenu
    {
        public ButtonPizzaView(Form1Test form1) : base(form1) { }

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

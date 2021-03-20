using System.Drawing;

namespace Pizza
{
    class ButtonPizzaView : ButtonMenu
    {
        public ButtonPizzaView(Form1 form1) : base(form1) { }

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

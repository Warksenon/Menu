using System.Drawing;

namespace Pizza
{
    class ButtonPizzaSetting : ButtonMenu, IMenuButton
    {
        public ButtonPizzaSetting(Form1 form1) : base(form1) { }

        public void SetButtonSetting()
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

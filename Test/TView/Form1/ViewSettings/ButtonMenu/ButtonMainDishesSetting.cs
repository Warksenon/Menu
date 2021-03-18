using System.Drawing;

namespace Test
{
    class ButtonMainDishesSetting :ButtonMenu
    {
        public ButtonMainDishesSetting(Form1Test form1) : base(form1) { }

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

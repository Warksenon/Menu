using System.Drawing;

namespace Test
{
    class ButtonSoupsSetting :ButtonMenu
    {
        public ButtonSoupsSetting(Form1Test form1) : base(form1) { }

        public override void ViewSetting()
        {
            ClearColorButton();
            SoupsButtonSettings();
        }

        private void SoupsButtonSettings()
        {
            ButtonSeting();
            ChengeNameLabelMenuInfo("Zupy");
            bMenu.SoupButton.BackColor = Color.LawnGreen;             
        }
    }
}

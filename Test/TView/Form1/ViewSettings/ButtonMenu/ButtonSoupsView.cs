using System.Drawing;

namespace Test
{
    class ButtonSoupsView :ButtonMenu
    {
        public ButtonSoupsView(Form1Test form1) : base(form1) { }

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

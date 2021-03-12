using System.Drawing;

namespace Pizza.Presenters.PresenterForm1.VisableElements.Button
{
    class ButtonSoupsSetting :ButtonMenu, IView
    {
        public ButtonSoupsSetting(Form1 form1) : base(form1) { }

        public void ViewSetting()
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

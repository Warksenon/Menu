using System.Drawing;

namespace Pizza.Presenters.PresenterForm1.VisableElements.Button
{
    class ButtonMainDishesSetting :ButtonMenu, IMenuButton
    {
        public ButtonMainDishesSetting(Form1 form1) : base(form1) { }

        public void SetButtonSetting()
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

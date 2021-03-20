using System.Drawing;

namespace Pizza.Presenters.PresenterForm1.VisableElements.Button
{
    class ButtonMainDishesView :ButtonMenu
    {
        public ButtonMainDishesView(Form1 form1) : base(form1) { }

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

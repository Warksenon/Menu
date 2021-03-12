using System.Drawing;

namespace Pizza.Presenters.PresenterForm1.VisableElements.Button
{
    class ButtonMainDishesSetting :ButtonMenu, IView
    {
        public ButtonMainDishesSetting(Form1 form1) : base(form1) { }
      
        private void MainDishButtonSettings()
        {
            ChengeNameLabelMenuInfo("Dania główne");
            ButtonSeting();
            bMenu.MainButton.BackColor = Color.LawnGreen;
        }

        void IView.ViewSetting()
        {
            ClearColorButton();
            MainDishButtonSettings();
        }
    }
}

using Pizza.View.Form1View.ViewSettings.ButtonMenu;
using System.Drawing;

namespace Pizza.Presenters.PresenterForm1.VisableElements.Button
{
    public class ButtonMainDishesView :ButtonMenu
    {
        public ButtonMainDishesView(FormMenu form1) : base(form1) { }

        public override void ViewSetting()
        {
            ClearColorButton();
            MainDishButtonSettings();
        }

        private void MainDishButtonSettings()
        {
            ChengeNameLabelMenuInfo("Dania główne");
            ButtonSeting();
            form.MainButton.BackColor = Color.LawnGreen;
        }
    }
}

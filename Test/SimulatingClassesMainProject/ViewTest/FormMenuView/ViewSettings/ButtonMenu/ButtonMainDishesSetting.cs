using Pizza;
using System.Drawing;

namespace Test
{
    public class ButtonMainDishesView : ButtonMenu
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

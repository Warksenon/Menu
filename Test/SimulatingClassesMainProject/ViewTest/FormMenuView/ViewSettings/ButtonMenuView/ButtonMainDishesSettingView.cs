using System.Drawing;

using Pizza;

namespace Test
{
    public class ButtonMainDishesView : ButtonMenuView
    {
        public ButtonMainDishesView( FormMenu form1 ) : base( form1 ) { }

        public override void ViewSetting()
        {
            ClearColorButton();
            MainDishButtonSettings();
        }

        private void MainDishButtonSettings()
        {
            ChengeNameLabelMenuInfo( "Dania główne" );
            ButtonSeting();
            form.MainButton.BackColor = Color.LawnGreen;
        }
    }
}

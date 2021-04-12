using System.Drawing;

using Pizza;

namespace Test
{
    public class ButtonDrinksView : ButtonMenuView
    {
        public ButtonDrinksView( FormMenu form1 ) : base( form1 ) { }

        public override void ViewSetting()
        {
            ClearColorButton();
            DrinkseButtonSettings();
        }

        private void DrinkseButtonSettings()
        {
            ChengeNameLabelMenuInfo( "Napoje" );
            ButtonSeting();
            form.DrinksButton.BackColor = Color.LawnGreen;
        }
    }
}

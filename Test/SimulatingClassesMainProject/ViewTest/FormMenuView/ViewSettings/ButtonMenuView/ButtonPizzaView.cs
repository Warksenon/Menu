using System.Drawing;

using Pizza;

namespace Test
{
    public class ButtonPizzaView : ButtonMenuView
    {
        public ButtonPizzaView ( FormMenu form ) : base( form ) { }

        public override void ViewSetting ()
        {
            ClearColorButton();
            PizzaButtonSettings();
        }

        private void PizzaButtonSettings ()
        {
            ChengeNameLabelMenuInfo( "Pizza" );
            ButtonSeting();
            form.PizzzaButton.BackColor = Color.LawnGreen;
        }
    }
}

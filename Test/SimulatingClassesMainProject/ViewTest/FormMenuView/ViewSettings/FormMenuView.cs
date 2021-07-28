using Pizza;

namespace Test
{
    internal class FormMenuView : ViewFormMenuTest, IView
    {
        public FormMenuView ( FormMenu form ) : base( form ) { }

        public void ViewSetting ()
        {
            eevent.SetView( new ButtonPizzaView( form ) );
            eevent.SetView( new ButtonRemoveAll( form ) );
        }
    }
}

using Pizza;

namespace Test
{
    public abstract class ViewFormMenu : TestVisibleElements
    {
        protected FormMenu form;
        protected IOnEventTest eevent = new OnEventTest();

        protected ViewFormMenu( FormMenu form )
        {
            this.form = form;
        }
    }
}

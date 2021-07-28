using Pizza;

namespace Test
{
    public abstract class ViewFormMenuTest : TestVisibleElements
    {
        protected FormMenu form;
        protected IOnEventTest eevent = new OnEventTest();

        protected ViewFormMenuTest ( FormMenu form )
        {
            this.form = form;
        }
    }
}

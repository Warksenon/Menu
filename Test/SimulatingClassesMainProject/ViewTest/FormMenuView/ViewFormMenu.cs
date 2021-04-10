using Pizza;

namespace Test
{
    public abstract class ViewFormMenu : TestVisibleElements
    {
        protected FormMenu form;
        protected IOnEvent eevent = new OnEvent();

        protected ViewFormMenu( FormMenu form )
        {
            this.form = form;
        }
    }
}

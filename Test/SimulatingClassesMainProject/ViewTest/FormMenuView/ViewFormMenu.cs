using Pizza;

namespace Test
{
    public abstract class ViewFormMenu : TestVisibleElements
    {
        protected FormMenu form;
        protected IAction eevent = new Aktion();

        protected ViewFormMenu( FormMenu form )
        {
            this.form = form;
        }
    }
}

using Pizza.Presenters;

namespace Pizza.View.Form1View
{
    public abstract class ViewFormMenu
    {
        protected FormMenu form;
        protected IOnEvent eevent = new OnEvent();

        protected ViewFormMenu(FormMenu form)
        {
            this.form = form;
        }
    }
}

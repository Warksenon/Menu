using Pizza.Presenters;

namespace Pizza.View.Form1View
{
    public abstract class ViewFormMenu 
    {
        protected FormMenu form;
        protected IEvent eevent = new Event();

        protected ViewFormMenu(FormMenu form)
        {
            this.form = form;
        }
    }
}

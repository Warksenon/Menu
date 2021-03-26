using Pizza.Presenters;
using Pizza.View.FormMenuView.ViewSettings;

namespace Pizza.View.Form1View
{
    public abstract class ViewFormMenu : TestVisibleElements
    {
        protected FormMenu form;
        protected IEvent eevent = new Event();

        protected ViewFormMenu(FormMenu form)
        {
            this.form = form;
        }
    }
}

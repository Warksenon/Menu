namespace Pizza.Presenters.PresenterForm1
{
    abstract class RemoveOrderLogic : ILogic
    {
        protected FormMenu form;
        protected IForm1ListViewOrder lvOrder;
        public RemoveOrderLogic(FormMenu form)
        {
            lvOrder = form;
            this.form = form;
        }

        public abstract void LogicSettings();
    }
}

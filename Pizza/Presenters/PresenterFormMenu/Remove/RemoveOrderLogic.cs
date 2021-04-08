namespace Pizza.Presenters.PresenterFormMenu
{
    abstract class RemoveOrderLogic : ILogic
    {
        protected FormMenu form;
        protected IForm1ListViewOrder lvOrder;
        public RemoveOrderLogic( FormMenu form )
        {
            lvOrder = form;
            this.form = form;
        }

        public abstract void LogicSettings();
    }
}

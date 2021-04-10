namespace Pizza.Presenters.PresenterFormMenu
{
    abstract class RemoveOrderLogic : ILogic
    {
        protected FormMenu form;
        protected OnEvent action = new OnEvent();

        public RemoveOrderLogic(FormMenu form)
        {
            this.form = form;
        }

        public abstract void LogicSettings();
    }
}

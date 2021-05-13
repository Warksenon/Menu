namespace Pizza.Presenters.PresenterFormMenu
{
    internal abstract class RemoveOrderLogic : ILogic
    {
        protected FormMenu form;
        protected OnEvent action = new OnEvent();

        public RemoveOrderLogic( FormMenu form )
        {
            this.form = form;
        }

        public abstract void LogicSettings();
    }
}

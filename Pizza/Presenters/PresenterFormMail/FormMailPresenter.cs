namespace Pizza.Presenters.PresenterFormMail
{
    abstract class FormMailPresenter : ILogic
    {
       protected FormMail mail;

        protected FormMailPresenter(FormMail mail)
        {
            this.mail = mail;
        }

        public abstract void LogicSettings();       
    }
}

namespace Pizza.Presenters
{
    public class OnEvent : IOnEvent
    {
        public OnEvent() { }


        public void SetLogic( ILogic logic )
        {
            logic.LogicSettings();
        }

        public void SetView( IView view )
        {
            view.ViewSetting();
        }
    }
}

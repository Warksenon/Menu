namespace Test
{
    public class Aktion : IAction
    {
        public Aktion() { }


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

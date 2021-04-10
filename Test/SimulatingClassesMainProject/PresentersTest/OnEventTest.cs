namespace Test
{
    public class OnEventTest : IOnEventTest
    {
        public OnEventTest() { }


        public void SetLogic(ILogic logic)
        {
            logic.LogicSettings();
        }

        public void SetView(IView view)
        {
            view.ViewSetting();
        }
    }
}

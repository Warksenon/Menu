namespace Pizza
{
    public interface IEvent
    {
        void SetView(IView view);

        void SetLogic(ILogic logic);
    }
}

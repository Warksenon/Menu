namespace Pizza
{
    public interface IOnEvent
    {
        void SetView(IView view);

        void SetLogic(ILogic logic);
    }
}

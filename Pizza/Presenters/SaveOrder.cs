namespace Pizza.Presenters
{
    internal class SaveOrder
    {
        public void AddOrder( IAddOrder save )
        {
            save.AddOrder();
        }
    }
}

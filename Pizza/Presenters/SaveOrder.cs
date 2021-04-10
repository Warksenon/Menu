namespace Pizza.Presenters
{
    class SaveOrder
    {
        public void AddOrder(IAddOrder save)
        {
            save.AddOrder();
        }
    }
}

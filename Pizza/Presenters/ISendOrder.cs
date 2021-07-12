namespace Pizza.Presenters
{
    interface ISendOrder
    {
        bool SendMessag ( IElementGet<Order> element);
    }
}

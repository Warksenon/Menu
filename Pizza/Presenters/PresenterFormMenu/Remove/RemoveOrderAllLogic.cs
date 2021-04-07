namespace Pizza.Presenters.PresenterForm1.Remove
{
    class RemoveOrderAllLogic : RemoveOrderLogic
    {
        public RemoveOrderAllLogic( FormMenu form1 ) : base( form1 ) { }

        public override void LogicSettings()
        {
            lvOrder.ListViewOrder.Items.Clear();
        }
    }
}

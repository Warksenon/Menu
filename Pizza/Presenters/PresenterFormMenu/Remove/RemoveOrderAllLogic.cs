namespace Pizza.Presenters.PresenterFormMenu.Remove
{
    internal class RemoveOrderAllLogic : RemoveOrderLogic
    {
        public RemoveOrderAllLogic( FormMenu form ) : base( form ) { }

        public override void LogicSettings()
        {
            form.ListViewOrder.Items.Clear();
            action.SetLogic( new Form1LabelPricePresenter( form ) );
        }
    }
}

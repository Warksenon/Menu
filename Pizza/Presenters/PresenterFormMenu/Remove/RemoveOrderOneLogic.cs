namespace Pizza.Presenters.PresenterFormMenu.Remove
{
    class RemoveOrderOneLogic : RemoveOrderLogic
    {
        OnEvent action = new OnEvent();

        public RemoveOrderOneLogic(FormMenu form) : base(form)
        {

        }

        public override void LogicSettings()
        {
            lvOrder.ListViewOrder.SelectedItems[0].Remove();
            action.SetLogic(new Form1LabelPricePresenter(form));
        }
    }
}

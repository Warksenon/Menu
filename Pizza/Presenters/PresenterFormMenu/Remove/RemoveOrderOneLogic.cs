namespace Pizza.Presenters.PresenterFormMenu.Remove
{
    class RemoveOrderOneLogic : RemoveOrderLogic
    {
        public RemoveOrderOneLogic(FormMenu form) : base(form){}

        public override void LogicSettings()
        {
            form.ListViewOrder.SelectedItems[0].Remove();
            action.SetLogic(new Form1LabelPricePresenter(form));
        }
    }
}

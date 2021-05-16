using Pizza.View.Form1View;

namespace Pizza.Presenters.PresenterFormMenu
{
    internal class ButtonOkLogic : ViewFormMenu, ILogic
    {
        public ButtonOkLogic( FormMenu form ) : base( form ) { }

        public void LogicSettings()
        {
            eevent.SetLogic( new AddOrderListView( _form ) );
            eevent.SetLogic( new Form1LabelPricePresenter( _form ) );
        }
    }
}

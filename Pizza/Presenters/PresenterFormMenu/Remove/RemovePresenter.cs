using Pizza.Presenters;
using Pizza.Presenters.PresenterFormMenu;

namespace Pizza
{
    public class RemovePresenter : ILogic
    {
        FormMenu _form;
        RemoveFormMenu _remove;

        public RemovePresenter( FormMenu form,RemoveFormMenu remove )
        {
            _remove = remove;
            _form = form;
        }

        void Remove ()
        {
            OnEvent action = new OnEvent();

            switch (_remove)
            {
                case RemoveFormMenu.One:
                _form.ListViewOrder.SelectedItems [0].Remove();
                action.SetLogic( new Form1LabelPricePresenter( _form ) );              
                break;

                case RemoveFormMenu.All:
                _form.ListViewOrder.Items.Clear();
                action.SetLogic( new Form1LabelPricePresenter( _form ) );
                break;
            }
        }

        public void LogicSettings()
        {
            Remove();
        }
    }
}

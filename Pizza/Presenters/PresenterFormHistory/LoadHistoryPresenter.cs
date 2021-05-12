using System;
using System.Windows.Forms;

using Pizza.Models.SqlLite;
using Pizza.Presenters.PresenterFormHistory;

namespace Pizza
{
    public class LoadHistoryPresenter : ListViewHistory
    {
        Repositories _repositories;

        public LoadHistoryPresenter( FormHistory form, Repositories repositories ):base( form )
        {
            _repositories = repositories;
        }

        private void LoadHistoryFromSQL()
        {
            ClearAllList();
            orderList = load.LoadOrderList( new LoadHistorySQL() );
            LoadLVPriceAll();
        }

        private void LoadHistroyFromTxt()
        {
            ClearAllList();
            orderList = load.LoadOrderList( new LoadingFilesTxt() );
            LoadLVPriceAll();
        }

        private void ClearAllList()
        {
            _form.ListViewDishes.Items.Clear();
            _form.ListViewPrice.Items.Clear();
            orderList.Clear();
        }

        private void LoadLVPriceAll()
        {
            foreach (var price in orderList)
            {
                ListViewItem lvi = new ListViewItem(Convert.ToString(price.PriceAll.ID));
                lvi.SubItems.Add( price.PriceAll.Date );
                lvi.SubItems.Add( price.PriceAll.Price );
                lvi.SubItems.Add( price.PriceAll.Comments );
                _form.ListViewPrice.Items.Add( lvi );
            }
        }

        public override void LogicSettings()
        {
            switch (_repositories)
            {
                case Repositories.Txt:
                LoadHistroyFromTxt();
                break;
                case Repositories.Sql:
                LoadHistoryFromSQL();
                break;
            }
        }
    }
}

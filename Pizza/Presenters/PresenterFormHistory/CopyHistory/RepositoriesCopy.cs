using Pizza.Models.SqlLite;
using Pizza.Presenters.PresenterFormHistory.CopyHistory;

namespace Pizza
{
    public class RepositoriesCopy  : ILogic
    {
        Repositories _repositories;
        FormHistory _form;

        public RepositoriesCopy ( FormHistory form, Repositories repositories)
        {
           _repositories = repositories;
           _form = form;
        }

        private void Copy()
        {
            switch (_repositories)
            {
                case Repositories.Txt:
                CopyHistoryTxtAndSetListView();
                break;
                case Repositories.Sql:
                CopyHistorySqlAndSetListView();
                break;
            }  
        }

        void CopyHistoryTxtAndSetListView()
        {
            new HistoryCopy( new LoadingFilesTxt(), new SaveHistorySQL() );
            new LoadHistoryPresenter( _form, Repositories.Txt );
        }

        void CopyHistorySqlAndSetListView()
        {
            new HistoryCopy( new LoadHistorySQL(), new SaveFilesHistoryOrder() );
            new LoadHistoryPresenter( _form, Repositories.Sql );
        }

        public void LogicSettings ()
        {
            Copy();
        }
    }
}

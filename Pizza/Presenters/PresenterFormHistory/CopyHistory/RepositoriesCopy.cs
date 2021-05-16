using Pizza.Models.SqlLite;
using Pizza.Presenters.PresenterFormHistory.CopyHistory;

namespace Pizza
{
    public class RepositoriesCopy : ILogic
    {
        private readonly Repositories _repositories;
        private readonly FormHistory _form;

        public RepositoriesCopy( FormHistory form, Repositories repositories )
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

        private void CopyHistoryTxtAndSetListView()
        {
            new HistoryCopy( new LoadingFilesTxt(), new SaveHistorySQL() );
            new LoadHistoryPresenter( _form, Repositories.Txt );
        }

        private void CopyHistorySqlAndSetListView()
        {
            new HistoryCopy( new LoadHistorySQL(), new SaveFilesHistoryOrder() );
            new LoadHistoryPresenter( _form, Repositories.Sql );
        }

        public void LogicSettings()
        {
            Copy();
        }
    }
}

using Pizza.Models.SqlLite;
using Pizza.Presenters.PresenterFormHistory.CopyHistory;
using Pizza.Presenters.PresenterFormHistory.LoadHistory;

namespace Pizza
{
    public class RepositoriesCopy  : ILogic
    {
        Repositories repositories;
        FormHistory form;

        public RepositoriesCopy ( FormHistory form, Repositories repositories)
        {
            this.repositories = repositories;
            this.form = form;
        }

        private void Copy()
        {
            switch (repositories)
            {
                case Repositories.Txt:
                HistoryCopy< LoadingFilesTxt,SaveHistorySQL> copy = new HistoryCopy< LoadingFilesTxt,SaveHistorySQL>();
                copy.CopyHistory( new LoadingFilesTxt(), new SaveHistorySQL() );
                new FileTextLoad( form ).LogicSettings();
                break;
                case Repositories.Sql:
                HistoryCopy< LoadHistorySQL,SaveFilesHistoryOrder> copy1 = new HistoryCopy< LoadHistorySQL,SaveFilesHistoryOrder>();
                copy1.CopyHistory( new LoadHistorySQL(), new SaveFilesHistoryOrder() );
                new SqlLoad( form ).LogicSettings();
                break;
            }  
        }

        public void LogicSettings ()
        {
            Copy();
        }
    }
}

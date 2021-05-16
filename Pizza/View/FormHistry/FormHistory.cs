using System;
using System.Windows.Forms;

using Pizza.Presenters;
using Pizza.Presenters.PresenterFormHistory;
using Pizza.View.FormHistry.ButtonFormHistory;
using Pizza.View.FormHistry.ButtonFormMail;

namespace Pizza
{
    public partial class FormHistory : Form, IListViewHistory, IButtonFormHistory
    {
        private readonly OnEvent onEvent = new OnEvent();

        public FormHistory()
        {
            InitializeComponent();
        }

        public ListView ListViewPrice { get => LVprice; set => LVprice = value; }
        public ListView ListViewDishes { get => LVdishes; set => LVdishes = value; }
        public Button ButtonLoadTxt { get => bText; set => bText = value; }
        public Button ButtonLoadSql { get => bSql; set => bSql = value; }
        public Button ButtonCopyTxt { get => bTxtToSQL; set => bTxtToSQL = value; }
        public Button ButtonCopySql { get => buttonSQLToTxt; set => buttonSQLToTxt = value; }

        private void FormHistory_Load( object sender, EventArgs e )
        {
            onEvent.SetLogic( new LoadHistoryPresenter( this, Repositories.Sql ) );
            onEvent.SetView( new LoadSqlView( this ) );
        }

        private void ButtonTextList_Click( object sender, EventArgs e )
        {
            onEvent.SetLogic( new LoadHistoryPresenter( this, Repositories.Txt ) );
            onEvent.SetView( new LoadTxtView( this ) );
        }

        private void ButtonSqlList_Click( object sender, EventArgs e )
        {
            onEvent.SetLogic( new LoadHistoryPresenter( this, Repositories.Sql ) );
            onEvent.SetView( new LoadSqlView( this ) );
        }

        private void ButtonTxtToSql( object sender, EventArgs e )
        {
            onEvent.SetView( new CopyTxtView( this ) );
            onEvent.SetLogic( new RepositoriesCopy( this, Repositories.Txt ) );
            onEvent.SetView( new LoadTxtView( this ) );
        }

        private void ButtonSQLToTxt_Click( object sender, EventArgs e )
        {
            onEvent.SetView( new CopySqlView( this ) );
            onEvent.SetLogic( new RepositoriesCopy( this, Repositories.Sql ) );
            onEvent.SetView( new LoadSqlView( this ) );
        }

        private void ButtonClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void LVprice_SelectedIndexChanged( object sender, EventArgs e )
        {
            onEvent.SetLogic( new HistorySelect( this ) );
        }
    }
}

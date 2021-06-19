using System;
using System.Drawing;
using System.Windows.Forms;

using Pizza.Models.SqlLite;
using Pizza.Presenters;
using Pizza.Presenters.PresenterFormHistory;
using Pizza.Presenters.PresenterFormHistory.CopyHistory;
using Pizza.View.FormHistry.ButtonFormMail;

namespace Pizza
{
    public partial class FormHistory : Form, IListViewHistory, IButtonFormHistory
    {
        private readonly OnEvent onEvent = new OnEvent();
        HistoryPriceListView _priceLV;

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
            _priceLV = new HistoryPriceListView( this );
            _priceLV.SetList( new LoadHistorySQL() );
            AllButtonSetSystemColorsControl( bSql.Name );
        }

        private void ButtonTextList_Click( object sender, EventArgs e )
        {
            _priceLV.SetList( new LoadingFilesTxt() );
            AllButtonSetSystemColorsControl( bText.Name );
        }

        private void ButtonSqlList_Click( object sender, EventArgs e )
        {
            _priceLV.SetList( new LoadHistorySQL() );
            AllButtonSetSystemColorsControl( bSql.Name );
        }

        private void ButtonTxtToSql( object sender, EventArgs e )
        {
            AllButtonSetSystemColorsControl( bTxtToSQL.Name );
            new HistoryCopy( new LoadingFilesTxt(), new SaveHistorySQL() );
            _priceLV.SetList( new LoadingFilesTxt() );
            AllButtonSetSystemColorsControl( bText.Name );
        }

        private void ButtonSQLToTxt_Click( object sender, EventArgs e )
        {
            AllButtonSetSystemColorsControl( buttonSQLToTxt.Name );
            new HistoryCopy( new LoadHistorySQL(), new SaveFilesHistoryOrder() );
            _priceLV.SetList( new LoadingFilesTxt() );
            AllButtonSetSystemColorsControl( bSql.Name );
        }

        private void ButtonClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void LVprice_SelectedIndexChanged( object sender, EventArgs e )
        {
            new HistoryDishesListView( this ).SetList( _priceLV );
        }

        private void AllButtonSetSystemColorsControl (string nameButton)
        {
            bText.BackColor = SystemColors.Control;
            bSql.BackColor = SystemColors.Control;
            bTxtToSQL.BackColor = SystemColors.Control;
            buttonSQLToTxt.BackColor = SystemColors.Control;

            switch (nameButton)
            {
                case "bText":
                bText.BackColor = Color.LawnGreen;
                break;
                case "bSql":
                bSql.BackColor = Color.LawnGreen;
                break;
                case "bTxtToSQL":
                bTxtToSQL.BackColor = Color.LawnGreen;
                break;
                case "buttonSQLToTxt":
                buttonSQLToTxt.BackColor = Color.LawnGreen;
                break;
            }
        }
    }
}

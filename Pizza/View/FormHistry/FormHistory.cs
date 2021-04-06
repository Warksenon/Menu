using Pizza.Presenters;
using Pizza.Presenters.PresenterFormHistory;
using Pizza.Presenters.PresenterFormHistory.Copy;
using Pizza.Presenters.PresenterFormHistory.LoadHistory;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pizza
{
    public partial class FormHistory : Form , IListViewHistory
    {
        OnEvent onEvent = new OnEvent();
        public FormHistory()
        {
            InitializeComponent();         
        }
   
        public ListView ListViewPrice { get => LVprice; set => LVprice = value; }
        public ListView ListViewDishes { get => LVdishes; set => LVdishes = value; }

        private void FormHistory_Load(object sender, EventArgs e)
        {
            onEvent.SetLogic(new SqlLoad(this));
            ButtonColorChange(Button.HistSQL);
        }

        public enum Button
        {
            HistSQL,
            HistTXT,
            SqlToTxt,
            TxtToSql
        }

        private void ButtonColorChange(Button p)
        {
            AllButtonSetSystemColorsControl();

            switch (p)
            {
                case Button.HistSQL: bSql.BackColor = Color.LawnGreen; break;
                case Button.HistTXT: bText.BackColor = Color.LawnGreen; break;
                case Button.SqlToTxt: buttonSQLToTxt.BackColor = Color.Firebrick; break;
                case Button.TxtToSql: bTxtToSQL.BackColor = Color.Firebrick; break;
            }

        }

        private void AllButtonSetSystemColorsControl()
        {
            bSql.BackColor = SystemColors.Control;
            bText.BackColor = SystemColors.Control;
            buttonSQLToTxt.BackColor = SystemColors.Control;
            bTxtToSQL.BackColor = SystemColors.Control;
        }

        private void ButtonTextList_Click(object sender, EventArgs e)
        {
            onEvent.SetLogic(new FileTextLoad(this));
            ButtonColorChange(Button.HistTXT);
        }

        private void ButtonSqlList_Click(object sender, EventArgs e)
        {
            onEvent.SetLogic(new SqlLoad(this));
            ButtonColorChange(Button.HistSQL);
        }

        private void ButtonTxtToSql(object sender, EventArgs e)
        {
            onEvent.SetLogic(new SqlCopy(this));
            ButtonColorChange(Button.TxtToSql);        
            ButtonColorChange(Button.HistTXT);
        }

        private void ButtonSQLToTxt_Click(object sender, EventArgs e)
        {
            onEvent.SetLogic(new FileTextCopy(this));
            ButtonColorChange(Button.SqlToTxt);        
            ButtonColorChange(Button.HistSQL);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LVprice_SelectedIndexChanged(object sender, EventArgs e)
        {
            onEvent.SetLogic(new HistorySelect(this));
        }
    }

}

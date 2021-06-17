using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Pizza.Presenters;
using Pizza.Presenters.PresenterFormMenu;
using Pizza.SqlLite;
using Pizza.View.Form1;
using Pizza.View.Form1View.ViewSettings.ButtonMenu;
using Pizza.View.FormMenuView.InterfaceFormMenu;
using Pizza.View.FormMenuView.ViewSettings;


namespace Pizza
{

    public partial class FormMenu : Form, IForm1ListViewDishes, IForm1ListViewOrder, IFormMenuButtonMenu,
                                     IForm1ChecedListBoxSides, IForm1AddButton, IForm1QuantityTextBox, IFrom1InfoLabel,
                                     IFormMenuLabelPrice, IButtonRemove, IButtonSend, ITextBoxComments, IFormMenuBackgroundWorker
    {
        public FormMenu()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private IPrice _price;
        IListSet<Dish> _getDishes;
        IListSet<string> _getSides;


        private void Form1_Load_1( object sender, EventArgs e )
        {
            _getDishes = new DishesListView( this );
            _getSides = new SidesCheckListBox( this );
            _price = new OrderListView( this );
            MenuDishes.CreateMenuPizza( new DishesListView( this ), new SidesCheckListBox( this ) );
            new CreateSQLiteTables().CreateSqliteTables();
            new ButtonMenuView( this ).PizzaButtonSettings();
            new ButtonRemoveView( this ).RemoveAll();
        }

        public ListView ListViewDishes { get => listViewDish; set => listViewDish = value; }
        public CheckedListBox CheckedListBoxSide { get => chListBoxSideDishes; set => chListBoxSideDishes = value; }
        public TextBox TextBoxQuantityDishes { get => textBoxQuantityDishes; set => textBoxQuantityDishes = value; }
        public ListView ListViewOrder { get => listViewOrder; set => listViewOrder = value; }
        public BackgroundWorker BackgroundWorker { get => backgroundWorker1; set => backgroundWorker1 = value; }
        public TextBox TextBoxComments { get => tComments; set => tComments = value; }
        public Button PizzzaButton { get => bPizza; set => bPizza = value; }
        public Button MainButton { get => bMainDish; set => bMainDish = value; }
        public Button SoupButton { get => bSoups; set => bSoups = value; }
        public Button DrinksButton { get => bDrinks; set => bDrinks = value; }
        public Button AddButton { get => bAddDish; set => bAddDish = value; }
        public TextBox QTextbox { get => textBoxQuantityDishes; set => textBoxQuantityDishes = value; }
        public Label LabelMenu { get => lMenuInfo; set => lMenuInfo = value; }
        public Label LabelPrice { get => lPrice; set => lPrice = value; }
        public Button ButtonRemoveOne { get => bRemoveListBox; set => bRemoveListBox = value; }
        public Button ButtonRemoveAll { get => bRemoveAllListBox; set => bRemoveAllListBox = value; }
        public Button ButtonSubmitOrder { get => bOrder; set => bOrder = value; }

        private void ButtonPizza_Click( object sender, EventArgs e )
        {
            MenuDishes.CreateMenuPizza( _getDishes, _getSides );
            new ButtonMenuView( this ).PizzaButtonSettings();
        }

        private void ButtonMainDish_Click( object sender, EventArgs e )
        {
            MenuDishes.CreateMenuMainDishes( _getDishes, _getSides );
            new ButtonMenuView( this ).MainDishButtonSettings();
        }

        private void ButtonDrinks_Click( object sender, EventArgs e )
        {
            MenuDishes.CreateMenuDrinks( _getDishes, _getSides );
            new ButtonMenuView( this ).DrinkseButtonSettings();
        }

        private void ButtonSoup_Click( object sender, EventArgs e )
        {
            MenuDishes.CreateMenuSoups( _getDishes, _getSides );
            new ButtonMenuView( this ).SoupsButtonSettings();
        }

        private void ButtonOrder_Click( object sender, EventArgs e )
        {
            var order = new OrderListView(this);
            new ButtonPlaceOrderLogic( this, order ).LogicSettings();
        }

        private void ButtonOk_Click( object sender, EventArgs e )
        {
            new ButtonOkView( this ).ViewSetting();
            new AddOrderListView( this ).LogicSettings();
            new Form1LabelPricePresenter( this, _price );
        }

        private void ListViewDish_SelectedIndexChanged( object sender, EventArgs e )
        {
           new ListViewDishes( this ).ViewSetting();
        }

        private void ListViewOrder_SelectedIndexChanged( object sender, EventArgs e )
        {
            bRemoveListBox.Visible = true;
        }

        private void ButtonRemoveListBox_Click( object sender, EventArgs e )
        {
            new RemovePresenter( this ).RemoveOne();
            new ButtonRemoveView( this ).RemoveOne();
        }

        private void ButtonRemoveAllListBox_Click( object sender, EventArgs e )
        {
            new ButtonRemoveView( this ).RemoveAll();
            new RemovePresenter( this).RemoveAll();
        }

        private void AddressEmailToolStripMenuItem_Click( object sender, EventArgs e )
        {
            FormMail fm = new FormMail();
            fm.ShowDialog();
            fm.Close();
        }

        private void HistoryToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if (backgroundWorker1.IsBusy != true)
            {
                FormHistory fm = new FormHistory();
                fm.ShowDialog();
                fm.Close();
            }
            else
            {
                MessageBox.Show( "Historia jeszcze nie gotowa", "Przetwarzanie danych" );
            }
        }

        private void BackgroundWorker1_DoWork( object sender, DoWorkEventArgs e )
        {
            ButtonSubmitOrder.BackColor = Color.Firebrick;
        }

        private void BackgroundWorker1_RunWorkerCompleted( object sender, RunWorkerCompletedEventArgs e )
        {
            ButtonSubmitOrder.BackColor = Color.LawnGreen;
        }
    }
}

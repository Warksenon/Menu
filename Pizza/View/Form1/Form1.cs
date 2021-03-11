using Pizza.Presenters;
using Pizza.Presenters.PresenterForm1;
using Pizza.Presenters.PresenterForm1.LoadDishesAndSideDishForm1;
using Pizza.Presenters.PresenterForm1.VisableElements.Button;
using Pizza.View.Form1;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace Pizza
{

    public partial class Form1 : Form , IForm1ListViewDishes, IForm1ListViewOrder, IForm1ButtonMenu, 
                                     IForm1ChecedListBoxSides, IForm1AddButton, IForm1QuantityTextBox, IFrom1InfoLabel,
                                     IForm1LabelPrice
        {
        public Form1 form1;

        public Form1()
        { 
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;            
        }

        private Form1AddOrderListViewPresenters orderPresenters ;
        private Form1LoadDishesPresenters loadDishesToListView;
        private Form1LoadSidesPresenter loadSidesToCheckedListBox;
        private readonly SettingButtonMenu buttonMenu = new SettingButtonMenu();
        private Form1LabelPricePresenter labelPricePresenter;

        private void Form1_Load_1(object sender, EventArgs e)
        {
            form1 = this;
            orderPresenters = new Form1AddOrderListViewPresenters(this);
            loadDishesToListView = new Form1LoadDishesPresenters(this);
            loadDishesToListView.LoadPizza();
            buttonMenu.ButtonSettings(new ButtonPizzaSetting(form1));
            loadSidesToCheckedListBox = new Form1LoadSidesPresenter(this);
            loadSidesToCheckedListBox.LoadSidesPizza();
            labelPricePresenter = new Form1LabelPricePresenter(this);


            SetVisibleButtonRemoveAll();
            SetVisibleButtonRemove();
           

           // SqlLite.CreateTabeles createTabeles = new SqlLite.CreateTabeles();
           // createTabeles.CreateSQLiteTables();        
        }     
        public ListView ListViewDishes { get => listViewDish; set => listViewDish = value; }
        public CheckedListBox CheckedListBoxSide { get => chListBoxSideDishes; set => chListBoxSideDishes = value; }
        public TextBox TextBoxQuantityDishes { get => textBoxQuantityDishes; set => textBoxQuantityDishes = value; }
        public ListView ListViewOrder { get => listViewOrder; set => listViewOrder = value; }
      //  public Label LabelPrice { get => lPrice; set => lPrice = value; }
        public BackgroundWorker BackgroundWorker { get => backgroundWorker1; set => backgroundWorker1 = value; }
        public TextBox TextBoxComments { get => tComments; set => tComments = value; }
        public System.Windows.Forms.Button PizzzaButton { get => bPizza; set => bPizza = value; }
        public System.Windows.Forms.Button MainButton { get => bMainDish; set => bMainDish = value; }
        public System.Windows.Forms.Button SoupButton { get => bSoups; set => bSoups = value; }
        public System.Windows.Forms.Button DrinksButton { get => bDrinks; set => bDrinks = value; }
        public Button AddButton { get => bAddDish; set => bAddDish = value; }
        public TextBox QTextbox { get => textBoxQuantityDishes; set => textBoxQuantityDishes = value; }
        public Label LabelMenu { get => lMenuInfo; set =>  lMenuInfo = value; }       
        public Label LabelPrice { get => lPrice; set => lPrice = value; }

        private void ButtonPizza_Click(object sender, EventArgs e)
        {
            buttonMenu.ButtonSettings(new ButtonPizzaSetting(form1));
            loadSidesToCheckedListBox.LoadSidesPizza();
            loadDishesToListView.LoadPizza();  
        }

        private void ButtonMainDish_Click(object sender, EventArgs e)
        {
            buttonMenu.ButtonSettings(new ButtonMainDishesSetting(form1));
            loadSidesToCheckedListBox.LoadSidesMainDishes();
            loadDishesToListView.LoadMainDish();         
        }

        private void ButtonDrinks_Click(object sender, EventArgs e)
        {
            buttonMenu.ButtonSettings(new ButtonDrinksSettings(form1));
            loadSidesToCheckedListBox.ClearCheckedListBox();
            loadDishesToListView.LoadDrinks();          
        }
      
        private void ButtonSoup_Click(object sender, EventArgs e)
        {
            buttonMenu.ButtonSettings(new ButtonSoupsSetting(form1));
            loadSidesToCheckedListBox.ClearCheckedListBox();
            loadDishesToListView.LoadSoups();            
        }

        private void ButtonOrder_Click(object sender, EventArgs e)
        {
           // orderPresenters.SubmitOrder();            
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            orderPresenters.AddOrderToListView();
            SetVisibleButtonRemoveAll();
            labelPricePresenter.SetTextLabelPrice();
            SelectColorbOrder();
        }

        private void SelectColorbOrder()
        {
            if((listViewOrder.Items.Count > 0)|| (backgroundWorker1.IsBusy == true))
            {
                if (listViewOrder.Items.Count > 0) bOrder.BackColor = Color.LawnGreen;
                if (backgroundWorker1.IsBusy == true) bOrder.BackColor = Color.Firebrick;
            }          
            else bOrder.BackColor = SystemColors.Control;
        }

        private void ButtonRemoveListBox_Click(object sender, EventArgs e)
        {

            if (listViewOrder.SelectedItems.Count == 0) return;
            listViewOrder.SelectedItems[0].Remove();           
            labelPricePresenter.SetTextLabelPrice();
            SetVisibleButtonRemoveAll();
            SetVisibleButtonRemove();
            bRemoveListBox.Visible = false;
            SelectColorbOrder();
        }

        private void ButtonRemoveAllListBox_Click(object sender, EventArgs e)
        {
            listViewOrder.Items.Clear();            
            labelPricePresenter.SetTextLabelPrice();
            SelectColorbOrder();
            SetVisibleButtonRemoveAll();
            SetVisibleButtonRemove();
        }

        private void AddressEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMail fm = new FormMail();
            fm.ShowDialog();
            fm.Close();
        }

        private void HistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            if (backgroundWorker1.IsBusy != true)
            {
                FormHistory fm = new FormHistory();
                fm.ShowDialog();
                fm.Close();
            }
            else
            {
                MessageBox.Show("Historia jeszcze nie gotowa", "Przetwarzanie danych");
            }
           
        }
      
        private void BackgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {        
            SelectColorbOrder();
           // orderPresenters.SendEmailAndSaveOrder();          
        }

        private void BackgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SelectColorbOrder();
        }

        private void BackgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        private void ListViDania_SelectedIndexChanged(object sender, EventArgs e)
        {
           SetVisibleButtonRemove();
        }

        private void SetVisibleButtonRemove()
        {
            if (CheckingListOrderIfEmpty())
            {
                bRemoveListBox.Visible = true;
            }
            else bRemoveListBox.Visible = false;
        }

        private void SetVisibleButtonRemoveAll()
        {
            if (CheckingListOrderIfEmpty())
            {
                bRemoveAllListBox.Visible = true;
            }
            else bRemoveAllListBox.Visible = false;
        }

        private bool CheckingListOrderIfEmpty()
        {
            if (listViewOrder.Items.Count > 0) return true;
            else return false;
        }

        private void ListViewDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewDishes lv = new ListViewDishes(form1);
            lv.SettingVisable();
        }
    }
}

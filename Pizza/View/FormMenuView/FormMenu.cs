using Pizza.Presenters;
using Pizza.Presenters.PresenterForm1;
using Pizza.Presenters.PresenterForm1.Logic;
using Pizza.Presenters.PresenterForm1.Remove;
using Pizza.Presenters.PresenterForm1.VisableElements.Button;
using Pizza.View.Form1;
using Pizza.View.Form1View.ViewSettings;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace Pizza
{

    public partial class FormMenu : Form , IForm1ListViewDishes, IForm1ListViewOrder, IForm1ButtonMenu, 
                                     IForm1ChecedListBoxSides, IForm1AddButton, IForm1QuantityTextBox, IFrom1InfoLabel,
                                     IForm1LabelPrice, IButtonRemove, IButtonSend, ITextBoxComments
    {
        public FormMenu()
        { 
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;            
        }

        private IEvent eevent = new Event();

        private void Form1_Load_1(object sender, EventArgs e)
        {
            eevent.SetLogic(new ButtonPizzaLogic(this));
            eevent.SetView(new ButtonPizzaView(this));         
            eevent.SetView(new ButtonRemoveAll(this));

           // SqlLite.CreateTabeles createTabeles = new SqlLite.CreateTabeles();
           // createTabeles.CreateSQLiteTables();        
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
        public Label LabelMenu { get => lMenuInfo; set =>  lMenuInfo = value; }       
        public Label LabelPrice { get => lPrice; set => lPrice = value; }
        public Button ButtonRemoveOne { get => bRemoveListBox; set => bRemoveListBox = value; }
        public Button ButtonRemoveAll { get => bRemoveAllListBox; set => bRemoveAllListBox = value; }
        public Button ButtonSendMassage { get => bOrder; set => bOrder = value; }
        

        private void ButtonPizza_Click(object sender, EventArgs e)
        {
            eevent.SetLogic(new ButtonPizzaLogic(this));
            eevent.SetView(new ButtonPizzaView(this));
        }

        private void ButtonMainDish_Click(object sender, EventArgs e)
        {
            eevent.SetLogic( new ButtonMainDishesLogic(this));
            eevent.SetView(new ButtonMainDishesView(this));
        }

        private void ButtonDrinks_Click(object sender, EventArgs e)
        {
            eevent.SetView(new ButtonDrinksView(this));
            eevent.SetLogic(new ButtonDriksLogic(this));
        }
      
        private void ButtonSoup_Click(object sender, EventArgs e)
        {
            eevent.SetView(new ButtonSoupsView(this));
            eevent.SetLogic(new ButtonSoupsLogic(this));
        }

        private void ButtonOrder_Click(object sender, EventArgs e)
        {
            Form1CreatingOrder creatingOrder = new Form1CreatingOrder(this);
            Order order = creatingOrder.GetOrderFromListView();
           // orderPresenters.SubmitOrder();            
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            eevent.SetView(new ButtonOkView(this));
            eevent.SetLogic(new Form1AddOrderListViewPresenters(this));          
            eevent.SetView(new Form1LabelPricePresenter(this));
        }

        private void ListViewDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            eevent.SetView(new ListViewDishes(this));
        }

        private void listViewOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            bRemoveListBox.Visible = true;
        }


        private void ButtonRemoveListBox_Click(object sender, EventArgs e)
        {                    
            eevent.SetView(new ButtonRemoveOne(this));
            eevent.SetLogic(new RemoveOrderOne(this));
            eevent.SetView(new Form1LabelPricePresenter(this));
        }

        private void ButtonRemoveAllListBox_Click(object sender, EventArgs e)
        {         
            eevent.SetView(new ButtonRemoveAll(this));
            eevent.SetLogic(new RemoveOrderAll(this));
            eevent.SetView(new Form1LabelPricePresenter(this));         
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
            bOrder.BackColor = Color.Firebrick;
            // orderPresenters.SendEmailAndSaveOrder();          
        }

        private void BackgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bOrder.BackColor = SystemColors.Control;
        }

        private void BackgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }
    }
}

using Pizza.Presenters;
using Pizza.Presenters.PresenterFormMenu;
using Pizza.Presenters.PresenterFormMenu.Logic;
using Pizza.Presenters.PresenterFormMenu.Remove;
using Pizza.Presenters.PresenterFormMenu.VisableElements.Button;
using Pizza.View.Form1;
using Pizza.View.FormMenuView.InterfaceFormMenu;
using Pizza.View.FormMenuView.ViewSettings;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace Pizza
{

    public partial class FormMenu : Form, IForm1ListViewDishes, IForm1ListViewOrder, IForm1ButtonMenu,
                                     IForm1ChecedListBoxSides, IForm1AddButton, IForm1QuantityTextBox, IFrom1InfoLabel,
                                     IFormMenuLabelPrice, IButtonRemove, IButtonSend, ITextBoxComments, IFormMenuBackgroundWorker
    {
        public FormMenu()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private IOnEvent eevent = new OnEvent();

        private void Form1_Load_1(object sender, EventArgs e)
        {
            eevent.SetLogic(new FormMenuLogic(this));
            eevent.SetView(new FormMenuView(this));
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


        private void ButtonPizza_Click(object sender, EventArgs e)
        {
            eevent.SetLogic(new ButtonPizzaLogic(this));
            eevent.SetView(new ButtonPizzaView(this));
        }

        private void ButtonMainDish_Click(object sender, EventArgs e)
        {
            eevent.SetLogic(new ButtonMainDishesLogic(this));
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
            eevent.SetLogic(new ButtonPlaceOrderLogic(this));
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            eevent.SetView(new ButtonOkView(this));
            eevent.SetLogic(new ButtonOkLogic( this));
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
            eevent.SetLogic(new RemoveOrderOneLogic(this));
            eevent.SetView(new ButtonRemoveOne(this));
        }

        private void ButtonRemoveAllListBox_Click(object sender, EventArgs e)
        {
            eevent.SetView(new ButtonRemoveAll(this));
            eevent.SetLogic(new RemoveOrderAllLogic(this));
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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ButtonSubmitOrder.BackColor = Color.Firebrick;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ButtonSubmitOrder.BackColor = Color.LawnGreen;
        }
    }
}

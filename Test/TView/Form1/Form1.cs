using Pizza.Presenters;
using Pizza.Presenters.PresenterForm1;
using Pizza.Presenters.PresenterForm1.Logic;
using Pizza.Presenters.PresenterForm1.Remove;
using Pizza.Presenters.PresenterForm1.VisableElements.Button;
using Pizza.View.Form1;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace Test
{

    public partial class Form1Test : Form , IForm1ListViewDishes, IForm1ListViewOrder, IForm1ButtonMenu, 
                                     IForm1ChecedListBoxSides, IForm1AddButton, IForm1QuantityTextBox, IFrom1InfoLabel,
                                     IForm1LabelPrice, IButtonRemove, IButtonSend, ITextBoxComments
    {
        public Form1Test()
        { 
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;            
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

        private void Form1Test_Load(object sender, EventArgs e)
        {

        }
    }
}

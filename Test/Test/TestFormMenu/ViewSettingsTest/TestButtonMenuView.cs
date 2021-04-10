using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.Windows.Forms;

namespace Test
{
    [TestClass]
    public class TestButtonMenuView : Form1Test
    {
        //Button buttonPizza = new Button();
        //Button buttonMain = new Button();
        //Button buttonSoups = new Button();
        //Button buttonDrinks = new Button();
        //TextBox textBox = new TextBox();
        //Label labelMenu = new Label();

        //void SetColorButton( EnumMenu onClick )
        //{
        //    buttonPizza.BackColor = SystemColors.Control;
        //    buttonMain.BackColor = SystemColors.Control;
        //    buttonSoups.BackColor = SystemColors.Control;
        //    buttonDrinks.BackColor = SystemColors.Control;

        //    switch (onClick)
        //    {
        //        case EnumMenu.Pizza:
        //        buttonPizza.BackColor = Color.LawnGreen;
        //        break;
        //        case EnumMenu.MainDishes:
        //        buttonMain.BackColor = Color.LawnGreen;
        //        break;
        //        case EnumMenu.Soups:
        //        buttonSoups.BackColor = Color.LawnGreen;
        //        break;
        //        case EnumMenu.Drinks:
        //        buttonDrinks.BackColor = Color.LawnGreen;
        //        break;
        //    }
        //}

        //void SetSettingsButtonAddaAndTextBox()
        //{
        //    textBox.Text = "1";
        //}

        [TestMethod]
        public void TestViewOnClickButtonMenuPizza()
        {
            eevent.SetView( new ButtonPizzaView( form ) );

            Assert.AreEqual(Color.LawnGreen, form.PizzzaButton.BackColor );
            Assert.AreEqual(SystemColors.Control, form.MainButton.BackColor );
            Assert.AreEqual(SystemColors.Control, form.SoupButton.BackColor );
            Assert.AreEqual(SystemColors.Control, form.DrinksButton.BackColor );
            Assert.AreEqual( "1", form.QTextbox.Text );
            Assert.AreEqual("Pizza", form.LabelMenu.Text );
        }

        [TestMethod]
        public void TestViewOnClickButtonMenuMainDishes()
        {
            eevent.SetView( new ButtonMainDishesView( form ) );

            Assert.AreEqual(SystemColors.Control, form.PizzzaButton.BackColor);
            Assert.AreEqual(Color.LawnGreen, form.MainButton.BackColor);
            Assert.AreEqual(SystemColors.Control, form.SoupButton.BackColor);
            Assert.AreEqual(SystemColors.Control, form.DrinksButton.BackColor);
            Assert.AreEqual("1", form.QTextbox.Text);
            Assert.AreEqual("Dania główne", form.LabelMenu.Text);
        }

        [TestMethod]
        public void TestViewOnClickButtonMenuSoups()
        {
            eevent.SetView( new ButtonSoupsView( form ) );

            Assert.AreEqual(SystemColors.Control, form.PizzzaButton.BackColor);
            Assert.AreEqual(SystemColors.Control, form.MainButton.BackColor);
            Assert.AreEqual(Color.LawnGreen, form.SoupButton.BackColor);
            Assert.AreEqual(SystemColors.Control, form.DrinksButton.BackColor);
            Assert.AreEqual("1", form.QTextbox.Text);
            Assert.AreEqual("Zupy", form.LabelMenu.Text);
        }

        [TestMethod]
        public void TestViewOnClickButtonMenuDrinks()
        {
            eevent.SetView( new ButtonDrinksView( form ) );

            Assert.AreEqual(SystemColors.Control, form.PizzzaButton.BackColor);
            Assert.AreEqual(SystemColors.Control, form.MainButton.BackColor);
            Assert.AreEqual(SystemColors.Control, form.SoupButton.BackColor);
            Assert.AreEqual(Color.LawnGreen, form.DrinksButton.BackColor);
            Assert.AreEqual("1", form.QTextbox.Text);
            Assert.AreEqual("Napoje", form.LabelMenu.Text);
        }
    }
}

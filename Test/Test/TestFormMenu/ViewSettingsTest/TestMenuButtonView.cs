using System.Drawing;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Test.TestFormMenu.ViewSettingsTest
{
    [TestClass]
    public class TestMenuButtonView : Form1Test
    {
        [TestMethod]
        public void TestViewOnClickButtonMenuPizza()
        {

            eevent.SetView( new ButtonPizzaView( form ) );

            Assert.AreEqual( Color.LawnGreen, form.PizzzaButton.BackColor );
            Assert.AreEqual( SystemColors.Control, form.MainButton.BackColor );
            Assert.AreEqual( SystemColors.Control, form.SoupButton.BackColor );
            Assert.AreEqual( SystemColors.Control, form.DrinksButton.BackColor );
            Assert.AreEqual( "1", form.QTextbox.Text );
            Assert.AreEqual( "Pizza", form.LabelMenu.Text );
        }

        [TestMethod]
        public void TestViewOnClickButtonMenuMainDishes()
        {

            eevent.SetView( new ButtonMainDishesView( form ) );

            Assert.AreEqual( SystemColors.Control, form.PizzzaButton.BackColor );
            Assert.AreEqual( Color.LawnGreen, form.MainButton.BackColor );
            Assert.AreEqual( SystemColors.Control, form.SoupButton.BackColor );
            Assert.AreEqual( SystemColors.Control, form.DrinksButton.BackColor );
            Assert.AreEqual( "1", form.QTextbox.Text );
            Assert.AreEqual( "Dania główne", form.LabelMenu.Text );
        }

        [TestMethod]
        public void TestViewOnClickButtonMenuSoups()
        {

            eevent.SetView( new ButtonSoupsView( form ) );

            Assert.AreEqual( SystemColors.Control, form.PizzzaButton.BackColor );
            Assert.AreEqual( SystemColors.Control, form.MainButton.BackColor );
            Assert.AreEqual( Color.LawnGreen, form.SoupButton.BackColor );
            Assert.AreEqual( SystemColors.Control, form.DrinksButton.BackColor );
            Assert.AreEqual( "1", form.QTextbox.Text );
            Assert.AreEqual( "Zupy", form.LabelMenu.Text );
        }

        [TestMethod]
        public void TestViewOnClickButtonMenuDrinks()
        {
            eevent.SetView( new ButtonDrinksView( form ) );

            Assert.AreEqual( SystemColors.Control, form.PizzzaButton.BackColor );
            Assert.AreEqual( SystemColors.Control, form.MainButton.BackColor );
            Assert.AreEqual( SystemColors.Control, form.SoupButton.BackColor );
            Assert.AreEqual( Color.LawnGreen, form.DrinksButton.BackColor );
            Assert.AreEqual( "1", form.QTextbox.Text );
            Assert.AreEqual( "Napoje", form.LabelMenu.Text );
        }
    }
}


using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Test.Form1.ViewSettings
{
    [TestClass]
    public class TestButtonMenu
    {
        [TestMethod]
        public void TestButtonmenuPizza()
        {
            Form1Test form = new Form1Test();
            Event eevent = new Event();
            eevent.SetView(new ButtonPizzaSetting(form));

            Button buttonPizza = new Button();
            buttonPizza.BackColor = Color.LawnGreen;

            Button buttonMain = new Button();
            buttonMain.BackColor = SystemColors.Control;

            Button buttonSoups = new Button();
            buttonSoups.BackColor = SystemColors.Control;

            Button buttonDrinks = new Button();
            buttonDrinks.BackColor = SystemColors.Control;

            Button buttonAdd = new Button();
            buttonAdd.Visible = false;

            TextBox textBox = new TextBox();
            textBox.Text = "1";

            Label labelMenu = new Label();
            labelMenu.Text = "Pizza";


           

            Assert.AreEqual(buttonPizza.BackColor, form.bPizza.BackColor);
            Assert.AreEqual(buttonMain.BackColor, form.bMainDish.BackColor);
            Assert.AreEqual(buttonSoups.BackColor, form.bSoups.BackColor);
            Assert.AreEqual(buttonDrinks.BackColor, form.bSoups.BackColor);
            Assert.AreEqual(textBox.Text, form.QTextbox.Text);
            Assert.AreEqual(labelMenu.Text, form.LabelMenu.Text);
            Assert.AreEqual(buttonAdd.Visible, form.AddButton.Visible);

        }
    }
}

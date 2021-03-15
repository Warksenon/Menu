using Pizza.View.Form1;
using System.Drawing;

namespace Pizza
{
    abstract class ButtonMenu : IView
    {
        protected IForm1ButtonMenu bMenu;
        protected IForm1AddButton bAdd;
        protected IForm1QuantityTextBox qTextBox;
        protected IFrom1InfoLabel label;
        
        protected ButtonMenu(Form1 form1)
        {
            bMenu = form1;
            bAdd = form1;
            qTextBox = form1;
            label = form1;
        }

        protected void ButtonSeting() 
        {
            ClearColorButton();
            HidenButtonDishesOK();
            HidingTextBoxDishesQuantity();
            CleaningTextBoxDishesQuantity();
        }

        protected void ClearColorButton()
        {
            bMenu.PizzzaButton.BackColor = SystemColors.Control;
            bMenu.MainButton.BackColor = SystemColors.Control;
            bMenu.SoupButton.BackColor = SystemColors.Control;
            bMenu.DrinksButton.BackColor = SystemColors.Control;
        }

        protected void HidenButtonDishesOK()
        {              
                bAdd.AddButton.Visible = false;
        }

        protected void HidingTextBoxDishesQuantity()
        {                          
                qTextBox.QTextbox.Visible = false;          
        }

        protected void CleaningTextBoxDishesQuantity()
        {
            qTextBox.QTextbox.Text = "1";
        }

        protected void ChengeNameLabelMenuInfo(string infoMenu)
        {
            label.LabelMenu.Text = infoMenu;
        }

        public abstract void ViewSetting();
        
    }
}
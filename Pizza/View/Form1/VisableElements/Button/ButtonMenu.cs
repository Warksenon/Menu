using Pizza.View.Form1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    abstract class ButtonMenu 
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

        protected void ClearColorButton()
        {
            bMenu.PizzzaButton.BackColor = SystemColors.Control;
            bMenu.MainButton.BackColor = SystemColors.Control;
            bMenu.SoupButton.BackColor = SystemColors.Control;
            bMenu.DrinksButton.BackColor = SystemColors.Control;
        }

        protected void SetVisibleButtonDishesOK(bool visable)
        {
            if (visable) bAdd.AddButton.Visible = true;
            else
            {
                CleaningTextViewDishesQuantity();
                bAdd.AddButton.Visible = false;
            }
        }

        protected void CleaningTextViewDishesQuantity()
        {
            qTextBox.QTextbox.Text = "1";
        }

        protected void SetVisibleTextViewDishesQuantity(bool visalbe)
        {
            if (visalbe) qTextBox.QTextbox.Visible = true;
            else
            {
                CleaningTextViewDishesQuantity();
                qTextBox.QTextbox.Visible = false;
            }
        }

        protected void ChengeNameLabelMenuInfo(string infoMenu)
        {
            label.LabelMenu.Text = infoMenu;
        }
    }
}
using Pizza.View.Form1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza.Presenters.PresenterForm1.GetDishesAndSideDishForm1
{
    abstract class Form1Quantity
    {
        protected IForm1QuantityTextBox qTextBox;

        protected Form1Quantity(Form1 form1)
        {
            qTextBox = form1;
        }

        protected int CheckNumberTextViewDishes()
        {
            int number = CheckTextIsNumber(qTextBox.QTextbox.Text);           
            return number;
        }


        protected int CheckTextIsNumber(string textNumber)
        {
            int number = 0;
            try
            {
                number = Convert.ToUInt16(textNumber);
            }
            catch
            {
                MessageBox.Show("Podana ilość produktów nie jest prawidłowa");
            }
            return number;
        }
    }
}

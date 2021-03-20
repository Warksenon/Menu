using Pizza.View.Form1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public abstract class Form1Quantity
    {
        protected IForm1QuantityTextBox qTextBox;

        protected Form1Quantity(Form1Test form1)
        {
            qTextBox = form1;
        }

        protected int CheckNumberTextViewDishes()
        {
            int number = HelpFinding.ConvertTextToInt(qTextBox.QTextbox.Text);
            if (number < 1)
            {
                MessageBox.Show("Podana ilość produktów nie jest prawidłowa");
            }
            return number;
        }
    }
}

using System.Windows.Forms;

using Pizza;
using Pizza.View.Form1View;

namespace Test
{
    public abstract class FormMenuQuantityTest : ViewFormMenuTest
    {
        protected FormMenuQuantityTest( FormMenu form1 ) : base( form1 ) { }

        protected int CheckNumberTextViewDishes()
        {
            int number = HelpFinding.ConvertTextToInt(form.QTextbox.Text);
            if (number < 1)
            {
               // MessageBox.Show( "Podana ilość produktów nie jest prawidłowa" );
            }
            return number;
        }

    }
}

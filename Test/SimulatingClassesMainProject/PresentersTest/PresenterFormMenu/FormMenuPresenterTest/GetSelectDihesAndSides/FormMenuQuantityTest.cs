using Pizza;
using Pizza.Presenters;

namespace Test
{
    public abstract class FormMenuQuantityTest : ViewFormMenuTest
    {
        protected FormMenuQuantityTest( FormMenu form1 ) : base( form1 ) { }

        protected int CheckNumberTextViewDishes()
        {
            int number = HelperConvert.ConvertTextToInt(form.QTextbox.Text);
            if (number < 1)
            {
                // MessageBox.Show( "Podana ilość produktów nie jest prawidłowa" );
            }
            return number;
        }

    }
}

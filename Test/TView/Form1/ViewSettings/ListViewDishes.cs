
using Pizza.View.Form1;
using System.Drawing;

namespace Test
{
    public class ListViewDishes: IView
    {
        private readonly IForm1AddButton bAdd;
        private readonly IForm1QuantityTextBox qTextBox;

        public ListViewDishes(Form1Test form1)
        {           
            bAdd = form1;
            qTextBox = form1;            
        }

        public void ViewSetting()
        {
            SetVisibleButtonDishesOK();
            SetVisibleTextViewDishesQuantity();
        }

        private void SetVisibleButtonDishesOK()
        {
            bAdd.AddButton.Visible = true;            
        }

        private void SetVisibleTextViewDishesQuantity()
        {
            qTextBox.QTextbox.Visible = true;
        }
    }
}

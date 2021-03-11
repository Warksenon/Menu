
using Pizza.View.Form1;
using System.Drawing;

namespace Pizza
{
    public class ListViewDishes
    {
        private readonly IForm1AddButton bAdd;
        private readonly IForm1QuantityTextBox qTextBox;

        public ListViewDishes(Form1 form1)
        {           
            bAdd = form1;
            qTextBox = form1;            
        }

        public void SettingVisable()
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


using Pizza.View.Form1;
using Pizza.View.Form1View;
using System.Drawing;

namespace Pizza
{
    public class ListViewDishes: ViewFormMenu, IView
    {
        public ListViewDishes(FormMenu form) : base(form) { }

        public void ViewSetting()
        {
            SetVisibleButtonDishesOK();
            SetVisibleTextViewDishesQuantity();
        }

        private void SetVisibleButtonDishesOK()
        {
            form.AddButton.Visible = true;            
        }

        private void SetVisibleTextViewDishesQuantity()
        {
            form.QTextbox.Visible = true;
        }
    }
}

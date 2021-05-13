using Pizza.View.Form1View;

namespace Pizza
{
    public class ListViewDishes : ViewFormMenu, IView
    {
        public ListViewDishes( FormMenu form ) : base( form ) { }

        public void ViewSetting()
        {
            SetVisibleButtonDishesOK();
            SetVisibleTextViewDishesQuantity();
        }

        private void SetVisibleButtonDishesOK()
        {
            _form.AddButton.Visible = true;
        }

        private void SetVisibleTextViewDishesQuantity()
        {
            _form.QTextbox.Visible = true;
        }
    }
}

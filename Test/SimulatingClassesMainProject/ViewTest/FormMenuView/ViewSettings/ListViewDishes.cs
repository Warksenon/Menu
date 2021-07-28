using Pizza;

namespace Test
{
    public class ListViewDishes : ViewFormMenuTest, IView
    {
        public ListViewDishes ( FormMenu form ) : base( form ) { }

        public void ViewSetting ()
        {
            SetVisibleButtonDishesOK();
            SetVisibleTextViewDishesQuantity();
        }

        private void SetVisibleButtonDishesOK ()
        {
            form.AddButton.Visible = true;
        }

        private void SetVisibleTextViewDishesQuantity ()
        {
            form.QTextbox.Visible = true;
        }
    }
}

using System.Collections.Generic;

using Pizza.View.Form1View;

namespace Pizza.Presenters.PresenterFormMenu.LoadDishesAndSideDishForm1
{
    public class Form1LoadSidesPresenter : ViewFormMenu
    {
        public Form1LoadSidesPresenter( FormMenu form ) : base( form ) { }

        public void LoadCheckListBoxSideDishe( IForm1Sides listSides )
        {
            ClearCheckedListBox();
            List<string> list = listSides.GetSides();
            foreach (var side in list)
            {
                form.CheckedListBoxSide.Items.Add( side );
            }
        }

        public void ClearCheckedListBox()
        {
            form.CheckedListBoxSide.Items.Clear();
        }
    }
}

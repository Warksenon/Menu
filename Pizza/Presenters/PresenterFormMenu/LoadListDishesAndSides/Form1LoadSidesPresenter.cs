using System.Collections.Generic;

using Pizza.View.Form1View;

namespace Pizza.Presenters.PresenterFormMenu.LoadDishesAndSideDishForm1
{
    public class Form1LoadSidesPresenter : ViewFormMenu
    {
        public Form1LoadSidesPresenter( FormMenu form ) : base( form ) { }

        public void LoadCheckListBoxSideDishe( IList<string> listSides )
        {
            ClearCheckedListBox();
            var list = listSides.GetList();
            foreach (var side in list)
            {
                form.CheckedListBoxSide.Items.Add( side );
            }
        }

        private void ClearCheckedListBox()
        {
            form.CheckedListBoxSide.Items.Clear();
        }
    }
}

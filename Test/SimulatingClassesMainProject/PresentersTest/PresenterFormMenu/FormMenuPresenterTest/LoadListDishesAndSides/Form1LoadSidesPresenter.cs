using System.Collections.Generic;

using Pizza;
using Pizza.Presenters.PresenterFormMenu.LoadDishesAndSideDishForm1;

namespace Test
{
    public class Form1LoadSidesPresenter : ViewFormMenuTest
    {
        public Form1LoadSidesPresenter( FormMenu form ) : base( form ) { }


        public void LoadSidesPizza()
        {
            LoadCheckListBoxSideDishe( new ListSidesPizza() );
        }

        public void LoadSidesMainDishes()
        {
            LoadCheckListBoxSideDishe( new ListSidesMainDishes() );
        }

        private void LoadCheckListBoxSideDishe( Pizza.IList<string> listSides )
        {
            ClearCheckedListBox();
            List<string> list = listSides.GetList();
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

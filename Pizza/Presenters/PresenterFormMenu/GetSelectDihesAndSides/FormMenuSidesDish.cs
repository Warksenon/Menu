using System.Collections.Generic;

namespace Pizza.Presenters.PresenterFormMenu.GetDishesAndSideDishForm1
{
    public class FormMenuSidesDish : FormMenuQuantity
    {
        public FormMenuSidesDish( FormMenu form ) : base( form ) { }

        public List<string> GetListCheckedSides()
        {
            List<string> list = new List<string>();

            foreach (object item in form.CheckedListBoxSide.CheckedItems)
            {
                string side = item.ToString();
                list.Add( side );
            }

            return list;
        }

    }
}

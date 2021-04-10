using System.Collections.Generic;

namespace Pizza.Presenters.PresenterFormMenu.GetDishesAndSideDishForm1
{
    public class Form1SidesDish : FormMenuQuantity
    {
        public Form1SidesDish(FormMenu form) : base(form) { }

        public List<string> GetListCheckedSides()
        {
            List<string> list = new List<string>();
            foreach (object item in form.CheckedListBoxSide.CheckedItems)
            {
                string side = item.ToString();
                list.Add(side);
            }
            return list;
        }
    }
}

using System.Collections.Generic;

using Pizza;

namespace Test
{
    public class FormMenuSidesDishTest : FormMenuQuantityTest
    {
        public FormMenuSidesDishTest( FormMenu form ) : base( form ) { }

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

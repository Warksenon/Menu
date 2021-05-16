using System.Collections.Generic;

using Pizza;
using Pizza.View.Form1View;

namespace Test
{
    public class SidesCheckListBoxTest : ViewFormMenu, IListSet<string>, IListGet<string>
    {
        int [] SimulationSelectionSides { get; set; }
        public SidesCheckListBoxTest( FormMenu form ) : base( form ) { } 
  
        public List<string> GetList()
        {
            return GetListCheckedSides();
        }

        private List<string> GetListCheckedSides()
        {
            List<string> list = new List<string>();

            foreach (object item in SimulationSelectionSides)
            {
                string side = item.ToString();
                list.Add( side );
            }

            return list;
        }

        public void SetList( List<string> elements )
        {
            LoadCheckListBoxSideDishe( elements );
        }

        private void LoadCheckListBoxSideDishe( List<string> listSides )
        {
            ClearCheckedListBox();
           
            foreach (var side in listSides)
            {
                _form.CheckedListBoxSide.Items.Add( side );
            }
        }

        private void ClearCheckedListBox()
        {
            _form.CheckedListBoxSide.Items.Clear();
        }

       
    }
}

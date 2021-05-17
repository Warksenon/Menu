using System.Collections.Generic;

using Pizza;
using Pizza.View.Form1View;

namespace Test
{
    public class SidesCheckListBoxTest : ViewFormMenu, IListSet<string>, IListGet<string>
    {
        private readonly int [] simulationSelectionSides;
        public SidesCheckListBoxTest( FormMenu form, int [] simulationSelectionSides ) : base( form )
        {
            this.simulationSelectionSides = simulationSelectionSides;
        }

        public List<string> GetList()
        {
            return GetListCheckedSides();
        }

        private List<string> GetListCheckedSides()
        {
            List<string> list = new List<string>();

            if (simulationSelectionSides == null)
            {
                return list;
            }
            else
            {
                foreach (int item in simulationSelectionSides)
                {
                    string side =_form.CheckedListBoxSide.Items [item].ToString();
                    list.Add( side );
                }
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

using System.Collections.Generic;

using Pizza;

namespace Test
{
    public class FormMenuSidesDishTest : FormMenuQuantityTest
    {
        readonly int [] simulationSelectionSides;
        public FormMenuSidesDishTest( FormMenu form, int[] simulationSelectionSides ) : base( form ) 
        {
            this.simulationSelectionSides = simulationSelectionSides;
        }

        public List<string> GetListCheckedSides()
        {
            List<string> list = new List<string>();
            foreach (int i in simulationSelectionSides)
            {
                string side = form.CheckedListBoxSide.Items [i].ToString();
                list.Add( side );
            }
            return list;
        }

    }
}

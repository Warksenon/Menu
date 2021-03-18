﻿using Pizza.Models.Menu.Sides;
using System.Collections.Generic;

namespace Test
{
    public class Form1LoadSidesPresenter
    {
        private readonly IForm1ChecedListBoxSides loadSides;

        public Form1LoadSidesPresenter(Form1Test form1)
        {
            loadSides = form1;
        }

        public void LoadSidesPizza()
        {
            LoadCheckListBoxSideDishe(new ListSidesPizza());
        }

        public void LoadSidesMainDishes()
        {
            LoadCheckListBoxSideDishe(new ListSidesMainDishes());
        }


        private void LoadCheckListBoxSideDishe(IForm1Sides listSides)
        {
            ClearCheckedListBox();
            List<string> list = listSides.GetSides();
            foreach (var side in list)
            {              
                loadSides.CheckedListBoxSide.Items.Add(side);
            }
        }

        public void ClearCheckedListBox()
        {
            loadSides.CheckedListBoxSide.Items.Clear();
        }
    }
}

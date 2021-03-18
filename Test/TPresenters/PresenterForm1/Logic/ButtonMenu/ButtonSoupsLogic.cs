﻿using Pizza.Presenters.PresenterForm1.LoadDishesAndSideDishForm1;
using Pizza.Presenters.PresenterForm1.Logic.ButtonMenu;
using Pizza.Presenters.PresenterForm1.VisableElements.Button;
using Pizza.View.Form1;

namespace Test
{
    class ButtonSoupsLogic : MenuButton
    {
        public ButtonSoupsLogic(Form1Test form1) : base(form1) { }

            public override void LogicSettings()
        {
            loadSidesToCheckedListBox.ClearCheckedListBox();
            loadDishesToListView.LoadSoups();
        }
    }
}

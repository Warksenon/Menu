using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Pizza.Presenters.PresenterForm1.LoadDishesAndSideDishForm1;
using Pizza.Presenters.PresenterForm1.Logic.ButtonMenu;
using Pizza.Presenters.PresenterForm1.VisableElements.Button;
using Pizza.View.Form1;

namespace Pizza.Presenters.PresenterForm1.Logic
{
    class ButtonDriksLogic : MenuButton
    {        
        public ButtonDriksLogic(Form1 form1):base(form1){}

        public void LogicSettings()
        {
            loadDishesToListView.LoadPizza();
            loadSidesToCheckedListBox.ClearCheckedListBox();
        }
    }
}

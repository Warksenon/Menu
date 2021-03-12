using Pizza.Presenters.PresenterForm1.LoadDishesAndSideDishForm1;
using Pizza.Presenters.PresenterForm1.Logic.ButtonMenu;
using Pizza.View.Form1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Presenters.PresenterForm1.Logic
{
    class ButtonPizzaLogic: MenuButton
    {
        public ButtonPizzaLogic(Form1 form1) : base(form1) { }

        public void LogicSettings()
        {
            loadSidesToCheckedListBox.LoadSidesPizza();
            loadDishesToListView.LoadPizza();
        }
    }
}

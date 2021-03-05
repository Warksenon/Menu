using Pizza.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    class ButtonDrinksSettings : ButtonMenu,  IMenuButton
    {
        public void SetButtonSetting()
        {
            ClearColorButton();
            DrinkseButtonSettings();
        }

        public ButtonDrinksSettings(Form1 form1):base(form1)
        {            
            
        }

        private void DrinkseButtonSettings()
        {
            bMenu.DrinksButton.BackColor = Color.LawnGreen;
            ChengeNameLabelMenuInfo("Napoje");
            SetVisibleButtonDishesOK(false);
            SetVisibleTextViewDishesQuantity(false);
        }
    }
}

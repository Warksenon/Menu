﻿using Pizza;
using Pizza.View.Form1View.ViewSettings.ButtonMenu;
using System.Drawing;

namespace Test
{
    public class ButtonDrinksView : ButtonMenu
    {
        public ButtonDrinksView(FormMenu form1) : base(form1) { }

        public override void ViewSetting()
        {
            ClearColorButton();
            DrinkseButtonSettings();
        }

        private void DrinkseButtonSettings()
        {
            ChengeNameLabelMenuInfo("Napoje");
            ButtonSeting();
            form.DrinksButton.BackColor = Color.LawnGreen;
        }
    }
}
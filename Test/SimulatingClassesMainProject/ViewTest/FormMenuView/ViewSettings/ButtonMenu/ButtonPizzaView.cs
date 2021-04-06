﻿using Pizza;
using System.Drawing;

namespace Test
{
    public class ButtonPizzaView : ButtonMenu
    {
        public ButtonPizzaView(FormMenu form) : base(form) { }

        public override void ViewSetting()
        {
            ClearColorButton();
            PizzaButtonSettings();
        }

        private void PizzaButtonSettings()
        {          
            ChengeNameLabelMenuInfo("Pizza");
            ButtonSeting();
            form.PizzzaButton.BackColor = Color.LawnGreen;
        }
    }
}
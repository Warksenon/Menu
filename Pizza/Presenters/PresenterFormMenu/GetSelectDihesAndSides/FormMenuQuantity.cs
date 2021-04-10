﻿using Pizza.View.Form1View;
using System.Windows.Forms;

namespace Pizza.Presenters.PresenterFormMenu.GetDishesAndSideDishForm1
{
    public abstract class FormMenuQuantity : ViewFormMenu
    {

        protected FormMenuQuantity(FormMenu form1) : base(form1) { }

        protected int CheckNumberTextViewDishes()
        {
            int number = HelpFinding.ConvertTextToInt(form.QTextbox.Text);
            if (number < 1)
            {
                MessageBox.Show("Podana ilość produktów nie jest prawidłowa");
            }
            return number;
        }

    }
}

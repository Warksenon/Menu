using Pizza.View.FormMenuView.ViewSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class ButtonOkView : TestVisibleElements, IView
    {
        FormMenu form;

        public ButtonOkView(FormMenu form)
        {
            this.form = form;
        }

        public void ViewSetting()
        {
            string text = form.QTextbox.Text;
            int number = HelpFinding.ConvertTextToInt(text);

            if (number > 0) 
            {
                form.ButtonRemoveAll.Visible = true;
                ButtonRemoveAll = true;
            }
            else 
            { 
                form.ButtonRemoveAll.Visible = false;
                ButtonRemoveAll = false;
            }

            form.ButtonRemoveOne.Visible = false;
            ButtonRemoveOne = false;
        }
    }
}

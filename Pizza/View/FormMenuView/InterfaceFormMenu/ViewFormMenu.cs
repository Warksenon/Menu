using Pizza.View.FormMenuView.ViewSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.View.Form1View
{
    public abstract class ViewFormMenu : TestVisibleElements
    {
        protected FormMenu form;

        protected ViewFormMenu(FormMenu form)
        {
            this.form = form;
        }
    }
}

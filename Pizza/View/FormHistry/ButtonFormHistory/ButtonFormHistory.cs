using System.Drawing;

namespace Pizza.View.FormHistry.ButtonFormHistory
{
    abstract class ButtonFormHistory : IView
    {
        protected FormHistory form;

        public ButtonFormHistory(FormHistory form)
        {
            this.form = form;
        }

        public abstract void ViewSetting();

        protected void AllButtonSetSystemColorsControl()
        {
            form.ButtonLoadSql.BackColor = SystemColors.Control;
            form.ButtonLoadTxt.BackColor = SystemColors.Control;
            form.ButtonCopySql.BackColor = SystemColors.Control;
            form.ButtonCopyTxt.BackColor = SystemColors.Control;
        }
    }
}

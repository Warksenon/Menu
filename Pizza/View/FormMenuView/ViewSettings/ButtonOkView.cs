using System.Drawing;

namespace Pizza
{
    public class ButtonOkView : IView
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
                form.ButtonSubmitOrder.BackColor = Color.LawnGreen;
                form.ButtonRemoveAll.Visible = true;
            }
            else 
            { 
                form.ButtonRemoveAll.Visible = false;
            }

            form.ButtonRemoveOne.Visible = false;
        }
    }
}

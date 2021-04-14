using System.Drawing;

using Pizza;
using Pizza.Presenters;

namespace Test
{
    public class ButtonOkView : TestVisibleElements, IView
    {
        private readonly FormMenu form;

        public ButtonOkView( FormMenu form )
        {
            this.form = form;
        }

        public void ViewSetting()
        {
            string text = form.QTextbox.Text;
            int number = HelperConvert.ConvertTextToInt(text);

            if (number > 0)
            {
                form.ButtonSubmitOrder.BackColor = Color.LawnGreen;
                form.ButtonRemoveAll.Visible = true;
                ButtonRemoveAllVisibility = true;
            }
            else
            {
                form.ButtonRemoveAll.Visible = false;
                ButtonRemoveAllVisibility = false;
            }

            form.ButtonRemoveOne.Visible = false;
            ButtonRemoveOneVisibility = false;
        }
    }
}

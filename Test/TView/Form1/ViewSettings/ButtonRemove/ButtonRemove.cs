using Pizza.View.Form1;
using System.Drawing;

namespace Test
{
    abstract class ButtonRemove : IView
    {
        protected IButtonRemove remove;
        protected IForm1ListViewOrder lvOrder;
        protected IButtonSend send;


        protected ButtonRemove(Form1Test form1)
        {
            remove = form1;
            lvOrder = form1;
            send = form1;
        }

        public abstract void ViewSetting();

        protected void RemoveAll()
        {
            send.ButtonSendMassage.BackColor = SystemColors.Control;
            remove.ButtonRemoveAll.Visible = false;
            remove.ButtonRemoveOne.Visible = false;
        }
    }
}

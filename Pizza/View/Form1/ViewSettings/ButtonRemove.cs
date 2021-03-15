using Pizza.View.Form1;
using System.Drawing;

namespace Pizza
{
    class ButtonRemove: IView
    {
        IButtonRemove remove;
        IForm1ListViewOrder lvOrder;
        IButtonSend send;


        public ButtonRemove (Form1 form1)
        {
            remove = form1;
            lvOrder = form1;
            send = form1;
        }

        public void SchowButtonRemoveOne()
        {
            remove.ButtonRemoveOne.Visible = true;
        }

        public void SchowButtonRemoveAll()
        {
            SetSettingsButton();
        }

        public void RemoveOne()
        {          
            SetSettingsButton();
            remove.ButtonRemoveOne.Visible = false;
        }

        public void RemoveAll()
        {           
            remove.ButtonRemoveAll.Visible = false;
            remove.ButtonRemoveOne.Visible = false;
        }

        private bool CheckingListOrderIfEmpty()
        {
            if (lvOrder.ListViewOrder.Items.Count > 0) return true;
            else return false;
        }

        private void SetSettingsButton()
        {
            if (CheckingListOrderIfEmpty())
            {
                send.ButtonSendMassage.BackColor = Color.LawnGreen;
                remove.ButtonRemoveAll.Visible = true;
            }
            else 
            {
                send.ButtonSendMassage.BackColor = SystemColors.Control;    
                remove.ButtonRemoveAll.Visible = false;
            }
                
        }

        public void ViewSetting()
        {
            throw new System.NotImplementedException();
        }
    }
}

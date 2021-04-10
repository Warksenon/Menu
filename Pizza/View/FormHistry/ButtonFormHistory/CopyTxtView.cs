using System.Drawing;

namespace Pizza.View.FormHistry.ButtonFormHistory
{
    class CopyTxtView : ButtonFormHistory
    {
        public CopyTxtView(FormHistory form) : base(form) { }

        public override void ViewSetting()
        {
            SetColoButtons();
        }

        private void SetColoButtons()
        {
            AllButtonSetSystemColorsControl();
            form.ButtonCopyTxt.BackColor = Color.LawnGreen;
        }
    }
}

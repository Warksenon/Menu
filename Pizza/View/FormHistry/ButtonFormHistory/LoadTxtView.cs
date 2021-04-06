using System.Drawing;

namespace Pizza.View.FormHistry.ButtonFormHistory
{
    class LoadTxtView : ButtonFormHistory
    {
        public LoadTxtView (FormHistory form) : base(form) { }

        public override void ViewSetting()
        {
            SetColoButtons();
        }

        private void SetColoButtons()
        {
            AllButtonSetSystemColorsControl();
            form.ButtonLoadTxt.BackColor = Color.LawnGreen;
        }
    }
}

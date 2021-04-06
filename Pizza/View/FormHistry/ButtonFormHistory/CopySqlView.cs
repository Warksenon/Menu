using System.Drawing;
using System.Threading;

namespace Pizza.View.FormHistry.ButtonFormHistory
{
    class CopySqlView : ButtonFormHistory
    {
        public CopySqlView (FormHistory form): base(form) { }

        public override void ViewSetting()
        {
            SetColoButtons();
        }

        private void SetColoButtons()
        {
            AllButtonSetSystemColorsControl();
            form.ButtonCopySql.BackColor = Color.LawnGreen;
        }
    }
}

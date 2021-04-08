using System.Drawing;

namespace Pizza.View.FormHistry.ButtonFormHistory
{
    class LoadSqlView : ButtonFormHistory
    {
        public LoadSqlView( FormHistory form ) : base( form ) { }

        public override void ViewSetting()
        {
            SetColoButtons();
        }

        private void SetColoButtons()
        {
            AllButtonSetSystemColorsControl();
            form.ButtonLoadSql.BackColor = Color.LawnGreen;
        }
    }
}

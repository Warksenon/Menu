using System.Windows.Forms;

namespace Pizza.Presenters
{
    class DialogBox : IDialogService
    {
        public void ShowMessage ( string message )
        {
            MessageBox.Show( message );
        }
    }
}

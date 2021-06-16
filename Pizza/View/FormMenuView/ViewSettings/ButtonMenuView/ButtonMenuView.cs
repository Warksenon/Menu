using System.Drawing;

namespace Pizza.View.Form1View.ViewSettings.ButtonMenu
{
    public class ButtonMenuView 
    {      
        private readonly FormMenu _form;

        public ButtonMenuView( FormMenu form )
        {
            _form = form;
            ButtonSeting();
        }

        public void PizzaButtonSettings()
        {
            ChengeNameLabelMenuInfo( "Pizza" );
            _form.PizzzaButton.BackColor = Color.LawnGreen;
        }

        public void MainDishButtonSettings()
        {
            ChengeNameLabelMenuInfo( "Dania główne" );
            _form.MainButton.BackColor = Color.LawnGreen;
        }

        public void SoupsButtonSettings()
        {
            ChengeNameLabelMenuInfo( "Zupy" );
            _form.SoupButton.BackColor = Color.LawnGreen;
        }

        public void DrinkseButtonSettings()
        {
            
            ChengeNameLabelMenuInfo( "Napoje" );
            _form.DrinksButton.BackColor = Color.LawnGreen;
        }

        private void ButtonSeting()
        {
            ClearColorButton();
            HidenButtonDishesOK();
            HidingTextBoxDishesQuantity();
            CleaningTextBoxDishesQuantity();
        }

        private void ClearColorButton()
        {
            _form.PizzzaButton.BackColor = SystemColors.Control;
            _form.MainButton.BackColor = SystemColors.Control;
            _form.SoupButton.BackColor = SystemColors.Control;
            _form.DrinksButton.BackColor = SystemColors.Control;
        }

        private void HidenButtonDishesOK()
        {
            _form.AddButton.Visible = false;
        }

        private void HidingTextBoxDishesQuantity()
        {
            _form.QTextbox.Visible = false;
        }

        private void CleaningTextBoxDishesQuantity()
        {
            _form.QTextbox.Text = "1";
        }

        private void ChengeNameLabelMenuInfo( string infoMenu )
        {
            _form.LabelMenu.Text = infoMenu;
        }

    }
}
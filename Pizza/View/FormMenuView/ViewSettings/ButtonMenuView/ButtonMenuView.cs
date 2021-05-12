using System.Drawing;

namespace Pizza.View.Form1View.ViewSettings.ButtonMenu
{
    public class ButtonMenuView : IView
    {
        ButtonLoadMenu _loadMenu;
        FormMenu _form;
       
        public ButtonMenuView( FormMenu form, ButtonLoadMenu loadMenu ) 
        {
            _form = form;
            _loadMenu = loadMenu;
        }

        private void OnClickButtonMenu()
        {
            ButtonSeting();

            switch (_loadMenu)
            {
                case ButtonLoadMenu.Pizza:
                PizzaButtonSettings();
                break;
                case ButtonLoadMenu.MainDishes:
                MainDishButtonSettings();
                break;
                case ButtonLoadMenu.Soups:
                SoupsButtonSettings();
                break;
                case ButtonLoadMenu.Drinks:
                DrinkseButtonSettings();
                break;

            }
        }

        private void PizzaButtonSettings()
        {
            ChengeNameLabelMenuInfo( "Pizza" );
            _form.PizzzaButton.BackColor = Color.LawnGreen;
        }

        private void MainDishButtonSettings()
        {
            ChengeNameLabelMenuInfo( "Dania główne" );
            _form.MainButton.BackColor = Color.LawnGreen;
        }

        private void SoupsButtonSettings()
        {
            ChengeNameLabelMenuInfo( "Zupy" );
            _form.SoupButton.BackColor = Color.LawnGreen;
        }

        private void DrinkseButtonSettings()
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

        public void ViewSetting()
        {
            OnClickButtonMenu();
        }
    }
}
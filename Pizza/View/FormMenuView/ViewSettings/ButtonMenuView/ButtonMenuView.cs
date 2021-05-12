using System.Drawing;

namespace Pizza.View.Form1View.ViewSettings.ButtonMenu
{
    public class ButtonMenuView : ViewFormMenu, IView
    {
        ButtonLoadMenu _loadMenu;

        public ButtonMenuView( FormMenu form1, ButtonLoadMenu loadMenu ) : base( form1 ) 
        {
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
            form.PizzzaButton.BackColor = Color.LawnGreen;
        }

        private void MainDishButtonSettings()
        {
            ChengeNameLabelMenuInfo( "Dania główne" );
            form.MainButton.BackColor = Color.LawnGreen;
        }

        private void SoupsButtonSettings()
        {
            ChengeNameLabelMenuInfo( "Zupy" );
            form.SoupButton.BackColor = Color.LawnGreen;
        }

        private void DrinkseButtonSettings()
        {
            ChengeNameLabelMenuInfo( "Napoje" );
            form.DrinksButton.BackColor = Color.LawnGreen;
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
            form.PizzzaButton.BackColor = SystemColors.Control;
            form.MainButton.BackColor = SystemColors.Control;
            form.SoupButton.BackColor = SystemColors.Control;
            form.DrinksButton.BackColor = SystemColors.Control;
        }

        private void HidenButtonDishesOK()
        {
            form.AddButton.Visible = false;
        }

        private void HidingTextBoxDishesQuantity()
        {
            form.QTextbox.Visible = false;
        }

        private void CleaningTextBoxDishesQuantity()
        {
            form.QTextbox.Text = "1";
        }

        private void ChengeNameLabelMenuInfo( string infoMenu )
        {
            form.LabelMenu.Text = infoMenu;
        }

        public void ViewSetting()
        {
            OnClickButtonMenu();
        }
    }
}
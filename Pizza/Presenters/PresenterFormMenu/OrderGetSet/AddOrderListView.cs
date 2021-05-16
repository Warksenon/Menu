using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using Pizza.Presenters.PresenterFormMenu;
using Pizza.Presenters.PresenterFormMenu.OrderGetSet;

namespace Pizza.Presenters
{
    internal class AddOrderListView : FormMenuListViewOrder, ILogic
    {
        public AddOrderListView( FormMenu form1 ) : base( form1 ) { }
  
        public void LogicSettings()
        {
            AddOrderToListView();
        }

        private void AddOrderToListView()
        {
            var dish = CreateDish();
            var listDish =GetListSelektedDishes(dish);
            new OrderListView( _form ).SetList( listDish );
        }

        private Dish CreateDish()
        {
            var dish =  new DishesListView(_form).GetElement();
            var listSides = new SidesCheckListBox(_form).GetList();
            if (listSides.Count == 0)
            {
                dish.Sides = "";
            }
            else
            {             
                var allSidesToGether = AddAllSides(listSides);
                dish.Sides = allSidesToGether;
                var priceAll = AddPriceDisheAndSide(dish, listSides);
                dish.Price = priceAll;
            }

            return dish;
        } 

        private List<Dish> GetListSelektedDishes( Dish dish )
        {
            var list = new List<Dish>();
            int numbersRepetitions = CheckNumberTextViewDishes();

            if (numbersRepetitions > 0)
            {
                while (numbersRepetitions == 1)
                {
                    list.Add( dish );
                    numbersRepetitions -= 1;
                }
            }

            return list;
        }

        private int CheckNumberTextViewDishes()
        {
            int number = HelperConvert.ConvertTextToInt(_form.QTextbox.Text);

            if (number < 1)
            {
                MessageBox.Show( "Podana ilość produktów nie jest prawidłowa" );
            }

            return number;
        }

        private string AddAllSides( List<string> listSides )
        {
            StringBuilder allSidesToGether = new StringBuilder();
            for (int i = 0; i < listSides.Count; i++)
            {
                allSidesToGether.Append( listSides [i] );
                if (i == listSides.Count - 1)
                {
                    allSidesToGether.Append( "." );
                }
                else
                {
                    allSidesToGether.Append( "," );
                }
            }

            return allSidesToGether.ToString();
        }

        private string AddPriceDisheAndSide( Dish dish, List<string> listSides )
        {
            var priceSides = 0.0;
            var price = 0.0;

            foreach (var side in listSides)
            {
                price = FindPrice( side );
                priceSides += price;

            }

            price = FindPrice( dish.Price );
            var priceAll =  price + priceSides;
            return priceAll + "zł";
        }

    }
}

using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using Pizza.Presenters.PresenterFormMenu.GetDishesAndSideDishForm1;
using Pizza.Presenters.PresenterFormMenu.OrderGetSet;

namespace Pizza.Presenters
{
    internal class FormMenuAddOrderListView : FormMenuListViewOrder, ILogic
    {
        private readonly FormMenuListDishes lvDishes;
        private readonly FormMenuSidesDish chblSides;

        public FormMenuAddOrderListView( FormMenu form1 ) : base( form1 )
        {
            lvDishes = new FormMenuListDishes( form1 );
            chblSides = new FormMenuSidesDish( form1 );
        }

        public void LogicSettings()
        {
            AddOrderToListView();
        }

        private void AddOrderToListView()
        {
            var listDishes = lvDishes.GetListSelektedDishes();
            var listSides = chblSides.GetListCheckedSides();
            var allSidesToGether = AddAllSides(listSides);

            foreach (var dish in listDishes)
            {
                ListViewItem lvi;
                if (HelpFinding.CheckStringIsEmpty( allSidesToGether ))
                {
                    lvi = new ListViewItem( dish.Name );
                    lvi.SubItems.Add( allSidesToGether );
                    lvi.SubItems.Add( dish.Price );
                }
                else
                {
                    string priceAll = AddPriceDisheAndSide(listDishes, listSides);
                    lvi = new ListViewItem( dish.Name + " - " + dish.Price );
                    lvi.SubItems.Add( allSidesToGether );
                    lvi.SubItems.Add( priceAll );
                }

                form.ListViewOrder.Items.Add( lvi );
            }
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

        private string AddPriceDisheAndSide( List<Dish> listDishes, List<string> listSides )
        {
            var priceSides = 0.0;
            var price = 0.0;

            foreach (var side in listSides)
            {
                string textPrice = side;
                price = FindPrice( textPrice );
                priceSides += price;
            }

            var priceDish = FindPrice(listDishes[0].Price);
            var priceAll = priceDish + priceSides;
            return priceAll + "zł";
        }

    }
}

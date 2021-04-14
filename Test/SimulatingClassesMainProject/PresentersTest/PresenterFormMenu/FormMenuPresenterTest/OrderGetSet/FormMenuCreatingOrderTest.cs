using System;
using System.Collections.Generic;
using Pizza;
using Pizza.Presenters.PresenterFormMenu.OrderGetSet;

namespace Test
{
    internal class FormMenuCreatingOrderTest : FormMenuListViewOrderTest
    {
        private readonly Order order = new Order();

        public FormMenuCreatingOrderTest( FormMenu form ) : base( form ) { }

        public Order GetOrderFromListView()
        {
            GetListDishesFromListViewOrder();
            AddPriceAllToOrder();
            GetComments();
            GetDate();
            return order;
        }

        private void AddPriceAllToOrder()
        {
            double price = GetPricaAll();
            order.PriceAll.Price = price + "zł";
        }

        private void GetComments()
        {
            order.PriceAll.Comments = form.TextBoxComments.Text;
        }

        private void GetDate()
        {
            order.PriceAll.Date = DateTime.Now.ToString();
        }

        private void GetListDishesFromListViewOrder()
        {
            var list = new List<Dish>();
            int counter = form.ListViewOrder.Items.Count;

            for (int i = 0; i < counter; i++)
            {
                list.Add( new Dish()
                {
                    Name = form.ListViewOrder.Items [i].SubItems [0].Text,
                    Sides = form.ListViewOrder.Items [i].SubItems [1].Text,
                    Price = form.ListViewOrder.Items [i].SubItems [2].Text
                } );
            }

            order.ListDishes = list;
        }
    }
}

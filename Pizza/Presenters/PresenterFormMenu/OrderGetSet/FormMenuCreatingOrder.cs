using System;
using System.Collections.Generic;

using Pizza.Presenters.PresenterFormMenu.OrderGetSet;

namespace Pizza
{
    internal class FormMenuCreatingOrder : FormMenuListViewOrder
    {
        private readonly Order order = new Order();

        public FormMenuCreatingOrder( FormMenu form ) : base( form ) { }

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
            order.PriceAll.Comments = _form.TextBoxComments.Text;
        }

        private void GetDate()
        {
            order.PriceAll.Date = DateTime.Now.ToString();
        }

        private void GetListDishesFromListViewOrder()
        {
            var list = new List<Dish>();
            int counter = _form.ListViewOrder.Items.Count;

            for (int i = 0; i < counter; i++)
            {
                list.Add( new Dish()
                {
                    Name = _form.ListViewOrder.Items [i].SubItems [0].Text,
                    Sides = _form.ListViewOrder.Items [i].SubItems [1].Text,
                    Price = _form.ListViewOrder.Items [i].SubItems [2].Text
                } );
            }

            order.ListDishes = list;
        }
    }
}

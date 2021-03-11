using Pizza.Models.Menu.Sides;
using Pizza.Presenters.PresenterForm1.Order;
using System;
using System.Collections.Generic;

namespace Pizza
{
    class Form1CreatingOrder : Form1ListViewOrder
    {

        public Form1CreatingOrder(Form1 form1) : base(form1)
        {
            
        }

        private static  Order order = new Order();

        void AddPriceAllToOrder()
        {
            string price = Convert.ToString(GetPricaAll());
            order.PriceAll.Price = price + " zł";
        }


        public void SetListDishes()
        {

            var list = new List<Dish>();
            if (!(lvOrder.ListViewOrder.Items == null))
            {
                int i = 0;
                foreach (var item in lvOrder.ListViewOrder.Items)
                {
                    list.Add(new Dish()
                    {
                        Name = lvOrder.ListViewOrder.Items[i].SubItems[0].Text,
                        //   SidesDishes = ListView.Items[i].SubItems[1].Text,
                        Price = lvOrder.ListViewOrder.Items[i].SubItems[2].Text
                    });
                    i++;
                }
            }
            order.ListDishes = list;
        }

        List<string> GetSides (string textSide)
        {
            List<string> listSides = new List<string>();
            int indexEnd = textSide.IndexOf(".");
            while (indexEnd > 0)
            {
                IListSides addSide = new ListSidesPizza();             
                string sideWithPrice;
                int index = textSide.IndexOf(",");

                if (index > 0)
                {
                    sideWithPrice = textSide.Substring(0, index - 1);

                    addSide.AddSideToList(listSides, sideWithPrice);
                }
                else
                {
                    sideWithPrice = textSide.Replace(".", "");
                    addSide.AddSideToList(listSides, sideWithPrice);
                    indexEnd = -1;
                }
            }

            return listSides;
        }

        //public void SetCommentsAndDate(string comments)
        //{
        //    order.PriceAll.Comments = comments;
        //    order.PriceAll.Date = DateTime.Now.ToString();
        //}

        //public Order GetOrder()
        //{
        //    return order;
        //}





        //static string sendMesseg;
        //public void SubmitOrder()
        //{
        //    if (ChceckListViewOrderIsNotEpmty())
        //    {
        //        SetCommentsAndDate(form1Order.TextBoxComments.Text);
        //        SetListDishes(form1Order.ListViewOrder);
        //        //EmailMessage messeg = new EmailMessage(GetOrder());
        //     //   sendMesseg = messeg.WriteBill();
        //        if (form1Order.BackgroundWorker.IsBusy != true)
        //        {
        //            form1Order.BackgroundWorker.RunWorkerAsync();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Przetwarzanie danych proszę czekać");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Proszę wybrać produkt");
        //    }
        //}

        //private bool ChceckListViewOrderIsNotEpmty()
        //{
        //    if (form1Order.ListViewOrder.Items.Count > 0) return true;
        //    else return false;
        //}

        //private bool SendEmail(string message)
        //{
        //   // Email email = new Email();
        //    return email.SendEmail(message);
        //}

        //public void SendEmailAndSaveOrder()
        //{
        //    Save save = new Save();
        //    if (SendEmail(sendMesseg))
        //    {
        //        save.SaveOrder(Save.ChoiceSaveOrder.Txt, GetOrder());
        //        save.SaveOrder(Save.ChoiceSaveOrder.Sql, GetOrder());
        //    }
        //    else
        //    {
        //        MessageBox.Show("Wysłanie wiadomości nie powiodło się. Problem z adres e-mail lub z połaczeniem internetowym");
        //    }
        //}

    }
}

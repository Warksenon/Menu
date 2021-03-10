using Pizza.Models.Order;
using Pizza.Presenters.PresenterForm1.GetDishesAndSideDishForm1;
using Pizza.Presenters.PresenterForm1.Order;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pizza.Presenters
{
    class Form1OrderPresenters : IPriceAll
    {
        Form1ListDishes lvDishes;
        Form1SidesDish chblSides;
        IForm1ListViewOrder lvOrder;
        public Form1OrderPresenters(Form1 form1)
        {                     
            lvDishes = new Form1ListDishes(form1);
            chblSides = new Form1SidesDish(form1);
            lvOrder = form1;
        }

        public void AddOrderToListView()
        {
            List<Dish> listDishes = lvDishes.GetListDishes();
            List<Side> listSides = chblSides.GetListSides();
            string allSidesToGether = AddAllSides(listSides);

            foreach (var dish in listDishes)
            {
                ListViewItem lvi;
                if (HelpFinding.CheckStringIsEmpty(allSidesToGether))
                {
                    lvi = new ListViewItem(dish.Name);
                    lvi.SubItems.Add(allSidesToGether);
                    lvi.SubItems.Add(dish.Price);
                }
                else
                {
                    string priceAll = AddPriceDisheAndSide(listDishes, listSides);
                    lvi = new ListViewItem(dish.Name + " - " + dish.Price);
                    lvi.SubItems.Add(allSidesToGether);
                    lvi.SubItems.Add(priceAll);
                }
                lvOrder.ListViewOrder.Items.Add(lvi);
            }
        }

        private string AddAllSides(List<Side> listSides)
        {
            string allSidesToGether = "";
            for(int i = 0; i<listSides.Count; i++ )
            {
                string name = listSides[i].Name;
                string price = listSides[i].Price;
                allSidesToGether += name + " - " + price;
                if(i== listSides.Count)
                {
                    allSidesToGether += ".";
                }
                else
                {
                    allSidesToGether += ",";
                }
            }
           
            return allSidesToGether;
        }

        private string AddPriceDisheAndSide(List<Dish> listDishes, List<Side> listSide)
        {
            double priceSides=0;
            double price;

            foreach (var s in listSide)
            {
                string textPrice = s.Price;
                price = FindPrice(textPrice);
                priceSides += price; 
            }

            double priceDish = FindPrice(listDishes[0].Price);
            double priceAll = priceDish + priceSides;
            return priceAll + " zł";
        }

        private double FindPrice(string text)
        {
            double price=0;           
            try
            {
                string textPrice = text.Replace("zł", "");
                price = Convert.ToDouble(textPrice);
            }
            catch(Exception e)
            {
                RecordOfExceptions.Save(Convert.ToString(e), "Form1OrderPresenter - FindPrice");
            }           
            return price;
        }

        //public void LabelPrice()
        //{

        //    form1Order.LabelPrice.Text = "Cena: " + PriceCalculation(form1Order.ListViewOrder).ToString() + "zł";
        //}

        

        //static readonly Order order = new Order();

        //void AddPriceAllToOrder(double price)
        //{
        //    order.PriceAll.Price = Convert.ToString(price);

        //}


        //public void SetListDishes(ListView ListView)
        //{

        //    var list = new List<Dish>();
        //    if (!(ListView.Items == null))
        //    {
        //        int i = 0;
        //        foreach (var item in ListView.Items)
        //        {
        //            list.Add(new Dish()
        //            {
        //                Name = ListView.Items[i].SubItems[0].Text,
        //             //   SidesDishes = ListView.Items[i].SubItems[1].Text,
        //                Price = ListView.Items[i].SubItems[2].Text
        //            });
        //            i++;
        //        }
        //    }
        //    order.ListDishes = list;
        //}

        //public void SetCommentsAndDate(string comments)
        //{
        //    order.PriceAll.Comments = comments;
        //    order.PriceAll.Date = DateTime.Now.ToString();
        //}

        //public Order GetOrder()
        //{
        //    return order;
        //}

        public double GetPricaAll()
        {
            double priceAll = 0;
            double price;
            string textPrice;
            try
            {
                for (int i = 0; i < lvOrder.ListViewOrder.Items.Count; i++)
                {
                    textPrice = lvOrder.ListViewOrder.Items[i].SubItems[2].Text;
                    price = FindPrice(textPrice);
                    priceAll += price;
                }
            }
            catch(Exception e)
            {
                RecordOfExceptions.Save(Convert.ToString(e), "Form1OrderPresenter - FindPrice");
            }           
            return priceAll;
        }



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

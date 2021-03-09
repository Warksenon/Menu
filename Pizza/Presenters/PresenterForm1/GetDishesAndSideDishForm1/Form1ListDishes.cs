﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza.Presenters.PresenterForm1.GetDishesAndSideDishForm1
{
    class Form1ListDishes : Form1Quantity
    {
        private readonly IForm1ListViewDishes loadDishes;

        public Form1ListDishes(Form1 form1):base(form1)
        {
            loadDishes = form1;
        }

        public List<Dish> GetDishes()
        {
            List<Dish> list = new List<Dish>();
            int numbersRepetitions = CheckNumberTextViewDishes();
            if (numbersRepetitions > 0)
            {
                int x = CheckListDishesSelectedItem();             
                for (int i = 0; i < numbersRepetitions; i++)
                {
                    Dish dish = new Dish
                    {
                        Name = loadDishes.ListViewDishes.Items[x].SubItems[0].Text,
                        Price = loadDishes.ListViewDishes.Items[x].SubItems[1].Text
                    };
                    list.Add(dish);
                }
            }


            return list;
        }

        public void AddDishesToListViewOrder()
        {
            if (CheckNumberTextViewDishes() > 0)
            {
                int x = CheckListDishesSelectedItem();
                Dish dish = new Dish
                {
                    Name = loadDishes.ListViewDishes.Items[x].SubItems[0].Text,
                    Price = loadDishes.ListViewDishes.Items[x].SubItems[1].Text
                };

                for (int i = 0; i < CheckNumberTextViewDishes(); i++)
                {
                    
                }
            }
        }

        private int CheckListDishesSelectedItem()
        {
            return loadDishes.ListViewDishes.FocusedItem.Index;
        }

    }
}

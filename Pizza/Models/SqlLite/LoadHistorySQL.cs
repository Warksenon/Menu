using System;
using System.Collections.Generic;
using System.Data.SQLite;

using Pizza.SqlLite;

namespace Pizza.Models.SqlLite
{
    internal class LoadHistorySQL : CreateConnection, ILoadHistoryOrders
    {
        public List<Order> LoadHistory()
        {
            return LoadListOrderFromSQL();
        }

        private List<Order> LoadListOrderFromSQL()
        {
            List<Order> listorder = new List<Order>();
            SQLiteConnection cn = CreateSQLiteConnection();
            using (cn)
            {
                string qCeny = "SELECT * FROM " + Name.PriceAll + "";
                try
                {
                    cn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand( qCeny, cn ))
                    {
                        SQLiteDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            AddOrdersToListOrders( dr, listorder );
                            dr.Close();
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine( "Błąd przy pobieraniu listy zamowień\n" + e );
                }
                cn.Close();
            }
            return listorder;
        }

        private void AddOrdersToListOrders( SQLiteDataReader dr, List<Order> listorder )
        {
            while (dr.Read())
            {
                try
                {
                    Order order = new Order();
                    PriceAll price = new PriceAll()
                    {
                        ID = Convert.ToInt32(dr[0]),
                        Price = Convert.ToString(dr[1]),
                        Date = Convert.ToString(dr[2]),
                        Comments = Convert.ToString(dr[3])
                    };
                    order.PriceAll = price;
                    order = LoadDishes( Convert.ToString( price.ID ), order );
                    listorder.Add( order );
                }
                catch
                {
                    dr.Close();
                }
            }
        }

        private Order LoadDishes( string num, Order order )
        {
            SQLiteConnection cn = CreateSQLiteConnection();
            using (cn)
            {
                string qIdCeny = "SELECT * FROM " + Name.Dishes + " WHERE " + Name.IdPrice + " = " + num;
                try
                {
                    cn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand( qIdCeny, cn ))
                    {
                        AddDihes( order, cmd );
                        cmd.Cancel();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine( e );
                }
                cn.Close();
            }
            return order;
        }

        private void AddDihes( Order order, SQLiteCommand cmd )
        {
            SQLiteDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    try
                    {
                        int id = Convert.ToInt32(dr[1]);
                        Dish dish = new Dish()
                        {

                            Name = Convert.ToString(dr[2]),
                            Price = Convert.ToString(dr[3]),
                            Sides = Convert.ToString(dr[4])
                        };
                        order.AddDishToListDisch( dish );
                    }
                    catch
                    {
                        dr.Close();
                    }

                }
            }
            dr.Close();
        }
    }
}

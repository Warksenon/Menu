using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Pizza.Models.SqlLite
{
    class SaveHistorySQL : OrderSQL, ISaveHistory
    {
        public void SaveHistoryOrders(List<Order> listOrder)
        {
            UpdateAllTabele(listOrder);
        }

        private void UpdateAllTabele(List<Order> listOrder)
        {
            RemoveAllTask();

            foreach (var order in listOrder)
            {
                AddNewTaskOrder(order);
            }
        }

        private void RemoveAllTask()
        {
            SQLiteConnection cn = CreateSQLiteConnection();
            using (cn)
            {
                string deletePriceAll = "DELETE FROM " + Name.PriceAll;
                SQLiteCommand cmd = new SQLiteCommand(deletePriceAll, cn);
                cn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    RecordOfExceptions.Save(Convert.ToString(e), "SaveHistorySQL -DELETE FROM PriceAll");
                }

                cn.Close();
                SQLiteConnection.ClearAllPools();
            }
            cn = CreateSQLiteConnection();

            using (cn)
            {

                cn.Open();
                string sql = "DELETE FROM " + Name.Dishes;

                SQLiteCommand cmd = new SQLiteCommand(sql, cn);

                try
                {
                    cmd.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    RecordOfExceptions.Save(Convert.ToString(e), "SaveHistorySQL -DELETE FROM Dishes");
                }

                cn.Close();
                SQLiteConnection.ClearAllPools();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Pizza.Models.SqlLite
{
    internal class SaveHistorySQL : OrderSQL, ISaveHistory<Order>
    {
        private List<Order> listOrder;

        public SaveHistorySQL(  )
        {
           
        }

        private void UpdateAllTabele()
        {
            RemoveAllTask();

            foreach (var order in listOrder)
            {
                AddNewTaskOrder( order );
            }
        }

        private void RemoveAllTask()
        {
            SQLiteConnection cn = CreateSQLiteConnection();

            using (cn)
            {
                string deletePriceAll = "DELETE FROM " + Name.PriceAll;

                using (SQLiteCommand cmd = new SQLiteCommand( deletePriceAll, cn ))
                {
                    cn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        RecordOfExceptions.Save( Convert.ToString( e ), "SaveHistorySQL -DELETE FROM PriceAll" );
                    }
                }

                cn.Close();
                SQLiteConnection.ClearAllPools();
            }

            cn = CreateSQLiteConnection();

            using (cn)
            {
                cn.Open();
                string sql = "DELETE FROM " + Name.Dishes;

                using (SQLiteCommand cmd = new SQLiteCommand( sql, cn ))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();

                    }
                    catch (Exception e)
                    {
                        RecordOfExceptions.Save( Convert.ToString( e ), "SaveHistorySQL -DELETE FROM Dishes" );
                    }
                }

                cn.Close();
                SQLiteConnection.ClearAllPools();
            }
        }

        public void SaveHistoryOrders ( List<Order> listOrder )
        {
            this.listOrder = listOrder;
            UpdateAllTabele();
        }
    }
}

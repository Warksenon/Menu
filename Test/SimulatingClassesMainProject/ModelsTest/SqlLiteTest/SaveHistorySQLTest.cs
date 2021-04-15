﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;

using Pizza;

using Test.SimulatingClassesMainProject.ModelsTest;

namespace Test
{
    internal class SaveHistorySQLTest : OrderSQLTest, ISaveHistory, IDataCleansing
    {
        private readonly List<Order> listOrder;

        public SaveHistorySQLTest( List<Order> listOrder )
        {
            this.listOrder = listOrder;
        }

        public SaveHistorySQLTest() { }

        public void SaveHistoryOrders()
        {
            UpdateAllTabele();
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

        public void DeleteData()
        {
            RemoveAllTask();
        }
    }
}

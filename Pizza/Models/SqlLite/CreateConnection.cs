﻿using System.Data.SQLite;

namespace Pizza.SqlLite
{
    class CreateConnection
    {     
        public const string folderDatabase = @"c:\SQL\Konsola\sqlite\";
        public const string databaseFile = "SqlLitePizza.sqlite";
        public const string strConnection = @"Data Source=" + folderDatabase + databaseFile + ";Version=3;";

        public SQLiteConnection CreateSQLiteConnection()
        {
            SQLiteConnection cn = new SQLiteConnection(strConnection);
            return cn;
        }
    }
}

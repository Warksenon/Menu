using System.Data.SQLite;

namespace Test
{
    internal abstract class CreateConnection
    {
        protected const string folderDatabase = @"c:\SQLTEST\Konsola\sqlite\";
        protected const string databaseFile = "SqlLitePizza.sqlite";
        protected const string strConnection = @"Data Source=" + folderDatabase + databaseFile + ";Version=3;";

        protected SQLiteConnection CreateSQLiteConnection()
        {
            SQLiteConnection cn = new SQLiteConnection(strConnection);
            return cn;
        }
    }
}

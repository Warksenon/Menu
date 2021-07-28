using System.Data.SQLite;

namespace Test
{
    internal abstract class CreateConnectionTest
    {
        protected const string folderDatabase = @"c:\SQLTest\Konsola\sqlite\";
        protected const string databaseFile = "SqlLitePizza.sqlite";
        protected const string strConnection = @"Data Source=" + folderDatabase + databaseFile + ";Version=3;";

        protected void CreateTabeles ()
        {
            ILogic logic = new CreateSQLiteTablesTest();
            logic.LogicSettings();
        }

        protected SQLiteConnection CreateSQLiteConnection ()
        {
            SQLiteConnection cn = new SQLiteConnection(strConnection);
            return cn;
        }
    }
}

namespace NorthwindWindowsStore.DAL
{
    using System;
    using System.Data.SQLite;

    public class SqLiteBaseRepository
    {
        private String _runningPath { get; set; }

        public SqLiteBaseRepository(String path)
        {
            _runningPath = path;
        }

        public string DbFile
        {
            get { return _runningPath + "\\Northwind.sqlite"; }
        }

        public SQLiteConnection DbConnection()
        {
            return new SQLiteConnection("Data Source=" + DbFile, true);
        }
    }
}

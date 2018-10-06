using System;
using System.Diagnostics.Contracts;
using SQLite;

namespace AutoService.Data
{
    public class Database
    {
        protected SQLiteAsyncConnection Connection;

        public Database(string dbPath)
        {
            Connection = new SQLiteAsyncConnection(dbPath);
            Connection.CreateTableAsync<object>().Wait();
        }

       

    }
}

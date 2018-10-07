using System;
using System.Threading.Tasks;
using AutoService.Data.Model;
using SQLite;

namespace AutoService.Data
{
    public class DbContext : IDisposable
    {
        #region System

        protected SQLiteAsyncConnection Db;

        public DbContext(string dbPath)
        {
            Db = new SQLiteAsyncConnection(dbPath);
        }

        private bool _isInitialized = false;
        private object _initLockObject = new object();
        /// <summary>
        /// Init db connection.
        /// </summary>
        public void Init()
        {
            if (_isInitialized) return;
            lock (_initLockObject)
            {

                Db.CreateTableAsync<MAccount>().Wait();
                Db.CreateTableAsync<MSyncQueue>().Wait();

                _isInitialized = true;
            }
        }

        public void Dispose()
        {
            if (Db != null)
                Db.CloseAsync().Wait();
        }

        #endregion

        #region Operations

        public Task<int> InsertObject(DbObject entityObject) {
            if (entityObject == null) throw new ArgumentNullException(nameof(entityObject));
            if (!_isInitialized) throw new Exception("Context is not initialized.");
            return Db.InsertAsync(entityObject);
        }

        public Task<int> UpdateObject(DbObject entityObject) {
            if (entityObject == null) throw new ArgumentNullException(nameof(entityObject));
            if (!_isInitialized) throw new Exception("Context is not initialized.");
            return Db.UpdateAsync(entityObject);
        }

        public Task<int> Delete(DbObject entityObject) {
            if (entityObject == null) throw new ArgumentNullException(nameof(entityObject));
            if (!_isInitialized) throw new Exception("Context is not initialized.");
            return Db.DeleteAsync(entityObject);
        }

        #endregion
    }
}

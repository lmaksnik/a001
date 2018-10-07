using System;
using SQLite;

namespace AutoService.Data.Model
{
    public abstract class DbObject
    {
        protected DbObject() { }

        [PrimaryKey, AutoIncrement, Column("_id")]
        public long Id { get; set; }

        #region System

        [Ignore]
        public bool isNew { get { return Id < 1; } }

        /// <summary>
        /// Inserting new object and update exists object
        /// </summary>
        /// <param name="context">Context</param>
        public void Save(DbContext context) {
            if (context == null) throw new ArgumentNullException(nameof(context));
            if (isNew)
                context.InsertObject(this);
            else
                context.UpdateObject(this);
        }

        /// <summary>
        /// Deleting exist object
        /// </summary>s
        /// <param name="context">Context.</param>
        public void Delete(DbContext context) {
            if (context == null) throw new ArgumentNullException(nameof(context));
            if (!isNew)
                context.Delete(this);
        }

        #endregion
    }
}
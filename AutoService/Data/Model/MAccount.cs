using System;
using SQLite;

namespace AutoService.Data.Model
{
    public class MAccount : DbObject
    {

        [Column("_username")]
        public string UserName { get; set; }

    }
}
